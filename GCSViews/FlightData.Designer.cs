namespace MissionPlanner.GCSViews
{
    partial class FlightData
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainH = new System.Windows.Forms.SplitContainer();
            this.SubMainLeft = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelMessage = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.labelCutter = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.labelProximity = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelGps = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.labelRoute = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.labelArm = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.hud1 = new MissionPlanner.Controls.HUD();
            this.bindingSourceHud = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlactions = new System.Windows.Forms.TabControl();
            this.tabQuick = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelQuick = new System.Windows.Forms.TableLayoutPanel();
            this.quickView6 = new MissionPlanner.Controls.QuickView();
            this.contextMenuStripQuickView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setViewCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceQuickTab = new System.Windows.Forms.BindingSource(this.components);
            this.quickView5 = new MissionPlanner.Controls.QuickView();
            this.quickView4 = new MissionPlanner.Controls.QuickView();
            this.quickView3 = new MissionPlanner.Controls.QuickView();
            this.quickView2 = new MissionPlanner.Controls.QuickView();
            this.quickView1 = new MissionPlanner.Controls.QuickView();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.BUT_abortland = new MissionPlanner.Controls.MyButton();
            this.BUT_resumemis = new MissionPlanner.Controls.MyButton();
            this.CMB_mountmode = new System.Windows.Forms.ComboBox();
            this.BUT_mountmode = new MissionPlanner.Controls.MyButton();
            this.BUT_ARM = new MissionPlanner.Controls.MyButton();
            this.BUT_joystick = new MissionPlanner.Controls.MyButton();
            this.BUT_quickmanual = new MissionPlanner.Controls.MyButton();
            this.BUT_quickrtl = new MissionPlanner.Controls.MyButton();
            this.BUT_quickauto = new MissionPlanner.Controls.MyButton();
            this.CMB_setwp = new System.Windows.Forms.ComboBox();
            this.BUT_setwp = new MissionPlanner.Controls.MyButton();
            this.CMB_modes = new System.Windows.Forms.ComboBox();
            this.BUT_setmode = new MissionPlanner.Controls.MyButton();
            this.BUT_clear_track = new MissionPlanner.Controls.MyButton();
            this.CMB_action = new System.Windows.Forms.ComboBox();
            this.BUT_Homealt = new MissionPlanner.Controls.MyButton();
            this.BUT_RAWSensor = new MissionPlanner.Controls.MyButton();
            this.BUTrestartmission = new MissionPlanner.Controls.MyButton();
            this.BUTactiondo = new MissionPlanner.Controls.MyButton();
            this.tabActionsSimple = new System.Windows.Forms.TabPage();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton3 = new MissionPlanner.Controls.MyButton();
            this.tabPagePreFlight = new System.Windows.Forms.TabPage();
            this.tabGauges = new System.Windows.Forms.TabPage();
            this.Gvspeed = new AGaugeApp.AGauge();
            this.bindingSourceGaugesTab = new System.Windows.Forms.BindingSource(this.components);
            this.Gheading = new MissionPlanner.Controls.HSI();
            this.Galt = new AGaugeApp.AGauge();
            this.Gspeed = new AGaugeApp.AGauge();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.tabServo = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelServos = new System.Windows.Forms.FlowLayoutPanel();
            this.tabTLogs = new System.Windows.Forms.TabPage();
            this.tableLayoutPaneltlogs = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_loadtelem = new MissionPlanner.Controls.MyButton();
            this.lbl_playbackspeed = new MissionPlanner.Controls.MyLabel();
            this.lbl_logpercent = new MissionPlanner.Controls.MyLabel();
            this.tracklog = new System.Windows.Forms.TrackBar();
            this.LBL_logfn = new MissionPlanner.Controls.MyLabel();
            this.BUT_log2kml = new MissionPlanner.Controls.MyButton();
            this.BUT_playlog = new MissionPlanner.Controls.MyButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BUT_speed10 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed5 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_2 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_4 = new MissionPlanner.Controls.MyButton();
            this.BUT_speed1_10 = new MissionPlanner.Controls.MyButton();
            this.tablogbrowse = new System.Windows.Forms.TabPage();
            this.BUT_loganalysis = new MissionPlanner.Controls.MyButton();
            this.BUT_DFMavlink = new MissionPlanner.Controls.MyButton();
            this.but_dflogtokml = new MissionPlanner.Controls.MyButton();
            this.but_bintolog = new MissionPlanner.Controls.MyButton();
            this.BUT_matlab = new MissionPlanner.Controls.MyButton();
            this.BUT_logbrowse = new MissionPlanner.Controls.MyButton();
            this.tabScripts = new System.Windows.Forms.TabPage();
            this.checkBoxRedirectOutput = new System.Windows.Forms.CheckBox();
            this.BUT_edit_selected = new MissionPlanner.Controls.MyButton();
            this.labelSelectedScript = new System.Windows.Forms.Label();
            this.BUT_run_script = new MissionPlanner.Controls.MyButton();
            this.BUT_abort_script = new MissionPlanner.Controls.MyButton();
            this.labelScriptStatus = new System.Windows.Forms.Label();
            this.BUT_select_script = new MissionPlanner.Controls.MyButton();
            this.tabPagemessages = new System.Windows.Forms.TabPage();
            this.txt_messagebox = new System.Windows.Forms.TextBox();
            this.tabPayload = new System.Windows.Forms.TabPage();
            this.BUT_PayloadFolder = new MissionPlanner.Controls.MyButton();
            this.groupBoxRoll = new System.Windows.Forms.GroupBox();
            this.TXT_gimbalRollPos = new System.Windows.Forms.TextBox();
            this.bindingSourcePayloadTab = new System.Windows.Forms.BindingSource(this.components);
            this.trackBarRoll = new System.Windows.Forms.TrackBar();
            this.groupBoxYaw = new System.Windows.Forms.GroupBox();
            this.TXT_gimbalYawPos = new System.Windows.Forms.TextBox();
            this.trackBarYaw = new System.Windows.Forms.TrackBar();
            this.BUT_resetGimbalPos = new MissionPlanner.Controls.MyButton();
            this.groupBoxPitch = new System.Windows.Forms.GroupBox();
            this.trackBarPitch = new System.Windows.Forms.TrackBar();
            this.TXT_gimbalPitchPos = new System.Windows.Forms.TextBox();
            this.tabActionsNew = new System.Windows.Forms.TabPage();
            this.LblWPno = new System.Windows.Forms.Label();
            this.BtnActKeyClear = new System.Windows.Forms.Button();
            this.BtnActKey0 = new System.Windows.Forms.Button();
            this.BtnActKey3 = new System.Windows.Forms.Button();
            this.BtnActKey2 = new System.Windows.Forms.Button();
            this.BtnActKey1 = new System.Windows.Forms.Button();
            this.BtnActKey6 = new System.Windows.Forms.Button();
            this.BtnActKey5 = new System.Windows.Forms.Button();
            this.BtnActKey4 = new System.Windows.Forms.Button();
            this.BtnActKey9 = new System.Windows.Forms.Button();
            this.BtnActKey8 = new System.Windows.Forms.Button();
            this.BtnActKey7 = new System.Windows.Forms.Button();
            this.BtnActWPset = new System.Windows.Forms.Button();
            this.BtnActReboot = new System.Windows.Forms.Button();
            this.BtnActArm = new System.Windows.Forms.Button();
            this.BtnActLand = new System.Windows.Forms.Button();
            this.BtnActStab = new System.Windows.Forms.Button();
            this.BtnActLoiter = new System.Windows.Forms.Button();
            this.BtnActRtl = new System.Windows.Forms.Button();
            this.BtnAltHold = new System.Windows.Forms.Button();
            this.BtnActAuto = new System.Windows.Forms.Button();
            this.tableMap = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.ButtonPower = new System.Windows.Forms.Button();
            this.ButtonEmergency = new System.Windows.Forms.Button();
            this.ButtonResumeClear = new System.Windows.Forms.Button();
            this.labelResume = new System.Windows.Forms.Label();
            this.LabelCom = new System.Windows.Forms.Label();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.LabelPreArm = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonReturn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.but_disablejoystick = new MissionPlanner.Controls.MyButton();
            this.windDir1 = new MissionPlanner.Controls.WindDir();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_hdop = new MissionPlanner.Controls.MyLabel();
            this.lbl_sats = new MissionPlanner.Controls.MyLabel();
            this.gMapControl1 = new MissionPlanner.Controls.myGMAP();
            this.TRK_zoom = new MissionPlanner.Controls.MyTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.LabelNextWPdist = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelWPno = new System.Windows.Forms.Label();
            this.BUT_zoomOut = new System.Windows.Forms.Button();
            this.BUT_zoomIn = new System.Windows.Forms.Button();
            this.coords1 = new MissionPlanner.Controls.Coords();
            this.Zoomlevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new MissionPlanner.Controls.MyLabel();
            this.CHK_autopan = new System.Windows.Forms.CheckBox();
            this.CB_tuning = new System.Windows.Forms.CheckBox();
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyToHereAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointCameraHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PointCameraCoordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.triggerCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightPlannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setEKFHomeHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHomeHereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.takeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onOffCameraOverlapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altitudeAngelSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripHud = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordHudToAVIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setMJPEGSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGStreamerSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAspectRatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianHudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swapWithMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripactionstab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZedGraphTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openScriptDialog = new System.Windows.Forms.OpenFileDialog();
            this.scriptChecker = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Messagetabtimer = new System.Windows.Forms.Timer(this.components);
            this.bindingSourceStatusTab = new System.Windows.Forms.BindingSource(this.components);
            this.modifyandSetLoiterRad = new MissionPlanner.Controls.ModifyandSet();
            this.modifyandSetSpeed = new MissionPlanner.Controls.ModifyandSet();
            this.modifyandSetAlt = new MissionPlanner.Controls.ModifyandSet();
            this.checkListControl1 = new MissionPlanner.Controls.PreFlight.CheckListControl();
            this.servoOptions1 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions2 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions3 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions4 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions5 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions6 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions7 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions8 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions9 = new MissionPlanner.Controls.ServoOptions();
            this.servoOptions10 = new MissionPlanner.Controls.ServoOptions();
            this.distanceBar1 = new MissionPlanner.Controls.DistanceBar();
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).BeginInit();
            this.MainH.Panel1.SuspendLayout();
            this.MainH.Panel2.SuspendLayout();
            this.MainH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).BeginInit();
            this.SubMainLeft.Panel1.SuspendLayout();
            this.SubMainLeft.Panel2.SuspendLayout();
            this.SubMainLeft.SuspendLayout();
            this.tableLayoutPanelMessage.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).BeginInit();
            this.tabControlactions.SuspendLayout();
            this.tabQuick.SuspendLayout();
            this.tableLayoutPanelQuick.SuspendLayout();
            this.contextMenuStripQuickView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).BeginInit();
            this.tabActions.SuspendLayout();
            this.tabActionsSimple.SuspendLayout();
            this.tabPagePreFlight.SuspendLayout();
            this.tabGauges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).BeginInit();
            this.tabServo.SuspendLayout();
            this.flowLayoutPanelServos.SuspendLayout();
            this.tabTLogs.SuspendLayout();
            this.tableLayoutPaneltlogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).BeginInit();
            this.panel2.SuspendLayout();
            this.tablogbrowse.SuspendLayout();
            this.tabScripts.SuspendLayout();
            this.tabPagemessages.SuspendLayout();
            this.tabPayload.SuspendLayout();
            this.groupBoxRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePayloadTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).BeginInit();
            this.groupBoxYaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYaw)).BeginInit();
            this.groupBoxPitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).BeginInit();
            this.tabActionsNew.SuspendLayout();
            this.tableMap.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).BeginInit();
            this.contextMenuStripMap.SuspendLayout();
            this.contextMenuStripHud.SuspendLayout();
            this.contextMenuStripactionstab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).BeginInit();
            this.SuspendLayout();
            // 
            // MainH
            // 
            this.MainH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.MainH, "MainH");
            this.MainH.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainH.Name = "MainH";
            // 
            // MainH.Panel1
            // 
            this.MainH.Panel1.Controls.Add(this.SubMainLeft);
            // 
            // MainH.Panel2
            // 
            this.MainH.Panel2.Controls.Add(this.tableMap);
            // 
            // SubMainLeft
            // 
            this.SubMainLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.SubMainLeft, "SubMainLeft");
            this.SubMainLeft.Name = "SubMainLeft";
            // 
            // SubMainLeft.Panel1
            // 
            this.SubMainLeft.Panel1.Controls.Add(this.tableLayoutPanelMessage);
            this.SubMainLeft.Panel1.Controls.Add(this.hud1);
            // 
            // SubMainLeft.Panel2
            // 
            this.SubMainLeft.Panel2.Controls.Add(this.tabControlactions);
            // 
            // tableLayoutPanelMessage
            // 
            this.tableLayoutPanelMessage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.tableLayoutPanelMessage, "tableLayoutPanelMessage");
            this.tableLayoutPanelMessage.Controls.Add(this.panel11, 1, 3);
            this.tableLayoutPanelMessage.Controls.Add(this.panel10, 1, 2);
            this.tableLayoutPanelMessage.Controls.Add(this.panel9, 1, 1);
            this.tableLayoutPanelMessage.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanelMessage.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanelMessage.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanelMessage.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanelMessage.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanelMessage.Name = "tableLayoutPanelMessage";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label20);
            this.panel11.Controls.Add(this.labelCutter);
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.BackColor = System.Drawing.Color.Silver;
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Name = "label20";
            this.label20.Tag = "custom";
            // 
            // labelCutter
            // 
            this.labelCutter.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.labelCutter, "labelCutter");
            this.labelCutter.ForeColor = System.Drawing.Color.Black;
            this.labelCutter.Name = "labelCutter";
            this.labelCutter.Tag = "custom";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label18);
            this.panel10.Controls.Add(this.labelProximity);
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Name = "label18";
            this.label18.Tag = "custom";
            // 
            // labelProximity
            // 
            this.labelProximity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.labelProximity, "labelProximity");
            this.labelProximity.ForeColor = System.Drawing.Color.Black;
            this.labelProximity.Name = "labelProximity";
            this.labelProximity.Tag = "custom";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.labelGps);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Silver;
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Name = "label16";
            this.label16.Tag = "custom";
            // 
            // labelGps
            // 
            this.labelGps.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.labelGps, "labelGps");
            this.labelGps.ForeColor = System.Drawing.Color.Black;
            this.labelGps.Name = "labelGps";
            this.labelGps.Tag = "custom";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.labelRoute);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Name = "label14";
            this.label14.Tag = "custom";
            // 
            // labelRoute
            // 
            this.labelRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.labelRoute, "labelRoute");
            this.labelRoute.ForeColor = System.Drawing.Color.Black;
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Tag = "custom";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.labelMode);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Name = "label8";
            this.label8.Tag = "custom";
            // 
            // labelMode
            // 
            this.labelMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.labelMode, "labelMode");
            this.labelMode.ForeColor = System.Drawing.Color.Black;
            this.labelMode.Name = "labelMode";
            this.labelMode.Tag = "custom";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.labelArm);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Name = "label9";
            this.label9.Tag = "custom";
            // 
            // labelArm
            // 
            this.labelArm.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.labelArm, "labelArm");
            this.labelArm.ForeColor = System.Drawing.Color.Red;
            this.labelArm.Name = "labelArm";
            this.labelArm.Tag = "custom";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.labelError);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Name = "label10";
            this.label10.Tag = "custom";
            // 
            // labelError
            // 
            this.labelError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.labelError, "labelError");
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Name = "labelError";
            this.labelError.Tag = "custom";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.labelMessage);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Name = "label11";
            this.label11.Tag = "custom";
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.labelMessage, "labelMessage");
            this.labelMessage.ForeColor = System.Drawing.Color.Black;
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Tag = "custom";
            // 
            // hud1
            // 
            this.hud1.airspeed = 0F;
            this.hud1.alt = 0F;
            this.hud1.altunit = null;
            this.hud1.AOA = 0F;
            this.hud1.BackColor = System.Drawing.Color.Black;
            this.hud1.batterylevel = 0F;
            this.hud1.batteryon = false;
            this.hud1.batteryremaining = 0F;
            this.hud1.bgimage = null;
            this.hud1.connected = false;
            this.hud1.critAOA = 25F;
            this.hud1.critSSA = 30F;
            this.hud1.current = 0F;
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("airspeed", this.bindingSourceHud, "airspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("alt", this.bindingSourceHud, "alt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batterylevel", this.bindingSourceHud, "battery_voltage", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batteryremaining", this.bindingSourceHud, "battery_remaining", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("connected", this.bindingSourceHud, "connected", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("current", this.bindingSourceHud, "current", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("datetime", this.bindingSourceHud, "datetime", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("disttowp", this.bindingSourceHud, "wp_dist", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("ekfstatus", this.bindingSourceHud, "ekfstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("failsafe", this.bindingSourceHud, "failsafe", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix", this.bindingSourceHud, "gpsstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix2", this.bindingSourceHud, "gpsstatus2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop", this.bindingSourceHud, "gpshdop", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop2", this.bindingSourceHud, "gpshdop2", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundalt", this.bindingSourceHud, "HomeAlt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundcourse", this.bindingSourceHud, "groundcourse", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundspeed", this.bindingSourceHud, "groundspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("heading", this.bindingSourceHud, "yaw", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("linkqualitygcs", this.bindingSourceHud, "linkqualitygcs", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("message", this.bindingSourceHud, "messageHigh", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("messagetime", this.bindingSourceHud, "messageHighTime", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("mode", this.bindingSourceHud, "mode", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navpitch", this.bindingSourceHud, "nav_pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navroll", this.bindingSourceHud, "nav_roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("pitch", this.bindingSourceHud, "pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("roll", this.bindingSourceHud, "roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("status", this.bindingSourceHud, "armed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetalt", this.bindingSourceHud, "targetalt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetheading", this.bindingSourceHud, "nav_bearing", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetspeed", this.bindingSourceHud, "targetairspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("turnrate", this.bindingSourceHud, "turnrate", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("verticalspeed", this.bindingSourceHud, "verticalspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibex", this.bindingSourceHud, "vibex", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibey", this.bindingSourceHud, "vibey", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibez", this.bindingSourceHud, "vibez", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("wpno", this.bindingSourceHud, "wpno", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("xtrack_error", this.bindingSourceHud, "xtrack_error", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("AOA", this.bindingSourceHud, "AOA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("SSA", this.bindingSourceHud, "SSA", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("critAOA", this.bindingSourceHud, "crit_AOA", true));
            this.hud1.datetime = new System.DateTime(((long)(0)));
            this.hud1.displayalt = false;
            this.hud1.displayAOASSA = false;
            this.hud1.displayconninfo = false;
            this.hud1.displayekf = false;
            this.hud1.displayheading = false;
            this.hud1.displayrollpitch = false;
            this.hud1.displayspeed = false;
            this.hud1.displayvibe = false;
            this.hud1.displayxtrack = false;
            this.hud1.disttowp = 0F;
            this.hud1.distunit = null;
            resources.ApplyResources(this.hud1, "hud1");
            this.hud1.ekfstatus = 0F;
            this.hud1.failsafe = false;
            this.hud1.gpsfix = 0F;
            this.hud1.gpsfix2 = 0F;
            this.hud1.gpshdop = 0F;
            this.hud1.gpshdop2 = 0F;
            this.hud1.gpstext = "GPS: No GPS";
            this.hud1.groundalt = 0F;
            this.hud1.groundColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(184)))), ((int)(((byte)(36)))));
            this.hud1.groundColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(79)))), ((int)(((byte)(7)))));
            this.hud1.groundcourse = 0F;
            this.hud1.groundspeed = 0F;
            this.hud1.heading = 0F;
            this.hud1.hudcolor = System.Drawing.Color.LightGray;
            this.hud1.linkqualitygcs = 0F;
            this.hud1.lowairspeed = false;
            this.hud1.lowgroundspeed = false;
            this.hud1.lowvoltagealert = false;
            this.hud1.message = "";
            this.hud1.messagetime = new System.DateTime(((long)(0)));
            this.hud1.mode = "Unknown";
            this.hud1.Name = "hud1";
            this.hud1.navpitch = 0F;
            this.hud1.navroll = 0F;
            this.hud1.pitch = 0F;
            this.hud1.roll = 0F;
            this.hud1.Russian = false;
            this.hud1.skyColor1 = System.Drawing.Color.Blue;
            this.hud1.skyColor2 = System.Drawing.Color.LightBlue;
            this.hud1.speedunit = null;
            this.hud1.SSA = 0F;
            this.hud1.status = false;
            this.hud1.streamjpg = null;
            this.hud1.targetalt = 0F;
            this.hud1.targetheading = 0F;
            this.hud1.targetspeed = 0F;
            this.hud1.turnrate = 0F;
            this.hud1.verticalspeed = 0F;
            this.hud1.vibex = 0F;
            this.hud1.vibey = 0F;
            this.hud1.vibez = 0F;
            this.hud1.VSync = false;
            this.hud1.wpno = 0;
            this.hud1.xtrack_error = 0F;
            this.hud1.ekfclick += new System.EventHandler(this.hud1_ekfclick);
            this.hud1.vibeclick += new System.EventHandler(this.hud1_vibeclick);
            this.hud1.DoubleClick += new System.EventHandler(this.hud1_DoubleClick);
            this.hud1.Resize += new System.EventHandler(this.hud1_Resize);
            // 
            // bindingSourceHud
            // 
            this.bindingSourceHud.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // tabControlactions
            // 
            this.tabControlactions.Controls.Add(this.tabQuick);
            this.tabControlactions.Controls.Add(this.tabActions);
            this.tabControlactions.Controls.Add(this.tabActionsSimple);
            this.tabControlactions.Controls.Add(this.tabPagePreFlight);
            this.tabControlactions.Controls.Add(this.tabGauges);
            this.tabControlactions.Controls.Add(this.tabStatus);
            this.tabControlactions.Controls.Add(this.tabServo);
            this.tabControlactions.Controls.Add(this.tabTLogs);
            this.tabControlactions.Controls.Add(this.tablogbrowse);
            this.tabControlactions.Controls.Add(this.tabScripts);
            this.tabControlactions.Controls.Add(this.tabPagemessages);
            this.tabControlactions.Controls.Add(this.tabPayload);
            this.tabControlactions.Controls.Add(this.tabActionsNew);
            resources.ApplyResources(this.tabControlactions, "tabControlactions");
            this.tabControlactions.Multiline = true;
            this.tabControlactions.Name = "tabControlactions";
            this.tabControlactions.SelectedIndex = 0;
            this.tabControlactions.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlactions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControlactions.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabQuick
            // 
            resources.ApplyResources(this.tabQuick, "tabQuick");
            this.tabQuick.Controls.Add(this.tableLayoutPanelQuick);
            this.tabQuick.Name = "tabQuick";
            this.tabQuick.UseVisualStyleBackColor = true;
            this.tabQuick.Resize += new System.EventHandler(this.tabQuick_Resize);
            // 
            // tableLayoutPanelQuick
            // 
            resources.ApplyResources(this.tableLayoutPanelQuick, "tableLayoutPanelQuick");
            this.tableLayoutPanelQuick.Controls.Add(this.quickView6, 1, 2);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView5, 0, 2);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView4, 1, 1);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView3, 0, 1);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView2, 1, 0);
            this.tableLayoutPanelQuick.Controls.Add(this.quickView1, 0, 0);
            this.tableLayoutPanelQuick.Name = "tableLayoutPanelQuick";
            // 
            // quickView6
            // 
            this.quickView6.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView6.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "DistToHome", true));
            this.quickView6.desc = "DistToMAV";
            resources.ApplyResources(this.quickView6, "quickView6");
            this.quickView6.Name = "quickView6";
            this.quickView6.number = 0D;
            this.quickView6.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.quickView6.numberformat = "0.00";
            this.quickView6.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // contextMenuStripQuickView
            // 
            this.contextMenuStripQuickView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setViewCountToolStripMenuItem});
            this.contextMenuStripQuickView.Name = "contextMenuStripQuickView";
            resources.ApplyResources(this.contextMenuStripQuickView, "contextMenuStripQuickView");
            // 
            // setViewCountToolStripMenuItem
            // 
            this.setViewCountToolStripMenuItem.Name = "setViewCountToolStripMenuItem";
            resources.ApplyResources(this.setViewCountToolStripMenuItem, "setViewCountToolStripMenuItem");
            this.setViewCountToolStripMenuItem.Click += new System.EventHandler(this.setViewCountToolStripMenuItem_Click);
            // 
            // bindingSourceQuickTab
            // 
            this.bindingSourceQuickTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // quickView5
            // 
            this.quickView5.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView5.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "verticalspeed", true));
            this.quickView5.desc = "verticalspeed";
            resources.ApplyResources(this.quickView5, "quickView5");
            this.quickView5.Name = "quickView5";
            this.quickView5.number = 0D;
            this.quickView5.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(86)))));
            this.quickView5.numberformat = "0.00";
            this.quickView5.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView4
            // 
            this.quickView4.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView4.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "yaw", true));
            this.quickView4.desc = "yaw";
            resources.ApplyResources(this.quickView4, "quickView4");
            this.quickView4.Name = "quickView4";
            this.quickView4.number = 0D;
            this.quickView4.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(83)))));
            this.quickView4.numberformat = "0.00";
            this.quickView4.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView3
            // 
            this.quickView3.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView3.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "wp_dist", true));
            this.quickView3.desc = "wp_dist";
            resources.ApplyResources(this.quickView3, "quickView3");
            this.quickView3.Name = "quickView3";
            this.quickView3.number = 0D;
            this.quickView3.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(91)))));
            this.quickView3.numberformat = "0.00";
            this.quickView3.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView2
            // 
            this.quickView2.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView2.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "groundspeed", true));
            this.quickView2.desc = "groundspeed";
            resources.ApplyResources(this.quickView2, "quickView2");
            this.quickView2.Name = "quickView2";
            this.quickView2.number = 0D;
            this.quickView2.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(132)))), ((int)(((byte)(46)))));
            this.quickView2.numberformat = "0.00";
            this.quickView2.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // quickView1
            // 
            this.quickView1.ContextMenuStrip = this.contextMenuStripQuickView;
            this.quickView1.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceQuickTab, "alt", true));
            this.quickView1.desc = "alt";
            resources.ApplyResources(this.quickView1, "quickView1");
            this.quickView1.Name = "quickView1";
            this.quickView1.number = 0D;
            this.quickView1.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(151)))), ((int)(((byte)(248)))));
            this.quickView1.numberformat = "0.00";
            this.toolTip1.SetToolTip(this.quickView1, resources.GetString("quickView1.ToolTip"));
            this.quickView1.DoubleClick += new System.EventHandler(this.quickView_DoubleClick);
            // 
            // tabActions
            // 
            this.tabActions.Controls.Add(this.modifyandSetLoiterRad);
            this.tabActions.Controls.Add(this.BUT_abortland);
            this.tabActions.Controls.Add(this.BUT_resumemis);
            this.tabActions.Controls.Add(this.CMB_mountmode);
            this.tabActions.Controls.Add(this.BUT_mountmode);
            this.tabActions.Controls.Add(this.BUT_ARM);
            this.tabActions.Controls.Add(this.BUT_joystick);
            this.tabActions.Controls.Add(this.BUT_quickmanual);
            this.tabActions.Controls.Add(this.BUT_quickrtl);
            this.tabActions.Controls.Add(this.BUT_quickauto);
            this.tabActions.Controls.Add(this.CMB_setwp);
            this.tabActions.Controls.Add(this.BUT_setwp);
            this.tabActions.Controls.Add(this.CMB_modes);
            this.tabActions.Controls.Add(this.BUT_setmode);
            this.tabActions.Controls.Add(this.BUT_clear_track);
            this.tabActions.Controls.Add(this.CMB_action);
            this.tabActions.Controls.Add(this.BUT_Homealt);
            this.tabActions.Controls.Add(this.BUT_RAWSensor);
            this.tabActions.Controls.Add(this.BUTrestartmission);
            this.tabActions.Controls.Add(this.BUTactiondo);
            this.tabActions.Controls.Add(this.modifyandSetSpeed);
            this.tabActions.Controls.Add(this.modifyandSetAlt);
            resources.ApplyResources(this.tabActions, "tabActions");
            this.tabActions.Name = "tabActions";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // BUT_abortland
            // 
            this.BUT_abortland.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_abortland.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_abortland.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_abortland, "BUT_abortland");
            this.BUT_abortland.Name = "BUT_abortland";
            this.toolTip1.SetToolTip(this.BUT_abortland, resources.GetString("BUT_abortland.ToolTip"));
            this.BUT_abortland.UseVisualStyleBackColor = true;
            this.BUT_abortland.Click += new System.EventHandler(this.BUT_abortland_Click);
            // 
            // BUT_resumemis
            // 
            this.BUT_resumemis.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_resumemis.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_resumemis.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_resumemis, "BUT_resumemis");
            this.BUT_resumemis.Name = "BUT_resumemis";
            this.BUT_resumemis.UseVisualStyleBackColor = true;
            this.BUT_resumemis.Click += new System.EventHandler(this.BUT_resumemis_Click);
            // 
            // CMB_mountmode
            // 
            this.CMB_mountmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_mountmode.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_mountmode, "CMB_mountmode");
            this.CMB_mountmode.Name = "CMB_mountmode";
            // 
            // BUT_mountmode
            // 
            this.BUT_mountmode.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_mountmode.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_mountmode.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_mountmode, "BUT_mountmode");
            this.BUT_mountmode.Name = "BUT_mountmode";
            this.toolTip1.SetToolTip(this.BUT_mountmode, resources.GetString("BUT_mountmode.ToolTip"));
            this.BUT_mountmode.UseVisualStyleBackColor = true;
            this.BUT_mountmode.Click += new System.EventHandler(this.BUT_mountmode_Click);
            // 
            // BUT_ARM
            // 
            this.BUT_ARM.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_ARM.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_ARM.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_ARM, "BUT_ARM");
            this.BUT_ARM.Name = "BUT_ARM";
            this.toolTip1.SetToolTip(this.BUT_ARM, resources.GetString("BUT_ARM.ToolTip"));
            this.BUT_ARM.UseVisualStyleBackColor = true;
            this.BUT_ARM.Click += new System.EventHandler(this.BUT_ARM_Click);
            // 
            // BUT_joystick
            // 
            this.BUT_joystick.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_joystick.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_joystick.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_joystick, "BUT_joystick");
            this.BUT_joystick.Name = "BUT_joystick";
            this.toolTip1.SetToolTip(this.BUT_joystick, resources.GetString("BUT_joystick.ToolTip"));
            this.BUT_joystick.UseVisualStyleBackColor = true;
            this.BUT_joystick.Click += new System.EventHandler(this.BUT_joystick_Click);
            // 
            // BUT_quickmanual
            // 
            this.BUT_quickmanual.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickmanual.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickmanual.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_quickmanual, "BUT_quickmanual");
            this.BUT_quickmanual.Name = "BUT_quickmanual";
            this.toolTip1.SetToolTip(this.BUT_quickmanual, resources.GetString("BUT_quickmanual.ToolTip"));
            this.BUT_quickmanual.UseVisualStyleBackColor = true;
            this.BUT_quickmanual.Click += new System.EventHandler(this.BUT_quickmanual_Click);
            // 
            // BUT_quickrtl
            // 
            this.BUT_quickrtl.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickrtl.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickrtl.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_quickrtl, "BUT_quickrtl");
            this.BUT_quickrtl.Name = "BUT_quickrtl";
            this.toolTip1.SetToolTip(this.BUT_quickrtl, resources.GetString("BUT_quickrtl.ToolTip"));
            this.BUT_quickrtl.UseVisualStyleBackColor = true;
            this.BUT_quickrtl.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // BUT_quickauto
            // 
            this.BUT_quickauto.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_quickauto.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_quickauto.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_quickauto, "BUT_quickauto");
            this.BUT_quickauto.Name = "BUT_quickauto";
            this.toolTip1.SetToolTip(this.BUT_quickauto, resources.GetString("BUT_quickauto.ToolTip"));
            this.BUT_quickauto.UseVisualStyleBackColor = true;
            this.BUT_quickauto.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // CMB_setwp
            // 
            this.CMB_setwp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_setwp.FormattingEnabled = true;
            this.CMB_setwp.Items.AddRange(new object[] {
            resources.GetString("CMB_setwp.Items")});
            resources.ApplyResources(this.CMB_setwp, "CMB_setwp");
            this.CMB_setwp.Name = "CMB_setwp";
            this.CMB_setwp.Click += new System.EventHandler(this.CMB_setwp_Click);
            // 
            // BUT_setwp
            // 
            this.BUT_setwp.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_setwp.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_setwp.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_setwp, "BUT_setwp");
            this.BUT_setwp.Name = "BUT_setwp";
            this.toolTip1.SetToolTip(this.BUT_setwp, resources.GetString("BUT_setwp.ToolTip"));
            this.BUT_setwp.UseVisualStyleBackColor = true;
            this.BUT_setwp.Click += new System.EventHandler(this.BUT_setwp_Click);
            // 
            // CMB_modes
            // 
            this.CMB_modes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_modes.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_modes, "CMB_modes");
            this.CMB_modes.Name = "CMB_modes";
            this.CMB_modes.Click += new System.EventHandler(this.CMB_modes_Click);
            // 
            // BUT_setmode
            // 
            this.BUT_setmode.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_setmode.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_setmode.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_setmode, "BUT_setmode");
            this.BUT_setmode.Name = "BUT_setmode";
            this.toolTip1.SetToolTip(this.BUT_setmode, resources.GetString("BUT_setmode.ToolTip"));
            this.BUT_setmode.UseVisualStyleBackColor = true;
            this.BUT_setmode.Click += new System.EventHandler(this.BUT_setmode_Click);
            // 
            // BUT_clear_track
            // 
            this.BUT_clear_track.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_clear_track.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_clear_track.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_clear_track, "BUT_clear_track");
            this.BUT_clear_track.Name = "BUT_clear_track";
            this.toolTip1.SetToolTip(this.BUT_clear_track, resources.GetString("BUT_clear_track.ToolTip"));
            this.BUT_clear_track.UseVisualStyleBackColor = true;
            this.BUT_clear_track.Click += new System.EventHandler(this.BUT_clear_track_Click);
            // 
            // CMB_action
            // 
            this.CMB_action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_action.DropDownWidth = 150;
            this.CMB_action.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_action, "CMB_action");
            this.CMB_action.Name = "CMB_action";
            // 
            // BUT_Homealt
            // 
            this.BUT_Homealt.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_Homealt.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_Homealt.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_Homealt, "BUT_Homealt");
            this.BUT_Homealt.Name = "BUT_Homealt";
            this.toolTip1.SetToolTip(this.BUT_Homealt, resources.GetString("BUT_Homealt.ToolTip"));
            this.BUT_Homealt.UseVisualStyleBackColor = true;
            this.BUT_Homealt.Click += new System.EventHandler(this.BUT_Homealt_Click);
            // 
            // BUT_RAWSensor
            // 
            this.BUT_RAWSensor.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_RAWSensor.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_RAWSensor.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_RAWSensor, "BUT_RAWSensor");
            this.BUT_RAWSensor.Name = "BUT_RAWSensor";
            this.toolTip1.SetToolTip(this.BUT_RAWSensor, resources.GetString("BUT_RAWSensor.ToolTip"));
            this.BUT_RAWSensor.UseVisualStyleBackColor = true;
            this.BUT_RAWSensor.Click += new System.EventHandler(this.BUT_RAWSensor_Click);
            // 
            // BUTrestartmission
            // 
            this.BUTrestartmission.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUTrestartmission.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUTrestartmission.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUTrestartmission, "BUTrestartmission");
            this.BUTrestartmission.Name = "BUTrestartmission";
            this.toolTip1.SetToolTip(this.BUTrestartmission, resources.GetString("BUTrestartmission.ToolTip"));
            this.BUTrestartmission.UseVisualStyleBackColor = true;
            this.BUTrestartmission.Click += new System.EventHandler(this.BUTrestartmission_Click);
            // 
            // BUTactiondo
            // 
            this.BUTactiondo.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUTactiondo.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUTactiondo.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUTactiondo, "BUTactiondo");
            this.BUTactiondo.Name = "BUTactiondo";
            this.toolTip1.SetToolTip(this.BUTactiondo, resources.GetString("BUTactiondo.ToolTip"));
            this.BUTactiondo.UseVisualStyleBackColor = true;
            this.BUTactiondo.Click += new System.EventHandler(this.BUTactiondo_Click);
            // 
            // tabActionsSimple
            // 
            this.tabActionsSimple.Controls.Add(this.myButton1);
            this.tabActionsSimple.Controls.Add(this.myButton2);
            this.tabActionsSimple.Controls.Add(this.myButton3);
            resources.ApplyResources(this.tabActionsSimple, "tabActionsSimple");
            this.tabActionsSimple.Name = "tabActionsSimple";
            this.tabActionsSimple.UseVisualStyleBackColor = true;
            // 
            // myButton1
            // 
            this.myButton1.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton1.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton1.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.Name = "myButton1";
            this.toolTip1.SetToolTip(this.myButton1, resources.GetString("myButton1.ToolTip"));
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.BUT_quickmanual_Click);
            // 
            // myButton2
            // 
            this.myButton2.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton2.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton2.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.Name = "myButton2";
            this.toolTip1.SetToolTip(this.myButton2, resources.GetString("myButton2.ToolTip"));
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // myButton3
            // 
            this.myButton3.ColorMouseDown = System.Drawing.Color.Empty;
            this.myButton3.ColorMouseOver = System.Drawing.Color.Empty;
            this.myButton3.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.myButton3, "myButton3");
            this.myButton3.Name = "myButton3";
            this.toolTip1.SetToolTip(this.myButton3, resources.GetString("myButton3.ToolTip"));
            this.myButton3.UseVisualStyleBackColor = true;
            this.myButton3.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // tabPagePreFlight
            // 
            this.tabPagePreFlight.Controls.Add(this.checkListControl1);
            resources.ApplyResources(this.tabPagePreFlight, "tabPagePreFlight");
            this.tabPagePreFlight.Name = "tabPagePreFlight";
            this.tabPagePreFlight.UseVisualStyleBackColor = true;
            // 
            // tabGauges
            // 
            this.tabGauges.Controls.Add(this.Gvspeed);
            this.tabGauges.Controls.Add(this.Gheading);
            this.tabGauges.Controls.Add(this.Galt);
            this.tabGauges.Controls.Add(this.Gspeed);
            resources.ApplyResources(this.tabGauges, "tabGauges");
            this.tabGauges.Name = "tabGauges";
            this.tabGauges.UseVisualStyleBackColor = true;
            this.tabGauges.Resize += new System.EventHandler(this.tabPage1_Resize);
            // 
            // Gvspeed
            // 
            this.Gvspeed.BackColor = System.Drawing.Color.Transparent;
            this.Gvspeed.BackgroundImage = global::MissionPlanner.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.Gvspeed, "Gvspeed");
            this.Gvspeed.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gvspeed.BaseArcRadius = 60;
            this.Gvspeed.BaseArcStart = 20;
            this.Gvspeed.BaseArcSweep = 320;
            this.Gvspeed.BaseArcWidth = 2;
            this.Gvspeed.Cap_Idx = ((byte)(0));
            this.Gvspeed.CapColor = System.Drawing.Color.White;
            this.Gvspeed.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gvspeed.CapPosition = new System.Drawing.Point(65, 85);
            this.Gvspeed.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(65, 85),
        new System.Drawing.Point(30, 55),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gvspeed.CapsText = new string[] {
        "VSI",
        "",
        "",
        "",
        ""};
            this.Gvspeed.CapText = "VSI";
            this.Gvspeed.Center = new System.Drawing.Point(75, 75);
            this.Gvspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "verticalspeed", true));
            this.Gvspeed.MaxValue = 10F;
            this.Gvspeed.MinValue = -10F;
            this.Gvspeed.Name = "Gvspeed";
            this.Gvspeed.Need_Idx = ((byte)(3));
            this.Gvspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gvspeed.NeedleColor2 = System.Drawing.Color.White;
            this.Gvspeed.NeedleEnabled = false;
            this.Gvspeed.NeedleRadius = 80;
            this.Gvspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gvspeed.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.Gvspeed.NeedlesEnabled = new bool[] {
        true,
        false,
        false,
        false};
            this.Gvspeed.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.Gvspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gvspeed.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.Gvspeed.NeedleType = 0;
            this.Gvspeed.NeedleWidth = 2;
            this.Gvspeed.Range_Idx = ((byte)(0));
            this.Gvspeed.RangeColor = System.Drawing.Color.LightGreen;
            this.Gvspeed.RangeEnabled = false;
            this.Gvspeed.RangeEndValue = 360F;
            this.Gvspeed.RangeInnerRadius = 1;
            this.Gvspeed.RangeOuterRadius = 60;
            this.Gvspeed.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gvspeed.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gvspeed.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.Gvspeed.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gvspeed.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.Gvspeed.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.Gvspeed.RangeStartValue = 0F;
            this.Gvspeed.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesInterInnerRadius = 52;
            this.Gvspeed.ScaleLinesInterOuterRadius = 60;
            this.Gvspeed.ScaleLinesInterWidth = 1;
            this.Gvspeed.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gvspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gvspeed.ScaleLinesMajorStepValue = 2F;
            this.Gvspeed.ScaleLinesMajorWidth = 2;
            this.Gvspeed.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gvspeed.ScaleLinesMinorNumOf = 9;
            this.Gvspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gvspeed.ScaleLinesMinorWidth = 1;
            this.Gvspeed.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gvspeed.ScaleNumbersFormat = "";
            this.Gvspeed.ScaleNumbersRadius = 42;
            this.Gvspeed.ScaleNumbersRotation = 0;
            this.Gvspeed.ScaleNumbersStartScaleLine = 1;
            this.Gvspeed.ScaleNumbersStepScaleLines = 1;
            this.Gvspeed.Value = 0F;
            this.Gvspeed.Value0 = 0F;
            this.Gvspeed.Value1 = 0F;
            this.Gvspeed.Value2 = 0F;
            this.Gvspeed.Value3 = 0F;
            // 
            // bindingSourceGaugesTab
            // 
            this.bindingSourceGaugesTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // Gheading
            // 
            this.Gheading.BackColor = System.Drawing.Color.Transparent;
            this.Gheading.BackgroundImage = global::MissionPlanner.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.Gheading, "Gheading");
            this.Gheading.DataBindings.Add(new System.Windows.Forms.Binding("Heading", this.bindingSourceGaugesTab, "yaw", true));
            this.Gheading.DataBindings.Add(new System.Windows.Forms.Binding("NavHeading", this.bindingSourceGaugesTab, "nav_bearing", true));
            this.Gheading.Heading = 0;
            this.Gheading.Name = "Gheading";
            this.Gheading.NavHeading = 0;
            // 
            // Galt
            // 
            this.Galt.BackColor = System.Drawing.Color.Transparent;
            this.Galt.BackgroundImage = global::MissionPlanner.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.Galt, "Galt");
            this.Galt.BaseArcColor = System.Drawing.Color.Transparent;
            this.Galt.BaseArcRadius = 60;
            this.Galt.BaseArcStart = 270;
            this.Galt.BaseArcSweep = 360;
            this.Galt.BaseArcWidth = 2;
            this.Galt.Cap_Idx = ((byte)(0));
            this.Galt.CapColor = System.Drawing.Color.White;
            this.Galt.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Galt.CapPosition = new System.Drawing.Point(68, 85);
            this.Galt.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(68, 85),
        new System.Drawing.Point(30, 55),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Galt.CapsText = new string[] {
        "Alt",
        "",
        "",
        "",
        ""};
            this.Galt.CapText = "Alt";
            this.Galt.Center = new System.Drawing.Point(75, 75);
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "altd100", true));
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSourceGaugesTab, "altd1000", true));
            this.Galt.DataBindings.Add(new System.Windows.Forms.Binding("Value2", this.bindingSourceGaugesTab, "targetaltd100", true));
            this.Galt.MaxValue = 9.99F;
            this.Galt.MinValue = 0F;
            this.Galt.Name = "Galt";
            this.Galt.Need_Idx = ((byte)(3));
            this.Galt.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Galt.NeedleColor2 = System.Drawing.Color.White;
            this.Galt.NeedleEnabled = false;
            this.Galt.NeedleRadius = 80;
            this.Galt.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Galt.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.Galt.NeedlesEnabled = new bool[] {
        true,
        true,
        true,
        false};
            this.Galt.NeedlesRadius = new int[] {
        50,
        30,
        50,
        80};
            this.Galt.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Galt.NeedlesWidth = new int[] {
        2,
        2,
        2,
        2};
            this.Galt.NeedleType = 0;
            this.Galt.NeedleWidth = 2;
            this.Galt.Range_Idx = ((byte)(0));
            this.Galt.RangeColor = System.Drawing.Color.LightGreen;
            this.Galt.RangeEnabled = false;
            this.Galt.RangeEndValue = 360F;
            this.Galt.RangeInnerRadius = 1;
            this.Galt.RangeOuterRadius = 60;
            this.Galt.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Galt.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Galt.RangesEndValue = new float[] {
        360F,
        200F,
        150F,
        0F,
        0F};
            this.Galt.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Galt.RangesOuterRadius = new int[] {
        60,
        60,
        60,
        80,
        80};
            this.Galt.RangesStartValue = new float[] {
        0F,
        150F,
        75F,
        0F,
        0F};
            this.Galt.RangeStartValue = 0F;
            this.Galt.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesInterInnerRadius = 52;
            this.Galt.ScaleLinesInterOuterRadius = 60;
            this.Galt.ScaleLinesInterWidth = 1;
            this.Galt.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesMajorInnerRadius = 50;
            this.Galt.ScaleLinesMajorOuterRadius = 60;
            this.Galt.ScaleLinesMajorStepValue = 1F;
            this.Galt.ScaleLinesMajorWidth = 2;
            this.Galt.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Galt.ScaleLinesMinorInnerRadius = 55;
            this.Galt.ScaleLinesMinorNumOf = 9;
            this.Galt.ScaleLinesMinorOuterRadius = 60;
            this.Galt.ScaleLinesMinorWidth = 1;
            this.Galt.ScaleNumbersColor = System.Drawing.Color.White;
            this.Galt.ScaleNumbersFormat = "";
            this.Galt.ScaleNumbersRadius = 42;
            this.Galt.ScaleNumbersRotation = 0;
            this.Galt.ScaleNumbersStartScaleLine = 1;
            this.Galt.ScaleNumbersStepScaleLines = 1;
            this.Galt.Value = 0F;
            this.Galt.Value0 = 0F;
            this.Galt.Value1 = 0F;
            this.Galt.Value2 = 0F;
            this.Galt.Value3 = 0F;
            // 
            // Gspeed
            // 
            this.Gspeed.BackColor = System.Drawing.Color.Transparent;
            this.Gspeed.BackgroundImage = global::MissionPlanner.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.Gspeed, "Gspeed");
            this.Gspeed.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gspeed.BaseArcRadius = 70;
            this.Gspeed.BaseArcStart = 135;
            this.Gspeed.BaseArcSweep = 270;
            this.Gspeed.BaseArcWidth = 2;
            this.Gspeed.Cap_Idx = ((byte)(0));
            this.Gspeed.CapColor = System.Drawing.Color.White;
            this.Gspeed.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gspeed.CapPosition = new System.Drawing.Point(58, 85);
            this.Gspeed.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gspeed.CapsText = new string[] {
        "Speed",
        "",
        "",
        "",
        ""};
            this.Gspeed.CapText = "Speed";
            this.Gspeed.Center = new System.Drawing.Point(75, 75);
            this.Gspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSourceGaugesTab, "airspeed", true));
            this.Gspeed.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSourceGaugesTab, "groundspeed", true));
            this.Gspeed.MaxValue = 60F;
            this.Gspeed.MinValue = 0F;
            this.Gspeed.Name = "Gspeed";
            this.Gspeed.Need_Idx = ((byte)(3));
            this.Gspeed.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gspeed.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gspeed.NeedleEnabled = false;
            this.Gspeed.NeedleRadius = 70;
            this.Gspeed.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gspeed.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gspeed.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gspeed.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gspeed.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gspeed.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gspeed.NeedleType = 0;
            this.Gspeed.NeedleWidth = 2;
            this.Gspeed.Range_Idx = ((byte)(2));
            this.Gspeed.RangeColor = System.Drawing.Color.Orange;
            this.Gspeed.RangeEnabled = false;
            this.Gspeed.RangeEndValue = 50F;
            this.Gspeed.RangeInnerRadius = 1;
            this.Gspeed.RangeOuterRadius = 70;
            this.Gspeed.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gspeed.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gspeed.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gspeed.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gspeed.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gspeed.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gspeed.RangeStartValue = 35F;
            this.Gspeed.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesInterInnerRadius = 52;
            this.Gspeed.ScaleLinesInterOuterRadius = 60;
            this.Gspeed.ScaleLinesInterWidth = 1;
            this.Gspeed.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMajorInnerRadius = 50;
            this.Gspeed.ScaleLinesMajorOuterRadius = 60;
            this.Gspeed.ScaleLinesMajorStepValue = 10F;
            this.Gspeed.ScaleLinesMajorWidth = 2;
            this.Gspeed.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gspeed.ScaleLinesMinorInnerRadius = 55;
            this.Gspeed.ScaleLinesMinorNumOf = 9;
            this.Gspeed.ScaleLinesMinorOuterRadius = 60;
            this.Gspeed.ScaleLinesMinorWidth = 1;
            this.Gspeed.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gspeed.ScaleNumbersFormat = null;
            this.Gspeed.ScaleNumbersRadius = 42;
            this.Gspeed.ScaleNumbersRotation = 0;
            this.Gspeed.ScaleNumbersStartScaleLine = 1;
            this.Gspeed.ScaleNumbersStepScaleLines = 1;
            this.toolTip1.SetToolTip(this.Gspeed, resources.GetString("Gspeed.ToolTip"));
            this.Gspeed.Value = 0F;
            this.Gspeed.Value0 = 0F;
            this.Gspeed.Value1 = 0F;
            this.Gspeed.Value2 = 0F;
            this.Gspeed.Value3 = 0F;
            this.Gspeed.DoubleClick += new System.EventHandler(this.Gspeed_DoubleClick);
            // 
            // tabStatus
            // 
            resources.ApplyResources(this.tabStatus, "tabStatus");
            this.tabStatus.Name = "tabStatus";
            // 
            // tabServo
            // 
            this.tabServo.Controls.Add(this.flowLayoutPanelServos);
            resources.ApplyResources(this.tabServo, "tabServo");
            this.tabServo.Name = "tabServo";
            this.tabServo.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelServos
            // 
            resources.ApplyResources(this.flowLayoutPanelServos, "flowLayoutPanelServos");
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions1);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions2);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions3);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions4);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions5);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions6);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions7);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions8);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions9);
            this.flowLayoutPanelServos.Controls.Add(this.servoOptions10);
            this.flowLayoutPanelServos.Name = "flowLayoutPanelServos";
            // 
            // tabTLogs
            // 
            this.tabTLogs.Controls.Add(this.tableLayoutPaneltlogs);
            resources.ApplyResources(this.tabTLogs, "tabTLogs");
            this.tabTLogs.Name = "tabTLogs";
            this.tabTLogs.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPaneltlogs
            // 
            resources.ApplyResources(this.tableLayoutPaneltlogs, "tableLayoutPaneltlogs");
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_loadtelem, 0, 0);
            this.tableLayoutPaneltlogs.Controls.Add(this.lbl_playbackspeed, 2, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.lbl_logpercent, 2, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.tracklog, 1, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.LBL_logfn, 1, 0);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_log2kml, 0, 2);
            this.tableLayoutPaneltlogs.Controls.Add(this.BUT_playlog, 0, 1);
            this.tableLayoutPaneltlogs.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPaneltlogs.Name = "tableLayoutPaneltlogs";
            // 
            // BUT_loadtelem
            // 
            this.BUT_loadtelem.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_loadtelem.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_loadtelem, "BUT_loadtelem");
            this.BUT_loadtelem.Name = "BUT_loadtelem";
            this.BUT_loadtelem.UseVisualStyleBackColor = true;
            this.BUT_loadtelem.Click += new System.EventHandler(this.BUT_loadtelem_Click);
            // 
            // lbl_playbackspeed
            // 
            resources.ApplyResources(this.lbl_playbackspeed, "lbl_playbackspeed");
            this.lbl_playbackspeed.Name = "lbl_playbackspeed";
            this.lbl_playbackspeed.resize = false;
            // 
            // lbl_logpercent
            // 
            resources.ApplyResources(this.lbl_logpercent, "lbl_logpercent");
            this.lbl_logpercent.Name = "lbl_logpercent";
            this.lbl_logpercent.resize = false;
            // 
            // tracklog
            // 
            resources.ApplyResources(this.tracklog, "tracklog");
            this.tracklog.Maximum = 100;
            this.tracklog.Name = "tracklog";
            this.tracklog.TickFrequency = 5;
            this.tracklog.Scroll += new System.EventHandler(this.tracklog_Scroll);
            // 
            // LBL_logfn
            // 
            this.tableLayoutPaneltlogs.SetColumnSpan(this.LBL_logfn, 2);
            resources.ApplyResources(this.LBL_logfn, "LBL_logfn");
            this.LBL_logfn.Name = "LBL_logfn";
            this.LBL_logfn.resize = false;
            // 
            // BUT_log2kml
            // 
            this.BUT_log2kml.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_log2kml.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_log2kml.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_log2kml, "BUT_log2kml");
            this.BUT_log2kml.Name = "BUT_log2kml";
            this.BUT_log2kml.UseVisualStyleBackColor = true;
            this.BUT_log2kml.Click += new System.EventHandler(this.BUT_log2kml_Click);
            // 
            // BUT_playlog
            // 
            this.BUT_playlog.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_playlog.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_playlog, "BUT_playlog");
            this.BUT_playlog.Name = "BUT_playlog";
            this.BUT_playlog.UseVisualStyleBackColor = true;
            this.BUT_playlog.Click += new System.EventHandler(this.BUT_playlog_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BUT_speed10);
            this.panel2.Controls.Add(this.BUT_speed5);
            this.panel2.Controls.Add(this.BUT_speed2);
            this.panel2.Controls.Add(this.BUT_speed1);
            this.panel2.Controls.Add(this.BUT_speed1_2);
            this.panel2.Controls.Add(this.BUT_speed1_4);
            this.panel2.Controls.Add(this.BUT_speed1_10);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // BUT_speed10
            // 
            this.BUT_speed10.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed10.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed10.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed10, "BUT_speed10");
            this.BUT_speed10.Name = "BUT_speed10";
            this.BUT_speed10.Tag = "10";
            this.BUT_speed10.UseVisualStyleBackColor = true;
            this.BUT_speed10.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed5
            // 
            this.BUT_speed5.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed5.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed5.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed5, "BUT_speed5");
            this.BUT_speed5.Name = "BUT_speed5";
            this.BUT_speed5.Tag = "5";
            this.BUT_speed5.UseVisualStyleBackColor = true;
            this.BUT_speed5.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed2
            // 
            this.BUT_speed2.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed2.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed2.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed2, "BUT_speed2");
            this.BUT_speed2.Name = "BUT_speed2";
            this.BUT_speed2.Tag = "2";
            this.BUT_speed2.UseVisualStyleBackColor = true;
            this.BUT_speed2.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1
            // 
            this.BUT_speed1.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1, "BUT_speed1");
            this.BUT_speed1.Name = "BUT_speed1";
            this.BUT_speed1.Tag = "1";
            this.BUT_speed1.UseVisualStyleBackColor = true;
            this.BUT_speed1.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_2
            // 
            this.BUT_speed1_2.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_2.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_2.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1_2, "BUT_speed1_2");
            this.BUT_speed1_2.Name = "BUT_speed1_2";
            this.BUT_speed1_2.Tag = "0.5";
            this.BUT_speed1_2.UseVisualStyleBackColor = true;
            this.BUT_speed1_2.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_4
            // 
            this.BUT_speed1_4.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_4.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_4.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1_4, "BUT_speed1_4");
            this.BUT_speed1_4.Name = "BUT_speed1_4";
            this.BUT_speed1_4.Tag = "0.25";
            this.BUT_speed1_4.UseVisualStyleBackColor = true;
            this.BUT_speed1_4.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // BUT_speed1_10
            // 
            this.BUT_speed1_10.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_speed1_10.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_speed1_10.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_speed1_10, "BUT_speed1_10");
            this.BUT_speed1_10.Name = "BUT_speed1_10";
            this.BUT_speed1_10.Tag = "0.1";
            this.BUT_speed1_10.UseVisualStyleBackColor = true;
            this.BUT_speed1_10.Click += new System.EventHandler(this.BUT_speed1_Click);
            // 
            // tablogbrowse
            // 
            this.tablogbrowse.Controls.Add(this.BUT_loganalysis);
            this.tablogbrowse.Controls.Add(this.BUT_DFMavlink);
            this.tablogbrowse.Controls.Add(this.but_dflogtokml);
            this.tablogbrowse.Controls.Add(this.but_bintolog);
            this.tablogbrowse.Controls.Add(this.BUT_matlab);
            this.tablogbrowse.Controls.Add(this.BUT_logbrowse);
            resources.ApplyResources(this.tablogbrowse, "tablogbrowse");
            this.tablogbrowse.Name = "tablogbrowse";
            this.tablogbrowse.UseVisualStyleBackColor = true;
            // 
            // BUT_loganalysis
            // 
            this.BUT_loganalysis.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_loganalysis.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_loganalysis.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_loganalysis, "BUT_loganalysis");
            this.BUT_loganalysis.Name = "BUT_loganalysis";
            this.BUT_loganalysis.UseVisualStyleBackColor = true;
            this.BUT_loganalysis.Click += new System.EventHandler(this.BUT_loganalysis_Click);
            // 
            // BUT_DFMavlink
            // 
            this.BUT_DFMavlink.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_DFMavlink.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_DFMavlink.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_DFMavlink, "BUT_DFMavlink");
            this.BUT_DFMavlink.Name = "BUT_DFMavlink";
            this.BUT_DFMavlink.UseVisualStyleBackColor = true;
            this.BUT_DFMavlink.Click += new System.EventHandler(this.BUT_DFMavlink_Click);
            // 
            // but_dflogtokml
            // 
            this.but_dflogtokml.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_dflogtokml.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_dflogtokml.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.but_dflogtokml, "but_dflogtokml");
            this.but_dflogtokml.Name = "but_dflogtokml";
            this.but_dflogtokml.UseVisualStyleBackColor = true;
            this.but_dflogtokml.Click += new System.EventHandler(this.but_dflogtokml_Click);
            // 
            // but_bintolog
            // 
            this.but_bintolog.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_bintolog.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_bintolog.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.but_bintolog, "but_bintolog");
            this.but_bintolog.Name = "but_bintolog";
            this.but_bintolog.UseVisualStyleBackColor = true;
            this.but_bintolog.Click += new System.EventHandler(this.but_bintolog_Click);
            // 
            // BUT_matlab
            // 
            this.BUT_matlab.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_matlab.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_matlab.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_matlab, "BUT_matlab");
            this.BUT_matlab.Name = "BUT_matlab";
            this.BUT_matlab.UseVisualStyleBackColor = true;
            this.BUT_matlab.Click += new System.EventHandler(this.BUT_matlab_Click);
            // 
            // BUT_logbrowse
            // 
            this.BUT_logbrowse.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_logbrowse.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_logbrowse.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_logbrowse, "BUT_logbrowse");
            this.BUT_logbrowse.Name = "BUT_logbrowse";
            this.BUT_logbrowse.UseVisualStyleBackColor = true;
            this.BUT_logbrowse.Click += new System.EventHandler(this.BUT_logbrowse_Click);
            // 
            // tabScripts
            // 
            this.tabScripts.Controls.Add(this.checkBoxRedirectOutput);
            this.tabScripts.Controls.Add(this.BUT_edit_selected);
            this.tabScripts.Controls.Add(this.labelSelectedScript);
            this.tabScripts.Controls.Add(this.BUT_run_script);
            this.tabScripts.Controls.Add(this.BUT_abort_script);
            this.tabScripts.Controls.Add(this.labelScriptStatus);
            this.tabScripts.Controls.Add(this.BUT_select_script);
            resources.ApplyResources(this.tabScripts, "tabScripts");
            this.tabScripts.Name = "tabScripts";
            this.tabScripts.UseVisualStyleBackColor = true;
            // 
            // checkBoxRedirectOutput
            // 
            resources.ApplyResources(this.checkBoxRedirectOutput, "checkBoxRedirectOutput");
            this.checkBoxRedirectOutput.Checked = true;
            this.checkBoxRedirectOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRedirectOutput.Name = "checkBoxRedirectOutput";
            this.checkBoxRedirectOutput.UseVisualStyleBackColor = true;
            // 
            // BUT_edit_selected
            // 
            this.BUT_edit_selected.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_edit_selected.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_edit_selected.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_edit_selected, "BUT_edit_selected");
            this.BUT_edit_selected.Name = "BUT_edit_selected";
            this.BUT_edit_selected.UseVisualStyleBackColor = true;
            this.BUT_edit_selected.Click += new System.EventHandler(this.BUT_edit_selected_Click);
            // 
            // labelSelectedScript
            // 
            resources.ApplyResources(this.labelSelectedScript, "labelSelectedScript");
            this.labelSelectedScript.Name = "labelSelectedScript";
            // 
            // BUT_run_script
            // 
            this.BUT_run_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_run_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_run_script.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_run_script, "BUT_run_script");
            this.BUT_run_script.Name = "BUT_run_script";
            this.BUT_run_script.UseVisualStyleBackColor = true;
            this.BUT_run_script.Click += new System.EventHandler(this.BUT_run_script_Click);
            // 
            // BUT_abort_script
            // 
            this.BUT_abort_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_abort_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_abort_script.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_abort_script, "BUT_abort_script");
            this.BUT_abort_script.Name = "BUT_abort_script";
            this.BUT_abort_script.UseVisualStyleBackColor = true;
            this.BUT_abort_script.Click += new System.EventHandler(this.BUT_abort_script_Click);
            // 
            // labelScriptStatus
            // 
            resources.ApplyResources(this.labelScriptStatus, "labelScriptStatus");
            this.labelScriptStatus.Name = "labelScriptStatus";
            // 
            // BUT_select_script
            // 
            this.BUT_select_script.ColorMouseDown = System.Drawing.Color.Empty;
            this.BUT_select_script.ColorMouseOver = System.Drawing.Color.Empty;
            this.BUT_select_script.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.BUT_select_script, "BUT_select_script");
            this.BUT_select_script.Name = "BUT_select_script";
            this.BUT_select_script.UseVisualStyleBackColor = true;
            this.BUT_select_script.Click += new System.EventHandler(this.BUT_select_script_Click);
            // 
            // tabPagemessages
            // 
            this.tabPagemessages.Controls.Add(this.txt_messagebox);
            resources.ApplyResources(this.tabPagemessages, "tabPagemessages");
            this.tabPagemessages.Name = "tabPagemessages";
            this.tabPagemessages.UseVisualStyleBackColor = true;
            // 
            // txt_messagebox
            // 
            resources.ApplyResources(this.txt_messagebox, "txt_messagebox");
            this.txt_messagebox.Name = "txt_messagebox";
            // 
            // tabPayload
            // 
            this.tabPayload.Controls.Add(this.BUT_PayloadFolder);
            this.tabPayload.Controls.Add(this.groupBoxRoll);
            this.tabPayload.Controls.Add(this.groupBoxYaw);
            this.tabPayload.Controls.Add(this.BUT_resetGimbalPos);
            this.tabPayload.Controls.Add(this.groupBoxPitch);
            resources.ApplyResources(this.tabPayload, "tabPayload");
            this.tabPayload.Name = "tabPayload";
            this.tabPayload.UseVisualStyleBackColor = true;
            // 
            // BUT_PayloadFolder
            // 
            resources.ApplyResources(this.BUT_PayloadFolder, "BUT_PayloadFolder");
            this.BUT_PayloadFolder.Name = "BUT_PayloadFolder";
            this.BUT_PayloadFolder.UseVisualStyleBackColor = true;
            // 
            // groupBoxRoll
            // 
            this.groupBoxRoll.Controls.Add(this.TXT_gimbalRollPos);
            this.groupBoxRoll.Controls.Add(this.trackBarRoll);
            resources.ApplyResources(this.groupBoxRoll, "groupBoxRoll");
            this.groupBoxRoll.Name = "groupBoxRoll";
            this.groupBoxRoll.TabStop = false;
            // 
            // TXT_gimbalRollPos
            // 
            this.TXT_gimbalRollPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointb", true));
            resources.ApplyResources(this.TXT_gimbalRollPos, "TXT_gimbalRollPos");
            this.TXT_gimbalRollPos.Name = "TXT_gimbalRollPos";
            // 
            // bindingSourcePayloadTab
            // 
            this.bindingSourcePayloadTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // trackBarRoll
            // 
            resources.ApplyResources(this.trackBarRoll, "trackBarRoll");
            this.trackBarRoll.LargeChange = 10;
            this.trackBarRoll.Maximum = 45;
            this.trackBarRoll.Minimum = -45;
            this.trackBarRoll.Name = "trackBarRoll";
            this.trackBarRoll.TickFrequency = 10;
            this.trackBarRoll.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // groupBoxYaw
            // 
            this.groupBoxYaw.Controls.Add(this.TXT_gimbalYawPos);
            this.groupBoxYaw.Controls.Add(this.trackBarYaw);
            resources.ApplyResources(this.groupBoxYaw, "groupBoxYaw");
            this.groupBoxYaw.Name = "groupBoxYaw";
            this.groupBoxYaw.TabStop = false;
            // 
            // TXT_gimbalYawPos
            // 
            this.TXT_gimbalYawPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointc", true));
            resources.ApplyResources(this.TXT_gimbalYawPos, "TXT_gimbalYawPos");
            this.TXT_gimbalYawPos.Name = "TXT_gimbalYawPos";
            // 
            // trackBarYaw
            // 
            resources.ApplyResources(this.trackBarYaw, "trackBarYaw");
            this.trackBarYaw.LargeChange = 10;
            this.trackBarYaw.Maximum = 45;
            this.trackBarYaw.Minimum = -45;
            this.trackBarYaw.Name = "trackBarYaw";
            this.trackBarYaw.TickFrequency = 10;
            this.trackBarYaw.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // BUT_resetGimbalPos
            // 
            resources.ApplyResources(this.BUT_resetGimbalPos, "BUT_resetGimbalPos");
            this.BUT_resetGimbalPos.Name = "BUT_resetGimbalPos";
            this.BUT_resetGimbalPos.UseVisualStyleBackColor = true;
            this.BUT_resetGimbalPos.Click += new System.EventHandler(this.BUT_resetGimbalPos_Click);
            // 
            // groupBoxPitch
            // 
            this.groupBoxPitch.Controls.Add(this.trackBarPitch);
            this.groupBoxPitch.Controls.Add(this.TXT_gimbalPitchPos);
            resources.ApplyResources(this.groupBoxPitch, "groupBoxPitch");
            this.groupBoxPitch.Name = "groupBoxPitch";
            this.groupBoxPitch.TabStop = false;
            // 
            // trackBarPitch
            // 
            resources.ApplyResources(this.trackBarPitch, "trackBarPitch");
            this.trackBarPitch.LargeChange = 10;
            this.trackBarPitch.Maximum = 45;
            this.trackBarPitch.Minimum = -45;
            this.trackBarPitch.Name = "trackBarPitch";
            this.trackBarPitch.SmallChange = 5;
            this.trackBarPitch.TickFrequency = 10;
            this.trackBarPitch.Scroll += new System.EventHandler(this.gimbalTrackbar_Scroll);
            // 
            // TXT_gimbalPitchPos
            // 
            this.TXT_gimbalPitchPos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePayloadTab, "campointa", true));
            resources.ApplyResources(this.TXT_gimbalPitchPos, "TXT_gimbalPitchPos");
            this.TXT_gimbalPitchPos.Name = "TXT_gimbalPitchPos";
            // 
            // tabActionsNew
            // 
            this.tabActionsNew.Controls.Add(this.LblWPno);
            this.tabActionsNew.Controls.Add(this.BtnActKeyClear);
            this.tabActionsNew.Controls.Add(this.BtnActKey0);
            this.tabActionsNew.Controls.Add(this.BtnActKey3);
            this.tabActionsNew.Controls.Add(this.BtnActKey2);
            this.tabActionsNew.Controls.Add(this.BtnActKey1);
            this.tabActionsNew.Controls.Add(this.BtnActKey6);
            this.tabActionsNew.Controls.Add(this.BtnActKey5);
            this.tabActionsNew.Controls.Add(this.BtnActKey4);
            this.tabActionsNew.Controls.Add(this.BtnActKey9);
            this.tabActionsNew.Controls.Add(this.BtnActKey8);
            this.tabActionsNew.Controls.Add(this.BtnActKey7);
            this.tabActionsNew.Controls.Add(this.BtnActWPset);
            this.tabActionsNew.Controls.Add(this.BtnActReboot);
            this.tabActionsNew.Controls.Add(this.BtnActArm);
            this.tabActionsNew.Controls.Add(this.BtnActLand);
            this.tabActionsNew.Controls.Add(this.BtnActStab);
            this.tabActionsNew.Controls.Add(this.BtnActLoiter);
            this.tabActionsNew.Controls.Add(this.BtnActRtl);
            this.tabActionsNew.Controls.Add(this.BtnAltHold);
            this.tabActionsNew.Controls.Add(this.BtnActAuto);
            resources.ApplyResources(this.tabActionsNew, "tabActionsNew");
            this.tabActionsNew.Name = "tabActionsNew";
            this.tabActionsNew.UseVisualStyleBackColor = true;
            // 
            // LblWPno
            // 
            this.LblWPno.BackColor = System.Drawing.SystemColors.Control;
            this.LblWPno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.LblWPno, "LblWPno");
            this.LblWPno.Name = "LblWPno";
            // 
            // BtnActKeyClear
            // 
            this.BtnActKeyClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtnActKeyClear, "BtnActKeyClear");
            this.BtnActKeyClear.FlatAppearance.BorderSize = 0;
            this.BtnActKeyClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActKeyClear.Name = "BtnActKeyClear";
            this.BtnActKeyClear.UseVisualStyleBackColor = false;
            this.BtnActKeyClear.Click += new System.EventHandler(this.BtnActKeyClear_Click);
            // 
            // BtnActKey0
            // 
            this.BtnActKey0.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtnActKey0, "BtnActKey0");
            this.BtnActKey0.FlatAppearance.BorderSize = 0;
            this.BtnActKey0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActKey0.Name = "BtnActKey0";
            this.BtnActKey0.Tag = "0";
            this.BtnActKey0.UseVisualStyleBackColor = false;
            this.BtnActKey0.Click += new System.EventHandler(this.BtnActKey_Click);
            // 
            // BtnActKey3
            // 
            this.BtnActKey3.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtnActKey3, "BtnActKey3");
            this.BtnActKey3.FlatAppearance.BorderSize = 0;
            this.BtnActKey3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActKey3.Name = "BtnActKey3";
            this.BtnActKey3.Tag = "3";
            this.BtnActKey3.UseVisualStyleBackColor = false;
            this.BtnActKey3.Click += new System.EventHandler(this.BtnActKey_Click);
            // 
            // BtnActKey2
            // 
            this.BtnActKey2.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtnActKey2, "BtnActKey2");
            this.BtnActKey2.FlatAppearance.BorderSize = 0;
            this.BtnActKey2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActKey2.Name = "BtnActKey2";
            this.BtnActKey2.Tag = "2";
            this.BtnActKey2.UseVisualStyleBackColor = false;
            this.BtnActKey2.Click += new System.EventHandler(this.BtnActKey_Click);
            // 
            // BtnActKey1
            // 
            this.BtnActKey1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtnActKey1, "BtnActKey1");
            this.BtnActKey1.FlatAppearance.BorderSize = 0;
            this.BtnActKey1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActKey1.Name = "BtnActKey1";
            this.BtnActKey1.Tag = "1";
            this.BtnActKey1.UseVisualStyleBackColor = false;
            this.BtnActKey1.Click += new System.EventHandler(this.BtnActKey_Click);
            // 
            // BtnActKey6
            // 
            this.BtnActKey6.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtnActKey6, "BtnActKey6");
            this.BtnActKey6.FlatAppearance.BorderSize = 0;
            this.BtnActKey6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActKey6.Name = "BtnActKey6";
            this.BtnActKey6.Tag = "6";
            this.BtnActKey6.UseVisualStyleBackColor = false;
            this.BtnActKey6.Click += new System.EventHandler(this.BtnActKey_Click);
            // 
            // BtnActKey5
            // 
            this.BtnActKey5.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtnActKey5, "BtnActKey5");
            this.BtnActKey5.FlatAppearance.BorderSize = 0;
            this.BtnActKey5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActKey5.Name = "BtnActKey5";
            this.BtnActKey5.Tag = "5";
            this.BtnActKey5.UseVisualStyleBackColor = false;
            this.BtnActKey5.Click += new System.EventHandler(this.BtnActKey_Click);
            // 
            // BtnActKey4
            // 
            this.BtnActKey4.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtnActKey4, "BtnActKey4");
            this.BtnActKey4.FlatAppearance.BorderSize = 0;
            this.BtnActKey4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActKey4.Name = "BtnActKey4";
            this.BtnActKey4.Tag = "4";
            this.BtnActKey4.UseVisualStyleBackColor = false;
            this.BtnActKey4.Click += new System.EventHandler(this.BtnActKey_Click);
            // 
            // BtnActKey9
            // 
            this.BtnActKey9.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtnActKey9, "BtnActKey9");
            this.BtnActKey9.FlatAppearance.BorderSize = 0;
            this.BtnActKey9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActKey9.Name = "BtnActKey9";
            this.BtnActKey9.Tag = "9";
            this.BtnActKey9.UseVisualStyleBackColor = false;
            this.BtnActKey9.Click += new System.EventHandler(this.BtnActKey_Click);
            // 
            // BtnActKey8
            // 
            this.BtnActKey8.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtnActKey8, "BtnActKey8");
            this.BtnActKey8.FlatAppearance.BorderSize = 0;
            this.BtnActKey8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActKey8.Name = "BtnActKey8";
            this.BtnActKey8.Tag = "8";
            this.BtnActKey8.UseVisualStyleBackColor = false;
            this.BtnActKey8.Click += new System.EventHandler(this.BtnActKey_Click);
            // 
            // BtnActKey7
            // 
            this.BtnActKey7.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.BtnActKey7, "BtnActKey7");
            this.BtnActKey7.FlatAppearance.BorderSize = 0;
            this.BtnActKey7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActKey7.Name = "BtnActKey7";
            this.BtnActKey7.Tag = "7";
            this.BtnActKey7.UseVisualStyleBackColor = false;
            this.BtnActKey7.Click += new System.EventHandler(this.BtnActKey_Click);
            // 
            // BtnActWPset
            // 
            this.BtnActWPset.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnActWPset, "BtnActWPset");
            this.BtnActWPset.FlatAppearance.BorderSize = 0;
            this.BtnActWPset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActWPset.Name = "BtnActWPset";
            this.toolTip1.SetToolTip(this.BtnActWPset, resources.GetString("BtnActWPset.ToolTip"));
            this.BtnActWPset.UseVisualStyleBackColor = false;
            this.BtnActWPset.Click += new System.EventHandler(this.BtnActWPset_Click);
            // 
            // BtnActReboot
            // 
            this.BtnActReboot.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnActReboot, "BtnActReboot");
            this.BtnActReboot.FlatAppearance.BorderSize = 0;
            this.BtnActReboot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActReboot.Name = "BtnActReboot";
            this.toolTip1.SetToolTip(this.BtnActReboot, resources.GetString("BtnActReboot.ToolTip"));
            this.BtnActReboot.UseVisualStyleBackColor = false;
            this.BtnActReboot.Click += new System.EventHandler(this.BtnActReboot_Click);
            // 
            // BtnActArm
            // 
            this.BtnActArm.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnActArm, "BtnActArm");
            this.BtnActArm.FlatAppearance.BorderSize = 0;
            this.BtnActArm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActArm.Name = "BtnActArm";
            this.toolTip1.SetToolTip(this.BtnActArm, resources.GetString("BtnActArm.ToolTip"));
            this.BtnActArm.UseVisualStyleBackColor = false;
            this.BtnActArm.Click += new System.EventHandler(this.BUT_ARM_Click);
            // 
            // BtnActLand
            // 
            this.BtnActLand.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnActLand, "BtnActLand");
            this.BtnActLand.FlatAppearance.BorderSize = 0;
            this.BtnActLand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActLand.Name = "BtnActLand";
            this.toolTip1.SetToolTip(this.BtnActLand, resources.GetString("BtnActLand.ToolTip"));
            this.BtnActLand.UseVisualStyleBackColor = false;
            this.BtnActLand.Click += new System.EventHandler(this.BtnActLand_Click);
            // 
            // BtnActStab
            // 
            this.BtnActStab.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnActStab, "BtnActStab");
            this.BtnActStab.FlatAppearance.BorderSize = 0;
            this.BtnActStab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActStab.Name = "BtnActStab";
            this.toolTip1.SetToolTip(this.BtnActStab, resources.GetString("BtnActStab.ToolTip"));
            this.BtnActStab.UseVisualStyleBackColor = false;
            this.BtnActStab.Click += new System.EventHandler(this.BtnActStab_Click);
            // 
            // BtnActLoiter
            // 
            this.BtnActLoiter.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnActLoiter, "BtnActLoiter");
            this.BtnActLoiter.FlatAppearance.BorderSize = 0;
            this.BtnActLoiter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActLoiter.Name = "BtnActLoiter";
            this.toolTip1.SetToolTip(this.BtnActLoiter, resources.GetString("BtnActLoiter.ToolTip"));
            this.BtnActLoiter.UseVisualStyleBackColor = false;
            this.BtnActLoiter.Click += new System.EventHandler(this.BUT_quickmanual_Click);
            // 
            // BtnActRtl
            // 
            this.BtnActRtl.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnActRtl, "BtnActRtl");
            this.BtnActRtl.FlatAppearance.BorderSize = 0;
            this.BtnActRtl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActRtl.Name = "BtnActRtl";
            this.toolTip1.SetToolTip(this.BtnActRtl, resources.GetString("BtnActRtl.ToolTip"));
            this.BtnActRtl.UseVisualStyleBackColor = false;
            this.BtnActRtl.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // BtnAltHold
            // 
            this.BtnAltHold.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnAltHold, "BtnAltHold");
            this.BtnAltHold.FlatAppearance.BorderSize = 0;
            this.BtnAltHold.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAltHold.Name = "BtnAltHold";
            this.toolTip1.SetToolTip(this.BtnAltHold, resources.GetString("BtnAltHold.ToolTip"));
            this.BtnAltHold.UseVisualStyleBackColor = false;
            this.BtnAltHold.Click += new System.EventHandler(this.BtnAltHold_Click);
            // 
            // BtnActAuto
            // 
            this.BtnActAuto.BackColor = System.Drawing.Color.Transparent;
            this.BtnActAuto.BackgroundImage = global::MissionPlanner.Properties.Resources.btn_act_auto;
            resources.ApplyResources(this.BtnActAuto, "BtnActAuto");
            this.BtnActAuto.FlatAppearance.BorderSize = 0;
            this.BtnActAuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActAuto.Name = "BtnActAuto";
            this.toolTip1.SetToolTip(this.BtnActAuto, resources.GetString("BtnActAuto.ToolTip"));
            this.BtnActAuto.UseVisualStyleBackColor = false;
            this.BtnActAuto.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // tableMap
            // 
            resources.ApplyResources(this.tableMap, "tableMap");
            this.tableMap.Controls.Add(this.panel3, 0, 0);
            this.tableMap.Controls.Add(this.splitContainer1, 0, 1);
            this.tableMap.Controls.Add(this.panel1, 0, 2);
            this.tableMap.Name = "tableMap";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ButtonMode);
            this.panel3.Controls.Add(this.ButtonPower);
            this.panel3.Controls.Add(this.ButtonEmergency);
            this.panel3.Controls.Add(this.ButtonResumeClear);
            this.panel3.Controls.Add(this.labelResume);
            this.panel3.Controls.Add(this.LabelCom);
            this.panel3.Controls.Add(this.ButtonConnect);
            this.panel3.Controls.Add(this.LabelPreArm);
            this.panel3.Controls.Add(this.ButtonStart);
            this.panel3.Controls.Add(this.ButtonStop);
            this.panel3.Controls.Add(this.ButtonReturn);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // ButtonMode
            // 
            this.ButtonMode.BackColor = System.Drawing.Color.MediumOrchid;
            resources.ApplyResources(this.ButtonMode, "ButtonMode");
            this.ButtonMode.FlatAppearance.BorderSize = 0;
            this.ButtonMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonMode.Name = "ButtonMode";
            this.toolTip1.SetToolTip(this.ButtonMode, resources.GetString("ButtonMode.ToolTip"));
            this.ButtonMode.UseVisualStyleBackColor = false;
            this.ButtonMode.Click += new System.EventHandler(this.ButtonMode_Click);
            // 
            // ButtonPower
            // 
            this.ButtonPower.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.ButtonPower, "ButtonPower");
            this.ButtonPower.FlatAppearance.BorderSize = 0;
            this.ButtonPower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonPower.Name = "ButtonPower";
            this.toolTip1.SetToolTip(this.ButtonPower, resources.GetString("ButtonPower.ToolTip"));
            this.ButtonPower.UseVisualStyleBackColor = false;
            this.ButtonPower.Click += new System.EventHandler(this.ButtonPower_Click);
            // 
            // ButtonEmergency
            // 
            this.ButtonEmergency.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.ButtonEmergency, "ButtonEmergency");
            this.ButtonEmergency.FlatAppearance.BorderSize = 0;
            this.ButtonEmergency.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonEmergency.Name = "ButtonEmergency";
            this.toolTip1.SetToolTip(this.ButtonEmergency, resources.GetString("ButtonEmergency.ToolTip"));
            this.ButtonEmergency.UseVisualStyleBackColor = false;
            this.ButtonEmergency.Click += new System.EventHandler(this.ButtonEmergency_Click);
            // 
            // ButtonResumeClear
            // 
            resources.ApplyResources(this.ButtonResumeClear, "ButtonResumeClear");
            this.ButtonResumeClear.BackColor = System.Drawing.Color.Transparent;
            this.ButtonResumeClear.BackgroundImage = global::MissionPlanner.Properties.Resources.btn_resume_clear;
            this.ButtonResumeClear.FlatAppearance.BorderSize = 0;
            this.ButtonResumeClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonResumeClear.Name = "ButtonResumeClear";
            this.toolTip1.SetToolTip(this.ButtonResumeClear, resources.GetString("ButtonResumeClear.ToolTip"));
            this.ButtonResumeClear.UseVisualStyleBackColor = false;
            this.ButtonResumeClear.Click += new System.EventHandler(this.ButtonResumeClear_Click);
            // 
            // labelResume
            // 
            resources.ApplyResources(this.labelResume, "labelResume");
            this.labelResume.BackColor = System.Drawing.Color.Transparent;
            this.labelResume.ForeColor = System.Drawing.Color.Red;
            this.labelResume.Name = "labelResume";
            this.labelResume.Tag = "custom";
            // 
            // LabelCom
            // 
            resources.ApplyResources(this.LabelCom, "LabelCom");
            this.LabelCom.BackColor = System.Drawing.Color.Red;
            this.LabelCom.ForeColor = System.Drawing.Color.Black;
            this.LabelCom.Name = "LabelCom";
            this.LabelCom.Tag = "custom";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.BackColor = System.Drawing.Color.Transparent;
            this.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonConnect.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonConnect, "ButtonConnect");
            this.ButtonConnect.ForeColor = System.Drawing.Color.Black;
            this.ButtonConnect.Image = global::MissionPlanner.Properties.Resources.light_connect_icon;
            this.ButtonConnect.Name = "ButtonConnect";
            this.toolTip1.SetToolTip(this.ButtonConnect, resources.GetString("ButtonConnect.ToolTip"));
            this.ButtonConnect.UseVisualStyleBackColor = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // LabelPreArm
            // 
            resources.ApplyResources(this.LabelPreArm, "LabelPreArm");
            this.LabelPreArm.BackColor = System.Drawing.SystemColors.Desktop;
            this.LabelPreArm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelPreArm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelPreArm.Image = global::MissionPlanner.Properties.Resources.btn_flight_ok;
            this.LabelPreArm.Name = "LabelPreArm";
            this.LabelPreArm.Tag = "custom";
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.SystemColors.Desktop;
            this.ButtonStart.BackgroundImage = global::MissionPlanner.Properties.Resources.btn_start;
            resources.ApplyResources(this.ButtonStart, "ButtonStart");
            this.ButtonStart.FlatAppearance.BorderSize = 0;
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonStart.Name = "ButtonStart";
            this.toolTip1.SetToolTip(this.ButtonStart, resources.GetString("ButtonStart.ToolTip"));
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.SystemColors.Desktop;
            this.ButtonStop.BackgroundImage = global::MissionPlanner.Properties.Resources.btn_stop;
            resources.ApplyResources(this.ButtonStop, "ButtonStop");
            this.ButtonStop.FlatAppearance.BorderSize = 0;
            this.ButtonStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonStop.Name = "ButtonStop";
            this.toolTip1.SetToolTip(this.ButtonStop, resources.GetString("ButtonStop.ToolTip"));
            this.ButtonStop.UseVisualStyleBackColor = false;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonReturn
            // 
            this.ButtonReturn.BackColor = System.Drawing.SystemColors.Desktop;
            this.ButtonReturn.BackgroundImage = global::MissionPlanner.Properties.Resources.btn_return;
            resources.ApplyResources(this.ButtonReturn, "ButtonReturn");
            this.ButtonReturn.FlatAppearance.BorderSize = 0;
            this.ButtonReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonReturn.Name = "ButtonReturn";
            this.toolTip1.SetToolTip(this.ButtonReturn, resources.GetString("ButtonReturn.ToolTip"));
            this.ButtonReturn.UseVisualStyleBackColor = false;
            this.ButtonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.zg1);
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.but_disablejoystick);
            this.splitContainer1.Panel2.Controls.Add(this.distanceBar1);
            this.splitContainer1.Panel2.Controls.Add(this.windDir1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_hdop);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_sats);
            this.splitContainer1.Panel2.Controls.Add(this.gMapControl1);
            this.splitContainer1.Panel2.Controls.Add(this.TRK_zoom);
            // 
            // zg1
            // 
            resources.ApplyResources(this.zg1, "zg1");
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;
            this.zg1.DoubleClick += new System.EventHandler(this.zg1_DoubleClick);
            // 
            // but_disablejoystick
            // 
            this.but_disablejoystick.ColorMouseDown = System.Drawing.Color.Empty;
            this.but_disablejoystick.ColorMouseOver = System.Drawing.Color.Empty;
            this.but_disablejoystick.ColorNotEnabled = System.Drawing.Color.Empty;
            resources.ApplyResources(this.but_disablejoystick, "but_disablejoystick");
            this.but_disablejoystick.Name = "but_disablejoystick";
            this.but_disablejoystick.UseVisualStyleBackColor = true;
            this.but_disablejoystick.Click += new System.EventHandler(this.but_disablejoystick_Click);
            // 
            // windDir1
            // 
            this.windDir1.BackColor = System.Drawing.Color.Transparent;
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Direction", this.bindingSource1, "wind_dir", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.DataBindings.Add(new System.Windows.Forms.Binding("Speed", this.bindingSource1, "wind_vel", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.windDir1.Direction = 180D;
            resources.ApplyResources(this.windDir1, "windDir1");
            this.windDir1.Name = "windDir1";
            this.windDir1.Speed = 0D;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            this.label6.Tag = "custom";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Name = "label5";
            this.label5.Tag = "custom";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Name = "label3";
            this.label3.Tag = "custom";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            this.label4.Tag = "custom";
            // 
            // lbl_hdop
            // 
            resources.ApplyResources(this.lbl_hdop, "lbl_hdop");
            this.lbl_hdop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "gpshdop", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "hdop: 0.0"));
            this.lbl_hdop.Name = "lbl_hdop";
            this.lbl_hdop.resize = true;
            this.toolTip1.SetToolTip(this.lbl_hdop, resources.GetString("lbl_hdop.ToolTip"));
            // 
            // lbl_sats
            // 
            resources.ApplyResources(this.lbl_sats, "lbl_sats");
            this.lbl_sats.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "satcount", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "Sats: 0"));
            this.lbl_sats.Name = "lbl_sats";
            this.lbl_sats.resize = true;
            this.toolTip1.SetToolTip(this.lbl_sats, resources.GetString("lbl_sats.ToolTip"));
            // 
            // gMapControl1
            // 
            this.gMapControl1.BackColor = System.Drawing.Color.Black;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            resources.ApplyResources(this.gMapControl1, "gMapControl1");
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Gray;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.HoldInvalidation = false;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 24;
            this.gMapControl1.MinZoom = 0;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Zoom = 3D;
            this.gMapControl1.OnPositionChanged += new GMap.NET.PositionChanged(this.gMapControl1_OnPositionChanged);
            this.gMapControl1.Click += new System.EventHandler(this.gMapControl1_Click);
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDown);
            this.gMapControl1.MouseLeave += new System.EventHandler(this.gMapControl1_MouseLeave);
            this.gMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseMove);
            // 
            // TRK_zoom
            // 
            resources.ApplyResources(this.TRK_zoom, "TRK_zoom");
            this.TRK_zoom.LargeChange = 1F;
            this.TRK_zoom.Maximum = 24F;
            this.TRK_zoom.Minimum = 1F;
            this.TRK_zoom.Name = "TRK_zoom";
            this.TRK_zoom.SmallChange = 1F;
            this.TRK_zoom.TickFrequency = 1F;
            this.TRK_zoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TRK_zoom.Value = 1F;
            this.TRK_zoom.Scroll += new System.EventHandler(this.TRK_zoom_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.LabelNextWPdist);
            this.panel1.Controls.Add(this.LabelTime);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.LabelWPno);
            this.panel1.Controls.Add(this.BUT_zoomOut);
            this.panel1.Controls.Add(this.BUT_zoomIn);
            this.panel1.Controls.Add(this.coords1);
            this.panel1.Controls.Add(this.Zoomlevel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CHK_autopan);
            this.panel1.Controls.Add(this.CB_tuning);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.label13.Tag = "custom";
            // 
            // LabelNextWPdist
            // 
            resources.ApplyResources(this.LabelNextWPdist, "LabelNextWPdist");
            this.LabelNextWPdist.Name = "LabelNextWPdist";
            this.LabelNextWPdist.Tag = "custom";
            // 
            // LabelTime
            // 
            resources.ApplyResources(this.LabelTime, "LabelTime");
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Tag = "custom";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.label12.Tag = "custom";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Tag = "custom";
            // 
            // LabelWPno
            // 
            resources.ApplyResources(this.LabelWPno, "LabelWPno");
            this.LabelWPno.Name = "LabelWPno";
            this.LabelWPno.Tag = "custom";
            // 
            // BUT_zoomOut
            // 
            resources.ApplyResources(this.BUT_zoomOut, "BUT_zoomOut");
            this.BUT_zoomOut.BackgroundImage = global::MissionPlanner.Properties.Resources.btn_zoomout;
            this.BUT_zoomOut.FlatAppearance.BorderSize = 0;
            this.BUT_zoomOut.Name = "BUT_zoomOut";
            this.toolTip1.SetToolTip(this.BUT_zoomOut, resources.GetString("BUT_zoomOut.ToolTip"));
            this.BUT_zoomOut.UseVisualStyleBackColor = true;
            this.BUT_zoomOut.Click += new System.EventHandler(this.BUT_zoomOut_Click);
            // 
            // BUT_zoomIn
            // 
            resources.ApplyResources(this.BUT_zoomIn, "BUT_zoomIn");
            this.BUT_zoomIn.BackgroundImage = global::MissionPlanner.Properties.Resources.btn_zoomin;
            this.BUT_zoomIn.FlatAppearance.BorderSize = 0;
            this.BUT_zoomIn.Name = "BUT_zoomIn";
            this.toolTip1.SetToolTip(this.BUT_zoomIn, resources.GetString("BUT_zoomIn.ToolTip"));
            this.BUT_zoomIn.UseVisualStyleBackColor = true;
            this.BUT_zoomIn.Click += new System.EventHandler(this.BUT_zoomIn_Click);
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltSource = "";
            this.coords1.AltUnit = "m";
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Alt", this.bindingSource1, "alt", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lat", this.bindingSource1, "lat", true));
            this.coords1.DataBindings.Add(new System.Windows.Forms.Binding("Lng", this.bindingSource1, "lng", true));
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            this.coords1.Name = "coords1";
            this.coords1.Vertical = false;
            // 
            // Zoomlevel
            // 
            resources.ApplyResources(this.Zoomlevel, "Zoomlevel");
            this.Zoomlevel.DecimalPlaces = 1;
            this.Zoomlevel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Zoomlevel.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Zoomlevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Zoomlevel.Name = "Zoomlevel";
            this.toolTip1.SetToolTip(this.Zoomlevel, resources.GetString("Zoomlevel.ToolTip"));
            this.Zoomlevel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Zoomlevel.ValueChanged += new System.EventHandler(this.Zoomlevel_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.resize = false;
            // 
            // CHK_autopan
            // 
            resources.ApplyResources(this.CHK_autopan, "CHK_autopan");
            this.CHK_autopan.Checked = true;
            this.CHK_autopan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_autopan.Name = "CHK_autopan";
            this.toolTip1.SetToolTip(this.CHK_autopan, resources.GetString("CHK_autopan.ToolTip"));
            this.CHK_autopan.UseVisualStyleBackColor = true;
            this.CHK_autopan.CheckedChanged += new System.EventHandler(this.CHK_autopan_CheckedChanged);
            // 
            // CB_tuning
            // 
            resources.ApplyResources(this.CB_tuning, "CB_tuning");
            this.CB_tuning.Name = "CB_tuning";
            this.toolTip1.SetToolTip(this.CB_tuning, resources.GetString("CB_tuning.ToolTip"));
            this.CB_tuning.UseVisualStyleBackColor = true;
            this.CB_tuning.CheckedChanged += new System.EventHandler(this.CB_tuning_CheckedChanged);
            // 
            // contextMenuStripMap
            // 
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goHereToolStripMenuItem,
            this.flyToHereAltToolStripMenuItem,
            this.addPoiToolStripMenuItem,
            this.pointCameraHereToolStripMenuItem,
            this.PointCameraCoordsToolStripMenuItem1,
            this.triggerCameraToolStripMenuItem,
            this.flightPlannerToolStripMenuItem,
            this.setHomeHereToolStripMenuItem,
            this.takeOffToolStripMenuItem,
            this.onOffCameraOverlapToolStripMenuItem,
            this.altitudeAngelSettingsToolStripMenuItem});
            this.contextMenuStripMap.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStripMap, "contextMenuStripMap");
            // 
            // goHereToolStripMenuItem
            // 
            this.goHereToolStripMenuItem.Name = "goHereToolStripMenuItem";
            resources.ApplyResources(this.goHereToolStripMenuItem, "goHereToolStripMenuItem");
            this.goHereToolStripMenuItem.Click += new System.EventHandler(this.goHereToolStripMenuItem_Click);
            // 
            // flyToHereAltToolStripMenuItem
            // 
            this.flyToHereAltToolStripMenuItem.Name = "flyToHereAltToolStripMenuItem";
            resources.ApplyResources(this.flyToHereAltToolStripMenuItem, "flyToHereAltToolStripMenuItem");
            this.flyToHereAltToolStripMenuItem.Click += new System.EventHandler(this.flyToHereAltToolStripMenuItem_Click);
            // 
            // addPoiToolStripMenuItem
            // 
            this.addPoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.loadFileToolStripMenuItem});
            this.addPoiToolStripMenuItem.Name = "addPoiToolStripMenuItem";
            resources.ApplyResources(this.addPoiToolStripMenuItem, "addPoiToolStripMenuItem");
            this.addPoiToolStripMenuItem.Click += new System.EventHandler(this.addPoiToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            resources.ApplyResources(this.saveFileToolStripMenuItem, "saveFileToolStripMenuItem");
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            resources.ApplyResources(this.loadFileToolStripMenuItem, "loadFileToolStripMenuItem");
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // pointCameraHereToolStripMenuItem
            // 
            this.pointCameraHereToolStripMenuItem.Name = "pointCameraHereToolStripMenuItem";
            resources.ApplyResources(this.pointCameraHereToolStripMenuItem, "pointCameraHereToolStripMenuItem");
            this.pointCameraHereToolStripMenuItem.Click += new System.EventHandler(this.pointCameraHereToolStripMenuItem_Click);
            // 
            // PointCameraCoordsToolStripMenuItem1
            // 
            this.PointCameraCoordsToolStripMenuItem1.Name = "PointCameraCoordsToolStripMenuItem1";
            resources.ApplyResources(this.PointCameraCoordsToolStripMenuItem1, "PointCameraCoordsToolStripMenuItem1");
            this.PointCameraCoordsToolStripMenuItem1.Click += new System.EventHandler(this.PointCameraCoordsToolStripMenuItem1_Click);
            // 
            // triggerCameraToolStripMenuItem
            // 
            this.triggerCameraToolStripMenuItem.Name = "triggerCameraToolStripMenuItem";
            resources.ApplyResources(this.triggerCameraToolStripMenuItem, "triggerCameraToolStripMenuItem");
            this.triggerCameraToolStripMenuItem.Click += new System.EventHandler(this.triggerCameraToolStripMenuItem_Click);
            // 
            // flightPlannerToolStripMenuItem
            // 
            this.flightPlannerToolStripMenuItem.Name = "flightPlannerToolStripMenuItem";
            resources.ApplyResources(this.flightPlannerToolStripMenuItem, "flightPlannerToolStripMenuItem");
            this.flightPlannerToolStripMenuItem.Click += new System.EventHandler(this.flightPlannerToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem
            // 
            this.setHomeHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setEKFHomeHereToolStripMenuItem,
            this.setHomeHereToolStripMenuItem1});
            this.setHomeHereToolStripMenuItem.Name = "setHomeHereToolStripMenuItem";
            resources.ApplyResources(this.setHomeHereToolStripMenuItem, "setHomeHereToolStripMenuItem");
            this.setHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // setEKFHomeHereToolStripMenuItem
            // 
            this.setEKFHomeHereToolStripMenuItem.Name = "setEKFHomeHereToolStripMenuItem";
            resources.ApplyResources(this.setEKFHomeHereToolStripMenuItem, "setEKFHomeHereToolStripMenuItem");
            this.setEKFHomeHereToolStripMenuItem.Click += new System.EventHandler(this.setEKFHomeHereToolStripMenuItem_Click);
            // 
            // setHomeHereToolStripMenuItem1
            // 
            this.setHomeHereToolStripMenuItem1.Name = "setHomeHereToolStripMenuItem1";
            resources.ApplyResources(this.setHomeHereToolStripMenuItem1, "setHomeHereToolStripMenuItem1");
            this.setHomeHereToolStripMenuItem1.Click += new System.EventHandler(this.setHomeHereToolStripMenuItem_Click);
            // 
            // takeOffToolStripMenuItem
            // 
            this.takeOffToolStripMenuItem.Name = "takeOffToolStripMenuItem";
            resources.ApplyResources(this.takeOffToolStripMenuItem, "takeOffToolStripMenuItem");
            this.takeOffToolStripMenuItem.Click += new System.EventHandler(this.takeOffToolStripMenuItem_Click);
            // 
            // onOffCameraOverlapToolStripMenuItem
            // 
            this.onOffCameraOverlapToolStripMenuItem.CheckOnClick = true;
            this.onOffCameraOverlapToolStripMenuItem.Name = "onOffCameraOverlapToolStripMenuItem";
            resources.ApplyResources(this.onOffCameraOverlapToolStripMenuItem, "onOffCameraOverlapToolStripMenuItem");
            this.onOffCameraOverlapToolStripMenuItem.Click += new System.EventHandler(this.onOffCameraOverlapToolStripMenuItem_Click);
            // 
            // altitudeAngelSettingsToolStripMenuItem
            // 
            this.altitudeAngelSettingsToolStripMenuItem.Name = "altitudeAngelSettingsToolStripMenuItem";
            resources.ApplyResources(this.altitudeAngelSettingsToolStripMenuItem, "altitudeAngelSettingsToolStripMenuItem");
            this.altitudeAngelSettingsToolStripMenuItem.Click += new System.EventHandler(this.altitudeAngelSettingsToolStripMenuItem_Click);
            // 
            // contextMenuStripHud
            // 
            this.contextMenuStripHud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.setAspectRatioToolStripMenuItem,
            this.userItemsToolStripMenuItem,
            this.russianHudToolStripMenuItem,
            this.swapWithMapToolStripMenuItem});
            this.contextMenuStripHud.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStripHud, "contextMenuStripHud");
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordHudToAVIToolStripMenuItem,
            this.stopRecordToolStripMenuItem,
            this.setMJPEGSourceToolStripMenuItem,
            this.startCameraToolStripMenuItem,
            this.setGStreamerSourceToolStripMenuItem});
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            resources.ApplyResources(this.videoToolStripMenuItem, "videoToolStripMenuItem");
            // 
            // recordHudToAVIToolStripMenuItem
            // 
            this.recordHudToAVIToolStripMenuItem.Name = "recordHudToAVIToolStripMenuItem";
            resources.ApplyResources(this.recordHudToAVIToolStripMenuItem, "recordHudToAVIToolStripMenuItem");
            this.recordHudToAVIToolStripMenuItem.Click += new System.EventHandler(this.recordHudToAVIToolStripMenuItem_Click);
            // 
            // stopRecordToolStripMenuItem
            // 
            this.stopRecordToolStripMenuItem.Name = "stopRecordToolStripMenuItem";
            resources.ApplyResources(this.stopRecordToolStripMenuItem, "stopRecordToolStripMenuItem");
            this.stopRecordToolStripMenuItem.Click += new System.EventHandler(this.stopRecordToolStripMenuItem_Click);
            // 
            // setMJPEGSourceToolStripMenuItem
            // 
            this.setMJPEGSourceToolStripMenuItem.Name = "setMJPEGSourceToolStripMenuItem";
            resources.ApplyResources(this.setMJPEGSourceToolStripMenuItem, "setMJPEGSourceToolStripMenuItem");
            this.setMJPEGSourceToolStripMenuItem.Click += new System.EventHandler(this.setMJPEGSourceToolStripMenuItem_Click);
            // 
            // startCameraToolStripMenuItem
            // 
            this.startCameraToolStripMenuItem.Name = "startCameraToolStripMenuItem";
            resources.ApplyResources(this.startCameraToolStripMenuItem, "startCameraToolStripMenuItem");
            this.startCameraToolStripMenuItem.Click += new System.EventHandler(this.startCameraToolStripMenuItem_Click);
            // 
            // setGStreamerSourceToolStripMenuItem
            // 
            this.setGStreamerSourceToolStripMenuItem.Name = "setGStreamerSourceToolStripMenuItem";
            resources.ApplyResources(this.setGStreamerSourceToolStripMenuItem, "setGStreamerSourceToolStripMenuItem");
            this.setGStreamerSourceToolStripMenuItem.Click += new System.EventHandler(this.setGStreamerSourceToolStripMenuItem_Click);
            // 
            // setAspectRatioToolStripMenuItem
            // 
            this.setAspectRatioToolStripMenuItem.Name = "setAspectRatioToolStripMenuItem";
            resources.ApplyResources(this.setAspectRatioToolStripMenuItem, "setAspectRatioToolStripMenuItem");
            this.setAspectRatioToolStripMenuItem.Click += new System.EventHandler(this.setAspectRatioToolStripMenuItem_Click);
            // 
            // userItemsToolStripMenuItem
            // 
            this.userItemsToolStripMenuItem.Name = "userItemsToolStripMenuItem";
            resources.ApplyResources(this.userItemsToolStripMenuItem, "userItemsToolStripMenuItem");
            this.userItemsToolStripMenuItem.Click += new System.EventHandler(this.hud_UserItem);
            // 
            // russianHudToolStripMenuItem
            // 
            this.russianHudToolStripMenuItem.Name = "russianHudToolStripMenuItem";
            resources.ApplyResources(this.russianHudToolStripMenuItem, "russianHudToolStripMenuItem");
            this.russianHudToolStripMenuItem.Click += new System.EventHandler(this.russianHudToolStripMenuItem_Click);
            // 
            // swapWithMapToolStripMenuItem
            // 
            this.swapWithMapToolStripMenuItem.Name = "swapWithMapToolStripMenuItem";
            resources.ApplyResources(this.swapWithMapToolStripMenuItem, "swapWithMapToolStripMenuItem");
            this.swapWithMapToolStripMenuItem.Click += new System.EventHandler(this.swapWithMapToolStripMenuItem_Click);
            // 
            // contextMenuStripactionstab
            // 
            this.contextMenuStripactionstab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem});
            this.contextMenuStripactionstab.Name = "contextMenuStripactionstab";
            resources.ApplyResources(this.contextMenuStripactionstab, "contextMenuStripactionstab");
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            resources.ApplyResources(this.customizeToolStripMenuItem, "customizeToolStripMenuItem");
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // ZedGraphTimer
            // 
            this.ZedGraphTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(150)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            // 
            // openScriptDialog
            // 
            resources.ApplyResources(this.openScriptDialog, "openScriptDialog");
            // 
            // scriptChecker
            // 
            this.scriptChecker.Tick += new System.EventHandler(this.scriptChecker_Tick);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = global::MissionPlanner.Properties.Resources.up;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = global::MissionPlanner.Properties.Resources.down;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // Messagetabtimer
            // 
            this.Messagetabtimer.Interval = 200;
            this.Messagetabtimer.Tick += new System.EventHandler(this.Messagetabtimer_Tick);
            // 
            // bindingSourceStatusTab
            // 
            this.bindingSourceStatusTab.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // modifyandSetLoiterRad
            // 
            this.modifyandSetLoiterRad.ButtonText = "Set Loiter Rad";
            resources.ApplyResources(this.modifyandSetLoiterRad, "modifyandSetLoiterRad");
            this.modifyandSetLoiterRad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.modifyandSetLoiterRad.Name = "modifyandSetLoiterRad";
            this.modifyandSetLoiterRad.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetLoiterRad.Click += new System.EventHandler(this.modifyandSetLoiterRad_Click);
            // 
            // modifyandSetSpeed
            // 
            this.modifyandSetSpeed.ButtonText = "Change Speed";
            resources.ApplyResources(this.modifyandSetSpeed, "modifyandSetSpeed");
            this.modifyandSetSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.modifyandSetSpeed.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.modifyandSetSpeed.Name = "modifyandSetSpeed";
            this.modifyandSetSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetSpeed.Click += new System.EventHandler(this.modifyandSetSpeed_Click);
            this.modifyandSetSpeed.ParentChanged += new System.EventHandler(this.modifyandSetSpeed_ParentChanged);
            // 
            // modifyandSetAlt
            // 
            this.modifyandSetAlt.ButtonText = "Change Alt";
            resources.ApplyResources(this.modifyandSetAlt, "modifyandSetAlt");
            this.modifyandSetAlt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.modifyandSetAlt.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.modifyandSetAlt.Name = "modifyandSetAlt";
            this.modifyandSetAlt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.modifyandSetAlt.Click += new System.EventHandler(this.modifyandSetAlt_Click);
            // 
            // checkListControl1
            // 
            resources.ApplyResources(this.checkListControl1, "checkListControl1");
            this.checkListControl1.Name = "checkListControl1";
            // 
            // servoOptions1
            // 
            resources.ApplyResources(this.servoOptions1, "servoOptions1");
            this.servoOptions1.Name = "servoOptions1";
            this.servoOptions1.thisservo = 5;
            // 
            // servoOptions2
            // 
            resources.ApplyResources(this.servoOptions2, "servoOptions2");
            this.servoOptions2.Name = "servoOptions2";
            this.servoOptions2.thisservo = 6;
            // 
            // servoOptions3
            // 
            resources.ApplyResources(this.servoOptions3, "servoOptions3");
            this.servoOptions3.Name = "servoOptions3";
            this.servoOptions3.thisservo = 7;
            // 
            // servoOptions4
            // 
            resources.ApplyResources(this.servoOptions4, "servoOptions4");
            this.servoOptions4.Name = "servoOptions4";
            this.servoOptions4.thisservo = 8;
            // 
            // servoOptions5
            // 
            resources.ApplyResources(this.servoOptions5, "servoOptions5");
            this.servoOptions5.Name = "servoOptions5";
            this.servoOptions5.thisservo = 9;
            // 
            // servoOptions6
            // 
            resources.ApplyResources(this.servoOptions6, "servoOptions6");
            this.servoOptions6.Name = "servoOptions6";
            this.servoOptions6.thisservo = 10;
            // 
            // servoOptions7
            // 
            resources.ApplyResources(this.servoOptions7, "servoOptions7");
            this.servoOptions7.Name = "servoOptions7";
            this.servoOptions7.thisservo = 11;
            // 
            // servoOptions8
            // 
            resources.ApplyResources(this.servoOptions8, "servoOptions8");
            this.servoOptions8.Name = "servoOptions8";
            this.servoOptions8.thisservo = 12;
            // 
            // servoOptions9
            // 
            resources.ApplyResources(this.servoOptions9, "servoOptions9");
            this.servoOptions9.Name = "servoOptions9";
            this.servoOptions9.thisservo = 13;
            // 
            // servoOptions10
            // 
            resources.ApplyResources(this.servoOptions10, "servoOptions10");
            this.servoOptions10.Name = "servoOptions10";
            this.servoOptions10.thisservo = 14;
            // 
            // distanceBar1
            // 
            resources.ApplyResources(this.distanceBar1, "distanceBar1");
            this.distanceBar1.BackColor = System.Drawing.Color.Transparent;
            this.distanceBar1.Name = "distanceBar1";
            this.distanceBar1.totaldist = 100F;
            this.distanceBar1.traveleddist = 0F;
            // 
            // FlightData
            // 
            this.Controls.Add(this.MainH);
            resources.ApplyResources(this, "$this");
            this.Name = "FlightData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightData_FormClosing);
            this.Load += new System.EventHandler(this.FlightData_Load);
            this.Resize += new System.EventHandler(this.FlightData_Resize);
            this.ParentChanged += new System.EventHandler(this.FlightData_ParentChanged);
            this.MainH.Panel1.ResumeLayout(false);
            this.MainH.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainH)).EndInit();
            this.MainH.ResumeLayout(false);
            this.SubMainLeft.Panel1.ResumeLayout(false);
            this.SubMainLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubMainLeft)).EndInit();
            this.SubMainLeft.ResumeLayout(false);
            this.tableLayoutPanelMessage.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHud)).EndInit();
            this.tabControlactions.ResumeLayout(false);
            this.tabQuick.ResumeLayout(false);
            this.tableLayoutPanelQuick.ResumeLayout(false);
            this.contextMenuStripQuickView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuickTab)).EndInit();
            this.tabActions.ResumeLayout(false);
            this.tabActionsSimple.ResumeLayout(false);
            this.tabPagePreFlight.ResumeLayout(false);
            this.tabGauges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGaugesTab)).EndInit();
            this.tabServo.ResumeLayout(false);
            this.flowLayoutPanelServos.ResumeLayout(false);
            this.tabTLogs.ResumeLayout(false);
            this.tableLayoutPaneltlogs.ResumeLayout(false);
            this.tableLayoutPaneltlogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracklog)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tablogbrowse.ResumeLayout(false);
            this.tabScripts.ResumeLayout(false);
            this.tabScripts.PerformLayout();
            this.tabPagemessages.ResumeLayout(false);
            this.tabPagemessages.PerformLayout();
            this.tabPayload.ResumeLayout(false);
            this.groupBoxRoll.ResumeLayout(false);
            this.groupBoxRoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePayloadTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoll)).EndInit();
            this.groupBoxYaw.ResumeLayout(false);
            this.groupBoxYaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYaw)).EndInit();
            this.groupBoxPitch.ResumeLayout(false);
            this.groupBoxPitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPitch)).EndInit();
            this.tabActionsNew.ResumeLayout(false);
            this.tableMap.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).EndInit();
            this.contextMenuStripMap.ResumeLayout(false);
            this.contextMenuStripHud.ResumeLayout(false);
            this.contextMenuStripactionstab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceStatusTab)).EndInit();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Timer ZedGraphTimer;
        private System.Windows.Forms.SplitContainer MainH;
        private System.Windows.Forms.SplitContainer SubMainLeft;
        private System.Windows.Forms.ToolStripMenuItem goHereToolStripMenuItem;
        private Controls.HUD hud1;
        private Controls.MyButton BUT_clear_track;
        private System.Windows.Forms.CheckBox CB_tuning;
        private Controls.MyButton BUT_RAWSensor;
        private Controls.MyButton BUTactiondo;
        private Controls.MyButton BUTrestartmission;
        private System.Windows.Forms.ComboBox CMB_action;
        private Controls.MyButton BUT_Homealt;
        private System.Windows.Forms.TrackBar tracklog;
        private Controls.MyButton BUT_playlog;
        private Controls.MyButton BUT_loadtelem;
        private AGaugeApp.AGauge Galt;
        private AGaugeApp.AGauge Gspeed;
        private AGaugeApp.AGauge Gvspeed;
        private System.Windows.Forms.TableLayoutPanel tableMap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Zoomlevel;
        private Controls.MyLabel label1;
        private System.Windows.Forms.CheckBox CHK_autopan;
        public Controls.myGMAP gMapControl1;
        private ZedGraph.ZedGraphControl zg1;
        public System.Windows.Forms.TabControl tabControlactions;
        public System.Windows.Forms.TabPage tabGauges;
        public System.Windows.Forms.TabPage tabStatus;
        public System.Windows.Forms.TabPage tabActions;
        public System.Windows.Forms.TabPage tabTLogs;
        private System.Windows.Forms.ComboBox CMB_modes;
        private Controls.MyButton BUT_setmode;
        private System.Windows.Forms.ComboBox CMB_setwp;
        private Controls.MyButton BUT_setwp;
        private Controls.MyButton BUT_quickmanual;
        private Controls.MyButton BUT_quickrtl;
        private Controls.MyButton BUT_quickauto;
        private Controls.MyButton BUT_log2kml;
        private Controls.MyButton BUT_joystick;
        private System.Windows.Forms.ToolTip toolTip1;
        private Controls.MyLabel lbl_logpercent;
        private System.Windows.Forms.ToolStripMenuItem pointCameraHereToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.MyLabel lbl_hdop;
        private Controls.MyLabel lbl_sats;
        private Controls.HSI Gheading;
        private Controls.MyLabel lbl_playbackspeed;
        private System.Windows.Forms.ToolStripMenuItem setAspectRatioToolStripMenuItem;
        public System.Windows.Forms.TabPage tabQuick;
        private Controls.QuickView quickView3;
        private Controls.QuickView quickView2;
        private Controls.QuickView quickView1;
        private Controls.QuickView quickView4;
        private Controls.QuickView quickView6;
        private Controls.QuickView quickView5;
        private System.Windows.Forms.ToolStripMenuItem flyToHereAltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightPlannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userItemsToolStripMenuItem;
        //private Crom.Controls.Docking.DockContainer dockContainer1;
        private Controls.MyButton BUT_ARM;
        private Controls.ModifyandSet modifyandSetAlt;
        private Controls.ModifyandSet modifyandSetSpeed;
        private System.Windows.Forms.ToolStripMenuItem triggerCameraToolStripMenuItem;
        private Controls.MyTrackBar TRK_zoom;
        private Controls.MyLabel LBL_logfn;
        public System.Windows.Forms.TabPage tabServo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelServos;
        private Controls.ServoOptions servoOptions1;
        private Controls.ServoOptions servoOptions2;
        private Controls.ServoOptions servoOptions3;
        private Controls.ServoOptions servoOptions4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPaneltlogs;
        private Controls.ServoOptions servoOptions5;
        private Controls.ServoOptions servoOptions6;
        private Controls.ServoOptions servoOptions7;
        private Controls.ServoOptions servoOptions8;
        private Controls.ServoOptions servoOptions9;
        private Controls.ServoOptions servoOptions10;
        private System.Windows.Forms.BindingSource bindingSourceHud;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQuick;
        private System.Windows.Forms.Panel panel2;
        private Controls.MyButton BUT_speed10;
        private Controls.MyButton BUT_speed5;
        private Controls.MyButton BUT_speed2;
        private Controls.MyButton BUT_speed1;
        private Controls.MyButton BUT_speed1_2;
        private Controls.MyButton BUT_speed1_4;
        private Controls.MyButton BUT_speed1_10;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabPage tablogbrowse;
        private Controls.MyButton BUT_logbrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TabPage tabScripts;
        private Controls.MyButton BUT_edit_selected;
        private System.Windows.Forms.Label labelSelectedScript;
        private Controls.MyButton BUT_run_script;
        private Controls.MyButton BUT_abort_script;
        private System.Windows.Forms.Label labelScriptStatus;
        private Controls.MyButton BUT_select_script;
        private System.Windows.Forms.OpenFileDialog openScriptDialog;
        private System.Windows.Forms.Timer scriptChecker;
        private System.Windows.Forms.CheckBox checkBoxRedirectOutput;
        private System.Windows.Forms.ToolStripMenuItem russianHudToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripHud;
        private System.Windows.Forms.BindingSource bindingSourceQuickTab;
        private System.Windows.Forms.BindingSource bindingSourceStatusTab;
        private System.Windows.Forms.BindingSource bindingSourceGaugesTab;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem;
        private MissionPlanner.Controls.Coords coords1;
        private Controls.MyButton BUT_matlab;
        private System.Windows.Forms.ComboBox CMB_mountmode;
        private Controls.MyButton BUT_mountmode;
        public Controls.WindDir windDir1;
        private Controls.MyButton but_bintolog;
        private Controls.MyButton but_dflogtokml;
        private Controls.MyButton BUT_DFMavlink;
        public System.Windows.Forms.TabPage tabPagemessages;
        private System.Windows.Forms.TextBox txt_messagebox;
        private System.Windows.Forms.Timer Messagetabtimer;
        public System.Windows.Forms.TabPage tabActionsSimple;
        private Controls.MyButton myButton1;
        private Controls.MyButton myButton2;
        private Controls.MyButton myButton3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripactionstab;
        private Controls.MyButton BUT_loganalysis;
        private System.Windows.Forms.ToolStripMenuItem addPoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private Controls.DistanceBar distanceBar1;
        private System.Windows.Forms.ToolStripMenuItem takeOffToolStripMenuItem;
        private Controls.MyButton BUT_resumemis;
        public System.Windows.Forms.TabPage tabPagePreFlight;
        private Controls.PreFlight.CheckListControl checkListControl1;
        private System.Windows.Forms.ToolStripMenuItem swapWithMapToolStripMenuItem;
        private Controls.MyButton BUT_abortland;
        private Controls.MyButton but_disablejoystick;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordHudToAVIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setMJPEGSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PointCameraCoordsToolStripMenuItem1;
        private Controls.ModifyandSet modifyandSetLoiterRad;
        private System.Windows.Forms.ToolStripMenuItem onOffCameraOverlapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altitudeAngelSettingsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripQuickView;
        private System.Windows.Forms.ToolStripMenuItem setViewCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGStreamerSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setEKFHomeHereToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPayload;
        private System.Windows.Forms.BindingSource bindingSourcePayloadTab;
        private System.Windows.Forms.TrackBar trackBarYaw;
        private System.Windows.Forms.TrackBar trackBarRoll;
        private System.Windows.Forms.TrackBar trackBarPitch;
        private Controls.MyButton BUT_resetGimbalPos;
        private System.Windows.Forms.TextBox TXT_gimbalPitchPos;
        private System.Windows.Forms.TextBox TXT_gimbalYawPos;
        private System.Windows.Forms.TextBox TXT_gimbalRollPos;
        private System.Windows.Forms.GroupBox groupBoxRoll;
        private System.Windows.Forms.GroupBox groupBoxYaw;
        private System.Windows.Forms.GroupBox groupBoxPitch;
        private Controls.MyButton BUT_PayloadFolder;
        private System.Windows.Forms.ToolStripMenuItem setHomeHereToolStripMenuItem1;
