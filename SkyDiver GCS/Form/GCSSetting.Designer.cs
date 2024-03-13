
namespace SkyDiver_GCS
{
    partial class GCSSetting
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
            this.MavlinkTerminal = new System.Windows.Forms.RichTextBox();
            this.buttonConnectVideo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelVideoStream = new System.Windows.Forms.Panel();
            this.splitVideoStream = new System.Windows.Forms.SplitContainer();
            this.VideoStream = new System.Windows.Forms.Label();
            this.labelCamId = new System.Windows.Forms.Label();
            this.cbCamId = new System.Windows.Forms.ComboBox();
            this.labelRatio = new System.Windows.Forms.Label();
            this.cbStreamScreenRatio = new System.Windows.Forms.ComboBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBVideoSource = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelVideoStream.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitVideoStream)).BeginInit();
            this.splitVideoStream.Panel1.SuspendLayout();
            this.splitVideoStream.Panel2.SuspendLayout();
            this.splitVideoStream.SuspendLayout();
            this.SuspendLayout();
            // 
            // MavlinkTerminal
            // 
            this.MavlinkTerminal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MavlinkTerminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MavlinkTerminal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MavlinkTerminal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MavlinkTerminal.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.MavlinkTerminal.ForeColor = System.Drawing.SystemColors.Info;
            this.MavlinkTerminal.Location = new System.Drawing.Point(0, 615);
            this.MavlinkTerminal.Name = "MavlinkTerminal";
            this.MavlinkTerminal.Size = new System.Drawing.Size(1318, 36);
            this.MavlinkTerminal.TabIndex = 0;
            this.MavlinkTerminal.Text = "";
            // 
            // buttonConnectVideo
            // 
            this.buttonConnectVideo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConnectVideo.Location = new System.Drawing.Point(55, 89);
            this.buttonConnectVideo.Name = "buttonConnectVideo";
            this.buttonConnectVideo.Size = new System.Drawing.Size(75, 23);
            this.buttonConnectVideo.TabIndex = 1;
            this.buttonConnectVideo.Text = "Open";
            this.buttonConnectVideo.UseVisualStyleBackColor = true;
            this.buttonConnectVideo.Click += new System.EventHandler(this.buttonConnectVideo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.panelVideoStream);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(200, 615);
            this.panel1.TabIndex = 2;
            // 
            // panelVideoStream
            // 
            this.panelVideoStream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelVideoStream.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelVideoStream.Controls.Add(this.splitVideoStream);
            this.panelVideoStream.Location = new System.Drawing.Point(2, 2);
            this.panelVideoStream.Name = "panelVideoStream";
            this.panelVideoStream.Size = new System.Drawing.Size(196, 155);
            this.panelVideoStream.TabIndex = 0;
            // 
            // splitVideoStream
            // 
            this.splitVideoStream.BackColor = System.Drawing.Color.White;
            this.splitVideoStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitVideoStream.IsSplitterFixed = true;
            this.splitVideoStream.Location = new System.Drawing.Point(0, 0);
            this.splitVideoStream.Name = "splitVideoStream";
            this.splitVideoStream.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitVideoStream.Panel1
            // 
            this.splitVideoStream.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitVideoStream.Panel1.Controls.Add(this.VideoStream);
            // 
            // splitVideoStream.Panel2
            // 
            this.splitVideoStream.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.splitVideoStream.Panel2.Controls.Add(this.labelCamId);
            this.splitVideoStream.Panel2.Controls.Add(this.cbCamId);
            this.splitVideoStream.Panel2.Controls.Add(this.labelRatio);
            this.splitVideoStream.Panel2.Controls.Add(this.cbStreamScreenRatio);
            this.splitVideoStream.Panel2.Controls.Add(this.labelSource);
            this.splitVideoStream.Panel2.Controls.Add(this.label1);
            this.splitVideoStream.Panel2.Controls.Add(this.cBVideoSource);
            this.splitVideoStream.Panel2.Controls.Add(this.buttonConnectVideo);
            this.splitVideoStream.Size = new System.Drawing.Size(192, 151);
            this.splitVideoStream.SplitterDistance = 26;
            this.splitVideoStream.TabIndex = 0;
            // 
            // VideoStream
            // 
            this.VideoStream.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(43)))), ((int)(((byte)(70)))));
            this.VideoStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoStream.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.VideoStream.ForeColor = System.Drawing.Color.White;
            this.VideoStream.Location = new System.Drawing.Point(0, 0);
            this.VideoStream.Name = "VideoStream";
            this.VideoStream.Size = new System.Drawing.Size(192, 26);
            this.VideoStream.TabIndex = 2;
            this.VideoStream.Text = "Video Stream";
            this.VideoStream.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCamId
            // 
            this.labelCamId.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelCamId.ForeColor = System.Drawing.Color.White;
            this.labelCamId.Location = new System.Drawing.Point(9, 58);
            this.labelCamId.Name = "labelCamId";
            this.labelCamId.Size = new System.Drawing.Size(53, 21);
            this.labelCamId.TabIndex = 9;
            this.labelCamId.Text = "Cam   :";
            this.labelCamId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCamId
            // 
            this.cbCamId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCamId.FormattingEnabled = true;
            this.cbCamId.Location = new System.Drawing.Point(68, 58);
            this.cbCamId.Name = "cbCamId";
            this.cbCamId.Size = new System.Drawing.Size(115, 21);
            this.cbCamId.TabIndex = 8;
            this.cbCamId.DropDown += new System.EventHandler(this.cbCamId_DropDown);
            // 
            // labelRatio
            // 
            this.labelRatio.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelRatio.ForeColor = System.Drawing.Color.White;
            this.labelRatio.Location = new System.Drawing.Point(9, 33);
            this.labelRatio.Name = "labelRatio";
            this.labelRatio.Size = new System.Drawing.Size(53, 21);
            this.labelRatio.TabIndex = 7;
            this.labelRatio.Text = "Ratio   :";
            this.labelRatio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbStreamScreenRatio
            // 
            this.cbStreamScreenRatio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbStreamScreenRatio.FormattingEnabled = true;
            this.cbStreamScreenRatio.Location = new System.Drawing.Point(68, 33);
            this.cbStreamScreenRatio.Name = "cbStreamScreenRatio";
            this.cbStreamScreenRatio.Size = new System.Drawing.Size(115, 21);
            this.cbStreamScreenRatio.TabIndex = 6;
            this.cbStreamScreenRatio.SelectedIndexChanged += new System.EventHandler(this.cbStreamScreenRatio_SelectedIndexChanged);
            // 
            // labelSource
            // 
            this.labelSource.Font = new System.Drawing.Font("Futura Md BT", 9F);
            this.labelSource.ForeColor = System.Drawing.Color.White;
            this.labelSource.Location = new System.Drawing.Point(9, 9);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(53, 21);
            this.labelSource.TabIndex = 5;
            this.labelSource.Text = "Source :";
            this.labelSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // cBVideoSource
            // 
            this.cBVideoSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBVideoSource.FormattingEnabled = true;
            this.cBVideoSource.Location = new System.Drawing.Point(68, 9);
            this.cBVideoSource.Name = "cBVideoSource";
            this.cBVideoSource.Size = new System.Drawing.Size(115, 21);
            this.cBVideoSource.TabIndex = 3;
            this.cBVideoSource.SelectedIndexChanged += new System.EventHandler(this.cBVideoSource_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 615);
            this.panel2.TabIndex = 3;
            // 
            // GCSSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1318, 651);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MavlinkTerminal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "GCSSetting";
            this.Text = "GCSSetting";
            this.panel1.ResumeLayout(false);
            this.panelVideoStream.ResumeLayout(false);
            this.splitVideoStream.Panel1.ResumeLayout(false);
            this.splitVideoStream.Panel2.ResumeLayout(false);
            this.splitVideoStream.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitVideoStream)).EndInit();
            this.splitVideoStream.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MavlinkTerminal;
        private System.Windows.Forms.Button buttonConnectVideo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VideoStream;
        private System.Windows.Forms.Panel panelVideoStream;
        private System.Windows.Forms.SplitContainer splitVideoStream;
        private System.Windows.Forms.ComboBox cBVideoSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelRatio;
        private System.Windows.Forms.ComboBox cbStreamScreenRatio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCamId;
        private System.Windows.Forms.ComboBox cbCamId;
    }
}