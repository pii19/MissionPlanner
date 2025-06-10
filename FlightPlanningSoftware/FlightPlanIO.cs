using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using static MAVLink;

namespace FlightPlanningSoftware
{
    /// <summary>
    /// フライトプラン（WP, FENCE_INCLUTION, FENCE_EXCLUTION, RALLY）の読み書きを行うクラスです。
    /// 各 CommandManager（およびその GetCommandList(), AddCommand(), ClearCommands() など）
    /// と連携して、各機能で保持しているコマンド情報の入出力を行います。
    /// </summary>
    public static class FlightPlanIO
    {
        /// <summary>
        /// 指定のファイルに現在のフライトプラン（WP、FENCE_INCLUTION、FENCE_EXCLUTION、RALLY）を書き出します。
        /// WPセクションでは、緯度・経度はdouble型、高度はfloat型で出力し、Param1は出力しません。
        /// </summary>
        /// <param name="filePath">保存先のファイルパス</param>
        /// <param name="wpManager">ウェイポイント用 CommandManager</param>
        /// <param name="fenceIncManager">逸脱防止フェンス用 CommandManager</param>
        /// <param name="fenceExcManager">進入禁止フェンス用 CommandManager</param>
        /// <param name="rallyManager">緊急着陸（RALLY）用 CommandManager</param>
        public static void SaveFlightPlan(string filePath,
                                            CommandManager wpManager,
                                            CommandManager fenceIncManager,
                                            CommandManager fenceExcManager,
                                            CommandManager rallyManager)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // ヘッダーにフォーマットバージョンを記載
                sw.WriteLine("EAMS Flight Plan Format 1.0");

                // WP セクション（Param1は出力せず、緯度・経度はdouble、高度はfloatとして出力）
                sw.WriteLine("WP");
                List<Locationwp> wpList = wpManager.GetCommandList();
                for (int i = 0; i < wpList.Count; i++)
                {
                    var wp = wpList[i];
                    // wp.Tag に値があるのは "H" と "G" のみとする。それ以外の場合はインデックス（i+1）を出力する
                    string tagOutput = (!string.IsNullOrEmpty(wp.Tag?.ToString())) ? wp.Tag.ToString() : (i + 1).ToString();
                    // 書式: {タグ} {緯度(double)} {経度(double)} {高度(float)}
                    // 例: H 37.123 137.123 10
                    sw.WriteLine(string.Format(CultureInfo.InvariantCulture,
                        "{0} {1:R} {2:R} {3:R}", tagOutput, wp.lat, wp.lng, wp.alt));
                }
                sw.WriteLine();

                // FENCE_INCLUTION セクション
                sw.WriteLine("FENCE_INCLUTION");
                List<Locationwp> fenceIncList = fenceIncManager.GetCommandList();
                int totalFenceInc = fenceIncList.Count;
                for (int i = 0; i < totalFenceInc; i++)
                {
                    var cmd = fenceIncList[i];
                    // 書式: {頂点番号} {緯度} {経度}
                    sw.WriteLine(string.Format(CultureInfo.InvariantCulture,
                        "{0} {1:R} {2:R}", i + 1, cmd.lat, cmd.lng));
                }
                sw.WriteLine();

                // FENCE_EXCLUTION セクション
                sw.WriteLine("FENCE_EXCLUTION");
                List<Locationwp> fenceExcList = fenceExcManager.GetCommandList();
                int totalFenceExc = fenceExcList.Count;
                for (int i = 0; i < totalFenceExc; i++)
                {
                    var cmd = fenceExcList[i];
                    sw.WriteLine(string.Format(CultureInfo.InvariantCulture,
                        "{0} {1:R} {2:R}", i + 1, cmd.lat, cmd.lng));
                }
                sw.WriteLine();

