
namespace SkyDiver_GCS
{
    partial class PlanPanel
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
            System.Windows.Forms.Button btnResetFZ;
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelDrawMarker = new System.Windows.Forms.Panel();
            this.splitDrawMaker = new System.Windows.Forms.SplitContainer();
            this.labelDrawMarker = new System.Windows.Forms.Label();
            this.btnResetP = new System.Windows.Forms.Button();
            this.btnDrawWP = new System.Windows.Forms.Button();
            this.btnResetDC = new System.Windows.Forms.Button();
            this.btnDrawFZ = new System.Windows.Forms.Button();
            this.btnResetDZ = new System.Windows.Forms.Button();
            this.btnDrawDZ = new System.Windows.Forms.Button();
            this.btnResetW = new System.Windows.Forms.Button();
            this.btnDPointCand = new System.Windows.Forms.Button();
            this.btnPole = new System.Windows.Forms.Button();
            this.MapsSettingPanel = new System.Windows.Forms.Panel();
            this.splitMapSetting = new System.Windows.Forms.SplitContainer();
            this.MapsSetting = new System.Windows.Forms.Label();
            this.btnFindPlane = new System.Windows.Forms.Button();
            this.labelMapMode = new System.Windows.Forms.Label();
            this.btnFindLoc = new System.Windows.Forms.Button();
            this.cbMapMode = new System.Windows.Forms.ComboBox();
            this.labelLang = new System.Windows.Forms.Label();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.labelLat = new System.Windows.Forms.Label();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.MapScaler = new System.Windows.Forms.TrackBar();
            this.MouseMapLatLangRaw = new System.Windows.Forms.Label();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.PanelDataBar = new System.Windows.Forms.Panel();
            this.PanelMap = new System.Windows.Forms.Panel();
            this.panelRuler = new System.Windows.Forms.Panel();
            this.btnMapRuler = new System.Windows.Forms.Button();
            btnResetFZ = new System.Windows.Forms.Button();
            this.panelDrawMarker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDrawMaker)).BeginInit();
            this.splitDrawMaker.Panel1.SuspendLayout();
            this.splitDrawMaker.Panel2.SuspendLayout();
            this.splitDrawMaker.SuspendLayout();
            this.MapsSettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMapSetting)).BeginInit();
            this.splitMapSetting.Panel1.SuspendLayout();
            this.splitMapSetting.Panel2.SuspendLayout();
            this.splitMapSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapScaler)).BeginInit();
            this.PanelDataBar.SuspendLayout();
            this.PanelMap.SuspendLayout();
            this.panelRuler.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResetFZ
            // 
            btnResetFZ.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Btn_Reset_490;
            btnResetFZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnResetFZ.FlatAppearance.BorderSize = 0;
            btnResetFZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetFZ.ForeColor = System.Drawing.Color.White;
            btnResetFZ.Location = new System.Drawing.Point(115, 14);
            btnResetFZ.MaximumSize = new System.Drawing.Size(35, 35);
            btnResetFZ.MinimumSize = new System.Drawing.Size(20, 20);
            btnResetFZ.Name = "btnResetFZ";
            btnResetFZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnResetFZ.Size = new System.Drawing.Size(20, 20);
            btnResetFZ.TabIndex = 13;
            btnResetFZ.UseVisualStyleBackColor = true;
            btnResetFZ.Click += new System.EventHandler(this.btnResetFZ_Click);
            // 
            // panelDrawMarker
            // 
            this.panelDrawMarker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawMarker.Controls.Add(this.splitDrawMaker);
            this.panelDrawMarker.Location = new System.Drawing.Point(10, 10);
            this.panelDrawMarker.Name = "panelDrawMarker";
            this.panelDrawMarker.Padding = new System.Windows.Forms.Padding(2);
            this.panelDrawMarker.Size = new System.Drawing.Size(144, 242);
            this.panelDrawMarker.TabIndex = 2;
            // 
            // splitDrawMaker
            // 
            this.splitDrawMaker.BackColor = System.Drawing.Color.Snow;
            this.splitDrawMaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDrawMaker.IsSplitterFixed = true;
            this.splitDrawMaker.Location = new System.Drawing.Point(2, 2);
            this.splitDrawMaker.Name = "splitDrawMaker";
            this.splitDrawMaker.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitDrawMaker.Panel1
            // 
            this.splitDrawMaker.Panel1.Controls.Add(this.labelDrawMarker);
            this.splitDrawMaker.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitDrawMaker.Panel2
            // 
            this.splitDrawMaker.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitDrawMaker.Panel2.Controls.Add(this.btnResetP);
            this.splitDrawMaker.Panel2.Controls.Add(this.btnDrawWP);
            this.splitDrawMaker.Panel2.Controls.Add(this.btnResetDC);
            this.splitDrawMaker.Panel2.Controls.Add(this.btnDrawFZ);
            this.splitDrawMaker.Panel2.Controls.Add(this.btnResetDZ);
            this.splitDrawMaker.Panel2.Controls.Add(this.btnDrawDZ);
            this.splitDrawMaker.Panel2.Controls.Add(this.btnResetW);
            this.splitDrawMaker.Panel2.Controls.Add(this.btnDPointCand);
            this.splitDrawMaker.Panel2.Controls.Add(btnResetFZ);
            this.splitDrawMaker.Panel2.Controls.Add(this.btnPole);
            this.splitDrawMaker.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitDrawMaker.Size = new System.Drawing.Size(138, 236);
            this.splitDrawMaker.SplitterDistance = 25;
            this.splitDrawMaker.TabIndex = 0;
            // 
            // labelDrawMarker
            // 
            this.labelDrawMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.labelDrawMarker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDrawMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDrawMarker.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelDrawMarker.ForeColor = System.Drawing.Color.White;
            this.labelDrawMarker.Location = new System.Drawing.Point(0, 0);
            this.labelDrawMarker.Name = "labelDrawMarker";
            this.labelDrawMarker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDrawMarker.Size = new System.Drawing.Size(138, 25);
            this.labelDrawMarker.TabIndex = 6;
            this.labelDrawMarker.Text = "Draw Marker";
            this.labelDrawMarker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetP
            // 
            this.btnResetP.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Btn_Reset_490;
            this.btnResetP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResetP.FlatAppearance.BorderSize = 0;
            this.btnResetP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetP.ForeColor = System.Drawing.Color.White;
            this.btnResetP.Location = new System.Drawing.Point(115, 174);
            this.btnResetP.MaximumSize = new System.Drawing.Size(35, 35);
            this.btnResetP.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnResetP.Name = "btnResetP";
            this.btnResetP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResetP.Size = new System.Drawing.Size(20, 20);
            this.btnResetP.TabIndex = 17;
            this.btnResetP.UseVisualStyleBackColor = true;
            this.btnResetP.Click += new System.EventHandler(this.btnResetP_Click);
            // 
            // btnDrawWP
            // 
            this.btnDrawWP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDrawWP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDrawWP.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.BtnDrawWaypointDisactive_490;
            this.btnDrawWP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrawWP.FlatAppearance.BorderSize = 0;
            this.btnDrawWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawWP.Location = new System.Drawing.Point(3, 46);
            this.btnDrawWP.Name = "btnDrawWP";
            this.btnDrawWP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDrawWP.Size = new System.Drawing.Size(106, 35);
            this.btnDrawWP.TabIndex = 7;
            this.btnDrawWP.UseVisualStyleBackColor = false;
            this.btnDrawWP.Click += new System.EventHandler(this.btnDrawWP_Click);
            // 
            // btnResetDC
            // 
            this.btnResetDC.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Btn_Reset_490;
            this.btnResetDC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResetDC.FlatAppearance.BorderSize = 0;
            this.btnResetDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetDC.ForeColor = System.Drawing.Color.White;
            this.btnResetDC.Location = new System.Drawing.Point(115, 134);
            this.btnResetDC.MaximumSize = new System.Drawing.Size(35, 35);
            this.btnResetDC.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnResetDC.Name = "btnResetDC";
            this.btnResetDC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResetDC.Size = new System.Drawing.Size(20, 20);
            this.btnResetDC.TabIndex = 16;
            this.btnResetDC.UseVisualStyleBackColor = true;
            this.btnResetDC.Click += new System.EventHandler(this.btnResetDC_Click);
            // 
            // btnDrawFZ
            // 
            this.btnDrawFZ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDrawFZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDrawFZ.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.BtnDrawFlightZoneDisactive_490;
            this.btnDrawFZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrawFZ.FlatAppearance.BorderSize = 0;
            this.btnDrawFZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawFZ.Location = new System.Drawing.Point(3, 6);
            this.btnDrawFZ.Name = "btnDrawFZ";
            this.btnDrawFZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDrawFZ.Size = new System.Drawing.Size(106, 35);
            this.btnDrawFZ.TabIndex = 8;
            this.btnDrawFZ.UseVisualStyleBackColor = false;
            this.btnDrawFZ.Click += new System.EventHandler(this.btnDrawFZ_Click);
            // 
            // btnResetDZ
            // 
            this.btnResetDZ.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Btn_Reset_490;
            this.btnResetDZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResetDZ.FlatAppearance.BorderSize = 0;
            this.btnResetDZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetDZ.ForeColor = System.Drawing.Color.White;
            this.btnResetDZ.Location = new System.Drawing.Point(115, 94);
            this.btnResetDZ.MaximumSize = new System.Drawing.Size(35, 35);
            this.btnResetDZ.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnResetDZ.Name = "btnResetDZ";
            this.btnResetDZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResetDZ.Size = new System.Drawing.Size(20, 20);
            this.btnResetDZ.TabIndex = 15;
            this.btnResetDZ.UseVisualStyleBackColor = true;
            this.btnResetDZ.Click += new System.EventHandler(this.btnResetDZ_Click);
            // 
            // btnDrawDZ
            // 
            this.btnDrawDZ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDrawDZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDrawDZ.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.BtnDrawDropingZoneDisactive_490;
            this.btnDrawDZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrawDZ.FlatAppearance.BorderSize = 0;
            this.btnDrawDZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawDZ.Location = new System.Drawing.Point(3, 86);
            this.btnDrawDZ.Name = "btnDrawDZ";
            this.btnDrawDZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDrawDZ.Size = new System.Drawing.Size(106, 35);
            this.btnDrawDZ.TabIndex = 9;
            this.btnDrawDZ.UseVisualStyleBackColor = false;
            this.btnDrawDZ.Click += new System.EventHandler(this.btnDrawDZ_Click);
            // 
            // btnResetW
            // 
            this.btnResetW.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Btn_Reset_490;
            this.btnResetW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnResetW.FlatAppearance.BorderSize = 0;
            this.btnResetW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetW.ForeColor = System.Drawing.Color.White;
            this.btnResetW.Location = new System.Drawing.Point(115, 54);
            this.btnResetW.MaximumSize = new System.Drawing.Size(35, 35);
            this.btnResetW.MinimumSize = new System.Drawing.Size(20, 20);
            this.btnResetW.Name = "btnResetW";
            this.btnResetW.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResetW.Size = new System.Drawing.Size(20, 20);
            this.btnResetW.TabIndex = 14;
            this.btnResetW.UseVisualStyleBackColor = true;
            this.btnResetW.Click += new System.EventHandler(this.btnResetW_Click);
            // 
            // btnDPointCand
            // 
            this.btnDPointCand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDPointCand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDPointCand.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.BtnDrawDropingPointDisactive_490;
            this.btnDPointCand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDPointCand.FlatAppearance.BorderSize = 0;
            this.btnDPointCand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDPointCand.Location = new System.Drawing.Point(3, 126);
            this.btnDPointCand.Name = "btnDPointCand";
            this.btnDPointCand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDPointCand.Size = new System.Drawing.Size(106, 35);
            this.btnDPointCand.TabIndex = 10;
            this.btnDPointCand.UseVisualStyleBackColor = false;
            this.btnDPointCand.Click += new System.EventHandler(this.btnDPointCand_Click);
            // 
            // btnPole
            // 
            this.btnPole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPole.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.BtnDrawPoleDisactive_490;
            this.btnPole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPole.FlatAppearance.BorderSize = 0;
            this.btnPole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPole.Location = new System.Drawing.Point(3, 166);
            this.btnPole.Name = "btnPole";
            this.btnPole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPole.Size = new System.Drawing.Size(106, 35);
            this.btnPole.TabIndex = 11;
            this.btnPole.UseVisualStyleBackColor = false;
            this.btnPole.Click += new System.EventHandler(this.btnPole_Click);
            // 
            // MapsSettingPanel
            // 
            this.MapsSettingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MapsSettingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MapsSettingPanel.Controls.Add(this.splitMapSetting);
            this.MapsSettingPanel.Location = new System.Drawing.Point(1086, 10);
            this.MapsSettingPanel.Name = "MapsSettingPanel";
            this.MapsSettingPanel.Padding = new System.Windows.Forms.Padding(2);
            this.MapsSettingPanel.Size = new System.Drawing.Size(238, 112);
            this.MapsSettingPanel.TabIndex = 3;
            // 
            // splitMapSetting
            // 
            this.splitMapSetting.BackColor = System.Drawing.Color.Snow;
            this.splitMapSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMapSetting.IsSplitterFixed = true;
            this.splitMapSetting.Location = new System.Drawing.Point(2, 2);
            this.splitMapSetting.Name = "splitMapSetting";
            this.splitMapSetting.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMapSetting.Panel1
            // 
            this.splitMapSetting.Panel1.Controls.Add(this.MapsSetting);
            this.splitMapSetting.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitMapSetting.Panel2
            // 
            this.splitMapSetting.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitMapSetting.Panel2.Controls.Add(this.btnFindPlane);
            this.splitMapSetting.Panel2.Controls.Add(this.labelMapMode);
            this.splitMapSetting.Panel2.Controls.Add(this.btnFindLoc);
            this.splitMapSetting.Panel2.Controls.Add(this.cbMapMode);
            this.splitMapSetting.Panel2.Controls.Add(this.labelLang);
            this.splitMapSetting.Panel2.Controls.Add(this.tbLatitude);
            this.splitMapSetting.Panel2.Controls.Add(this.labelLat);
            this.splitMapSetting.Panel2.Controls.Add(this.tbLongitude);
            this.splitMapSetting.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitMapSetting.Size = new System.Drawing.Size(232, 106);
            this.splitMapSetting.SplitterDistance = 25;
            this.splitMapSetting.TabIndex = 0;
            // 
            // MapsSetting
            // 
            this.MapsSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.MapsSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapsSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapsSetting.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.MapsSetting.ForeColor = System.Drawing.Color.White;
            this.MapsSetting.Location = new System.Drawing.Point(0, 0);
            this.MapsSetting.Name = "MapsSetting";
            this.MapsSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MapsSetting.Size = new System.Drawing.Size(232, 25);
            this.MapsSetting.TabIndex = 7;
            this.MapsSetting.Text = "Maps";
            this.MapsSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFindPlane
            // 
            this.btnFindPlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFindPlane.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Btn_Search_Plane_490;
            this.btnFindPlane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindPlane.FlatAppearance.BorderSize = 0;
            this.btnFindPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.btnFindPlane.Location = new System.Drawing.Point(193, 35);
            this.btnFindPlane.Name = "btnFindPlane";
            this.btnFindPlane.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFindPlane.Size = new System.Drawing.Size(35, 35);
            this.btnFindPlane.TabIndex = 13;
            this.btnFindPlane.UseVisualStyleBackColor = false;
            // 
            // labelMapMode
            // 
            this.labelMapMode.AutoSize = true;
            this.labelMapMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMapMode.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelMapMode.ForeColor = System.Drawing.Color.Snow;
            this.labelMapMode.Location = new System.Drawing.Point(20, 9);
            this.labelMapMode.Name = "labelMapMode";
            this.labelMapMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMapMode.Size = new System.Drawing.Size(74, 15);
            this.labelMapMode.TabIndex = 12;
            this.labelMapMode.Text = "Map Mode :";
            // 
            // btnFindLoc
            // 
            this.btnFindLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFindLoc.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Btn_Search_Location_490;
            this.btnFindLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindLoc.FlatAppearance.BorderSize = 0;
            this.btnFindLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.btnFindLoc.Location = new System.Drawing.Point(152, 35);
            this.btnFindLoc.Name = "btnFindLoc";
            this.btnFindLoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFindLoc.Size = new System.Drawing.Size(35, 35);
            this.btnFindLoc.TabIndex = 5;
            this.btnFindLoc.UseVisualStyleBackColor = false;
            this.btnFindLoc.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cbMapMode
            // 
            this.cbMapMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMapMode.FormattingEnabled = true;
            this.cbMapMode.Location = new System.Drawing.Point(98, 8);
            this.cbMapMode.Name = "cbMapMode";
            this.cbMapMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbMapMode.Size = new System.Drawing.Size(105, 21);
            this.cbMapMode.TabIndex = 0;
            this.cbMapMode.SelectedIndexChanged += new System.EventHandler(this.cbMapMode_SelectedIndexChanged);
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLang.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelLang.ForeColor = System.Drawing.Color.Snow;
            this.labelLang.Location = new System.Drawing.Point(4, 56);
            this.labelLang.Name = "labelLang";
            this.labelLang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLang.Size = new System.Drawing.Size(42, 15);
            this.labelLang.TabIndex = 4;
            this.labelLang.Text = "Lang :";
            this.labelLang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLatitude
            // 
            this.tbLatitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLatitude.Location = new System.Drawing.Point(54, 36);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLatitude.Size = new System.Drawing.Size(90, 13);
            this.tbLatitude.TabIndex = 1;
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLat.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelLat.ForeColor = System.Drawing.Color.Snow;
            this.labelLat.Location = new System.Drawing.Point(4, 35);
            this.labelLat.Name = "labelLat";
            this.labelLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLat.Size = new System.Drawing.Size(32, 15);
            this.labelLat.TabIndex = 3;
            this.labelLat.Text = "Lat :";
            this.labelLat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLongitude
            // 
            this.tbLongitude.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLongitude.Location = new System.Drawing.Point(55, 57);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLongitude.Size = new System.Drawing.Size(90, 13);
            this.tbLongitude.TabIndex = 2;
            // 
            // MapScaler
            // 
            this.MapScaler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapScaler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MapScaler.LargeChange = 1;
            this.MapScaler.Location = new System.Drawing.Point(1280, 187);
            this.MapScaler.Maximum = 20;
            this.MapScaler.Minimum = 2;
            this.MapScaler.Name = "MapScaler";
            this.MapScaler.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MapScaler.Size = new System.Drawing.Size(45, 400);
            this.MapScaler.TabIndex = 1;
            this.MapScaler.Value = 2;
            this.MapScaler.ValueChanged += new System.EventHandler(this.MapScaler_ValueChanged);
            // 
            // MouseMapLatLangRaw
            // 
            this.MouseMapLatLangRaw.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MouseMapLatLangRaw.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.MouseMapLatLangRaw.ForeColor = System.Drawing.Color.White;
            this.MouseMapLatLangRaw.Location = new System.Drawing.Point(2, 4);
            this.MouseMapLatLangRaw.Name = "MouseMapLatLangRaw";
            this.MouseMapLatLangRaw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MouseMapLatLangRaw.Size = new System.Drawing.Size(342, 13);
            this.MouseMapLatLangRaw.TabIndex = 0;
            this.MouseMapLatLangRaw.Text = "Lat=000.000000000000, Lang=000.000000000000;";
            this.MouseMapLatLangRaw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.gMap.Size = new System.Drawing.Size(1334, 670);
            this.gMap.TabIndex = 1;
            this.gMap.Zoom = 0D;
            this.gMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMap_OnMapZoomChanged);
            this.gMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseClick);
            this.gMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseDown);
            this.gMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseMove);
            // 
            // PanelDataBar
            // 
            this.PanelDataBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelDataBar.Controls.Add(this.MouseMapLatLangRaw);
            this.PanelDataBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDataBar.Location = new System.Drawing.Point(0, 670);
            this.PanelDataBar.Name = "PanelDataBar";
            this.PanelDataBar.Size = new System.Drawing.Size(1334, 20);
            this.PanelDataBar.TabIndex = 4;
            // 
            // PanelMap
            // 
            this.PanelMap.Controls.Add(this.panelRuler);
            this.PanelMap.Controls.Add(this.MapsSettingPanel);
            this.PanelMap.Controls.Add(this.panelDrawMarker);
            this.PanelMap.Controls.Add(this.MapScaler);
            this.PanelMap.Controls.Add(this.gMap);
            this.PanelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMap.Location = new System.Drawing.Point(0, 0);
            this.PanelMap.Name = "PanelMap";
            this.PanelMap.Size = new System.Drawing.Size(1334, 670);
            this.PanelMap.TabIndex = 5;
            // 
            // panelRuler
            // 
            this.panelRuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelRuler.BackColor = System.Drawing.SystemColors.Control;
            this.panelRuler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRuler.Controls.Add(this.btnMapRuler);
            this.panelRuler.Location = new System.Drawing.Point(10, 612);
            this.panelRuler.Name = "panelRuler";
            this.panelRuler.Padding = new System.Windows.Forms.Padding(2);
            this.panelRuler.Size = new System.Drawing.Size(144, 41);
            this.panelRuler.TabIndex = 4;
            // 
            // btnMapRuler
            // 
            this.btnMapRuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMapRuler.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.BtnRulerDisactive_490;
            this.btnMapRuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMapRuler.FlatAppearance.BorderSize = 0;
            this.btnMapRuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapRuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMapRuler.ForeColor = System.Drawing.Color.White;
            this.btnMapRuler.Location = new System.Drawing.Point(2, 2);
            this.btnMapRuler.Name = "btnMapRuler";
            this.btnMapRuler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMapRuler.Size = new System.Drawing.Size(138, 35);
            this.btnMapRuler.TabIndex = 12;
            this.btnMapRuler.UseVisualStyleBackColor = false;
            this.btnMapRuler.Click += new System.EventHandler(this.btnMapRuler_Click);
            // 
            // PlanPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 690);
            this.Controls.Add(this.PanelMap);
            this.Controls.Add(this.PanelDataBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "PlanPanel";
            this.Text = "PlanPanel";
            this.Resize += new System.EventHandler(this.PlanPanel_Resize);
            this.panelDrawMarker.ResumeLayout(false);
            this.splitDrawMaker.Panel1.ResumeLayout(false);
            this.splitDrawMaker.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDrawMaker)).EndInit();
            this.splitDrawMaker.ResumeLayout(false);
            this.MapsSettingPanel.ResumeLayout(false);
            this.splitMapSetting.Panel1.ResumeLayout(false);
            this.splitMapSetting.Panel2.ResumeLayout(false);
            this.splitMapSetting.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMapSetting)).EndInit();
            this.splitMapSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapScaler)).EndInit();
            this.PanelDataBar.ResumeLayout(false);
            this.PanelMap.ResumeLayout(false);
            this.PanelMap.PerformLayout();
            this.panelRuler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelDrawMarker;
        private System.Windows.Forms.SplitContainer splitDrawMaker;
        private System.Windows.Forms.Label labelDrawMarker;
        private System.Windows.Forms.Button btnResetP;
        private System.Windows.Forms.Button btnDrawWP;
        private System.Windows.Forms.Button btnResetDC;
        private System.Windows.Forms.Button btnDrawFZ;
        private System.Windows.Forms.Button btnResetDZ;
        private System.Windows.Forms.Button btnDrawDZ;
        private System.Windows.Forms.Button btnResetW;
        private System.Windows.Forms.Button btnDPointCand;
        private System.Windows.Forms.Button btnPole;
        private System.Windows.Forms.Panel MapsSettingPanel;
        private System.Windows.Forms.SplitContainer splitMapSetting;
        private System.Windows.Forms.Label MapsSetting;
        private System.Windows.Forms.Label labelMapMode;
        private System.Windows.Forms.Button btnFindLoc;
        private System.Windows.Forms.ComboBox cbMapMode;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.TrackBar MapScaler;
        private System.Windows.Forms.Label MouseMapLatLangRaw;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Panel PanelDataBar;
        private System.Windows.Forms.Panel PanelMap;
        private System.Windows.Forms.Button btnFindPlane;
        private System.Windows.Forms.Panel panelRuler;
        private System.Windows.Forms.Button btnMapRuler;
    }
}