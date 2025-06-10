namespace FlightPlanningSoftware
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        // 上下分割用の SplitContainer
        private System.Windows.Forms.SplitContainer splitContainerVert;
        // 左右分割用の SplitContainer
        private System.Windows.Forms.SplitContainer splitContainerMain;

        // 左パネル(ボタン)・右パネル(地図)
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelMap;
        private MissionPlanner.Controls.myGMAP MainMap;

        // 下パネル(3テーブルまとめ) + 3つのテーブル用レイアウト
        private System.Windows.Forms.Panel panelWPs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWPs;

        // 9つのボタン
        private System.Windows.Forms.Button buttonTakeoff;
        private System.Windows.Forms.Button buttonWaypoint;
        private System.Windows.Forms.Button buttonLanding;
        private System.Windows.Forms.Button buttonFence;
        private System.Windows.Forms.Button buttonFenceInc;
        private System.Windows.Forms.Button buttonFenceExc;
        private System.Windows.Forms.Button buttonEmergency;
        private System.Windows.Forms.Button buttonBulkDelete;
        private System.Windows.Forms.Button buttonRoundTrip;

        // 距離ラベル
        private System.Windows.Forms.Label labelDistance;

        // 表示項目
        private System.Windows.Forms.Panel panelOverlay;
        private System.Windows.Forms.Label labelDisplayItem;
        private System.Windows.Forms.CheckBox checkBoxRoute;
        private System.Windows.Forms.CheckBox checkBoxFence;
        private System.Windows.Forms.CheckBox checkBoxEmergency;

        // ズーム
        private System.Windows.Forms.Panel panelZoomOverlay;
        private System.Windows.Forms.PictureBox pictureBoxZoomIn;
        private System.Windows.Forms.PictureBox pictureBoxZoomOut;
        private System.Windows.Forms.Label labelZoom;

        // 4つの DataGridView (WPs, FenceInc, FenceExc, Emergency)
        private System.Windows.Forms.DataGridView dataGridViewWPs;
        private System.Windows.Forms.DataGridView dataGridViewFenceInc;
        private System.Windows.Forms.DataGridView dataGridViewFenceExc;
        private System.Windows.Forms.DataGridView dataGridViewEmergency;

        private System.Windows.Forms.Panel panelWPsContainer;      // ウェイポイント用
        private System.Windows.Forms.Panel panelFenceIncContainer; // 逸脱防止フェンス用
        private System.Windows.Forms.Panel panelFenceExcContainer; // 進入禁止フェンス用
        private System.Windows.Forms.Panel panelEmergencyContainer;// 緊急着陸地点用

        private System.Windows.Forms.Label labelWPs;
        private System.Windows.Forms.Label labelFenceInc;
        private System.Windows.Forms.Label labelFenceExc;
        private System.Windows.Forms.Label labelEmergency;

        // ウェイポイント列
        private System.Windows.Forms.DataGridViewTextBoxColumn colWpCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWpParam1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWpParam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWpParam3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWpParam4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWpLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWpLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWpAlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWpFrame;
        private System.Windows.Forms.DataGridViewButtonColumn colWpDelete;

        // 逸脱防止フェンス列
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceIncCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceIncParam1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceIncParam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceIncParam3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceIncParam4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceIncLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceIncLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceIncAlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceIncFrame;
        private System.Windows.Forms.DataGridViewButtonColumn colFenceIncDelete;

        // 進入禁止フェンス列
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceExcCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceExcParam1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceExcParam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceExcParam3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceExcParam4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceExcLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceExcLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceExcAlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFenceExcFrame;
        private System.Windows.Forms.DataGridViewButtonColumn colFenceExcDelete;

        // 緊急着陸地点列
        private System.Windows.Forms.DataGridViewTextBoxColumn colRallyCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRallyParam1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRallyParam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRallyParam3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRallyParam4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRallyLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRallyLon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRallyAlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRallyFrame;
        private System.Windows.Forms.DataGridViewButtonColumn colRallyDelete;

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.Button buttonFileLoad;
        private System.Windows.Forms.Button buttonFileSave;
        private System.Windows.Forms.PictureBox pictureLogoEAMS;
        private System.Windows.Forms.PictureBox pictureLogoArdu;
        private System.Windows.Forms.Panel panelFooterContent;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainerVert = new System.Windows.Forms.SplitContainer();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonTakeoff = new System.Windows.Forms.Button();
            this.buttonWaypoint = new System.Windows.Forms.Button();
            this.buttonLanding = new System.Windows.Forms.Button();
            this.buttonFence = new System.Windows.Forms.Button();
            this.buttonFenceInc = new System.Windows.Forms.Button();
            this.buttonFenceExc = new System.Windows.Forms.Button();
            this.buttonEmergency = new System.Windows.Forms.Button();
            this.buttonBulkDelete = new System.Windows.Forms.Button();
            this.buttonRoundTrip = new System.Windows.Forms.Button();
            this.panelMap = new System.Windows.Forms.Panel();
            this.MainMap = new MissionPlanner.Controls.myGMAP();
            this.panelZoomOverlay = new System.Windows.Forms.Panel();
            this.pictureBoxZoomIn = new System.Windows.Forms.PictureBox();
            this.pictureBoxZoomOut = new System.Windows.Forms.PictureBox();
            this.labelZoom = new System.Windows.Forms.Label();
            this.panelOverlay = new System.Windows.Forms.Panel();
            this.labelDisplayItem = new System.Windows.Forms.Label();
            this.checkBoxRoute = new System.Windows.Forms.CheckBox();
            this.checkBoxFence = new System.Windows.Forms.CheckBox();
            this.checkBoxEmergency = new System.Windows.Forms.CheckBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.panelWPs = new System.Windows.Forms.Panel();
            this.tableLayoutPanelWPs = new System.Windows.Forms.TableLayoutPanel();
            this.panelWPsContainer = new System.Windows.Forms.Panel();
            this.dataGridViewWPs = new System.Windows.Forms.DataGridView();
            this.colWpCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWpParam1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWpParam2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWpParam3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWpParam4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWpLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWpLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWpAlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWpFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWpDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelWPs = new System.Windows.Forms.Label();
            this.panelFenceIncContainer = new System.Windows.Forms.Panel();
            this.dataGridViewFenceInc = new System.Windows.Forms.DataGridView();
            this.colFenceIncCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceIncParam1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceIncParam2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceIncParam3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceIncParam4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceIncLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceIncLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceIncAlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceIncFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceIncDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelFenceInc = new System.Windows.Forms.Label();
            this.panelFenceExcContainer = new System.Windows.Forms.Panel();
            this.dataGridViewFenceExc = new System.Windows.Forms.DataGridView();
            this.colFenceExcCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceExcParam1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceExcParam2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceExcParam3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceExcParam4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceExcLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceExcLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceExcAlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceExcFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFenceExcDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelFenceExc = new System.Windows.Forms.Label();
            this.panelEmergencyContainer = new System.Windows.Forms.Panel();
            this.dataGridViewEmergency = new System.Windows.Forms.DataGridView();
            this.colRallyCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRallyParam1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRallyParam2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRallyParam3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRallyParam4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRallyLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRallyLon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRallyAlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRallyFrame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRallyDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelEmergency = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelFooterContent = new System.Windows.Forms.Panel();
            this.buttonFileLoad = new System.Windows.Forms.Button();
            this.buttonFileSave = new System.Windows.Forms.Button();
            this.pictureLogoEAMS = new System.Windows.Forms.PictureBox();
            this.pictureLogoArdu = new System.Windows.Forms.PictureBox();
            this.labelSeparator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVert)).BeginInit();
            this.splitContainerVert.Panel1.SuspendLayout();
            this.splitContainerVert.Panel2.SuspendLayout();
            this.splitContainerVert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.MainMap.SuspendLayout();
            this.panelZoomOverlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomOut)).BeginInit();
            this.panelOverlay.SuspendLayout();
            this.panelWPs.SuspendLayout();
            this.tableLayoutPanelWPs.SuspendLayout();
            this.panelWPsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWPs)).BeginInit();
            this.panelFenceIncContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFenceInc)).BeginInit();
            this.panelFenceExcContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFenceExc)).BeginInit();
            this.panelEmergencyContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmergency)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.panelFooterContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoEAMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoArdu)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerVert
            // 
            this.splitContainerVert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVert.Location = new System.Drawing.Point(0, 0);
            this.splitContainerVert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerVert.Name = "splitContainerVert";
            this.splitContainerVert.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerVert.Panel1
            // 
            this.splitContainerVert.Panel1.Controls.Add(this.splitContainerMain);
            // 
            // splitContainerVert.Panel2
            // 
            this.splitContainerVert.Panel2.Controls.Add(this.panelWPs);
            this.splitContainerVert.Size = new System.Drawing.Size(1733, 851);
            this.splitContainerVert.SplitterDistance = 499;
            this.splitContainerVert.SplitterWidth = 5;
            this.splitContainerVert.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelButtons);
            this.splitContainerMain.Panel1MinSize = 0;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.panelMap);
            this.splitContainerMain.Size = new System.Drawing.Size(1733, 499);
            this.splitContainerMain.SplitterDistance = 533;
            this.splitContainerMain.SplitterWidth = 5;
            this.splitContainerMain.TabIndex = 1;
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.BackColor = System.Drawing.Color.Black;
            this.panelButtons.Controls.Add(this.buttonTakeoff);
            this.panelButtons.Controls.Add(this.buttonWaypoint);
            this.panelButtons.Controls.Add(this.buttonLanding);
            this.panelButtons.Controls.Add(this.buttonFence);
            this.panelButtons.Controls.Add(this.buttonFenceInc);
            this.panelButtons.Controls.Add(this.buttonFenceExc);
            this.panelButtons.Controls.Add(this.buttonEmergency);
            this.panelButtons.Controls.Add(this.buttonBulkDelete);
            this.panelButtons.Controls.Add(this.buttonRoundTrip);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(533, 499);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonTakeoff
            // 
            this.buttonTakeoff.AutoSize = true;
            this.buttonTakeoff.BackColor = System.Drawing.Color.Transparent;
            this.buttonTakeoff.Image = global::FlightPlanningSoftware.Properties.Resources.home;
            this.buttonTakeoff.Location = new System.Drawing.Point(27, 25);
            this.buttonTakeoff.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.buttonTakeoff.Name = "buttonTakeoff";
            this.buttonTakeoff.Size = new System.Drawing.Size(133, 125);
            this.buttonTakeoff.TabIndex = 0;
            this.buttonTakeoff.Text = "離陸地点";
            this.buttonTakeoff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonTakeoff.UseVisualStyleBackColor = false;
            this.buttonTakeoff.Click += new System.EventHandler(this.buttonTakeoff_Click);
            // 
            // buttonWaypoint
            // 
            this.buttonWaypoint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonWaypoint.AutoSize = true;
            this.buttonWaypoint.BackColor = System.Drawing.Color.Transparent;
            this.buttonWaypoint.Enabled = false;
            this.buttonWaypoint.Image = global::FlightPlanningSoftware.Properties.Resources.waypoint;
            this.buttonWaypoint.Location = new System.Drawing.Point(196, 25);
            this.buttonWaypoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonWaypoint.Name = "buttonWaypoint";
            this.buttonWaypoint.Size = new System.Drawing.Size(133, 125);
            this.buttonWaypoint.TabIndex = 1;
            this.buttonWaypoint.Text = "ウェイポイント";
            this.buttonWaypoint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonWaypoint.UseVisualStyleBackColor = false;
            this.buttonWaypoint.Click += new System.EventHandler(this.buttonWaypoint_Click);
            // 
            // buttonLanding
            // 
            this.buttonLanding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLanding.AutoSize = true;
            this.buttonLanding.BackColor = System.Drawing.Color.Transparent;
            this.buttonLanding.Enabled = false;
            this.buttonLanding.Image = global::FlightPlanningSoftware.Properties.Resources.landing;
            this.buttonLanding.Location = new System.Drawing.Point(367, 25);
            this.buttonLanding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLanding.Name = "buttonLanding";
            this.buttonLanding.Size = new System.Drawing.Size(133, 125);
            this.buttonLanding.TabIndex = 2;
            this.buttonLanding.Text = "着陸地点";
            this.buttonLanding.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLanding.UseVisualStyleBackColor = false;
            this.buttonLanding.Click += new System.EventHandler(this.buttonLanding_Click);
            // 
            // buttonFence
            // 
            this.buttonFence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonFence.BackColor = System.Drawing.Color.Transparent;
            this.buttonFence.Enabled = false;
            this.buttonFence.Image = global::FlightPlanningSoftware.Properties.Resources.fence;
            this.buttonFence.Location = new System.Drawing.Point(27, 187);
            this.buttonFence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFence.Name = "buttonFence";
            this.buttonFence.Size = new System.Drawing.Size(133, 125);
            this.buttonFence.TabIndex = 3;
            this.buttonFence.Text = "フェンス";
            this.buttonFence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFence.UseVisualStyleBackColor = false;
            this.buttonFence.Click += new System.EventHandler(this.buttonFence_Click);
            // 
            // buttonFenceInc
            // 
            this.buttonFenceInc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFenceInc.BackColor = System.Drawing.Color.Transparent;
            this.buttonFenceInc.Enabled = false;
            this.buttonFenceInc.Image = global::FlightPlanningSoftware.Properties.Resources.fence_inc;
            this.buttonFenceInc.Location = new System.Drawing.Point(196, 187);
            this.buttonFenceInc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFenceInc.Name = "buttonFenceInc";
            this.buttonFenceInc.Size = new System.Drawing.Size(133, 125);
            this.buttonFenceInc.TabIndex = 4;
            this.buttonFenceInc.Text = "逸脱防止";
            this.buttonFenceInc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFenceInc.UseVisualStyleBackColor = false;
            this.buttonFenceInc.Click += new System.EventHandler(this.buttonFenceInc_Click);
            // 
            // buttonFenceExc
            // 
            this.buttonFenceExc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonFenceExc.BackColor = System.Drawing.Color.Transparent;
            this.buttonFenceExc.Enabled = false;
            this.buttonFenceExc.Image = global::FlightPlanningSoftware.Properties.Resources.fence_exc;
            this.buttonFenceExc.Location = new System.Drawing.Point(367, 187);
            this.buttonFenceExc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFenceExc.Name = "buttonFenceExc";
            this.buttonFenceExc.Size = new System.Drawing.Size(133, 125);
            this.buttonFenceExc.TabIndex = 5;
            this.buttonFenceExc.Text = "進入禁止";
            this.buttonFenceExc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonFenceExc.UseVisualStyleBackColor = false;
            this.buttonFenceExc.Click += new System.EventHandler(this.buttonFenceExc_Click);
            // 
            // buttonEmergency
            // 
            this.buttonEmergency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEmergency.BackColor = System.Drawing.Color.Transparent;
            this.buttonEmergency.Enabled = false;
            this.buttonEmergency.Image = global::FlightPlanningSoftware.Properties.Resources.rally;
            this.buttonEmergency.Location = new System.Drawing.Point(27, 349);
            this.buttonEmergency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEmergency.Name = "buttonEmergency";
            this.buttonEmergency.Size = new System.Drawing.Size(133, 125);
            this.buttonEmergency.TabIndex = 6;
            this.buttonEmergency.Text = "緊急着陸地点";
            this.buttonEmergency.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEmergency.UseVisualStyleBackColor = false;
            this.buttonEmergency.Click += new System.EventHandler(this.buttonEmergency_Click);
            // 
            // buttonBulkDelete
            // 
            this.buttonBulkDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBulkDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonBulkDelete.Enabled = false;
            this.buttonBulkDelete.Image = global::FlightPlanningSoftware.Properties.Resources.all_delete;
            this.buttonBulkDelete.Location = new System.Drawing.Point(196, 349);
            this.buttonBulkDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBulkDelete.Name = "buttonBulkDelete";
            this.buttonBulkDelete.Size = new System.Drawing.Size(133, 125);
            this.buttonBulkDelete.TabIndex = 7;
            this.buttonBulkDelete.Text = "一括削除";
            this.buttonBulkDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBulkDelete.UseVisualStyleBackColor = false;
            this.buttonBulkDelete.Click += new System.EventHandler(this.buttonBulkDelete_Click);
            // 
            // buttonRoundTrip
            // 
            this.buttonRoundTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRoundTrip.BackColor = System.Drawing.Color.Transparent;
            this.buttonRoundTrip.Enabled = false;
            this.buttonRoundTrip.Image = global::FlightPlanningSoftware.Properties.Resources.round_trip;
            this.buttonRoundTrip.Location = new System.Drawing.Point(367, 349);
            this.buttonRoundTrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRoundTrip.Name = "buttonRoundTrip";
            this.buttonRoundTrip.Size = new System.Drawing.Size(133, 125);
            this.buttonRoundTrip.TabIndex = 8;
            this.buttonRoundTrip.Text = "往復";
            this.buttonRoundTrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRoundTrip.UseVisualStyleBackColor = false;
            this.buttonRoundTrip.Click += new System.EventHandler(this.buttonRoundTrip_Click);
            // 
            // panelMap
            // 
            this.panelMap.AutoSize = true;
            this.panelMap.BackColor = System.Drawing.Color.DimGray;
            this.panelMap.Controls.Add(this.MainMap);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1195, 499);
            this.panelMap.TabIndex = 2;
            // 
            // MainMap
            // 
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.Controls.Add(this.panelZoomOverlay);
            this.MainMap.Controls.Add(this.panelOverlay);
            this.MainMap.Controls.Add(this.labelDistance);
            this.MainMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.HoldInvalidation = false;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(0, 0);
            this.MainMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 24;
            this.MainMap.MinZoom = 0;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(1195, 499);
            this.MainMap.TabIndex = 0;
            this.MainMap.Zoom = 15D;
            this.MainMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainMap_MouseClick);
            this.MainMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMap_MouseDown);
            this.MainMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMap_MouseMove);
            this.MainMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainMap_MouseUp);
            // 
            // panelZoomOverlay
            // 
            this.panelZoomOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelZoomOverlay.BackColor = System.Drawing.Color.DimGray;
            this.panelZoomOverlay.Controls.Add(this.pictureBoxZoomIn);
            this.panelZoomOverlay.Controls.Add(this.pictureBoxZoomOut);
            this.panelZoomOverlay.Controls.Add(this.labelZoom);
            this.panelZoomOverlay.Location = new System.Drawing.Point(1117, 361);
            this.panelZoomOverlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelZoomOverlay.Name = "panelZoomOverlay";
            this.panelZoomOverlay.Size = new System.Drawing.Size(63, 88);
            this.panelZoomOverlay.TabIndex = 2;
            // 
            // pictureBoxZoomIn
            // 
            this.pictureBoxZoomIn.Image = global::FlightPlanningSoftware.Properties.Resources.zoom_plus;
            this.pictureBoxZoomIn.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxZoomIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxZoomIn.Name = "pictureBoxZoomIn";
            this.pictureBoxZoomIn.Size = new System.Drawing.Size(63, 34);
            this.pictureBoxZoomIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxZoomIn.TabIndex = 0;
            this.pictureBoxZoomIn.TabStop = false;
            this.pictureBoxZoomIn.Click += new System.EventHandler(this.pictureBoxZoomIn_Click);
            // 
            // pictureBoxZoomOut
            // 
            this.pictureBoxZoomOut.Image = global::FlightPlanningSoftware.Properties.Resources.zoom_minus;
            this.pictureBoxZoomOut.Location = new System.Drawing.Point(0, 32);
            this.pictureBoxZoomOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxZoomOut.Name = "pictureBoxZoomOut";
            this.pictureBoxZoomOut.Size = new System.Drawing.Size(63, 35);
            this.pictureBoxZoomOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxZoomOut.TabIndex = 1;
            this.pictureBoxZoomOut.TabStop = false;
            this.pictureBoxZoomOut.Click += new System.EventHandler(this.pictureBoxZoomOut_Click);
            // 
            // labelZoom
            // 
            this.labelZoom.BackColor = System.Drawing.Color.Transparent;
            this.labelZoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelZoom.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.labelZoom.ForeColor = System.Drawing.Color.White;
            this.labelZoom.Location = new System.Drawing.Point(0, 72);
            this.labelZoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(63, 16);
            this.labelZoom.TabIndex = 2;
            this.labelZoom.Text = "ズーム";
            this.labelZoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOverlay
            // 
            this.panelOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelOverlay.Controls.Add(this.labelDisplayItem);
            this.panelOverlay.Controls.Add(this.checkBoxRoute);
            this.panelOverlay.Controls.Add(this.checkBoxFence);
            this.panelOverlay.Controls.Add(this.checkBoxEmergency);
            this.panelOverlay.Location = new System.Drawing.Point(13, 387);
            this.panelOverlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelOverlay.Name = "panelOverlay";
            this.panelOverlay.Size = new System.Drawing.Size(221, 75);
            this.panelOverlay.TabIndex = 0;
            // 
            // labelDisplayItem
            // 
            this.labelDisplayItem.BackColor = System.Drawing.Color.Transparent;
            this.labelDisplayItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDisplayItem.ForeColor = System.Drawing.Color.White;
            this.labelDisplayItem.Location = new System.Drawing.Point(0, 0);
            this.labelDisplayItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDisplayItem.Name = "labelDisplayItem";
            this.labelDisplayItem.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelDisplayItem.Size = new System.Drawing.Size(80, 75);
            this.labelDisplayItem.TabIndex = 0;
            this.labelDisplayItem.Text = "表示項目";
            this.labelDisplayItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxRoute
            // 
            this.checkBoxRoute.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRoute.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRoute.Checked = true;
            this.checkBoxRoute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRoute.ForeColor = System.Drawing.Color.White;
            this.checkBoxRoute.Location = new System.Drawing.Point(80, 0);
            this.checkBoxRoute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxRoute.Name = "checkBoxRoute";
            this.checkBoxRoute.Size = new System.Drawing.Size(141, 30);
            this.checkBoxRoute.TabIndex = 1;
            this.checkBoxRoute.Text = "飛行ルート";
            this.checkBoxRoute.UseVisualStyleBackColor = false;
            this.checkBoxRoute.CheckedChanged += new System.EventHandler(this.checkBoxDisplay_CheckedChanged);
            // 
            // checkBoxFence
            // 
            this.checkBoxFence.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFence.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxFence.Checked = true;
            this.checkBoxFence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFence.ForeColor = System.Drawing.Color.White;
            this.checkBoxFence.Location = new System.Drawing.Point(80, 25);
            this.checkBoxFence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxFence.Name = "checkBoxFence";
            this.checkBoxFence.Size = new System.Drawing.Size(141, 30);
            this.checkBoxFence.TabIndex = 2;
            this.checkBoxFence.Text = "フェンス";
            this.checkBoxFence.UseVisualStyleBackColor = false;
            this.checkBoxFence.CheckedChanged += new System.EventHandler(this.checkBoxDisplay_CheckedChanged);
            // 
            // checkBoxEmergency
            // 
            this.checkBoxEmergency.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxEmergency.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEmergency.Checked = true;
            this.checkBoxEmergency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEmergency.ForeColor = System.Drawing.Color.White;
            this.checkBoxEmergency.Location = new System.Drawing.Point(80, 50);
            this.checkBoxEmergency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEmergency.Name = "checkBoxEmergency";
            this.checkBoxEmergency.Size = new System.Drawing.Size(141, 30);
            this.checkBoxEmergency.TabIndex = 3;
            this.checkBoxEmergency.Text = "緊急着陸地点";
            this.checkBoxEmergency.UseVisualStyleBackColor = false;
            this.checkBoxEmergency.CheckedChanged += new System.EventHandler(this.checkBoxDisplay_CheckedChanged);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDistance.ForeColor = System.Drawing.Color.White;
            this.labelDistance.Location = new System.Drawing.Point(13, 12);
            this.labelDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(0, 15);
            this.labelDistance.TabIndex = 1;
            // 
            // panelWPs
            // 
            this.panelWPs.AutoSize = true;
            this.panelWPs.BackColor = System.Drawing.Color.Black;
            this.panelWPs.Controls.Add(this.tableLayoutPanelWPs);
            this.panelWPs.Controls.Add(this.panelFooter);
            this.panelWPs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWPs.Location = new System.Drawing.Point(0, 0);
            this.panelWPs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelWPs.Name = "panelWPs";
            this.panelWPs.Size = new System.Drawing.Size(1733, 347);
            this.panelWPs.TabIndex = 0;
            // 
            // tableLayoutPanelWPs
            // 
            this.tableLayoutPanelWPs.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelWPs.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelWPs.ColumnCount = 4;
            this.tableLayoutPanelWPs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanelWPs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanelWPs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanelWPs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanelWPs.Controls.Add(this.panelWPsContainer, 0, 0);
            this.tableLayoutPanelWPs.Controls.Add(this.panelFenceIncContainer, 1, 0);
            this.tableLayoutPanelWPs.Controls.Add(this.panelFenceExcContainer, 2, 0);
            this.tableLayoutPanelWPs.Controls.Add(this.panelEmergencyContainer, 3, 0);
            this.tableLayoutPanelWPs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWPs.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelWPs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelWPs.Name = "tableLayoutPanelWPs";
            this.tableLayoutPanelWPs.RowCount = 1;
            this.tableLayoutPanelWPs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWPs.Size = new System.Drawing.Size(1733, 272);
            this.tableLayoutPanelWPs.TabIndex = 0;
            // 
            // panelWPsContainer
            // 
            this.panelWPsContainer.BackColor = System.Drawing.Color.Black;
            this.panelWPsContainer.Controls.Add(this.dataGridViewWPs);
            this.panelWPsContainer.Controls.Add(this.labelWPs);
            this.panelWPsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWPsContainer.Location = new System.Drawing.Point(5, 5);
            this.panelWPsContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelWPsContainer.Name = "panelWPsContainer";
            this.panelWPsContainer.Size = new System.Drawing.Size(475, 262);
            this.panelWPsContainer.TabIndex = 3;
            // 
            // dataGridViewWPs
            // 
            this.dataGridViewWPs.AllowUserToAddRows = false;
            this.dataGridViewWPs.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWPs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWPs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWpCommand,
            this.colWpParam1,
            this.colWpParam2,
            this.colWpParam3,
            this.colWpParam4,
            this.colWpLat,
            this.colWpLon,
            this.colWpAlt,
            this.colWpFrame,
            this.colWpDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWPs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWPs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWPs.EnableHeadersVisualStyles = false;
            this.dataGridViewWPs.GridColor = System.Drawing.Color.White;
            this.dataGridViewWPs.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewWPs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewWPs.Name = "dataGridViewWPs";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWPs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewWPs.RowHeadersWidth = 50;
            this.dataGridViewWPs.Size = new System.Drawing.Size(475, 233);
            this.dataGridViewWPs.TabIndex = 0;
            this.dataGridViewWPs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWPs_CellContentClick);
            this.dataGridViewWPs.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridViewWPs_RowPostPaint);
            // 
            // colWpCommand
            // 
            this.colWpCommand.HeaderText = "コマンド";
            this.colWpCommand.Name = "colWpCommand";
            this.colWpCommand.Visible = false;
            // 
            // colWpParam1
            // 
            this.colWpParam1.HeaderText = "P1";
            this.colWpParam1.Name = "colWpParam1";
            this.colWpParam1.Visible = false;
            // 
            // colWpParam2
            // 
            this.colWpParam2.HeaderText = "P2";
            this.colWpParam2.Name = "colWpParam2";
            this.colWpParam2.Visible = false;
            // 
            // colWpParam3
            // 
            this.colWpParam3.HeaderText = "P3";
            this.colWpParam3.Name = "colWpParam3";
            this.colWpParam3.Visible = false;
            // 
            // colWpParam4
            // 
            this.colWpParam4.HeaderText = "P4";
            this.colWpParam4.Name = "colWpParam4";
            this.colWpParam4.Visible = false;
            // 
            // colWpLat
            // 
            this.colWpLat.HeaderText = "緯度[°]";
            this.colWpLat.Name = "colWpLat";
            // 
            // colWpLon
            // 
            this.colWpLon.HeaderText = "経度[°]";
            this.colWpLon.Name = "colWpLon";
            // 
            // colWpAlt
            // 
            this.colWpAlt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colWpAlt.HeaderText = "高度[m]";
            this.colWpAlt.Name = "colWpAlt";
            this.colWpAlt.Width = 71;
            // 
            // colWpFrame
            // 
            this.colWpFrame.HeaderText = "フレーム";
            this.colWpFrame.Name = "colWpFrame";
            this.colWpFrame.Visible = false;
            // 
            // colWpDelete
            // 
            this.colWpDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colWpDelete.HeaderText = "削除";
            this.colWpDelete.Name = "colWpDelete";
            this.colWpDelete.Text = "X";
            this.colWpDelete.UseColumnTextForButtonValue = true;
            this.colWpDelete.Width = 35;
            // 
            // labelWPs
            // 
            this.labelWPs.BackColor = System.Drawing.Color.Black;
            this.labelWPs.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWPs.ForeColor = System.Drawing.Color.White;
            this.labelWPs.Location = new System.Drawing.Point(0, 0);
            this.labelWPs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWPs.Name = "labelWPs";
            this.labelWPs.Padding = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.labelWPs.Size = new System.Drawing.Size(475, 29);
            this.labelWPs.TabIndex = 1;
            this.labelWPs.Text = "ウェイポイント";
            this.labelWPs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFenceIncContainer
            // 
            this.panelFenceIncContainer.BackColor = System.Drawing.Color.Black;
            this.panelFenceIncContainer.Controls.Add(this.dataGridViewFenceInc);
            this.panelFenceIncContainer.Controls.Add(this.labelFenceInc);
            this.panelFenceIncContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFenceIncContainer.Location = new System.Drawing.Point(489, 5);
            this.panelFenceIncContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFenceIncContainer.Name = "panelFenceIncContainer";
            this.panelFenceIncContainer.Size = new System.Drawing.Size(406, 262);
            this.panelFenceIncContainer.TabIndex = 4;
            // 
            // dataGridViewFenceInc
            // 
            this.dataGridViewFenceInc.AllowUserToAddRows = false;
            this.dataGridViewFenceInc.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFenceInc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFenceInc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFenceIncCommand,
            this.colFenceIncParam1,
            this.colFenceIncParam2,
            this.colFenceIncParam3,
            this.colFenceIncParam4,
            this.colFenceIncLat,
            this.colFenceIncLon,
            this.colFenceIncAlt,
            this.colFenceIncFrame,
            this.colFenceIncDelete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFenceInc.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFenceInc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFenceInc.EnableHeadersVisualStyles = false;
            this.dataGridViewFenceInc.GridColor = System.Drawing.Color.White;
            this.dataGridViewFenceInc.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewFenceInc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFenceInc.Name = "dataGridViewFenceInc";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFenceInc.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewFenceInc.RowHeadersWidth = 50;
            this.dataGridViewFenceInc.Size = new System.Drawing.Size(406, 233);
            this.dataGridViewFenceInc.TabIndex = 1;
            this.dataGridViewFenceInc.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView_RowPostPaint);
            // 
            // colFenceIncCommand
            // 
            this.colFenceIncCommand.HeaderText = "コマンド";
            this.colFenceIncCommand.Name = "colFenceIncCommand";
            this.colFenceIncCommand.Visible = false;
            // 
            // colFenceIncParam1
            // 
            this.colFenceIncParam1.HeaderText = "P1";
            this.colFenceIncParam1.Name = "colFenceIncParam1";
            this.colFenceIncParam1.Visible = false;
            // 
            // colFenceIncParam2
            // 
            this.colFenceIncParam2.HeaderText = "P2";
            this.colFenceIncParam2.Name = "colFenceIncParam2";
            this.colFenceIncParam2.Visible = false;
            // 
            // colFenceIncParam3
            // 
            this.colFenceIncParam3.HeaderText = "P3";
            this.colFenceIncParam3.Name = "colFenceIncParam3";
            this.colFenceIncParam3.Visible = false;
            // 
            // colFenceIncParam4
            // 
            this.colFenceIncParam4.HeaderText = "P4";
            this.colFenceIncParam4.Name = "colFenceIncParam4";
            this.colFenceIncParam4.Visible = false;
            // 
            // colFenceIncLat
            // 
            this.colFenceIncLat.HeaderText = "緯度[°]";
            this.colFenceIncLat.Name = "colFenceIncLat";
            // 
            // colFenceIncLon
            // 
            this.colFenceIncLon.HeaderText = "経度[°]";
            this.colFenceIncLon.Name = "colFenceIncLon";
            // 
            // colFenceIncAlt
            // 
            this.colFenceIncAlt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colFenceIncAlt.HeaderText = "高度[m]";
            this.colFenceIncAlt.Name = "colFenceIncAlt";
            this.colFenceIncAlt.Visible = false;
            // 
            // colFenceIncFrame
            // 
            this.colFenceIncFrame.HeaderText = "フレーム";
            this.colFenceIncFrame.Name = "colFenceIncFrame";
            this.colFenceIncFrame.Visible = false;
            // 
            // colFenceIncDelete
            // 
            this.colFenceIncDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colFenceIncDelete.HeaderText = "削除";
            this.colFenceIncDelete.Name = "colFenceIncDelete";
            this.colFenceIncDelete.Text = "X";
            this.colFenceIncDelete.UseColumnTextForButtonValue = true;
            this.colFenceIncDelete.Width = 35;
            // 
            // labelFenceInc
            // 
            this.labelFenceInc.BackColor = System.Drawing.Color.Black;
            this.labelFenceInc.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFenceInc.ForeColor = System.Drawing.Color.White;
            this.labelFenceInc.Location = new System.Drawing.Point(0, 0);
            this.labelFenceInc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFenceInc.Name = "labelFenceInc";
            this.labelFenceInc.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.labelFenceInc.Size = new System.Drawing.Size(406, 29);
            this.labelFenceInc.TabIndex = 2;
            this.labelFenceInc.Text = "逸脱防止フェンス";
            // 
            // panelFenceExcContainer
            // 
            this.panelFenceExcContainer.BackColor = System.Drawing.Color.Black;
            this.panelFenceExcContainer.Controls.Add(this.dataGridViewFenceExc);
            this.panelFenceExcContainer.Controls.Add(this.labelFenceExc);
            this.panelFenceExcContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFenceExcContainer.Location = new System.Drawing.Point(904, 5);
            this.panelFenceExcContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFenceExcContainer.Name = "panelFenceExcContainer";
            this.panelFenceExcContainer.Size = new System.Drawing.Size(406, 262);
            this.panelFenceExcContainer.TabIndex = 4;
            // 
            // dataGridViewFenceExc
            // 
            this.dataGridViewFenceExc.AllowUserToAddRows = false;
            this.dataGridViewFenceExc.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewFenceExc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFenceExc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFenceExcCommand,
            this.colFenceExcParam1,
            this.colFenceExcParam2,
            this.colFenceExcParam3,
            this.colFenceExcParam4,
            this.colFenceExcLat,
            this.colFenceExcLon,
            this.colFenceExcAlt,
            this.colFenceExcFrame,
            this.colFenceExcDelete});
            this.dataGridViewFenceExc.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFenceExc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFenceExc.EnableHeadersVisualStyles = false;
            this.dataGridViewFenceExc.GridColor = System.Drawing.Color.White;
            this.dataGridViewFenceExc.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewFenceExc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFenceExc.Name = "dataGridViewFenceExc";
            this.dataGridViewFenceExc.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewFenceExc.RowHeadersWidth = 50;
            this.dataGridViewFenceExc.Size = new System.Drawing.Size(406, 233);
            this.dataGridViewFenceExc.TabIndex = 1;
            this.dataGridViewFenceExc.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView_RowPostPaint);
            // 
            // colFenceExcCommand
            // 
            this.colFenceExcCommand.HeaderText = "コマンド";
            this.colFenceExcCommand.Name = "colFenceExcCommand";
            this.colFenceExcCommand.Visible = false;
            // 
            // colFenceExcParam1
            // 
            this.colFenceExcParam1.HeaderText = "P1";
            this.colFenceExcParam1.Name = "colFenceExcParam1";
            this.colFenceExcParam1.Visible = false;
            // 
            // colFenceExcParam2
            // 
            this.colFenceExcParam2.HeaderText = "P2";
            this.colFenceExcParam2.Name = "colFenceExcParam2";
            this.colFenceExcParam2.Visible = false;
            // 
            // colFenceExcParam3
            // 
            this.colFenceExcParam3.HeaderText = "P3";
            this.colFenceExcParam3.Name = "colFenceExcParam3";
            this.colFenceExcParam3.Visible = false;
            // 
            // colFenceExcParam4
            // 
            this.colFenceExcParam4.HeaderText = "P4";
            this.colFenceExcParam4.Name = "colFenceExcParam4";
            this.colFenceExcParam4.Visible = false;
            // 
            // colFenceExcLat
            // 
            this.colFenceExcLat.HeaderText = "緯度[°]";
            this.colFenceExcLat.Name = "colFenceExcLat";
            // 
            // colFenceExcLon
            // 
            this.colFenceExcLon.HeaderText = "経度[°]";
            this.colFenceExcLon.Name = "colFenceExcLon";
            // 
            // colFenceExcAlt
            // 
            this.colFenceExcAlt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colFenceExcAlt.HeaderText = "高度[m]";
            this.colFenceExcAlt.Name = "colFenceExcAlt";
            this.colFenceExcAlt.Visible = false;
            // 
            // colFenceExcFrame
            // 
            this.colFenceExcFrame.HeaderText = "フレーム";
            this.colFenceExcFrame.Name = "colFenceExcFrame";
            this.colFenceExcFrame.Visible = false;
            // 
            // colFenceExcDelete
            // 
            this.colFenceExcDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colFenceExcDelete.HeaderText = "削除";
            this.colFenceExcDelete.Name = "colFenceExcDelete";
            this.colFenceExcDelete.Text = "X";
            this.colFenceExcDelete.UseColumnTextForButtonValue = true;
            this.colFenceExcDelete.Width = 35;
            // 
            // labelFenceExc
            // 
            this.labelFenceExc.BackColor = System.Drawing.Color.Black;
            this.labelFenceExc.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFenceExc.ForeColor = System.Drawing.Color.White;
            this.labelFenceExc.Location = new System.Drawing.Point(0, 0);
            this.labelFenceExc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFenceExc.Name = "labelFenceExc";
            this.labelFenceExc.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.labelFenceExc.Size = new System.Drawing.Size(406, 29);
            this.labelFenceExc.TabIndex = 2;
            this.labelFenceExc.Text = "進入禁止フェンス";
            // 
            // panelEmergencyContainer
            // 
            this.panelEmergencyContainer.BackColor = System.Drawing.Color.Black;
            this.panelEmergencyContainer.Controls.Add(this.dataGridViewEmergency);
            this.panelEmergencyContainer.Controls.Add(this.labelEmergency);
            this.panelEmergencyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmergencyContainer.Location = new System.Drawing.Point(1319, 5);
            this.panelEmergencyContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEmergencyContainer.Name = "panelEmergencyContainer";
            this.panelEmergencyContainer.Size = new System.Drawing.Size(409, 262);
            this.panelEmergencyContainer.TabIndex = 5;
            // 
            // dataGridViewEmergency
            // 
            this.dataGridViewEmergency.AllowUserToAddRows = false;
            this.dataGridViewEmergency.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmergency.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewEmergency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRallyCommand,
            this.colRallyParam1,
            this.colRallyParam2,
            this.colRallyParam3,
            this.colRallyParam4,
            this.colRallyLat,
            this.colRallyLon,
            this.colRallyAlt,
            this.colRallyFrame,
            this.colRallyDelete});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmergency.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewEmergency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmergency.EnableHeadersVisualStyles = false;
            this.dataGridViewEmergency.GridColor = System.Drawing.Color.White;
            this.dataGridViewEmergency.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewEmergency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEmergency.Name = "dataGridViewEmergency";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmergency.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewEmergency.RowHeadersWidth = 50;
            this.dataGridViewEmergency.Size = new System.Drawing.Size(409, 233);
            this.dataGridViewEmergency.TabIndex = 2;
            this.dataGridViewEmergency.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView_RowPostPaint);
            // 
            // colRallyCommand
            // 
            this.colRallyCommand.HeaderText = "コマンド";
            this.colRallyCommand.Name = "colRallyCommand";
            this.colRallyCommand.Visible = false;
            // 
            // colRallyParam1
            // 
            this.colRallyParam1.HeaderText = "P1";
            this.colRallyParam1.Name = "colRallyParam1";
            this.colRallyParam1.Visible = false;
            // 
            // colRallyParam2
            // 
            this.colRallyParam2.HeaderText = "P2";
            this.colRallyParam2.Name = "colRallyParam2";
            this.colRallyParam2.Visible = false;
            // 
            // colRallyParam3
            // 
            this.colRallyParam3.HeaderText = "P3";
            this.colRallyParam3.Name = "colRallyParam3";
            this.colRallyParam3.Visible = false;
            // 
            // colRallyParam4
            // 
            this.colRallyParam4.HeaderText = "P4";
            this.colRallyParam4.Name = "colRallyParam4";
            this.colRallyParam4.Visible = false;
            // 
            // colRallyLat
            // 
            this.colRallyLat.HeaderText = "緯度[°]";
            this.colRallyLat.Name = "colRallyLat";
            // 
            // colRallyLon
            // 
            this.colRallyLon.HeaderText = "経度[°]";
            this.colRallyLon.Name = "colRallyLon";
            // 
            // colRallyAlt
            // 
            this.colRallyAlt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRallyAlt.HeaderText = "高度[m]";
            this.colRallyAlt.Name = "colRallyAlt";
            this.colRallyAlt.Visible = false;
            // 
            // colRallyFrame
            // 
            this.colRallyFrame.HeaderText = "フレーム";
            this.colRallyFrame.Name = "colRallyFrame";
            this.colRallyFrame.Visible = false;
            // 
            // colRallyDelete
            // 
            this.colRallyDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRallyDelete.HeaderText = "削除";
            this.colRallyDelete.Name = "colRallyDelete";
            this.colRallyDelete.Text = "X";
            this.colRallyDelete.UseColumnTextForButtonValue = true;
            this.colRallyDelete.Width = 35;
            // 
            // labelEmergency
            // 
            this.labelEmergency.BackColor = System.Drawing.Color.Black;
            this.labelEmergency.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEmergency.ForeColor = System.Drawing.Color.White;
            this.labelEmergency.Location = new System.Drawing.Point(0, 0);
            this.labelEmergency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmergency.Name = "labelEmergency";
            this.labelEmergency.Padding = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.labelEmergency.Size = new System.Drawing.Size(409, 29);
            this.labelEmergency.TabIndex = 3;
            this.labelEmergency.Text = "緊急着陸地点";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Black;
            this.panelFooter.Controls.Add(this.panelFooterContent);
            this.panelFooter.Controls.Add(this.labelSeparator);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 272);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1733, 75);
            this.panelFooter.TabIndex = 1;
            // 
            // panelFooterContent
            // 
            this.panelFooterContent.BackColor = System.Drawing.Color.Black;
            this.panelFooterContent.Controls.Add(this.buttonFileLoad);
            this.panelFooterContent.Controls.Add(this.buttonFileSave);
            this.panelFooterContent.Controls.Add(this.pictureLogoEAMS);
            this.panelFooterContent.Controls.Add(this.pictureLogoArdu);
            this.panelFooterContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFooterContent.Location = new System.Drawing.Point(0, 2);
            this.panelFooterContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFooterContent.Name = "panelFooterContent";
            this.panelFooterContent.Size = new System.Drawing.Size(1733, 73);
            this.panelFooterContent.TabIndex = 0;
            // 
            // buttonFileLoad
            // 
            this.buttonFileLoad.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonFileLoad.ForeColor = System.Drawing.Color.White;
            this.buttonFileLoad.Location = new System.Drawing.Point(27, 12);
            this.buttonFileLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFileLoad.Name = "buttonFileLoad";
            this.buttonFileLoad.Size = new System.Drawing.Size(160, 50);
            this.buttonFileLoad.TabIndex = 0;
            this.buttonFileLoad.Text = "ファイル読み込み";
            this.buttonFileLoad.UseVisualStyleBackColor = false;
            this.buttonFileLoad.Click += new System.EventHandler(this.buttonFileLoad_Click);
            // 
            // buttonFileSave
            // 
            this.buttonFileSave.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonFileSave.ForeColor = System.Drawing.Color.White;
            this.buttonFileSave.Location = new System.Drawing.Point(213, 12);
            this.buttonFileSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFileSave.Name = "buttonFileSave";
            this.buttonFileSave.Size = new System.Drawing.Size(160, 50);
            this.buttonFileSave.TabIndex = 1;
            this.buttonFileSave.Text = "ファイルの保存";
            this.buttonFileSave.UseVisualStyleBackColor = false;
            this.buttonFileSave.Click += new System.EventHandler(this.buttonFileSave_Click);
            // 
            // pictureLogoEAMS
            // 
            this.pictureLogoEAMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLogoEAMS.Image = global::FlightPlanningSoftware.Properties.Resources.EAMS_logo;
            this.pictureLogoEAMS.Location = new System.Drawing.Point(1059, 19);
            this.pictureLogoEAMS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureLogoEAMS.Name = "pictureLogoEAMS";
            this.pictureLogoEAMS.Size = new System.Drawing.Size(333, 50);
            this.pictureLogoEAMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogoEAMS.TabIndex = 2;
            this.pictureLogoEAMS.TabStop = false;
            // 
            // pictureLogoArdu
            // 
            this.pictureLogoArdu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLogoArdu.Image = global::FlightPlanningSoftware.Properties.Resources._0d92fed790a3a70170e61a86db103f399a595c70;
            this.pictureLogoArdu.Location = new System.Drawing.Point(1405, 21);
            this.pictureLogoArdu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureLogoArdu.Name = "pictureLogoArdu";
            this.pictureLogoArdu.Size = new System.Drawing.Size(307, 45);
            this.pictureLogoArdu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogoArdu.TabIndex = 3;
            this.pictureLogoArdu.TabStop = false;
            // 
            // labelSeparator
            // 
            this.labelSeparator.BackColor = System.Drawing.Color.White;
            this.labelSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSeparator.Location = new System.Drawing.Point(0, 0);
            this.labelSeparator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(1733, 2);
            this.labelSeparator.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 851);
            this.Controls.Add(this.splitContainerVert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Flight Planning Software";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FlightPlanningSoftware_FormClosed);
            this.Load += new System.EventHandler(this.FlightPlanningSoftware_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlightPlanningSoftware_KeyDown);
            this.splitContainerVert.Panel1.ResumeLayout(false);
            this.splitContainerVert.Panel2.ResumeLayout(false);
            this.splitContainerVert.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVert)).EndInit();
            this.splitContainerVert.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelMap.ResumeLayout(false);
            this.MainMap.ResumeLayout(false);
            this.MainMap.PerformLayout();
            this.panelZoomOverlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomOut)).EndInit();
            this.panelOverlay.ResumeLayout(false);
            this.panelWPs.ResumeLayout(false);
            this.tableLayoutPanelWPs.ResumeLayout(false);
            this.panelWPsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWPs)).EndInit();
            this.panelFenceIncContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFenceInc)).EndInit();
            this.panelFenceExcContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFenceExc)).EndInit();
            this.panelEmergencyContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmergency)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooterContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoEAMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoArdu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