                // RALLY セクション
                sw.WriteLine("RALLY");
                List<Locationwp> rallyList = rallyManager.GetCommandList();
                foreach (var rally in rallyList)
                {
                    // 形式: {インデックス} {緯度} {経度}
                    sw.WriteLine(string.Format(CultureInfo.InvariantCulture,
                        "{0} {1:R} {2:R}", 1, rally.lat, rally.lng));
                }
            }
        }

        /// <summary>
        /// 指定のファイルからフライトプラン（WP、FENCE_INCLUTION、FENCE_EXCLUTION、RALLY）を読み込み、
        /// 各 CommandManager に登録します。
        /// WPセクションは、{タグ} {緯度} {経度} {高度} の形式となっているものとします。
        /// </summary>
        /// <param name="filePath">読込対象のファイルパス</param>
        /// <param name="wpManager">ウェイポイント用 CommandManager</param>
        /// <param name="fenceIncManager">逸脱防止フェンス用 CommandManager</param>
        /// <param name="fenceExcManager">進入禁止フェンス用 CommandManager</param>
        /// <param name="rallyManager">緊急着陸（RALLY）用 CommandManager</param>
        public static void LoadFlightPlan(string filePath,
                                            CommandManager wpManager,
                                            CommandManager fenceIncManager,
                                            CommandManager fenceExcManager,
                                            CommandManager rallyManager)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("フライトプランファイルが見つかりません。", filePath);

            // 既存のコマンドをクリアする
            wpManager.ClearCommands();
            fenceIncManager.ClearCommands();
            fenceExcManager.ClearCommands();
            rallyManager.ClearCommands();

            string[] lines = File.ReadAllLines(filePath);
            string currentSection = "";
            // FENCE セクションは、全頂点数が必要なため一旦行を溜める
            List<string> fenceIncLines = new List<string>();
            List<string> fenceExcLines = new List<string>();

            foreach (string rawLine in lines)
            {
                string line = rawLine.Trim();
                if (string.IsNullOrEmpty(line))
                    continue;
                if (line == "EAMS" || line == "EAMS Flight Plan Format 1.0")
                    continue;
                else if (line == "WP" || line == "FENCE_INCLUTION" || line == "FENCE_EXCLUTION" || line == "RALLY")
                {
                    currentSection = line;
                    continue;
                }
                else
                {
                    switch (currentSection)
                    {
                        case "WP":
                            {
                                // 形式: {タグ} {緯度(double)} {経度(double)} {高度(float)}
                                string[] tokens = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                if (tokens.Length < 4)
                                    continue;
                                string tag = tokens[0];
                                double lat = double.Parse(tokens[1], CultureInfo.InvariantCulture);
                                double lng = double.Parse(tokens[2], CultureInfo.InvariantCulture);
                                float alt = float.Parse(tokens[3], CultureInfo.InvariantCulture);
                                // タグに応じてコマンド種別を振り分ける
                                if (tag == "H")
                                {
                                    wpManager.AddCommand(MAV_CMD.TAKEOFF, 0, 0, 0, 0, lng, lat, alt, tag);
                                }
                                else if (tag == "G")
                                {
                                    wpManager.AddCommand(MAV_CMD.LAND, 0, 0, 0, 0, lng, lat, alt, tag);
                                }
                                else
                                {
                                    wpManager.AddCommand(MAV_CMD.WAYPOINT, 0, 0, 0, 0, lng, lat, alt, tag);
                                }
                            }
                            break;
                        case "FENCE_INCLUTION":
                            {
                                fenceIncLines.Add(line);
                            }
                            break;
                        case "FENCE_EXCLUTION":
                            {
                                fenceExcLines.Add(line);
                            }
                            break;
                        case "RALLY":
                            {
                                // 形式: {インデックス} {緯度} {経度}
                                string[] tokens = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                if (tokens.Length < 3)
                                    continue;
                                double lat = double.Parse(tokens[1], CultureInfo.InvariantCulture);
                                double lng = double.Parse(tokens[2], CultureInfo.InvariantCulture);
                                // Rally は常に MAV_CMD.RALLY_POINT として登録（タグは tokens[0] をそのまま利用）
                                rallyManager.AddCommand(MAV_CMD.RALLY_POINT, 0, 0, 0, 0, lng, lat, 0, tokens[0]);
                            }
                            break;
                    }
                }
            }

            // FENCE_INCLUTION：頂点数を計算してから各頂点を登録
            if (fenceIncLines.Count > 0)
            {
                int total = fenceIncLines.Count;
                for (int i = 0; i < total; i++)
                {
                    string[] tokens = fenceIncLines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (tokens.Length < 3)
                        continue;
                    double lat = double.Parse(tokens[1], CultureInfo.InvariantCulture);
                    double lng = double.Parse(tokens[2], CultureInfo.InvariantCulture);
#if FMS
                    fenceIncManager.AddCommand(MAV_CMD.FENCE_POLYGON_VERTEX_INCLUSION, total, 0, 0, 0, lng, lat, 0);
#else
                    fenceIncManager.AddCommand(MAV_CMD.FENCE_POLYGON_VERTEX_INCLUSION, i, total, 0, 0, lng, lat, 0);
#endif
                }
            }

            // FENCE_EXCLUTION：同様に処理
            if (fenceExcLines.Count > 0)
            {
                int total = fenceExcLines.Count;
                for (int i = 0; i < total; i++)
                {
                    string[] tokens = fenceExcLines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (tokens.Length < 3)
                        continue;
                    double lat = double.Parse(tokens[1], CultureInfo.InvariantCulture);
                    double lng = double.Parse(tokens[2], CultureInfo.InvariantCulture);
                    double defaultExcRadius = Settings.Instance.GetDouble("default_exclusion_radius", 10);
                    fenceExcManager.AddCommand(MAV_CMD.FENCE_CIRCLE_EXCLUSION, defaultExcRadius, 0, 0, 0, lng, lat, 0);
                }
            }
        }
    }
}
