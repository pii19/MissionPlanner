using System;
using System.Collections.Generic;
using System.Drawing;
using ClipperLib;
using GMap.NET;
using MissionPlanner.Utilities;

namespace FlightPlanningSoftware
{
    /// <summary>
    /// ウェイポイントリストからフェンス用の多角形（バッファ領域）の頂点を、ロバストな手法で計算するクラスです。
    /// ClipperLib を利用して、自己交差や複雑な形状にも対処します。
    /// </summary>
    public class FenceCalculator
    {
        // ローカル座標（メートル単位）を Clipper の整数値に変換するためのスケール（例: 1m = 1000 単位）
        private const double scale = 1000.0;

        /// <summary>
        /// 指定されたウェイポイントからオフセット多角形を計算して返します。
        /// offsetMeter の値に比例して拡張距離も自動算出され、ClipperOffset により自己交差を防ぎます。
        /// </summary>
        public List<PointLatLng> CalculateFencePolygon(List<Locationwp> wps, double offsetMeter)
        {
            int n = wps.Count;
            if (n < 2)
                throw new ArgumentException("少なくとも2点のウェイポイントが必要です。");

            // 1. ウェイポイントをローカル座標 (PointF、単位: meter) に変換
            List<PointF> localWPs = ConvertWPsToLocalXY(wps);

            // 2. ウェイポイントからオープンなポリラインを作成
            List<IntPoint> polyline = new List<IntPoint>();
            foreach (var pt in localWPs)
            {
                // スケールアップして整数値に変換
                polyline.Add(new IntPoint(pt.X * scale, pt.Y * scale));
            }

            // 3. ClipperOffset によるオフセット処理
            ClipperOffset co = new ClipperOffset();
            // オープンパスとして追加
            co.AddPath(polyline, JoinType.jtSquare, EndType.etOpenSquare);
            List<List<IntPoint>> solution = new List<List<IntPoint>>();
            // オフセット距離をスケールアップして指定
            double offsetScaled = offsetMeter * scale;
            co.Execute(ref solution, offsetScaled);

            if (solution.Count == 0)
                throw new Exception("オフセット多角形が生成できませんでした。");

            // ここでは、得られた複数の多角形のうち、最も面積の大きいものを選ぶ（自己交差対策）
            List<IntPoint> bestPoly = null;
            long bestArea = 0;
            foreach (var poly in solution)
            {
                long area = (long)Math.Abs(Clipper.Area(poly));
                if (area > bestArea)
                {
                    bestArea = area;
                    bestPoly = poly;
                }
            }

            // 4. 生成されたオフセット多角形をローカル座標（PointF）に戻す
            List<PointF> localPolygon = new List<PointF>();
            foreach (var ip in bestPoly)
            {
                localPolygon.Add(new PointF((float)(ip.X / scale), (float)(ip.Y / scale)));
            }

            // 5. ローカル座標から緯度経度に変換（基準は最初のウェイポイント）
            List<PointLatLng> polygonLatLon = LocalXYToLatLon(localPolygon, wps[0].lat, wps[0].lng);
            return polygonLatLon;
        }

        /// <summary>
        /// ウェイポイントリストをローカル座標（メートル単位、PointF）に変換する
        /// </summary>
        private List<PointF> ConvertWPsToLocalXY(List<Locationwp> wps)
        {
            double lat0 = wps[0].lat;
            double lon0 = wps[0].lng;
            double degToMeterLat = 111000.0;
            double degToMeterLon = 111000.0 * Math.Cos(lat0 * Math.PI / 180.0);
            var localPts = new List<PointF>();
            foreach (var wp in wps)
            {
                float x = (float)((wp.lng - lon0) * degToMeterLon);
                float y = (float)((wp.lat - lat0) * degToMeterLat);
                localPts.Add(new PointF(x, y));
            }
            return localPts;
        }

        /// <summary>
        /// ローカル座標（PointF）から、基準となる緯度・経度を使って緯度経度 (PointLatLng) に変換する
        /// </summary>
        private List<PointLatLng> LocalXYToLatLon(List<PointF> localPts, double baseLat, double baseLon)
        {
            double degToMeterLat = 111000.0;
            double degToMeterLon = 111000.0 * Math.Cos(baseLat * Math.PI / 180.0);
            var result = new List<PointLatLng>();
            foreach (var pt in localPts)
            {
                double lat = baseLat + pt.Y / degToMeterLat;
                double lng = baseLon + pt.X / degToMeterLon;
                result.Add(new PointLatLng(lat, lng));
            }
            return result;
        }
    }
}
