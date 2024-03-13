
namespace SkyDiver_GCS
{
    partial class MainWindow
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.ampereMeter = new System.Windows.Forms.Label();
            this.voltMeter = new System.Windows.Forms.Label();
            this.stateOfChargeIcon = new System.Windows.Forms.PictureBox();
            this.stateOfCharge = new System.Windows.Forms.Label();
            this.btnEngine = new System.Windows.Forms.Button();
            this.engineStatus = new System.Windows.Forms.Label();
            this.failsafe = new System.Windows.Forms.Label();
            this.flightMode = new System.Windows.Forms.Label();
            this.panelSerialCon = new System.Windows.Forms.Panel();
            this.btnSerialCon = new System.Windows.Forms.Button();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.panelToolStrip = new System.Windows.Forms.Panel();
            this.mainTool = new System.Windows.Forms.ToolStrip();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnPlan = new System.Windows.Forms.ToolStripButton();
            this.btnConfig = new System.Windows.Forms.ToolStripButton();
            this.btnGCSSetting = new System.Windows.Forms.ToolStripButton();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.banner1 = new System.Windows.Forms.PictureBox();
            this.logo2 = new System.Windows.Forms.PictureBox();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateOfChargeIcon)).BeginInit();
            this.panelSerialCon.SuspendLayout();
            this.panelToolStrip.SuspendLayout();
            this.mainTool.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelHeader.Controls.Add(this.panelStatus);
            this.panelHeader.Controls.Add(this.panelSerialCon);
            this.panelHeader.Controls.Add(this.panelToolStrip);
            this.panelHeader.Controls.Add(this.panelPicture);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.MaximumSize = new System.Drawing.Size(1920, 52);
            this.panelHeader.MinimumSize = new System.Drawing.Size(1024, 52);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1350, 52);
            this.panelHeader.TabIndex = 0;
            // 
            // panelStatus
            // 
            this.panelStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelStatus.Controls.Add(this.ampereMeter);
            this.panelStatus.Controls.Add(this.voltMeter);
            this.panelStatus.Controls.Add(this.stateOfChargeIcon);
            this.panelStatus.Controls.Add(this.stateOfCharge);
            this.panelStatus.Controls.Add(this.btnEngine);
            this.panelStatus.Controls.Add(this.engineStatus);
            this.panelStatus.Controls.Add(this.failsafe);
            this.panelStatus.Controls.Add(this.flightMode);
            this.panelStatus.Location = new System.Drawing.Point(446, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(472, 52);
            this.panelStatus.TabIndex = 4;
            // 
            // ampereMeter
            // 
            this.ampereMeter.AutoSize = true;
            this.ampereMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ampereMeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ampereMeter.Location = new System.Drawing.Point(407, 26);
            this.ampereMeter.Name = "ampereMeter";
            this.ampereMeter.Size = new System.Drawing.Size(51, 15);
            this.ampereMeter.TabIndex = 8;
            this.ampereMeter.Text = "00.00A";
            this.ampereMeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // voltMeter
            // 
            this.voltMeter.AutoSize = true;
            this.voltMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.voltMeter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.voltMeter.Location = new System.Drawing.Point(407, 9);
            this.voltMeter.Name = "voltMeter";
            this.voltMeter.Size = new System.Drawing.Size(51, 15);
            this.voltMeter.TabIndex = 7;
            this.voltMeter.Text = "00.00V";
            this.voltMeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stateOfChargeIcon
            // 
            this.stateOfChargeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateOfChargeIcon.Image = global::SkyDiver_GCS.Properties.Resources.Battery_Full_400;
            this.stateOfChargeIcon.Location = new System.Drawing.Point(384, 10);
            this.stateOfChargeIcon.MaximumSize = new System.Drawing.Size(20, 30);
            this.stateOfChargeIcon.MinimumSize = new System.Drawing.Size(20, 30);
            this.stateOfChargeIcon.Name = "stateOfChargeIcon";
            this.stateOfChargeIcon.Size = new System.Drawing.Size(20, 30);
            this.stateOfChargeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stateOfChargeIcon.TabIndex = 6;
            this.stateOfChargeIcon.TabStop = false;
            // 
            // stateOfCharge
            // 
            this.stateOfCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.stateOfCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.stateOfCharge.Location = new System.Drawing.Point(326, 18);
            this.stateOfCharge.Name = "stateOfCharge";
            this.stateOfCharge.Size = new System.Drawing.Size(55, 15);
            this.stateOfCharge.TabIndex = 5;
            this.stateOfCharge.Text = "0.0%";
            this.stateOfCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEngine
            // 
            this.btnEngine.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Engine_Off_490;
            this.btnEngine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEngine.FlatAppearance.BorderSize = 0;
            this.btnEngine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEngine.ForeColor = System.Drawing.Color.White;
            this.btnEngine.Location = new System.Drawing.Point(180, 5);
            this.btnEngine.Name = "btnEngine";
            this.btnEngine.Size = new System.Drawing.Size(40, 40);
            this.btnEngine.TabIndex = 4;
            this.btnEngine.UseVisualStyleBackColor = true;
            this.btnEngine.Click += new System.EventHandler(this.btnEngine_Click);
            // 
            // engineStatus
            // 
            this.engineStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.engineStatus.Location = new System.Drawing.Point(224, 18);
            this.engineStatus.Name = "engineStatus";
            this.engineStatus.Size = new System.Drawing.Size(100, 15);
            this.engineStatus.TabIndex = 3;
            this.engineStatus.Text = "ENGINE OFF";
            this.engineStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // failsafe
            // 
            this.failsafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failsafe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.failsafe.Location = new System.Drawing.Point(4, 9);
            this.failsafe.Name = "failsafe";
            this.failsafe.Size = new System.Drawing.Size(174, 15);
            this.failsafe.TabIndex = 2;
            this.failsafe.Text = "UNINITIALIZED";
            this.failsafe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flightMode
            // 
            this.flightMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.flightMode.Location = new System.Drawing.Point(78, 26);
            this.flightMode.Name = "flightMode";
            this.flightMode.Size = new System.Drawing.Size(100, 15);
            this.flightMode.TabIndex = 1;
            this.flightMode.Text = "UNKNOWN";
            this.flightMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelSerialCon
            // 
            this.panelSerialCon.Controls.Add(this.btnSerialCon);
            this.panelSerialCon.Controls.Add(this.cbBaudrate);
            this.panelSerialCon.Controls.Add(this.cbSerialPort);
            this.panelSerialCon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSerialCon.Location = new System.Drawing.Point(1142, 0);
            this.panelSerialCon.Name = "panelSerialCon";
            this.panelSerialCon.Size = new System.Drawing.Size(208, 52);
            this.panelSerialCon.TabIndex = 3;
            // 
            // btnSerialCon
            // 
            this.btnSerialCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSerialCon.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.BtnDisconnectSerial_200;
            this.btnSerialCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialCon.FlatAppearance.BorderSize = 0;
            this.btnSerialCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialCon.Font = new System.Drawing.Font("Arial Black", 5F, System.Drawing.FontStyle.Bold);
            this.btnSerialCon.ForeColor = System.Drawing.Color.White;
            this.btnSerialCon.Location = new System.Drawing.Point(120, 3);
            this.btnSerialCon.MaximumSize = new System.Drawing.Size(86, 45);
            this.btnSerialCon.MinimumSize = new System.Drawing.Size(82, 42);
            this.btnSerialCon.Name = "btnSerialCon";
            this.btnSerialCon.Size = new System.Drawing.Size(86, 45);
            this.btnSerialCon.TabIndex = 2;
            this.btnSerialCon.Text = "DISCONNECTED";
            this.btnSerialCon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSerialCon.UseVisualStyleBackColor = true;
            this.btnSerialCon.Click += new System.EventHandler(this.btnSerialCon_Click);
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudrate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.ItemHeight = 13;
            this.cbBaudrate.Location = new System.Drawing.Point(14, 26);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(100, 21);
            this.cbBaudrate.TabIndex = 1;
            this.cbBaudrate.DropDown += new System.EventHandler(this.cbBaudrate_DropDown);
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.ItemHeight = 13;
            this.cbSerialPort.Location = new System.Drawing.Point(14, 3);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(100, 21);
            this.cbSerialPort.TabIndex = 0;
            this.cbSerialPort.DropDown += new System.EventHandler(this.cbSerialPort_DropDown);
            // 
            // panelToolStrip
            // 
            this.panelToolStrip.Controls.Add(this.mainTool);
            this.panelToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelToolStrip.Location = new System.Drawing.Point(256, 0);
            this.panelToolStrip.Name = "panelToolStrip";
            this.panelToolStrip.Size = new System.Drawing.Size(190, 52);
            this.panelToolStrip.TabIndex = 2;
            // 
            // mainTool
            // 
            this.mainTool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.mainTool.Dock = System.Windows.Forms.DockStyle.None;
            this.mainTool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.btnPlan,
            this.btnConfig,
            this.btnGCSSetting});
            this.mainTool.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainTool.Location = new System.Drawing.Point(0, 5);
            this.mainTool.MaximumSize = new System.Drawing.Size(171, 45);
            this.mainTool.MinimumSize = new System.Drawing.Size(171, 45);
            this.mainTool.Name = "mainTool";
            this.mainTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainTool.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTool.Size = new System.Drawing.Size(171, 45);
            this.mainTool.TabIndex = 1;
            this.mainTool.Text = "tool";
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = false;
            this.btnHome.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Icon_Btn_Home_490;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.btnHome.Size = new System.Drawing.Size(42, 42);
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.AutoSize = false;
            this.btnPlan.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Icon_Btn_Plan_490;
            this.btnPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(42, 42);
            this.btnPlan.Text = "Plan";
            this.btnPlan.Click += new System.EventHandler(this.BtnPlan_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.AutoSize = false;
            this.btnConfig.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Icon_Btn_ConfigTuning_490;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(42, 42);
            this.btnConfig.Text = "Config/Tuning Plane";
            this.btnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // btnGCSSetting
            // 
            this.btnGCSSetting.AutoSize = false;
            this.btnGCSSetting.BackgroundImage = global::SkyDiver_GCS.Properties.Resources.Icon_Btn_GCS_Setting_490;
            this.btnGCSSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGCSSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGCSSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGCSSetting.Name = "btnGCSSetting";
            this.btnGCSSetting.Size = new System.Drawing.Size(42, 42);
            this.btnGCSSetting.Text = "GCS Setting";
            this.btnGCSSetting.Click += new System.EventHandler(this.BtnGCSSetting_Click);
            // 
            // panelPicture
            // 
            this.panelPicture.Controls.Add(this.banner1);
            this.panelPicture.Controls.Add(this.logo2);
            this.panelPicture.Controls.Add(this.logo1);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(256, 52);
            this.panelPicture.TabIndex = 0;
            // 
            // banner1
            // 
            this.banner1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.banner1.Image = global::SkyDiver_GCS.Properties.Resources.Cakra_Dirga_Logo_490;
            this.banner1.Location = new System.Drawing.Point(103, 4);
            this.banner1.MaximumSize = new System.Drawing.Size(139, 42);
            this.banner1.MinimumSize = new System.Drawing.Size(139, 42);
            this.banner1.Name = "banner1";
            this.banner1.Size = new System.Drawing.Size(139, 42);
            this.banner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.banner1.TabIndex = 2;
            this.banner1.TabStop = false;
            // 
            // logo2
            // 
            this.logo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo2.Image = global::SkyDiver_GCS.Properties.Resources.Tubitak_490;
            this.logo2.Location = new System.Drawing.Point(53, 4);
            this.logo2.MaximumSize = new System.Drawing.Size(42, 42);
            this.logo2.MinimumSize = new System.Drawing.Size(42, 42);
            this.logo2.Name = "logo2";
            this.logo2.Size = new System.Drawing.Size(42, 42);
            this.logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo2.TabIndex = 1;
            this.logo2.TabStop = false;
            // 
            // logo1
            // 
            this.logo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo1.Image = global::SkyDiver_GCS.Properties.Resources.Logo_UM_490;
            this.logo1.Location = new System.Drawing.Point(7, 4);
            this.logo1.MaximumSize = new System.Drawing.Size(42, 42);
            this.logo1.MinimumSize = new System.Drawing.Size(42, 42);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(42, 42);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo1.TabIndex = 0;
            this.logo1.TabStop = false;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyPanel.Location = new System.Drawing.Point(0, 50);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1350, 679);
            this.bodyPanel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.panelHeader);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainWindow";
            this.Text = "SkyDiver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.panelHeader.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateOfChargeIcon)).EndInit();
            this.panelSerialCon.ResumeLayout(false);
            this.panelToolStrip.ResumeLayout(false);
            this.panelToolStrip.PerformLayout();
            this.mainTool.ResumeLayout(false);
            this.mainTool.PerformLayout();
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.banner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.ToolStrip mainTool;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton btnPlan;
        private System.Windows.Forms.ToolStripButton btnConfig;
        private System.Windows.Forms.ToolStripButton btnGCSSetting;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox banner1;
        private System.Windows.Forms.PictureBox logo2;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.Panel panelToolStrip;
        private System.Windows.Forms.Panel panelSerialCon;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.Button btnSerialCon;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label flightMode;
        private System.Windows.Forms.Label failsafe;
        private System.Windows.Forms.Label engineStatus;
        private System.Windows.Forms.Button btnEngine;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label ampereMeter;
        private System.Windows.Forms.Label voltMeter;
        private System.Windows.Forms.PictureBox stateOfChargeIcon;
        private System.Windows.Forms.Label stateOfCharge;
        private System.Windows.Forms.Timer timer1;
    }
}