#if false
        private Controls.MyButton BUT_zoomOut;
        private Controls.MyButton BUT_zoomIn;
#else
        private System.Windows.Forms.Button BUT_zoomOut;
        private System.Windows.Forms.Button BUT_zoomIn;
#endif
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonReturn;
        private System.Windows.Forms.Label LabelPreArm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMessage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelArm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Label LabelCom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelWPno;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LabelNextWPdist;
        private System.Windows.Forms.Label labelResume;
        private System.Windows.Forms.Button ButtonResumeClear;
        public System.Windows.Forms.TabPage tabActionsNew;
        private System.Windows.Forms.Button BtnActAuto;
        private System.Windows.Forms.Button BtnActKeyClear;
        private System.Windows.Forms.Button BtnActKey0;
        private System.Windows.Forms.Button BtnActKey3;
        private System.Windows.Forms.Button BtnActKey2;
        private System.Windows.Forms.Button BtnActKey1;
        private System.Windows.Forms.Button BtnActKey6;
        private System.Windows.Forms.Button BtnActKey5;
        private System.Windows.Forms.Button BtnActKey4;
        private System.Windows.Forms.Button BtnActKey9;
        private System.Windows.Forms.Button BtnActKey8;
        private System.Windows.Forms.Button BtnActKey7;
        private System.Windows.Forms.Button BtnActWPset;
        private System.Windows.Forms.Button BtnActReboot;
        private System.Windows.Forms.Button BtnActArm;
        private System.Windows.Forms.Button BtnActLand;
        private System.Windows.Forms.Button BtnActStab;
        private System.Windows.Forms.Button BtnActLoiter;
        private System.Windows.Forms.Button BtnActRtl;
        private System.Windows.Forms.Button BtnAltHold;
        private System.Windows.Forms.Label LblWPno;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.Button ButtonPower;
        private System.Windows.Forms.Button ButtonEmergency;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelCutter;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelProximity;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelGps;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelRoute;
    }
}