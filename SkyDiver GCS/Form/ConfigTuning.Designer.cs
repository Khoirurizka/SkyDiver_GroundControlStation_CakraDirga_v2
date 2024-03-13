
namespace SkyDiver_GCS
{
    partial class ConfigTuning
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPayloadBayConfig = new System.Windows.Forms.Panel();
            this.splitPayloadBaysConfig = new System.Windows.Forms.SplitContainer();
            this.labelPayloadBay = new System.Windows.Forms.Label();
            this.labelToggle = new System.Windows.Forms.Label();
            this.btnSwitchPB2 = new System.Windows.Forms.Button();
            this.btnSwitchPB1 = new System.Windows.Forms.Button();
            this.cBPayloadBay2Servo = new System.Windows.Forms.ComboBox();
            this.labelThreshold = new System.Windows.Forms.Label();
            this.payload2ThresholdVal = new System.Windows.Forms.TextBox();
            this.payload1ThresholdVal = new System.Windows.Forms.TextBox();
            this.labelServoId = new System.Windows.Forms.Label();
            this.labelPayloadBay2Servo = new System.Windows.Forms.Label();
            this.labelPayloadBay1Servo = new System.Windows.Forms.Label();
            this.cBPayloadBay1Servo = new System.Windows.Forms.ComboBox();
            this.PayloadBayConfigSet = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelCalibration = new System.Windows.Forms.Panel();
            this.splitCalibration = new System.Windows.Forms.SplitContainer();
            this.labelCalibration = new System.Windows.Forms.Label();
            this.StatusLog = new System.Windows.Forms.Label();
            this.btnCalibrateLevel = new System.Windows.Forms.Button();
            this.btnCalibrateAccel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelPayloadBayConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPayloadBaysConfig)).BeginInit();
            this.splitPayloadBaysConfig.Panel1.SuspendLayout();
            this.splitPayloadBaysConfig.Panel2.SuspendLayout();
            this.splitPayloadBaysConfig.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelCalibration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCalibration)).BeginInit();
            this.splitCalibration.Panel1.SuspendLayout();
            this.splitCalibration.Panel2.SuspendLayout();
            this.splitCalibration.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelPayloadBayConfig);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 651);
            this.panel1.TabIndex = 0;
            // 
            // panelPayloadBayConfig
            // 
            this.panelPayloadBayConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelPayloadBayConfig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPayloadBayConfig.Controls.Add(this.splitPayloadBaysConfig);
            this.panelPayloadBayConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPayloadBayConfig.Location = new System.Drawing.Point(0, 0);
            this.panelPayloadBayConfig.Name = "panelPayloadBayConfig";
            this.panelPayloadBayConfig.Size = new System.Drawing.Size(308, 151);
            this.panelPayloadBayConfig.TabIndex = 2;
            // 
            // splitPayloadBaysConfig
            // 
            this.splitPayloadBaysConfig.BackColor = System.Drawing.Color.White;
            this.splitPayloadBaysConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPayloadBaysConfig.IsSplitterFixed = true;
            this.splitPayloadBaysConfig.Location = new System.Drawing.Point(0, 0);
            this.splitPayloadBaysConfig.Name = "splitPayloadBaysConfig";
            this.splitPayloadBaysConfig.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPayloadBaysConfig.Panel1
            // 
            this.splitPayloadBaysConfig.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitPayloadBaysConfig.Panel1.Controls.Add(this.labelPayloadBay);
            // 
            // splitPayloadBaysConfig.Panel2
            // 
            this.splitPayloadBaysConfig.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.labelToggle);
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.btnSwitchPB2);
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.btnSwitchPB1);
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.cBPayloadBay2Servo);
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.labelThreshold);
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.payload2ThresholdVal);
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.payload1ThresholdVal);
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.labelServoId);
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.labelPayloadBay2Servo);
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.labelPayloadBay1Servo);
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.cBPayloadBay1Servo);
            this.splitPayloadBaysConfig.Panel2.Controls.Add(this.PayloadBayConfigSet);
            this.splitPayloadBaysConfig.Size = new System.Drawing.Size(304, 147);
            this.splitPayloadBaysConfig.SplitterDistance = 25;
            this.splitPayloadBaysConfig.TabIndex = 0;
            // 
            // labelPayloadBay
            // 
            this.labelPayloadBay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.labelPayloadBay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPayloadBay.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelPayloadBay.ForeColor = System.Drawing.Color.White;
            this.labelPayloadBay.Location = new System.Drawing.Point(0, 0);
            this.labelPayloadBay.Name = "labelPayloadBay";
            this.labelPayloadBay.Size = new System.Drawing.Size(304, 25);
            this.labelPayloadBay.TabIndex = 2;
            this.labelPayloadBay.Text = "Payload Bay";
            this.labelPayloadBay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelToggle
            // 
            this.labelToggle.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelToggle.ForeColor = System.Drawing.Color.White;
            this.labelToggle.Location = new System.Drawing.Point(238, 2);
            this.labelToggle.Name = "labelToggle";
            this.labelToggle.Size = new System.Drawing.Size(60, 21);
            this.labelToggle.TabIndex = 15;
            this.labelToggle.Text = "Toggle";
            this.labelToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSwitchPB2
            // 
            this.btnSwitchPB2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSwitchPB2.Location = new System.Drawing.Point(236, 53);
            this.btnSwitchPB2.Name = "btnSwitchPB2";
            this.btnSwitchPB2.Size = new System.Drawing.Size(62, 23);
            this.btnSwitchPB2.TabIndex = 14;
            this.btnSwitchPB2.Text = "Switch";
            this.btnSwitchPB2.UseVisualStyleBackColor = true;
            this.btnSwitchPB2.Click += new System.EventHandler(this.btnSwitchPB2_Click);
            // 
            // btnSwitchPB1
            // 
            this.btnSwitchPB1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSwitchPB1.Location = new System.Drawing.Point(236, 26);
            this.btnSwitchPB1.Name = "btnSwitchPB1";
            this.btnSwitchPB1.Size = new System.Drawing.Size(62, 23);
            this.btnSwitchPB1.TabIndex = 13;
            this.btnSwitchPB1.Text = "Switch";
            this.btnSwitchPB1.UseVisualStyleBackColor = true;
            this.btnSwitchPB1.Click += new System.EventHandler(this.btnSwitchPB1_Click);
            // 
            // cBPayloadBay2Servo
            // 
            this.cBPayloadBay2Servo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBPayloadBay2Servo.FormattingEnabled = true;
            this.cBPayloadBay2Servo.Location = new System.Drawing.Point(106, 53);
            this.cBPayloadBay2Servo.Name = "cBPayloadBay2Servo";
            this.cBPayloadBay2Servo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBPayloadBay2Servo.Size = new System.Drawing.Size(45, 21);
            this.cBPayloadBay2Servo.TabIndex = 12;
            // 
            // labelThreshold
            // 
            this.labelThreshold.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelThreshold.ForeColor = System.Drawing.Color.White;
            this.labelThreshold.Location = new System.Drawing.Point(157, 2);
            this.labelThreshold.Name = "labelThreshold";
            this.labelThreshold.Size = new System.Drawing.Size(75, 21);
            this.labelThreshold.TabIndex = 11;
            this.labelThreshold.Text = "Threshold";
            this.labelThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payload2ThresholdVal
            // 
            this.payload2ThresholdVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payload2ThresholdVal.Location = new System.Drawing.Point(157, 55);
            this.payload2ThresholdVal.Name = "payload2ThresholdVal";
            this.payload2ThresholdVal.Size = new System.Drawing.Size(75, 20);
            this.payload2ThresholdVal.TabIndex = 10;
            this.payload2ThresholdVal.Text = "1300";
            this.payload2ThresholdVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // payload1ThresholdVal
            // 
            this.payload1ThresholdVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.payload1ThresholdVal.Location = new System.Drawing.Point(157, 28);
            this.payload1ThresholdVal.Name = "payload1ThresholdVal";
            this.payload1ThresholdVal.Size = new System.Drawing.Size(75, 20);
            this.payload1ThresholdVal.TabIndex = 9;
            this.payload1ThresholdVal.Text = "1300";
            this.payload1ThresholdVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelServoId
            // 
            this.labelServoId.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelServoId.ForeColor = System.Drawing.Color.White;
            this.labelServoId.Location = new System.Drawing.Point(103, 2);
            this.labelServoId.Name = "labelServoId";
            this.labelServoId.Size = new System.Drawing.Size(48, 21);
            this.labelServoId.TabIndex = 8;
            this.labelServoId.Text = "Servo";
            this.labelServoId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPayloadBay2Servo
            // 
            this.labelPayloadBay2Servo.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelPayloadBay2Servo.ForeColor = System.Drawing.Color.White;
            this.labelPayloadBay2Servo.Location = new System.Drawing.Point(9, 53);
            this.labelPayloadBay2Servo.Name = "labelPayloadBay2Servo";
            this.labelPayloadBay2Servo.Size = new System.Drawing.Size(93, 21);
            this.labelPayloadBay2Servo.TabIndex = 7;
            this.labelPayloadBay2Servo.Text = "Payload Bay 2 :";
            this.labelPayloadBay2Servo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPayloadBay1Servo
            // 
            this.labelPayloadBay1Servo.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelPayloadBay1Servo.ForeColor = System.Drawing.Color.White;
            this.labelPayloadBay1Servo.Location = new System.Drawing.Point(9, 26);
            this.labelPayloadBay1Servo.Name = "labelPayloadBay1Servo";
            this.labelPayloadBay1Servo.Size = new System.Drawing.Size(93, 21);
            this.labelPayloadBay1Servo.TabIndex = 5;
            this.labelPayloadBay1Servo.Text = "Payload Bay 1 :";
            this.labelPayloadBay1Servo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cBPayloadBay1Servo
            // 
            this.cBPayloadBay1Servo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBPayloadBay1Servo.FormattingEnabled = true;
            this.cBPayloadBay1Servo.Location = new System.Drawing.Point(106, 26);
            this.cBPayloadBay1Servo.Name = "cBPayloadBay1Servo";
            this.cBPayloadBay1Servo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBPayloadBay1Servo.Size = new System.Drawing.Size(45, 21);
            this.cBPayloadBay1Servo.TabIndex = 3;
            // 
            // PayloadBayConfigSet
            // 
            this.PayloadBayConfigSet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PayloadBayConfigSet.Location = new System.Drawing.Point(76, 80);
            this.PayloadBayConfigSet.Name = "PayloadBayConfigSet";
            this.PayloadBayConfigSet.Size = new System.Drawing.Size(75, 23);
            this.PayloadBayConfigSet.TabIndex = 1;
            this.PayloadBayConfigSet.Text = "Set HUD";
            this.PayloadBayConfigSet.UseVisualStyleBackColor = true;
            this.PayloadBayConfigSet.Click += new System.EventHandler(this.PayloadBayConfigSet_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelCalibration);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(308, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 651);
            this.panel3.TabIndex = 1;
            // 
            // panelCalibration
            // 
            this.panelCalibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelCalibration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCalibration.Controls.Add(this.splitCalibration);
            this.panelCalibration.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCalibration.Location = new System.Drawing.Point(0, 0);
            this.panelCalibration.Name = "panelCalibration";
            this.panelCalibration.Size = new System.Drawing.Size(152, 161);
            this.panelCalibration.TabIndex = 2;
            // 
            // splitCalibration
            // 
            this.splitCalibration.BackColor = System.Drawing.Color.White;
            this.splitCalibration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCalibration.IsSplitterFixed = true;
            this.splitCalibration.Location = new System.Drawing.Point(0, 0);
            this.splitCalibration.Name = "splitCalibration";
            this.splitCalibration.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCalibration.Panel1
            // 
            this.splitCalibration.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitCalibration.Panel1.Controls.Add(this.labelCalibration);
            // 
            // splitCalibration.Panel2
            // 
            this.splitCalibration.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitCalibration.Panel2.Controls.Add(this.StatusLog);
            this.splitCalibration.Panel2.Controls.Add(this.btnCalibrateLevel);
            this.splitCalibration.Panel2.Controls.Add(this.btnCalibrateAccel);
            this.splitCalibration.Size = new System.Drawing.Size(148, 157);
            this.splitCalibration.SplitterDistance = 25;
            this.splitCalibration.TabIndex = 0;
            // 
            // labelCalibration
            // 
            this.labelCalibration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.labelCalibration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCalibration.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelCalibration.ForeColor = System.Drawing.Color.White;
            this.labelCalibration.Location = new System.Drawing.Point(0, 0);
            this.labelCalibration.Name = "labelCalibration";
            this.labelCalibration.Size = new System.Drawing.Size(148, 25);
            this.labelCalibration.TabIndex = 2;
            this.labelCalibration.Text = "Calibration";
            this.labelCalibration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLog
            // 
            this.StatusLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.StatusLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusLog.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.StatusLog.ForeColor = System.Drawing.Color.White;
            this.StatusLog.Location = new System.Drawing.Point(0, 77);
            this.StatusLog.Name = "StatusLog";
            this.StatusLog.Size = new System.Drawing.Size(148, 51);
            this.StatusLog.TabIndex = 3;
            this.StatusLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalibrateLevel
            // 
            this.btnCalibrateLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalibrateLevel.Location = new System.Drawing.Point(16, 39);
            this.btnCalibrateLevel.Name = "btnCalibrateLevel";
            this.btnCalibrateLevel.Size = new System.Drawing.Size(113, 23);
            this.btnCalibrateLevel.TabIndex = 2;
            this.btnCalibrateLevel.Text = "Calibrate Level";
            this.btnCalibrateLevel.UseVisualStyleBackColor = true;
            this.btnCalibrateLevel.Click += new System.EventHandler(this.btnCalibrateLevel_Click);
            // 
            // btnCalibrateAccel
            // 
            this.btnCalibrateAccel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalibrateAccel.Location = new System.Drawing.Point(16, 11);
            this.btnCalibrateAccel.Name = "btnCalibrateAccel";
            this.btnCalibrateAccel.Size = new System.Drawing.Size(113, 23);
            this.btnCalibrateAccel.TabIndex = 1;
            this.btnCalibrateAccel.Text = "Calibrate Accel";
            this.btnCalibrateAccel.UseVisualStyleBackColor = true;
            this.btnCalibrateAccel.Click += new System.EventHandler(this.btnCalibrateAccel_Click);
            // 
            // ConfigTuning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1318, 651);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "ConfigTuning";
            this.Text = "ConfigTuning";
            this.panel1.ResumeLayout(false);
            this.panelPayloadBayConfig.ResumeLayout(false);
            this.splitPayloadBaysConfig.Panel1.ResumeLayout(false);
            this.splitPayloadBaysConfig.Panel2.ResumeLayout(false);
            this.splitPayloadBaysConfig.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPayloadBaysConfig)).EndInit();
            this.splitPayloadBaysConfig.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelCalibration.ResumeLayout(false);
            this.splitCalibration.Panel1.ResumeLayout(false);
            this.splitCalibration.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCalibration)).EndInit();
            this.splitCalibration.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPayloadBayConfig;
        private System.Windows.Forms.SplitContainer splitPayloadBaysConfig;
        private System.Windows.Forms.Label labelPayloadBay;
        private System.Windows.Forms.Label labelToggle;
        private System.Windows.Forms.Button btnSwitchPB2;
        private System.Windows.Forms.Button btnSwitchPB1;
        private System.Windows.Forms.ComboBox cBPayloadBay2Servo;
        private System.Windows.Forms.Label labelThreshold;
        private System.Windows.Forms.TextBox payload2ThresholdVal;
        private System.Windows.Forms.TextBox payload1ThresholdVal;
        private System.Windows.Forms.Label labelServoId;
        private System.Windows.Forms.Label labelPayloadBay2Servo;
        private System.Windows.Forms.Label labelPayloadBay1Servo;
        private System.Windows.Forms.ComboBox cBPayloadBay1Servo;
        private System.Windows.Forms.Button PayloadBayConfigSet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelCalibration;
        private System.Windows.Forms.SplitContainer splitCalibration;
        private System.Windows.Forms.Label labelCalibration;
        private System.Windows.Forms.Button btnCalibrateLevel;
        private System.Windows.Forms.Button btnCalibrateAccel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label StatusLog;
    }
}