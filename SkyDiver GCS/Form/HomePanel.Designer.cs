
namespace SkyDiver_GCS
{
    partial class HomePanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitMapCam = new System.Windows.Forms.SplitContainer();
            this.panelMarker = new System.Windows.Forms.Panel();
            this.splitMarker = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListMarkerMap = new System.Windows.Forms.CheckedListBox();
            this.MapScaler = new System.Windows.Forms.TrackBar();
            this.PanelDataBar = new System.Windows.Forms.Panel();
            this.MouseMapLatLangRaw = new System.Windows.Forms.Label();
            this.MapsSettingPanel = new System.Windows.Forms.Panel();
            this.splitMapSetting = new System.Windows.Forms.SplitContainer();
            this.MapsSetting = new System.Windows.Forms.Label();
            this.btnFindPlane = new System.Windows.Forms.Button();
            this.btnFindLoc = new System.Windows.Forms.Button();
            this.labelLat = new System.Windows.Forms.Label();
            this.cbMapMode = new System.Windows.Forms.ComboBox();
            this.labelMapMode = new System.Windows.Forms.Label();
            this.labelLang = new System.Windows.Forms.Label();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.panelPayloadBayBG = new System.Windows.Forms.Panel();
            this.panelPayloadBay = new System.Windows.Forms.Panel();
            this.payloadbay2Status = new System.Windows.Forms.Label();
            this.payloadbay1Status = new System.Windows.Forms.Label();
            this.labelPaylaodBay2 = new System.Windows.Forms.Label();
            this.labelPaylaodBay1 = new System.Windows.Forms.Label();
            this.streamVideo = new System.Windows.Forms.PictureBox();
            this.panelThrottleAndClimbRateBg = new System.Windows.Forms.Panel();
            this.panelThrottleAndClimbRate = new System.Windows.Forms.Panel();
            this.climbRateVal = new System.Windows.Forms.Label();
            this.throttleVal = new System.Windows.Forms.Label();
            this.labelClimbRateName = new System.Windows.Forms.Label();
            this.labelThrottleName = new System.Windows.Forms.Label();
            this.panelSensorBar = new System.Windows.Forms.Panel();
            this.panelSensorBarVal = new System.Windows.Forms.Panel();
            this.altitudeVal = new System.Windows.Forms.Label();
            this.airSpeedVal = new System.Windows.Forms.Label();
            this.yawVal = new System.Windows.Forms.Label();
            this.groundSpeedVal = new System.Windows.Forms.Label();
            this.pitchVal = new System.Windows.Forms.Label();
            this.rollVal = new System.Windows.Forms.Label();
            this.panelSensorBarName = new System.Windows.Forms.Panel();
            this.labelRoll = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.labelYaw = new System.Windows.Forms.Label();
            this.labelAirSpeed = new System.Windows.Forms.Label();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.labelGroundSpeed = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitMapCam)).BeginInit();
            this.splitMapCam.Panel1.SuspendLayout();
            this.splitMapCam.Panel2.SuspendLayout();
            this.splitMapCam.SuspendLayout();
            this.panelMarker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMarker)).BeginInit();
            this.splitMarker.Panel1.SuspendLayout();
            this.splitMarker.Panel2.SuspendLayout();
            this.splitMarker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapScaler)).BeginInit();
            this.PanelDataBar.SuspendLayout();
            this.MapsSettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMapSetting)).BeginInit();
            this.splitMapSetting.Panel1.SuspendLayout();
            this.splitMapSetting.Panel2.SuspendLayout();
            this.splitMapSetting.SuspendLayout();
            this.panelPayloadBayBG.SuspendLayout();
            this.panelPayloadBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streamVideo)).BeginInit();
            this.panelThrottleAndClimbRateBg.SuspendLayout();
            this.panelThrottleAndClimbRate.SuspendLayout();
            this.panelSensorBar.SuspendLayout();
            this.panelSensorBarVal.SuspendLayout();
            this.panelSensorBarName.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMapCam
            // 
            this.splitMapCam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitMapCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMapCam.Location = new System.Drawing.Point(0, 0);
            this.splitMapCam.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.splitMapCam.Name = "splitMapCam";
            // 
            // splitMapCam.Panel1
            // 
            this.splitMapCam.Panel1.BackColor = System.Drawing.Color.Gray;
            this.splitMapCam.Panel1.Controls.Add(this.panelMarker);
            this.splitMapCam.Panel1.Controls.Add(this.MapScaler);
            this.splitMapCam.Panel1.Controls.Add(this.PanelDataBar);
            this.splitMapCam.Panel1.Controls.Add(this.MapsSettingPanel);
            this.splitMapCam.Panel1.Controls.Add(this.gMap);
            this.splitMapCam.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitMapCam.Panel2
            // 
            this.splitMapCam.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitMapCam.Panel2.Controls.Add(this.videoSourcePlayer);
            this.splitMapCam.Panel2.Controls.Add(this.panelPayloadBayBG);
            this.splitMapCam.Panel2.Controls.Add(this.streamVideo);
            this.splitMapCam.Panel2.Controls.Add(this.panelThrottleAndClimbRateBg);
            this.splitMapCam.Panel2.Controls.Add(this.panelSensorBar);
            this.splitMapCam.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitMapCam.Panel2MinSize = 640;
            this.splitMapCam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitMapCam.Size = new System.Drawing.Size(1334, 690);
            this.splitMapCam.SplitterDistance = 690;
            this.splitMapCam.TabIndex = 0;
            this.splitMapCam.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerDC_SplitterMoved);
            // 
            // panelMarker
            // 
            this.panelMarker.BackColor = System.Drawing.Color.White;
            this.panelMarker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMarker.Controls.Add(this.splitMarker);
            this.panelMarker.Location = new System.Drawing.Point(12, 12);
            this.panelMarker.Name = "panelMarker";
            this.panelMarker.Padding = new System.Windows.Forms.Padding(2);
            this.panelMarker.Size = new System.Drawing.Size(200, 120);
            this.panelMarker.TabIndex = 11;
            // 
            // splitMarker
            // 
            this.splitMarker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMarker.IsSplitterFixed = true;
            this.splitMarker.Location = new System.Drawing.Point(2, 2);
            this.splitMarker.Name = "splitMarker";
            this.splitMarker.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMarker.Panel1
            // 
            this.splitMarker.Panel1.Controls.Add(this.label1);
            this.splitMarker.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitMarker.Panel2
            // 
            this.splitMarker.Panel2.Controls.Add(this.checkedListMarkerMap);
            this.splitMarker.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitMarker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitMarker.Size = new System.Drawing.Size(194, 114);
            this.splitMarker.SplitterDistance = 25;
            this.splitMarker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Show Marker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListMarkerMap
            // 
            this.checkedListMarkerMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.checkedListMarkerMap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListMarkerMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListMarkerMap.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.checkedListMarkerMap.ForeColor = System.Drawing.SystemColors.Info;
            this.checkedListMarkerMap.FormattingEnabled = true;
            this.checkedListMarkerMap.Location = new System.Drawing.Point(0, 0);
            this.checkedListMarkerMap.Name = "checkedListMarkerMap";
            this.checkedListMarkerMap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListMarkerMap.Size = new System.Drawing.Size(194, 85);
            this.checkedListMarkerMap.TabIndex = 9;
            this.checkedListMarkerMap.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListMarkerMap_ItemCheck);
            this.checkedListMarkerMap.SelectedIndexChanged += new System.EventHandler(this.checkedListMarkerMap_SelectedIndexChanged);
            this.checkedListMarkerMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkedListMarkerMap_MouseDown);
            // 
            // MapScaler
            // 
            this.MapScaler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapScaler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MapScaler.LargeChange = 1;
            this.MapScaler.Location = new System.Drawing.Point(633, 206);
            this.MapScaler.Maximum = 20;
            this.MapScaler.Minimum = 2;
            this.MapScaler.Name = "MapScaler";
            this.MapScaler.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MapScaler.Size = new System.Drawing.Size(45, 400);
            this.MapScaler.TabIndex = 1;
            this.MapScaler.Value = 2;
            this.MapScaler.ValueChanged += new System.EventHandler(this.MapScaler_ValueChanged);
            // 
            // PanelDataBar
            // 
            this.PanelDataBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelDataBar.Controls.Add(this.MouseMapLatLangRaw);
            this.PanelDataBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDataBar.Location = new System.Drawing.Point(0, 670);
            this.PanelDataBar.Name = "PanelDataBar";
            this.PanelDataBar.Size = new System.Drawing.Size(690, 20);
            this.PanelDataBar.TabIndex = 1;
            // 
            // MouseMapLatLangRaw
            // 
            this.MouseMapLatLangRaw.AutoSize = true;
            this.MouseMapLatLangRaw.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.MouseMapLatLangRaw.ForeColor = System.Drawing.Color.White;
            this.MouseMapLatLangRaw.Location = new System.Drawing.Point(2, 4);
            this.MouseMapLatLangRaw.Name = "MouseMapLatLangRaw";
            this.MouseMapLatLangRaw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MouseMapLatLangRaw.Size = new System.Drawing.Size(301, 15);
            this.MouseMapLatLangRaw.TabIndex = 1;
            this.MouseMapLatLangRaw.Text = "Lat=000.000000000000, Lang=000.000000000000;";
            this.MouseMapLatLangRaw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MapsSettingPanel
            // 
            this.MapsSettingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MapsSettingPanel.BackColor = System.Drawing.Color.White;
            this.MapsSettingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MapsSettingPanel.Controls.Add(this.splitMapSetting);
            this.MapsSettingPanel.Location = new System.Drawing.Point(440, 12);
            this.MapsSettingPanel.Name = "MapsSettingPanel";
            this.MapsSettingPanel.Padding = new System.Windows.Forms.Padding(2);
            this.MapsSettingPanel.Size = new System.Drawing.Size(238, 112);
            this.MapsSettingPanel.TabIndex = 0;
            // 
            // splitMapSetting
            // 
            this.splitMapSetting.BackColor = System.Drawing.Color.White;
            this.splitMapSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMapSetting.IsSplitterFixed = true;
            this.splitMapSetting.Location = new System.Drawing.Point(2, 2);
            this.splitMapSetting.Name = "splitMapSetting";
            this.splitMapSetting.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMapSetting.Panel1
            // 
            this.splitMapSetting.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.splitMapSetting.Panel1.Controls.Add(this.MapsSetting);
            this.splitMapSetting.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitMapSetting.Panel2
            // 
            this.splitMapSetting.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitMapSetting.Panel2.Controls.Add(this.btnFindPlane);
            this.splitMapSetting.Panel2.Controls.Add(this.btnFindLoc);
            this.splitMapSetting.Panel2.Controls.Add(this.labelLat);
            this.splitMapSetting.Panel2.Controls.Add(this.cbMapMode);
            this.splitMapSetting.Panel2.Controls.Add(this.labelMapMode);
            this.splitMapSetting.Panel2.Controls.Add(this.labelLang);
            this.splitMapSetting.Panel2.Controls.Add(this.tbLatitude);
            this.splitMapSetting.Panel2.Controls.Add(this.tbLongitude);
            this.splitMapSetting.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitMapSetting.Size = new System.Drawing.Size(232, 106);
            this.splitMapSetting.SplitterDistance = 25;
            this.splitMapSetting.TabIndex = 0;
            // 
            // MapsSetting
            // 
            this.MapsSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapsSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.MapsSetting.ForeColor = System.Drawing.Color.White;
            this.MapsSetting.Location = new System.Drawing.Point(0, 0);
            this.MapsSetting.Name = "MapsSetting";
            this.MapsSetting.Size = new System.Drawing.Size(232, 25);
            this.MapsSetting.TabIndex = 0;
            this.MapsSetting.Text = "Maps";
            this.MapsSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFindPlane
            // 
            this.btnFindPlane.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFindPlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFindPlane.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Btn_Search_Plane_490;
            this.btnFindPlane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindPlane.FlatAppearance.BorderSize = 0;
            this.btnFindPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.btnFindPlane.Location = new System.Drawing.Point(193, 35);
            this.btnFindPlane.Name = "btnFindPlane";
            this.btnFindPlane.Size = new System.Drawing.Size(35, 35);
            this.btnFindPlane.TabIndex = 7;
            this.btnFindPlane.UseVisualStyleBackColor = false;
            // 
            // btnFindLoc
            // 
            this.btnFindLoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFindLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFindLoc.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Btn_Search_Location_490;
            this.btnFindLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindLoc.FlatAppearance.BorderSize = 0;
            this.btnFindLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.btnFindLoc.Location = new System.Drawing.Point(152, 35);
            this.btnFindLoc.Name = "btnFindLoc";
            this.btnFindLoc.Size = new System.Drawing.Size(35, 35);
            this.btnFindLoc.TabIndex = 6;
            this.btnFindLoc.UseVisualStyleBackColor = false;
            this.btnFindLoc.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // labelLat
            // 
            this.labelLat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLat.AutoSize = true;
            this.labelLat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLat.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelLat.ForeColor = System.Drawing.Color.White;
            this.labelLat.Location = new System.Drawing.Point(4, 35);
            this.labelLat.Name = "labelLat";
            this.labelLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLat.Size = new System.Drawing.Size(32, 15);
            this.labelLat.TabIndex = 4;
            this.labelLat.Text = "Lat :";
            // 
            // cbMapMode
            // 
            this.cbMapMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbMapMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMapMode.FormattingEnabled = true;
            this.cbMapMode.Location = new System.Drawing.Point(98, 8);
            this.cbMapMode.Name = "cbMapMode";
            this.cbMapMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbMapMode.Size = new System.Drawing.Size(105, 21);
            this.cbMapMode.TabIndex = 0;
            this.cbMapMode.SelectedIndexChanged += new System.EventHandler(this.cbMapType_SelectedIndexChanged);
            // 
            // labelMapMode
            // 
            this.labelMapMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMapMode.AutoSize = true;
            this.labelMapMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMapMode.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelMapMode.ForeColor = System.Drawing.Color.Snow;
            this.labelMapMode.Location = new System.Drawing.Point(20, 9);
            this.labelMapMode.Name = "labelMapMode";
            this.labelMapMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMapMode.Size = new System.Drawing.Size(74, 15);
            this.labelMapMode.TabIndex = 8;
            this.labelMapMode.Text = "Map Mode :";
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLang.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelLang.ForeColor = System.Drawing.Color.White;
            this.labelLang.Location = new System.Drawing.Point(4, 56);
            this.labelLang.Name = "labelLang";
            this.labelLang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLang.Size = new System.Drawing.Size(42, 15);
            this.labelLang.TabIndex = 5;
            this.labelLang.Text = "Lang :";
            // 
            // tbLatitude
            // 
            this.tbLatitude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbLatitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLatitude.Location = new System.Drawing.Point(54, 36);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(90, 13);
            this.tbLatitude.TabIndex = 1;
            // 
            // tbLongitude
            // 
            this.tbLongitude.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbLongitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLongitude.Location = new System.Drawing.Point(55, 57);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(90, 13);
            this.tbLongitude.TabIndex = 2;
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(690, 690);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            this.gMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMap_OnMapZoomChanged);
            this.gMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseMove);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(0, 144);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(640, 480);
            this.videoSourcePlayer.TabIndex = 4;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.Paint += new System.Windows.Forms.PaintEventHandler(this.videoSourcePlayer_Paint);
            // 
            // panelPayloadBayBG
            // 
            this.panelPayloadBayBG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPayloadBayBG.BackColor = System.Drawing.Color.White;
            this.panelPayloadBayBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPayloadBayBG.Controls.Add(this.panelPayloadBay);
            this.panelPayloadBayBG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelPayloadBayBG.Location = new System.Drawing.Point(467, 5);
            this.panelPayloadBayBG.Name = "panelPayloadBayBG";
            this.panelPayloadBayBG.Padding = new System.Windows.Forms.Padding(2);
            this.panelPayloadBayBG.Size = new System.Drawing.Size(173, 60);
            this.panelPayloadBayBG.TabIndex = 3;
            // 
            // panelPayloadBay
            // 
            this.panelPayloadBay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelPayloadBay.Controls.Add(this.payloadbay2Status);
            this.panelPayloadBay.Controls.Add(this.payloadbay1Status);
            this.panelPayloadBay.Controls.Add(this.labelPaylaodBay2);
            this.panelPayloadBay.Controls.Add(this.labelPaylaodBay1);
            this.panelPayloadBay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPayloadBay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelPayloadBay.Location = new System.Drawing.Point(2, 2);
            this.panelPayloadBay.Name = "panelPayloadBay";
            this.panelPayloadBay.Size = new System.Drawing.Size(167, 54);
            this.panelPayloadBay.TabIndex = 2;
            // 
            // payloadbay2Status
            // 
            this.payloadbay2Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.payloadbay2Status.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadbay2Status.ForeColor = System.Drawing.Color.White;
            this.payloadbay2Status.Location = new System.Drawing.Point(109, 28);
            this.payloadbay2Status.Name = "payloadbay2Status";
            this.payloadbay2Status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.payloadbay2Status.Size = new System.Drawing.Size(58, 28);
            this.payloadbay2Status.TabIndex = 4;
            this.payloadbay2Status.Text = "N/A";
            this.payloadbay2Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // payloadbay1Status
            // 
            this.payloadbay1Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.payloadbay1Status.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payloadbay1Status.ForeColor = System.Drawing.Color.White;
            this.payloadbay1Status.Location = new System.Drawing.Point(109, 0);
            this.payloadbay1Status.Name = "payloadbay1Status";
            this.payloadbay1Status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.payloadbay1Status.Size = new System.Drawing.Size(58, 28);
            this.payloadbay1Status.TabIndex = 3;
            this.payloadbay1Status.Text = "N/A";
            this.payloadbay1Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPaylaodBay2
            // 
            this.labelPaylaodBay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelPaylaodBay2.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaylaodBay2.ForeColor = System.Drawing.Color.White;
            this.labelPaylaodBay2.Location = new System.Drawing.Point(3, 28);
            this.labelPaylaodBay2.Name = "labelPaylaodBay2";
            this.labelPaylaodBay2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPaylaodBay2.Size = new System.Drawing.Size(105, 28);
            this.labelPaylaodBay2.TabIndex = 2;
            this.labelPaylaodBay2.Text = "Paylaod Bay 2 :";
            this.labelPaylaodBay2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPaylaodBay1
            // 
            this.labelPaylaodBay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelPaylaodBay1.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaylaodBay1.ForeColor = System.Drawing.Color.White;
            this.labelPaylaodBay1.Location = new System.Drawing.Point(3, 0);
            this.labelPaylaodBay1.Name = "labelPaylaodBay1";
            this.labelPaylaodBay1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPaylaodBay1.Size = new System.Drawing.Size(105, 28);
            this.labelPaylaodBay1.TabIndex = 1;
            this.labelPaylaodBay1.Text = "Paylaod Bay 1 :";
            this.labelPaylaodBay1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // streamVideo
            // 
            this.streamVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.streamVideo.BackColor = System.Drawing.Color.White;
            this.streamVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.streamVideo.Location = new System.Drawing.Point(0, 100);
            this.streamVideo.Name = "streamVideo";
            this.streamVideo.Size = new System.Drawing.Size(640, 480);
            this.streamVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.streamVideo.TabIndex = 2;
            this.streamVideo.TabStop = false;
            this.streamVideo.Paint += new System.Windows.Forms.PaintEventHandler(this.streamVideo_Paint);
            // 
            // panelThrottleAndClimbRateBg
            // 
            this.panelThrottleAndClimbRateBg.BackColor = System.Drawing.Color.White;
            this.panelThrottleAndClimbRateBg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelThrottleAndClimbRateBg.Controls.Add(this.panelThrottleAndClimbRate);
            this.panelThrottleAndClimbRateBg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelThrottleAndClimbRateBg.Location = new System.Drawing.Point(0, 5);
            this.panelThrottleAndClimbRateBg.Name = "panelThrottleAndClimbRateBg";
            this.panelThrottleAndClimbRateBg.Padding = new System.Windows.Forms.Padding(2);
            this.panelThrottleAndClimbRateBg.Size = new System.Drawing.Size(181, 60);
            this.panelThrottleAndClimbRateBg.TabIndex = 1;
            // 
            // panelThrottleAndClimbRate
            // 
            this.panelThrottleAndClimbRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelThrottleAndClimbRate.Controls.Add(this.climbRateVal);
            this.panelThrottleAndClimbRate.Controls.Add(this.throttleVal);
            this.panelThrottleAndClimbRate.Controls.Add(this.labelClimbRateName);
            this.panelThrottleAndClimbRate.Controls.Add(this.labelThrottleName);
            this.panelThrottleAndClimbRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThrottleAndClimbRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelThrottleAndClimbRate.Location = new System.Drawing.Point(2, 2);
            this.panelThrottleAndClimbRate.Name = "panelThrottleAndClimbRate";
            this.panelThrottleAndClimbRate.Size = new System.Drawing.Size(175, 54);
            this.panelThrottleAndClimbRate.TabIndex = 2;
            // 
            // climbRateVal
            // 
            this.climbRateVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.climbRateVal.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.climbRateVal.ForeColor = System.Drawing.Color.White;
            this.climbRateVal.Location = new System.Drawing.Point(86, 28);
            this.climbRateVal.Name = "climbRateVal";
            this.climbRateVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.climbRateVal.Size = new System.Drawing.Size(86, 28);
            this.climbRateVal.TabIndex = 4;
            this.climbRateVal.Text = "N/A";
            this.climbRateVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // throttleVal
            // 
            this.throttleVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.throttleVal.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throttleVal.ForeColor = System.Drawing.Color.White;
            this.throttleVal.Location = new System.Drawing.Point(86, 0);
            this.throttleVal.Name = "throttleVal";
            this.throttleVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.throttleVal.Size = new System.Drawing.Size(86, 28);
            this.throttleVal.TabIndex = 3;
            this.throttleVal.Text = "N/A";
            this.throttleVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelClimbRateName
            // 
            this.labelClimbRateName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelClimbRateName.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClimbRateName.ForeColor = System.Drawing.Color.White;
            this.labelClimbRateName.Location = new System.Drawing.Point(4, 28);
            this.labelClimbRateName.Name = "labelClimbRateName";
            this.labelClimbRateName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelClimbRateName.Size = new System.Drawing.Size(82, 28);
            this.labelClimbRateName.TabIndex = 2;
            this.labelClimbRateName.Text = "Climb Rate :";
            this.labelClimbRateName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelThrottleName
            // 
            this.labelThrottleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelThrottleName.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThrottleName.ForeColor = System.Drawing.Color.White;
            this.labelThrottleName.Location = new System.Drawing.Point(4, 0);
            this.labelThrottleName.Name = "labelThrottleName";
            this.labelThrottleName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelThrottleName.Size = new System.Drawing.Size(82, 28);
            this.labelThrottleName.TabIndex = 1;
            this.labelThrottleName.Text = "Throttle     :";
            this.labelThrottleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSensorBar
            // 
            this.panelSensorBar.BackColor = System.Drawing.Color.White;
            this.panelSensorBar.Controls.Add(this.panelSensorBarVal);
            this.panelSensorBar.Controls.Add(this.panelSensorBarName);
            this.panelSensorBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSensorBar.Location = new System.Drawing.Point(0, 630);
            this.panelSensorBar.Name = "panelSensorBar";
            this.panelSensorBar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.panelSensorBar.Size = new System.Drawing.Size(640, 60);
            this.panelSensorBar.TabIndex = 0;
            // 
            // panelSensorBarVal
            // 
            this.panelSensorBarVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelSensorBarVal.Controls.Add(this.altitudeVal);
            this.panelSensorBarVal.Controls.Add(this.airSpeedVal);
            this.panelSensorBarVal.Controls.Add(this.yawVal);
            this.panelSensorBarVal.Controls.Add(this.groundSpeedVal);
            this.panelSensorBarVal.Controls.Add(this.pitchVal);
            this.panelSensorBarVal.Controls.Add(this.rollVal);
            this.panelSensorBarVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSensorBarVal.Location = new System.Drawing.Point(0, 32);
            this.panelSensorBarVal.Name = "panelSensorBarVal";
            this.panelSensorBarVal.Size = new System.Drawing.Size(640, 28);
            this.panelSensorBarVal.TabIndex = 7;
            // 
            // altitudeVal
            // 
            this.altitudeVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altitudeVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.altitudeVal.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold);
            this.altitudeVal.ForeColor = System.Drawing.Color.White;
            this.altitudeVal.Location = new System.Drawing.Point(320, 0);
            this.altitudeVal.Name = "altitudeVal";
            this.altitudeVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.altitudeVal.Size = new System.Drawing.Size(100, 30);
            this.altitudeVal.TabIndex = 9;
            this.altitudeVal.Text = "N/A";
            this.altitudeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airSpeedVal
            // 
            this.airSpeedVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.airSpeedVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.airSpeedVal.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold);
            this.airSpeedVal.ForeColor = System.Drawing.Color.White;
            this.airSpeedVal.Location = new System.Drawing.Point(532, 0);
            this.airSpeedVal.Name = "airSpeedVal";
            this.airSpeedVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.airSpeedVal.Size = new System.Drawing.Size(100, 30);
            this.airSpeedVal.TabIndex = 11;
            this.airSpeedVal.Text = "N/A";
            this.airSpeedVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yawVal
            // 
            this.yawVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yawVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.yawVal.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold);
            this.yawVal.ForeColor = System.Drawing.Color.White;
            this.yawVal.Location = new System.Drawing.Point(214, 0);
            this.yawVal.Name = "yawVal";
            this.yawVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yawVal.Size = new System.Drawing.Size(100, 30);
            this.yawVal.TabIndex = 8;
            this.yawVal.Text = "N/A";
            this.yawVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groundSpeedVal
            // 
            this.groundSpeedVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groundSpeedVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.groundSpeedVal.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold);
            this.groundSpeedVal.ForeColor = System.Drawing.Color.White;
            this.groundSpeedVal.Location = new System.Drawing.Point(426, 0);
            this.groundSpeedVal.Name = "groundSpeedVal";
            this.groundSpeedVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groundSpeedVal.Size = new System.Drawing.Size(100, 30);
            this.groundSpeedVal.TabIndex = 10;
            this.groundSpeedVal.Text = "N/A";
            this.groundSpeedVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pitchVal
            // 
            this.pitchVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pitchVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pitchVal.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold);
            this.pitchVal.ForeColor = System.Drawing.Color.White;
            this.pitchVal.Location = new System.Drawing.Point(108, 0);
            this.pitchVal.Name = "pitchVal";
            this.pitchVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pitchVal.Size = new System.Drawing.Size(100, 30);
            this.pitchVal.TabIndex = 7;
            this.pitchVal.Text = "N/A";
            this.pitchVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rollVal
            // 
            this.rollVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rollVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rollVal.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollVal.ForeColor = System.Drawing.Color.White;
            this.rollVal.Location = new System.Drawing.Point(2, 0);
            this.rollVal.Name = "rollVal";
            this.rollVal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rollVal.Size = new System.Drawing.Size(100, 30);
            this.rollVal.TabIndex = 6;
            this.rollVal.Text = "N/A";
            this.rollVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSensorBarName
            // 
            this.panelSensorBarName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelSensorBarName.Controls.Add(this.labelRoll);
            this.panelSensorBarName.Controls.Add(this.labelPitch);
            this.panelSensorBarName.Controls.Add(this.labelYaw);
            this.panelSensorBarName.Controls.Add(this.labelAirSpeed);
            this.panelSensorBarName.Controls.Add(this.labelAltitude);
            this.panelSensorBarName.Controls.Add(this.labelGroundSpeed);
            this.panelSensorBarName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSensorBarName.Location = new System.Drawing.Point(0, 2);
            this.panelSensorBarName.Name = "panelSensorBarName";
            this.panelSensorBarName.Size = new System.Drawing.Size(640, 30);
            this.panelSensorBarName.TabIndex = 6;
            // 
            // labelRoll
            // 
            this.labelRoll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelRoll.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoll.ForeColor = System.Drawing.Color.White;
            this.labelRoll.Location = new System.Drawing.Point(2, 0);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRoll.Size = new System.Drawing.Size(107, 30);
            this.labelRoll.TabIndex = 0;
            this.labelRoll.Text = "Roll";
            this.labelRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPitch
            // 
            this.labelPitch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelPitch.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold);
            this.labelPitch.ForeColor = System.Drawing.Color.White;
            this.labelPitch.Location = new System.Drawing.Point(108, 0);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPitch.Size = new System.Drawing.Size(107, 30);
            this.labelPitch.TabIndex = 1;
            this.labelPitch.Text = "Pitch";
            this.labelPitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYaw
            // 
            this.labelYaw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelYaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelYaw.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold);
            this.labelYaw.ForeColor = System.Drawing.Color.White;
            this.labelYaw.Location = new System.Drawing.Point(214, 0);
            this.labelYaw.Name = "labelYaw";
            this.labelYaw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelYaw.Size = new System.Drawing.Size(107, 30);
            this.labelYaw.TabIndex = 2;
            this.labelYaw.Text = "Yaw";
            this.labelYaw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAirSpeed
            // 
            this.labelAirSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAirSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelAirSpeed.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold);
            this.labelAirSpeed.ForeColor = System.Drawing.Color.White;
            this.labelAirSpeed.Location = new System.Drawing.Point(532, 0);
            this.labelAirSpeed.Name = "labelAirSpeed";
            this.labelAirSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAirSpeed.Size = new System.Drawing.Size(107, 30);
            this.labelAirSpeed.TabIndex = 5;
            this.labelAirSpeed.Text = "Air Speed";
            this.labelAirSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAltitude
            // 
            this.labelAltitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAltitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelAltitude.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold);
            this.labelAltitude.ForeColor = System.Drawing.Color.White;
            this.labelAltitude.Location = new System.Drawing.Point(320, 0);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAltitude.Size = new System.Drawing.Size(107, 30);
            this.labelAltitude.TabIndex = 3;
            this.labelAltitude.Text = "Altitude";
            this.labelAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGroundSpeed
            // 
            this.labelGroundSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGroundSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelGroundSpeed.Font = new System.Drawing.Font("Futura Md BT", 9F, System.Drawing.FontStyle.Bold);
            this.labelGroundSpeed.ForeColor = System.Drawing.Color.White;
            this.labelGroundSpeed.Location = new System.Drawing.Point(426, 0);
            this.labelGroundSpeed.Name = "labelGroundSpeed";
            this.labelGroundSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGroundSpeed.Size = new System.Drawing.Size(107, 30);
            this.labelGroundSpeed.TabIndex = 4;
            this.labelGroundSpeed.Text = "Ground Speed";
            this.labelGroundSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1334, 690);
            this.Controls.Add(this.splitMapCam);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "HomePanel";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.HomePanel_Resize);
            this.splitMapCam.Panel1.ResumeLayout(false);
            this.splitMapCam.Panel1.PerformLayout();
            this.splitMapCam.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMapCam)).EndInit();
            this.splitMapCam.ResumeLayout(false);
            this.panelMarker.ResumeLayout(false);
            this.splitMarker.Panel1.ResumeLayout(false);
            this.splitMarker.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMarker)).EndInit();
            this.splitMarker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapScaler)).EndInit();
            this.PanelDataBar.ResumeLayout(false);
            this.PanelDataBar.PerformLayout();
            this.MapsSettingPanel.ResumeLayout(false);
            this.splitMapSetting.Panel1.ResumeLayout(false);
            this.splitMapSetting.Panel2.ResumeLayout(false);
            this.splitMapSetting.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMapSetting)).EndInit();
            this.splitMapSetting.ResumeLayout(false);
            this.panelPayloadBayBG.ResumeLayout(false);
            this.panelPayloadBay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.streamVideo)).EndInit();
            this.panelThrottleAndClimbRateBg.ResumeLayout(false);
            this.panelThrottleAndClimbRate.ResumeLayout(false);
            this.panelSensorBar.ResumeLayout(false);
            this.panelSensorBarVal.ResumeLayout(false);
            this.panelSensorBarName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMapCam;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label MouseMapLatLangRaw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar MapScaler;
        private System.Windows.Forms.Panel panelSensorBar;
        private System.Windows.Forms.Label labelYaw;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Label labelAirSpeed;
        private System.Windows.Forms.Label labelGroundSpeed;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.Label airSpeedVal;
        private System.Windows.Forms.Label groundSpeedVal;
        private System.Windows.Forms.Label altitudeVal;
        private System.Windows.Forms.Label yawVal;
        private System.Windows.Forms.Label pitchVal;
        private System.Windows.Forms.Label rollVal;
        private System.Windows.Forms.Panel panelSensorBarName;
        private System.Windows.Forms.Panel panelSensorBarVal;
        private System.Windows.Forms.Panel panelThrottleAndClimbRateBg;
        private System.Windows.Forms.Label labelThrottleName;
        private System.Windows.Forms.Label labelClimbRateName;
        private System.Windows.Forms.Panel panelThrottleAndClimbRate;
        private System.Windows.Forms.Label climbRateVal;
        private System.Windows.Forms.Label throttleVal;
        private System.Windows.Forms.Panel MapsSettingPanel;
        private System.Windows.Forms.SplitContainer splitMapSetting;
        private System.Windows.Forms.Label MapsSetting;
        private System.Windows.Forms.Button btnFindPlane;
        private System.Windows.Forms.Button btnFindLoc;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.ComboBox cbMapMode;
        private System.Windows.Forms.Label labelMapMode;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.Panel PanelDataBar;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Panel panelMarker;
        private System.Windows.Forms.SplitContainer splitMarker;
        private System.Windows.Forms.PictureBox streamVideo;
        private System.Windows.Forms.Panel panelPayloadBayBG;
        private System.Windows.Forms.Panel panelPayloadBay;
        private System.Windows.Forms.Label payloadbay2Status;
        private System.Windows.Forms.Label payloadbay1Status;
        private System.Windows.Forms.Label labelPaylaodBay2;
        private System.Windows.Forms.Label labelPaylaodBay1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckedListBox checkedListMarkerMap;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
    }
}