using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using log4net;
using MissionPlanner.ArduPilot;
using MissionPlanner.Maps;
using MissionPlanner.Utilities;
using static MAVLink;

namespace FlightPlanningSoftware
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // 各機能担当クラス
        private MapManager mapManager;
        private CommandManager commandManagerWP;
        private CommandManager commandManagerFenceInc;
        private CommandManager commandManagerFenceExc;
        private CommandManager commandManagerEmergency;
        private FenceCalculator fenceCalculator;

        // DRAG_THRESHOLD を Settings で管理するためのフィールド
        private int dragThreshold;

        // ドラッグ操作管理用
        private GMapMarker _dragMarker = null;
        private PointLatLng _dragStart;
        private Point _mouseDownPoint;
        private bool _isDragging = false;
        private bool _maybeClick = false;
        private GMapMarker _hoverMarker = null;

        // 状態管理用フラグ
        private bool isHomePlaced = false;
        private bool isLandingPlaced = false;
        private bool isFenceIncPlaced = false;
#if FMS
        static Button closeButton = null;
#endif
        public Form1()
        {
            InitializeComponent();
            log4net.Util.LogLog.InternalDebugging = true;
            log.Info("EAMS Planner loaded (constructor)");
#if FMS
            // add close button
            closeButton = new Button
            {
                Text = "閉じる",
                Width = 100,
                Height = 50,
                Top = 4,
                Left = panelFooterContent.Width - (100 + 50),
                Font = new Font("Yu Gothic UI", 18, FontStyle.Bold),
                BackColor = Color.FromArgb(89, 89, 89),
                Tag = "custom",
            };
            panelFooterContent.Controls.Add(closeButton);
            closeButton.Click += (s, e) => 
            {
                this.Close();
            };

            // invisible DataGrid delete buttons
            dataGridViewWPs.Columns["colWpDelete"].Visible = false;
            dataGridViewFenceInc.Columns["colFenceIncDelete"].Visible = false;
            dataGridViewFenceExc.Columns["colFenceExcDelete"].Visible = false;
            dataGridViewEmergency.Columns["colRallyDelete"].Visible = false;
#endif
        }

        private void FlightPlanningSoftware_Load(object sender, EventArgs e)
        {
#if !FMS
            // Designer により各コントロールが生成された後に初期化
            InitializeManagers();

            // Settings からマップ位置とズームを読み込む
            try
            {
                if (Settings.Instance["maplast_lat"] != null &&
                    Math.Round(Settings.Instance.GetDouble("maplast_lat"), 1) != 0)
                {
                    MainMap.Position = new PointLatLng(
                        Settings.Instance.GetDouble("maplast_lat"),
                        Settings.Instance.GetDouble("maplast_lng"));
                    var zoom = Settings.Instance.GetFloat("maplast_zoom");
                    MainMap.Zoom = zoom;
                }
            }
            catch
            {
                log.Info("eams_config error: maplast");
            }

            // fps_config.xml から fullscreen の設定を取得（キーがなければ true をデフォルトとする）
            string fsValue = Settings.Instance["fullscreen"];
            bool fullscreen = true; // デフォルトは true (フルスクリーン)
            if (!string.IsNullOrEmpty(fsValue))
            {
                bool.TryParse(fsValue.Trim(), out fullscreen);
            }

            if (fullscreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
#endif
        }

        private void InitializeManagers()
        {
            mapManager = new MapManager(MainMap);
            // WP用、FenceInc用、FenceExc用、Rally用の CommandManager を初期化（接頭辞を指定）
            commandManagerWP = new CommandManager(dataGridViewWPs, "colWp");
            commandManagerFenceInc = new CommandManager(dataGridViewFenceInc, "colFenceInc");
            commandManagerFenceExc = new CommandManager(dataGridViewFenceExc, "colFenceExc");
            commandManagerEmergency = new CommandManager(dataGridViewEmergency, "colRally");
            fenceCalculator = new FenceCalculator();

            foreach (DataGridViewColumn col in dataGridViewWPs.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // DRAG_THRESHOLD を Settings から取得（存在しなければ 5 を使用）
            dragThreshold = Settings.Instance.GetInt32("drag_threshold", 5);
        }
#if FMS
        public void AdjustLayout()
        {
            splitContainerMain.SplitterDistance = 0;
            //splitContainerVert.SplitterDistance = this.Height;
            buttonFileLoad.Visible = false;
            buttonFileSave.Visible = false;
            pictureLogoArdu.Visible = false;
            pictureLogoEAMS.Visible = false;

            // Designer により各コントロールが生成された後に初期化
            InitializeManagers();

            // Settings からマップ位置とズームを読み込む
            try
            {
                if (Settings.Instance["maplast_lat"] != null &&
                    Math.Round(Settings.Instance.GetDouble("maplast_lat"), 1) != 0)
                {
                    MainMap.Position = new PointLatLng(
                        Settings.Instance.GetDouble("maplast_lat"),
                        Settings.Instance.GetDouble("maplast_lng"));
                    var zoom = Settings.Instance.GetFloat("maplast_zoom");
                    MainMap.Zoom = zoom;
                }
            }
            catch
            {
                log.Info("eams_config error: maplast");
            }
        }

        public List<Locationwp> getWP()
        {
            return commandManagerWP.GetCommandList();
        }

        public List<Locationwp> getFence()
        {
            var inc = commandManagerFenceInc.GetCommandList();
            var exc = commandManagerFenceExc.GetCommandList();

            inc.AddRange(exc);

            return inc;
        }
        public List<Locationwp> getRally()
        {
            return commandManagerEmergency.GetCommandList();
        }

#endif
        private void FlightPlanningSoftware_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Instance["maplast_lat"] = MainMap.Position.Lat.ToString();
            Settings.Instance["maplast_lng"] = MainMap.Position.Lng.ToString();
            Settings.Instance["maplast_zoom"] = MainMap.Zoom.ToString();
            Settings.Instance["default_wpradius"] = Settings.Instance.GetDouble("default_wpradius", 10).ToString();
            Settings.Instance["default_altitude"] = Settings.Instance.GetDouble("default_altitude", 10).ToString();
            Settings.Instance["default_exclusion_radius"] = Settings.Instance.GetDouble("default_exclusion_radius", 10).ToString();
            Settings.Instance["drag_threshold"] = Settings.Instance.GetInt32("drag_threshold", 5).ToString();
            Settings.Instance["fence_offset"] = Settings.Instance.GetDouble("fence_offset", 10.0).ToString();
            Settings.Instance["map_provider"] = MainMap.MapProvider.ToString();
#if !FMS
            Settings.Instance["fullscreen"] = (this.WindowState == FormWindowState.Maximized &&
                                       this.FormBorderStyle == FormBorderStyle.None) ? "true" : "false";
#endif
            Settings.Instance.Save();
        }

        private void FlightPlanningSoftware_KeyDown(object sender, KeyEventArgs e)
        {
#if !FMS
            // Esc キーが押されたらアプリを終了（フォームを閉じる）
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
#endif
        }

        /// <summary>
        /// 各オーバーレイ（WP, FenceInc, FenceExc, Rally）を更新し、その後マップを再描画します。
        /// </summary>
        private void mapUpdate()
        {
            updateOverlay(mapManager.OverlayWP, commandManagerWP.GetCommandList());
            updateOverlay(mapManager.OverlayFenceInc, commandManagerFenceInc.GetCommandList());
            updateOverlay(mapManager.OverlayFenceExc, commandManagerFenceExc.GetCommandList());
            updateOverlay(mapManager.OverlayRally, commandManagerEmergency.GetCommandList());
            MainMap.Refresh();
            UpdateDistanceDisplay();
        }

        /// <summary>
        /// 指定したオーバーレイに対して、コマンドリストの内容に基づきマーカーまたは多角形を描画します。
        /// </summary>
        private void updateOverlay(GMapOverlay overlay, List<Locationwp> commandList)
        {
            overlay.Clear();
            double defaultWpRadius = Settings.Instance.GetDouble("default_wpradius", 10);
            WPOverlay wpOverlay = new WPOverlay();
            wpOverlay.overlay = overlay;
            wpOverlay.CreateOverlay(PointLatLngAlt.Zero, commandList, defaultWpRadius, 0, 1);
            if (overlay == mapManager.OverlayWP)
            {
                if (IsButtonSelected(buttonWaypoint))
                {
                    for (int i = 0; i < commandList.Count - 1; i++)
                    {
                        var mid = new PointLatLngAlt(
                            (commandList[i].lat + commandList[i + 1].lat) / 2,
                            (commandList[i].lng + commandList[i + 1].lng) / 2,
                            (commandList[i].alt + commandList[i + 1].alt) / 2);
                        var pnt = new GMapMarkerPlus(mid);
                        pnt.Tag = i + 1;
                        overlay.Markers.Add(pnt);
                    }
                }
            }
            else if (overlay == mapManager.OverlayFenceInc)
            {
                List<PointLatLng> fenceList = commandList.Select(wp => new PointLatLng(wp.lat, wp.lng)).ToList();
                var fencePoly = new GMapPolygon(fenceList, "fence_inc");
                fencePoly.Stroke = new Pen(Color.Pink, 2);
                fencePoly.Fill = new SolidBrush(Color.FromArgb(20, Color.LightPink));
                overlay.Polygons.Add(fencePoly);
                if (IsButtonSelected(buttonFence))
                {
                    for (int i = 0; i < commandList.Count - 1; i++)
                    {
                        var mid = new PointLatLngAlt(
                            (commandList[i].lat + commandList[i + 1].lat) / 2,
                            (commandList[i].lng + commandList[i + 1].lng) / 2,
                            (commandList[i].alt + commandList[i + 1].alt) / 2);
                        var pnt = new GMapMarkerPlus(mid);
                        pnt.Tag = i + 1;
                        overlay.Markers.Add(pnt);
                    }
                }
            }
            else if (overlay == mapManager.OverlayFenceExc)
            {
                // 何もしない
            }
            else if (overlay == mapManager.OverlayRally)
            {
                // 何もしない
            }
            overlay.ForceUpdate();
        }

        // マウスイベント
        private void MainMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isDragging || !_maybeClick)
                return;

            PointLatLng latlng = MainMap.FromLocalToLatLng(e.X, e.Y);
            GMapOverlay targetOverlay = null;
            List<Locationwp> commandList = null;

            if (IsButtonSelected(buttonTakeoff))
            {
                targetOverlay = mapManager.OverlayWP;
                for (int i = dataGridViewWPs.Rows.Count - 1; i >= 0; i--)
                {
                    var row = dataGridViewWPs.Rows[i];
                    var cellTag = row.Cells["colWpCommand"].Tag;
                    if (cellTag != null && cellTag.ToString() == "H")
                    {
                        dataGridViewWPs.Rows.RemoveAt(i);
                    }
                }
                double defaultAltitude = Settings.Instance.GetDouble("default_altitude", 10);
                commandManagerWP.InsertCommand(0, MAV_CMD.TAKEOFF, 0, 0, 0, 0, latlng.Lng, latlng.Lat, defaultAltitude, "H");
                isHomePlaced = true;
                buttonWaypoint.Enabled = true;
                buttonLanding.Enabled = true;
                buttonBulkDelete.Enabled = true;
                SetButtonSelected(buttonTakeoff, false);
                commandList = commandManagerWP.GetCommandList();
            }
            else if (IsButtonSelected(buttonWaypoint))
            {
                targetOverlay = mapManager.OverlayWP;
                for (int i = dataGridViewWPs.Rows.Count - 1; i >= 0; i--)
                {
                    var row = dataGridViewWPs.Rows[i];
                    var cellTag = row.Cells["colWpCommand"].Tag;
                    if (cellTag == null || cellTag.ToString() != "G")
                    {
                        double defaultAltitude = Settings.Instance.GetDouble("default_altitude", 10);
                        commandManagerWP.InsertCommand(i + 1, MAV_CMD.WAYPOINT, 0, 0, 0, 0, latlng.Lng, latlng.Lat, defaultAltitude);
                        break;
                    }
                }
                commandList = commandManagerWP.GetCommandList();
            }
            else if (IsButtonSelected(buttonLanding))
            {
                targetOverlay = mapManager.OverlayWP;
                for (int i = dataGridViewWPs.Rows.Count - 1; i >= 0; i--)
                {
                    var row = dataGridViewWPs.Rows[i];
                    var cellTag = row.Cells["colWpCommand"].Tag;
                    if (cellTag != null && cellTag.ToString() == "G")
                    {
                        dataGridViewWPs.Rows.RemoveAt(i);
                    }
                }
                commandManagerWP.AddCommand(MAV_CMD.LAND, 0, 0, 0, 0, latlng.Lng, latlng.Lat, 0, "G");
                isLandingPlaced = true;
                buttonFence.Enabled = true;
                buttonRoundTrip.Enabled = true;
                SetButtonSelected(buttonLanding, false);
                commandList = commandManagerWP.GetCommandList();
            }
            else if (IsButtonSelected(buttonFence))
            {
                if (IsButtonSelected(buttonFenceExc))
                {
                    targetOverlay = mapManager.OverlayFenceExc;
                    double defaultExcRadius = Settings.Instance.GetDouble("default_exclusion_radius", 10);
                    commandManagerFenceExc.AddCommand(MAV_CMD.FENCE_CIRCLE_EXCLUSION, defaultExcRadius, 0, 0, 0, latlng.Lng, latlng.Lat, 0);
                    commandList = commandManagerFenceExc.GetCommandList();
                }
                else
                {
                    // 逸脱防止はボタンの個別処理に任せるためMouseClick では何もしない
                    return;
                }
            }
            else if (IsButtonSelected(buttonEmergency))
            {
                targetOverlay = mapManager.OverlayRally;
                commandManagerEmergency.AddCommand(MAV_CMD.RALLY_POINT, 0, 0, 0, 0, latlng.Lng, latlng.Lat, 0);
                commandList = commandManagerEmergency.GetCommandList();
            }
            else
            {
                return;
            }

            mapUpdate();
            _maybeClick = false;
        }

        private void MainMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            PointLatLng clickPos = MainMap.FromLocalToLatLng(e.X, e.Y);
            _mouseDownPoint = e.Location;
            _maybeClick = true;

            if (IsButtonSelected(buttonWaypoint))
            {
                GMapMarker found = mapManager.GetMarkerAtPosition(mapManager.OverlayWP, e.X, e.Y);
                if (found != null)
                {
                    if (found is GMapMarkerWP)
                    {
                        _dragMarker = found;
                        _dragStart = clickPos;
                    }
                    else if (found is GMapMarkerPlus)
                    {
                        _dragMarker = found;
                        _maybeClick = false;
                    }
                }
            }
            else if (IsButtonSelected(buttonFence))
            {
                // ここではフェンス関連のドラッグ処理は個別の GridView で行う場合、必要に応じて追加
                GMapMarker found = mapManager.GetMarkerAtPosition(mapManager.OverlayFenceInc, e.X, e.Y);
                if (found == null)
                {
                    found = mapManager.GetMarkerAtPosition(mapManager.OverlayFenceExc, e.X, e.Y);
                }
                if (found != null)
                {
                    if (found is GMapMarkerPlus)
                    {
                        _dragMarker = found;
                        _maybeClick = false;
                    }
                    else
                    {
                        _dragMarker = found;
                        _dragStart = clickPos;
                    }
                }
            }
            else if (IsButtonSelected(buttonEmergency))
            {
                GMapMarker found = mapManager.GetMarkerAtPosition(mapManager.OverlayRally, e.X, e.Y);
                if (found != null)
                {
                    _dragMarker = found;
                    _dragStart = clickPos;
                }
            }
        }

        private void MainMap_MouseMove(object sender, MouseEventArgs e)
        {
            // ドラッグ開始判定
            if (!_isDragging && _maybeClick)
            {
                if (Math.Abs(e.X - _mouseDownPoint.X) > dragThreshold ||
                    Math.Abs(e.Y - _mouseDownPoint.Y) > dragThreshold)
                {
                    _maybeClick = false;
                    if (_dragMarker != null)
                        _isDragging = true;
                }
            }
            else
            {
                // もし既にドラッグ対象 (_dragMarker) が設定されている場合、所属オーバーレイに応じて各 GridView の選択状態を更新する
                if (_dragMarker != null)
                {
                    // WP（ウェイポイント）の場合
                    if (IsButtonSelected(buttonWaypoint))
                    {
                        if (_hoverMarker != _dragMarker)
                        {
                            _hoverMarker = _dragMarker;
                            dataGridViewWPs.ClearSelection();
                            int rowIndex;
                            if (int.TryParse(_dragMarker.Tag.ToString(), out rowIndex))
                            {
                                // Tag は 1～ の番号を想定しているので、GridView は 0～ に調整
                                rowIndex--;
                                if (rowIndex >= 0 && rowIndex < dataGridViewWPs.Rows.Count)
                                    dataGridViewWPs.CurrentCell = dataGridViewWPs.Rows[rowIndex].Cells["colWpDelete"];
                            }
                        }
                    }
                    // Fence の場合（逸脱防止フェンス、進入禁止フェンスは別の GridView で管理）
                    else if (IsButtonSelected(buttonFence))
                    {
                        if (mapManager.OverlayFenceInc.Markers.Contains(_dragMarker))
                        {
                            if (_hoverMarker != _dragMarker)
                            {
                                _hoverMarker = _dragMarker;
                                dataGridViewFenceInc.ClearSelection();
                                int rowIndex;
                                if (int.TryParse(_dragMarker.Tag.ToString(), out rowIndex))
                                {
                                    rowIndex--;
                                    if (rowIndex >= 0 && rowIndex < dataGridViewFenceInc.Rows.Count)
                                        dataGridViewFenceInc.CurrentCell = dataGridViewFenceInc.Rows[rowIndex].Cells["colFenceIncDelete"];
                                }
                            }
                        }
                        else if (mapManager.OverlayFenceExc.Markers.Contains(_dragMarker))
                        {
                            if (_hoverMarker != _dragMarker)
                            {
                                _hoverMarker = _dragMarker;
                                dataGridViewFenceExc.ClearSelection();
                                int rowIndex;
                                if (int.TryParse(_dragMarker.Tag.ToString(), out rowIndex))
                                {
                                    rowIndex--;
                                    if (rowIndex >= 0 && rowIndex < dataGridViewFenceExc.Rows.Count)
                                        dataGridViewFenceExc.CurrentCell = dataGridViewFenceExc.Rows[rowIndex].Cells["colFenceExcDelete"];
                                }
                            }
                        }
                    }
                    // Rally（緊急着陸地点）の場合
                    else if (IsButtonSelected(buttonEmergency))
                    {
                        if (_hoverMarker != _dragMarker)
                        {
                            _hoverMarker = _dragMarker;
                            dataGridViewEmergency.ClearSelection();
                            int rowIndex;
                            if (int.TryParse(_dragMarker.Tag.ToString(), out rowIndex))
                            {
                                rowIndex--;
                                if (rowIndex >= 0 && rowIndex < dataGridViewEmergency.Rows.Count)
                                    dataGridViewEmergency.CurrentCell = dataGridViewEmergency.Rows[rowIndex].Cells["colRallyDelete"];
                            }
                        }
                    }
                }
                else
                {
                    // ドラッグ対象が設定されていない場合、マウス座標上のマーカーを各オーバーレイから探し、対象の GridView を更新する
                    GMapMarker marker = mapManager.GetMarkerAtPosition(mapManager.OverlayWP, e.X, e.Y)
                        ?? mapManager.GetMarkerAtPosition(mapManager.OverlayFenceInc, e.X, e.Y)
                        ?? mapManager.GetMarkerAtPosition(mapManager.OverlayFenceExc, e.X, e.Y)
                        ?? mapManager.GetMarkerAtPosition(mapManager.OverlayRally, e.X, e.Y);
                    if (marker != null)
                    {
                        if (_hoverMarker != marker)
                        {
                            _hoverMarker = marker;
                            // 更新する GridView を、対象の Marker が所属する Overlay に応じて決定
                            if (mapManager.OverlayWP.Markers.Contains(marker))
                            {
                                dataGridViewWPs.ClearSelection();
                                int rowIndex;
                                if (int.TryParse(marker.Tag.ToString(), out rowIndex))
                                {
                                    rowIndex--;
                                }
                                else
                                {
                                    if (marker.Tag.ToString() == "H")
                                    {
                                        rowIndex = 0;
                                    }
                                    else if (marker.Tag.ToString() == "G")
                                    {
                                        rowIndex = dataGridViewWPs.RowCount - 1;
                                    }
                                }
                                if (rowIndex >= 0 && rowIndex < dataGridViewWPs.Rows.Count)
                                    dataGridViewWPs.CurrentCell = dataGridViewWPs.Rows[rowIndex].Cells["colWpDelete"];
                            }
                            else if (mapManager.OverlayFenceInc.Markers.Contains(marker))
                            {
                                dataGridViewFenceInc.ClearSelection();
                                int rowIndex;
                                if (int.TryParse(marker.Tag.ToString(), out rowIndex))
                                {
                                    rowIndex--;
                                    if (rowIndex >= 0 && rowIndex < dataGridViewFenceInc.Rows.Count)
                                        dataGridViewFenceInc.CurrentCell = dataGridViewFenceInc.Rows[rowIndex].Cells["colFenceIncDelete"];
                                }
                            }
                            else if (mapManager.OverlayFenceExc.Markers.Contains(marker))
                            {
                                dataGridViewFenceExc.ClearSelection();
                                int rowIndex;
                                if (int.TryParse(marker.Tag.ToString(), out rowIndex))
                                {
                                    rowIndex--;
                                    if (rowIndex >= 0 && rowIndex < dataGridViewFenceExc.Rows.Count)
                                        dataGridViewFenceExc.CurrentCell = dataGridViewFenceExc.Rows[rowIndex].Cells["colFenceExcDelete"];
                                }
                            }
                            else if (mapManager.OverlayRally.Markers.Contains(marker))
                            {
                                dataGridViewEmergency.ClearSelection();
                                int rowIndex;
                                if (int.TryParse(marker.Tag.ToString(), out rowIndex))
                                {
                                    rowIndex--;
                                    if (rowIndex >= 0 && rowIndex < dataGridViewEmergency.Rows.Count)
                                        dataGridViewEmergency.CurrentCell = dataGridViewEmergency.Rows[rowIndex].Cells["colRallyDelete"];
                                }
                            }
                        }
                    }
                    else
                    {
                        // どのオーバーレイにもマーカーが見つからない場合は、全ての GridView の選択をクリア
                        if (_hoverMarker != null)
                        {
                            _hoverMarker = null;
                            dataGridViewWPs.ClearSelection();
                            dataGridViewFenceInc.ClearSelection();
                            dataGridViewFenceExc.ClearSelection();
                            dataGridViewEmergency.ClearSelection();
                        }
                    }
                }

                // ドラッグ中ならマーカーの位置を更新
                if (_isDragging && _dragMarker != null)
                {
                    PointLatLng currentPos = MainMap.FromLocalToLatLng(e.X, e.Y);
                    _dragMarker.Position = currentPos;
                    MainMap.Refresh();
                }
            }
        }

        private void MainMap_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_isDragging && _dragMarker != null)
                {
                    // WP, FenceInc, FenceExc, Rally それぞれの場合で処理を分岐
                    if (mapManager.OverlayWP.Markers.Contains(_dragMarker))
                    {
                        int rowIndex;
                        if (int.TryParse(_dragMarker.Tag.ToString(), out rowIndex))
                        {
                            rowIndex--; // 1-based → 0-based
                            if (rowIndex >= 0 && rowIndex < dataGridViewWPs.Rows.Count)
                            {
                                dataGridViewWPs.Rows[rowIndex].Cells["colWpLat"].Value = _dragMarker.Position.Lat;
                                dataGridViewWPs.Rows[rowIndex].Cells["colWpLon"].Value = _dragMarker.Position.Lng;
                            }
                        }
                    }
                    else if (mapManager.OverlayFenceInc.Markers.Contains(_dragMarker))
                    {
                        int rowIndex;
                        if (int.TryParse(_dragMarker.Tag.ToString(), out rowIndex))
                        {
                            rowIndex--;
                            if (rowIndex >= 0 && rowIndex < dataGridViewFenceInc.Rows.Count)
                            {
                                dataGridViewFenceInc.Rows[rowIndex].Cells["colFenceIncLat"].Value = _dragMarker.Position.Lat;
                                dataGridViewFenceInc.Rows[rowIndex].Cells["colFenceIncLon"].Value = _dragMarker.Position.Lng;
                            }
                        }
                    }
                    else if (mapManager.OverlayFenceExc.Markers.Contains(_dragMarker))
                    {
                        int rowIndex;
                        if (int.TryParse(_dragMarker.Tag.ToString(), out rowIndex))
                        {
                            rowIndex--;
                            if (rowIndex >= 0 && rowIndex < dataGridViewFenceExc.Rows.Count)
                            {
                                dataGridViewFenceExc.Rows[rowIndex].Cells["colFenceExcLat"].Value = _dragMarker.Position.Lat;
                                dataGridViewFenceExc.Rows[rowIndex].Cells["colFenceExcLon"].Value = _dragMarker.Position.Lng;
                            }
                        }
                    }
                    else if (mapManager.OverlayRally.Markers.Contains(_dragMarker))
                    {
                        int rowIndex;
                        if (int.TryParse(_dragMarker.Tag.ToString(), out rowIndex))
                        {
                            rowIndex--;
                            if (rowIndex >= 0 && rowIndex < dataGridViewEmergency.Rows.Count)
                            {
                                dataGridViewEmergency.Rows[rowIndex].Cells["colRallyLat"].Value = _dragMarker.Position.Lat;
                                dataGridViewEmergency.Rows[rowIndex].Cells["colRallyLon"].Value = _dragMarker.Position.Lng;
                            }
                        }
                    }
                    _isDragging = false;
                    _dragMarker = null;
                    mapUpdate();
                }
                else if (_dragMarker is GMapMarkerPlus)
                {
                    if (IsButtonSelected(buttonWaypoint))
                    {
                        int ind;
                        if (int.TryParse(_dragMarker.Tag.ToString(), out ind))
                        {
                            commandManagerWP.InsertCommand(ind, MAV_CMD.WAYPOINT, 0, 0, 0, 0, _dragMarker.Position.Lng, _dragMarker.Position.Lat, Settings.Instance.GetDouble("default_altitude", 10));
                        }
                    }
                    else if (IsButtonSelected(buttonFence))
                    {
                        // ここでは中間点が追加されたと仮定
                        // 逸脱防止フェンスの場合、InsertCommand で追加した後、再インデックス処理を呼び出す
                        int ind;
                        if (int.TryParse(_dragMarker.Tag.ToString(), out ind))
                        {
                            commandManagerFenceInc.InsertCommand(ind, MAV_CMD.FENCE_POLYGON_VERTEX_INCLUSION, 0, 0, 0, 0, _dragMarker.Position.Lng, _dragMarker.Position.Lat, 0);
                            // 追加後、全体のインデックスと総件数を再設定
                            commandManagerFenceInc.ReindexCommands();
                        }
                    }
                    _dragMarker = null;
                    mapUpdate();
                }
            }
        }

        private bool IsButtonSelected(Button btn)
        {
            return (btn.Tag != null && (bool)btn.Tag == true);
        }

        private void SetButtonSelected(Button btn, bool selected)
        {
            btn.Tag = selected;
            btn.BackColor = selected ? Color.LightGreen : Color.Transparent;
        }

        private void ClearMainSelection()
        {
            SetButtonSelected(buttonTakeoff, false);
            SetButtonSelected(buttonWaypoint, false);
            SetButtonSelected(buttonLanding, false);
            SetButtonSelected(buttonFence, false);
            SetButtonSelected(buttonEmergency, false);
            ClearFenceSelection();
        }

        private void ClearFenceSelection()
        {
            SetButtonSelected(buttonFenceInc, false);
            SetButtonSelected(buttonFenceExc, false);
        }

        private void ToggleMainButton(Button clickedButton)
        {
            if (IsButtonSelected(clickedButton))
            {
                SetButtonSelected(clickedButton, false);
            }
            else
            {
                ClearMainSelection();
                SetButtonSelected(clickedButton, true);
            }
            bool fenceSelected = IsButtonSelected(buttonFence);
            buttonFenceInc.Enabled = fenceSelected;
            buttonFenceExc.Enabled = fenceSelected;
            if (!fenceSelected)
                ClearFenceSelection();
            mapUpdate();
        }

        private void ToggleFenceButton(Button clickedButton)
        {
            if (IsButtonSelected(clickedButton))
            {
                SetButtonSelected(clickedButton, false);
            }
            else
            {
                ClearFenceSelection();
                SetButtonSelected(clickedButton, true);
            }
        }

        private void buttonWaypoint_Click(object sender, EventArgs e)
        {
            if (!isHomePlaced)
            {
                Console.WriteLine("離陸地点が未配置 -> WP不可");
                return;
            }
            ToggleMainButton(buttonWaypoint);
        }

        private void buttonTakeoff_Click(object sender, EventArgs e)
        {
            ToggleMainButton(buttonTakeoff);
        }

        private void buttonLanding_Click(object sender, EventArgs e)
        {
            if (!isHomePlaced)
            {
                Console.WriteLine("離陸地点が未配置 -> Landing不可");
                return;
            }
            ToggleMainButton(buttonLanding);
        }

        private void buttonFence_Click(object sender, EventArgs e)
        {
            if (!isHomePlaced || !isLandingPlaced)
            {
                Console.WriteLine("離陸着陸がない -> Fence不可 (仮のロジック)");
                return;
            }
            ToggleMainButton(buttonFence);
        }

        private void buttonFenceInc_Click(object sender, EventArgs e)
        {
            // 逸脱防止フェンス作成：WPからフェンス多角形を計算し、commandManagerFenceInc に登録する
            List<Locationwp> wps = commandManagerWP.GetCommandList();
            if (wps.Count < 2)
            {
                log.Info("WPが2点未満のため作れません。");
                return;
            }
            try
            {
                double fenceOffset = Settings.Instance.GetDouble("fence_offset", 10.0);
                List<PointLatLng> fencePolygon = fenceCalculator.CalculateFencePolygon(wps, fenceOffset);
                InsertFenceIncPolygonInclusion(fencePolygon);
                mapUpdate();
                log.Info("逸脱防止フェンス（FenceInc）が生成されました。");
                isFenceIncPlaced = true;
                buttonEmergency.Enabled = true;
            }
            catch (Exception ex)
            {
                log.Error("逸脱防止フェンス計算エラー：", ex);
            }
        }

        /// <summary>
        /// 計算済みの逸脱防止フェンス多角形リストを、dataGridViewFenceInc に登録します。
        /// 各行には、FENCE_POLYGON_VERTEX_INCLUSION コマンドを設定します。
        /// </summary>
        /// <param name="polygon">フェンス多角形の頂点リスト</param>
        private void InsertFenceIncPolygonInclusion(List<PointLatLng> polygon)
        {
            dataGridViewFenceInc.Rows.Clear();
            int total = polygon.Count;
            for (int i = 0; i < total; i++)
            {
                commandManagerFenceInc.AddCommand(MAV_CMD.FENCE_POLYGON_VERTEX_INCLUSION, i, total, 0, 0, polygon[i].Lng, polygon[i].Lat, 0);
            }
        }

        private void buttonFenceExc_Click(object sender, EventArgs e)
        {
            // 進入禁止用
            ToggleFenceButton(buttonFenceExc);
        }

        private void buttonEmergency_Click(object sender, EventArgs e)
        {
            if (!isHomePlaced || !isLandingPlaced || !isFenceIncPlaced)
            {
                Console.WriteLine("逸脱防止がない -> Emergency不可 (仮)");
                return;
            }
            ToggleMainButton(buttonEmergency);
        }

        private void DataGridViewWPs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // sender を DataGridView として取得
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            // 行番号は 1 から始まるため、(e.RowIndex + 1) を文字列化
            string rowNumber = (e.RowIndex + 1).ToString();
            if (dgv[0, e.RowIndex].Tag != null)
            {
                if (dgv[0, e.RowIndex].Tag.ToString() == "H")
                    rowNumber = "H";
                else if (dgv[0, e.RowIndex].Tag.ToString() == "G")
                    rowNumber = "G";
            }
            // 行ヘッダーの描画領域を計算
            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth, e.RowBounds.Height);
            // 白色で中央寄せして描画
            TextRenderer.DrawText(e.Graphics, rowNumber, dgv.Font, headerBounds, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void DataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // sender を DataGridView として取得
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            // 行番号は 1 から始まるため、(e.RowIndex + 1) を文字列化
            string rowNumber = (e.RowIndex + 1).ToString();
            // 行ヘッダーの描画領域を計算
            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth, e.RowBounds.Height);
            // 白色で中央寄せして描画
            TextRenderer.DrawText(e.Graphics, rowNumber, dgv.Font, headerBounds, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void checkBoxDisplay_CheckedChanged(object sender, EventArgs e)
        {
            mapManager.OverlayWP.IsVisibile = checkBoxRoute.Checked;
            mapManager.OverlayFenceInc.IsVisibile = checkBoxFence.Checked;
            mapManager.OverlayFenceExc.IsVisibile = checkBoxFence.Checked;
            mapManager.OverlayRally.IsVisibile = checkBoxEmergency.Checked;
            MainMap.Refresh();
        }

        private void pictureBoxZoomIn_Click(object sender, EventArgs e)
        {
            if (MainMap.Zoom < MainMap.MaxZoom)
            {
                MainMap.Zoom++;
                MainMap.Refresh();
            }
        }

        private void pictureBoxZoomOut_Click(object sender, EventArgs e)
        {
            if (MainMap.Zoom > MainMap.MinZoom)
            {
                MainMap.Zoom--;
                MainMap.Refresh();
            }
        }

        // ウェイポイント用の削除処理
        private void dataGridViewWPs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            // 削除用ボタン列の名前は "colWpDelete" としているのでチェックします
            if (dataGridViewWPs.Columns[e.ColumnIndex].Name == "colWpDelete")
            {
                dataGridViewWPs.Rows.RemoveAt(e.RowIndex);
                mapUpdate();
            }
        }

        // 逸脱防止フェンス用の削除処理
        private void dataGridViewFenceInc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (dataGridViewFenceInc.Columns[e.ColumnIndex].Name == "colFenceIncDelete")
            {
                dataGridViewFenceInc.Rows.RemoveAt(e.RowIndex);
                mapUpdate();
            }
        }

        // 進入禁止フェンス用の削除処理
        private void dataGridViewFenceExc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (dataGridViewFenceExc.Columns[e.ColumnIndex].Name == "colFenceExcDelete")
            {
                dataGridViewFenceExc.Rows.RemoveAt(e.RowIndex);
                mapUpdate();
            }
        }

        // 緊急着陸地点用の削除処理
        private void dataGridViewEmergency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (dataGridViewEmergency.Columns[e.ColumnIndex].Name == "colRallyDelete")
            {
                dataGridViewEmergency.Rows.RemoveAt(e.RowIndex);
                mapUpdate();
            }
        }

        private void buttonFileSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "フライトプランファイル (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FlightPlanIO.SaveFlightPlan(sfd.FileName,
                            commandManagerWP, commandManagerFenceInc, commandManagerFenceExc, commandManagerEmergency);
                        MessageBox.Show("フライトプランを保存しました。", "保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("保存エラー: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonFileLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "フライトプランファイル (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // ファイルから各コマンドマネージャへ読み込み
                        FlightPlanIO.LoadFlightPlan(ofd.FileName,
                            commandManagerWP, commandManagerFenceInc, commandManagerFenceExc, commandManagerEmergency);
                        mapUpdate();
                        MainMap.ZoomAndCenterMarkers(mapManager.OverlayWP.Id.ToString());

                        // 読込んだWPリストからHome(離陸地点)とLanding(着陸地点)の有無を判定
                        var wpList = commandManagerWP.GetCommandList();
                        isHomePlaced = false;
                        isLandingPlaced = false;
                        for (int i = 0; i < wpList.Count; i++)
                        {
                            // wp.Tagに値が入っているのは "H" (離陸) と "G" (着陸) のみ
                            if (wpList[i].Tag != null)
                            {
                                string tag = wpList[i].Tag.ToString();
                                if (tag == "H")
                                {
                                    isHomePlaced = true;
                                }
                                if (tag == "G")
                                {
                                    isLandingPlaced = true;
                                }
                            }
                        }
                        // 条件に合わせたボタンの有効化
                        // ウェイポイントボタン：離陸地点が配置されている場合に有効
                        buttonWaypoint.Enabled = isHomePlaced;
                        // 着陸地点ボタン：離陸地点が配置されている場合に有効
                        buttonLanding.Enabled = isHomePlaced;
                        // 一括削除ボタン：離陸地点が配置されている場合に有効
                        buttonBulkDelete.Enabled = isHomePlaced;
                        // フェンスボタン：離陸地点と着陸地点の両方が配置されている場合に有効
                        buttonFence.Enabled = isHomePlaced && isLandingPlaced;
                        // 往復ボタン：離陸地点と着陸地点の両方が配置されている場合に有効
                        buttonRoundTrip.Enabled = isHomePlaced && isLandingPlaced;

                        // 逸脱防止フェンス（FENCE_INCLUTION）の有無で緊急着陸地点ボタンを有効にする
                        var fenceIncList = commandManagerFenceInc.GetCommandList();
                        isFenceIncPlaced = (fenceIncList.Count > 0);
                        buttonEmergency.Enabled = isFenceIncPlaced;
#if !FMS
                        MessageBox.Show("フライトプランを読込しました。", "読込", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("読込エラー: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
#if FMS
        public bool FileLoad()
        {
            buttonFileLoad_Click(null, null);
            var wp = commandManagerWP.GetCommandList();
            var inc = commandManagerFenceInc.GetCommandList();
            var emr = commandManagerEmergency.GetCommandList();
            if (wp.Count > 0 && inc.Count > 0 && emr.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
#endif
        private void buttonBulkDelete_Click(object sender, EventArgs e)
        {
            // 一括削除は離陸地点が配置されている場合にのみ有効
            if (!isHomePlaced)
            {
                MessageBox.Show("離陸地点が配置されていないため、一括削除は実行できません。",
                                "一括削除", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // WP, 逸脱防止フェンス, 進入禁止フェンス, 緊急着陸地点を全て削除
            commandManagerWP.ClearCommands();
            commandManagerFenceInc.ClearCommands();
            commandManagerFenceExc.ClearCommands();
            commandManagerEmergency.ClearCommands();

            // マップの更新
            mapUpdate();

            // 内部状態をリセット
            isHomePlaced = false;
            isLandingPlaced = false;
            isFenceIncPlaced = false;

            // 関連ボタンの有効／無効を更新（離陸・着陸・フェンス・緊急着陸地点ボタンを無効にする）
            buttonWaypoint.Enabled = false;
            buttonLanding.Enabled = false;
            buttonFence.Enabled = false;
            buttonFenceInc.Enabled = false;
            buttonFenceExc.Enabled = false;
            buttonEmergency.Enabled = false;
            buttonBulkDelete.Enabled = false;
            buttonRoundTrip.Enabled = false;

            ClearMainSelection();

            MessageBox.Show("WP、フェンス、緊急着陸地点を全て削除しました。",
                            "一括削除", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRoundTrip_Click(object sender, EventArgs e)
        {
            // 往復は離陸地点と着陸地点の両方が配置されている場合のみ実行可能
            if (!isHomePlaced || !isLandingPlaced)
            {
                MessageBox.Show("離陸地点と着陸地点の両方が配置されていなければ往復は実行できません。",
                                "往復", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // WPリストを取得（WPの先頭は離陸地点(H)、最終行は着陸地点(G)である前提）
            List<Locationwp> wpList = commandManagerWP.GetCommandList();
            if (wpList.Count < 2)
            {
                MessageBox.Show("十分なWPがありません。",
                                "往復", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 入力チェック（先頭がH, 最終行がGであること）
            if (wpList[0].Tag == null || wpList[0].Tag.ToString() != "H" ||
                wpList[wpList.Count - 1].Tag == null || wpList[wpList.Count - 1].Tag.ToString() != "G")
            {
                MessageBox.Show("離陸地点と着陸地点が正しく設定されていません。",
                                "往復", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // WPリストを反転して往復ルートを生成
            List<Locationwp> newList = new List<Locationwp>(wpList);
            newList.Reverse();

            // 反転後、もともとの着陸地点を新たな離陸地点（Tag="H"）に、もともとの離陸地点を新たな着陸地点（Tag="G"）に設定
            newList[0] = new Locationwp
            {
                lat = newList[0].lat,
                lng = newList[0].lng,
                alt = newList[newList.Count - 1].alt,
                id = newList[0].id,
                p1 = newList[0].p1,
                p2 = newList[0].p2,
                p3 = newList[0].p3,
                p4 = newList[0].p4,
                frame = newList[0].frame,
                Tag = "H"  // ここで新しいオブジェクトとして `Tag` を変更
            };
            newList[newList.Count - 1] = new Locationwp
            {
                lat = newList[newList.Count - 1].lat,
                lng = newList[newList.Count - 1].lng,
                alt = 0,
                id = newList[newList.Count - 1].id,
                p1 = newList[newList.Count - 1].p1,
                p2 = newList[newList.Count - 1].p2,
                p3 = newList[newList.Count - 1].p3,
                p4 = newList[newList.Count - 1].p4,
                frame = newList[newList.Count - 1].frame,
                Tag = "G"  // ここも新しいオブジェクトとして `Tag` を変更
            };

            // 現在のWPを全削除し、新たな順序で再登録
            commandManagerWP.ClearCommands();
            foreach (var wp in newList)
            {
                // Tagに応じて適切なコマンドを追加
                if (wp.Tag != null && wp.Tag.ToString() == "H")
                {
                    commandManagerWP.AddCommand(MAV_CMD.TAKEOFF, 0, 0, 0, 0, wp.lng, wp.lat, wp.alt, "H");
                }
                else if (wp.Tag != null && wp.Tag.ToString() == "G")
                {
                    commandManagerWP.AddCommand(MAV_CMD.LAND, 0, 0, 0, 0, wp.lng, wp.lat, wp.alt, "G");
                }
                else
                {
                    commandManagerWP.AddCommand(MAV_CMD.WAYPOINT, 0, 0, 0, 0, wp.lng, wp.lat, wp.alt, "");
                }
            }

            // マップ更新
            mapUpdate();

            MessageBox.Show("往復ルートを生成しました。",
                            "往復", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371; // 地球の半径 [km]
            double dLat = (lat2 - lat1) * Math.PI / 180.0;
            double dLon = (lon2 - lon1) * Math.PI / 180.0;
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(lat1 * Math.PI / 180.0) * Math.Cos(lat2 * Math.PI / 180.0) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        // 距離表示を更新するメソッド（1km未満なら m、1km以上なら km で表示）
        private void UpdateDistanceDisplay()
        {
            // ① ウェイポイント間の合計距離（ルート距離）を計算（単位は km）
            var wpList = commandManagerWP.GetCommandList();
            double routeDistanceKm = 0.0;
            for (int i = 1; i < wpList.Count; i++)
            {
                routeDistanceKm += CalculateDistance(wpList[i - 1].lat, wpList[i - 1].lng, wpList[i].lat, wpList[i].lng);
            }

            // ② 離陸地点（H）と着陸地点（G）の距離を計算
            // Locationwp が値型の場合、Nullable 型を使います
            Locationwp? home = null, landing = null;
            foreach (var wp in wpList)
            {
                if (wp.Tag != null)
                {
                    string tag = wp.Tag.ToString();
                    if (tag == "H")
                        home = wp;
                    else if (tag == "G")
                        landing = wp;
                }
            }
            double homeLandingDistanceKm = 0.0;
            if (home.HasValue && landing.HasValue)
            {
                homeLandingDistanceKm = CalculateDistance(home.Value.lat, home.Value.lng, landing.Value.lat, landing.Value.lng);
            }

            // ③ 距離の文字列をフォーマットする（1km未満は m 表示、1km以上は km 表示）
            string routeDistanceStr = routeDistanceKm < 1.0
                ? string.Format("{0:F0} m", routeDistanceKm * 1000)  // 1000倍して m 単位で表示（小数点はなし）
                : string.Format("{0:F2} km", routeDistanceKm);         // 1km以上は km 単位（小数点以下2桁）

            string homeLandingDistanceStr = homeLandingDistanceKm < 1.0
                ? string.Format("{0:F0} m", homeLandingDistanceKm * 1000)
                : string.Format("{0:F2} km", homeLandingDistanceKm);

            // ④ ラベルに表示（例として "Route: ・・・\nHome-Landing: ・・・" としています）
            labelDistance.Text = string.Format("総航行距離：{0}\n最後のウェイポイントからの距離：{1}", routeDistanceStr, homeLandingDistanceStr);
        }
    }
}
