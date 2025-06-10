using System;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using MissionPlanner.Utilities;
using System.IO;

namespace FlightPlanningSoftware
{
    /// <summary>
    /// マップの初期化、オーバーレイ作成、マーカー検出、マップ更新などを担当するクラスです。
    /// </summary>
    public class MapManager
    {
        public GMapControl MainMap { get; private set; }
        public GMapOverlay OverlayWP { get; private set; }
        public GMapOverlay OverlayFenceInc { get; private set; }
        public GMapOverlay OverlayFenceExc { get; private set; }
        public GMapOverlay OverlayRally { get; private set; }

        public MapManager(GMapControl mapControl)
        {
            GMapProviders.List.Add(MissionPlanner.Maps.Japan.Instance);
            MainMap = mapControl;
            InitializeMap();
            InitializeOverlays();
        }

        private void InitializeMap()
        {
            // キャッシュフォルダの設定
            GMaps.Instance.PrimaryCache = new MissionPlanner.Maps.MyImageCache();
            // Settings から "map_provider" を取得
            string providerName = Settings.Instance["map_provider"];
            if (!string.IsNullOrEmpty(providerName))
            {
                MainMap.MapProvider = GetMapProvider(providerName);
            }
            else
            {
                MainMap.MapProvider = GMapProviders.GoogleSatelliteMap;
            }
            MainMap.MapScaleInfoEnabled = true;
            MainMap.ScalePen = new Pen(Color.White, 2);
            MainMap.ScaleFont = new Font("Arial", 12, FontStyle.Bold);
            MainMap.DragButton = MouseButtons.Left;
            MainMap.Position = new PointLatLng(37.5527909, 140.9597043);
        }

        private GMapProvider GetMapProvider(string providerName)
        {
            // 必要に応じて他のプロバイダーも追加してください
            switch (providerName)
            {
                case "GoogleMap":
                    return GMapProviders.GoogleMap;
                case "GoogleSatelliteMap":
                    return GMapProviders.GoogleSatelliteMap;
                case "GoogleHybridMap":
                    return GMapProviders.GoogleHybridMap;
                case "BingMap":
                    return GMapProviders.BingMap;
                case "BingSatelliteMap":
                    return GMapProviders.BingSatelliteMap;
                case "BingHybridMap":
                    return GMapProviders.BingHybridMap;
                case "OpenStreetMap":
                    return GMapProviders.OpenStreetMap;
                case "Japan":
                    return MissionPlanner.Maps.Japan.Instance;
                default:
                    return GMapProviders.GoogleSatelliteMap;
            }
        }

        private void InitializeOverlays()
        {
            OverlayWP = new GMapOverlay("overlayWP");
            OverlayFenceInc = new GMapOverlay("overlayFenceInc");
            OverlayFenceExc = new GMapOverlay("overlayFenceExc");
            OverlayRally = new GMapOverlay("overlayRally");

            MainMap.Overlays.Add(OverlayWP);
            MainMap.Overlays.Add(OverlayFenceInc);
            MainMap.Overlays.Add(OverlayFenceExc);
            MainMap.Overlays.Add(OverlayRally);
        }

        /// <summary>
        /// 指定されたオーバーレイ内のマーカーについて、マウス座標にヒットするものを返します。
        /// </summary>
        public GMapMarker GetMarkerAtPosition(GMapOverlay overlay, int mouseX, int mouseY)
        {
            foreach (var marker in overlay.Markers)
            {
                Point markerPos = new Point(marker.LocalAreaInControlSpace.X, marker.LocalAreaInControlSpace.Y);
                Size markerSize = (marker is GMap.NET.WindowsForms.Markers.GMarkerGoogle g)
                    ? g.Size
                    : new Size(marker.LocalAreaInControlSpace.Width, marker.LocalAreaInControlSpace.Height);
                Rectangle markerRect = new Rectangle(markerPos, markerSize);
                if (markerRect.Contains(mouseX, mouseY))
                {
                    return marker;
                }
            }
            return null;
        }

        public void RefreshMap()
        {
            MainMap.Refresh();
        }
    }
}
