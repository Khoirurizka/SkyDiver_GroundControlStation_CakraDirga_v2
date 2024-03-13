using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyDiver_GCS
{
    public partial class GCSSetting : Form
    {
        public GCSSetting()
        {
            InitializeComponent();
            InitializeVarComponent();
            ImageVideoStream.InitializeComboBoxScreenRatio(cbStreamScreenRatio);
            ImageVideoStream.InitializeComboBoxLoadSource(cBVideoSource);
            ImageVideoStream.RefreshComboBoxCamId(cbCamId);
           // ImageVideoStream.SourceChanged += souceChanged;
            LogPrint.ValueChanged += OnLogPtintMessageCanged;
        }
        private void cbCamId_DropDown(object sender, EventArgs e)
        {
            cbCamId.DropDownWidth = CustomControl.setWidthComboBox(cbCamId);
        }

        private void cBVideoSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            souceChanged();
            if (cBVideoSource.Text == "Picture Source" || cBVideoSource.Text == "Video Source")
            {
                labelCamId.Hide();
                cbCamId.Hide();
            }
            else if (cBVideoSource.Text == "Video Stream")
            {
                labelCamId.Show();
                cbCamId.Show();
            }
        }
        private void buttonConnectVideo_Click(object sender, EventArgs e)
        {
            if (cBVideoSource.Text == "Picture Source")
            {
                try
                {
                //    ImageVideoStream.openImageSource();
                }
                catch (Exception ex)
                {
                    LogPrint.message = ex.Message;
                }
            }
            else if (cBVideoSource.Text == "Video Source")
            {
                try
                {
                    ImageVideoStream.openVideoSource();
                }
                catch (Exception ex)
                {
                    LogPrint.message = ex.Message;
                }
            }
            else if (cBVideoSource.Text == "Video Stream")
            {
                try
                {
                    //ImageVideoStream.openCamSource(cbCamId);
                }
                catch (Exception ex)
                {
                    LogPrint.message = ex.Message;
                }
            }
        }

        private void souceChanged(object sender, EventArgs e)
        {
            souceChanged();
        }
        private void souceChanged()
        {
            if (cBVideoSource.Text == "Picture Source")
            {
                buttonConnectVideo.Text = "Open";
            }
            else if (cBVideoSource.Text == "Video Source")
            {
                if (!StreamVar.frameIsBusy)
                    buttonConnectVideo.Text = "Open";
                else
                    buttonConnectVideo.Text = "Stop";
            }
            else if (cBVideoSource.Text == "Video Stream")
            {
                if (!StreamVar.frameIsBusy)
                    buttonConnectVideo.Text = "Connect";
                else
                    buttonConnectVideo.Text = "Disconnect";
            }
        }
        private void cbStreamScreenRatio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbStreamScreenRatio.Text == "1:1")
                {
                    GCSSettingVar.streamScreenRatio = 1f;
                }
                else  if (cbStreamScreenRatio.Text == "4:3")
                {
                    GCSSettingVar.streamScreenRatio = 0.75f;
                }
                else if (cbStreamScreenRatio.Text == "16:9")
                {
                    GCSSettingVar.streamScreenRatio = 0.5625f;
                }
            }
            catch (Exception ex)
            {
                LogPrint.message = ex.Message;
            }
        }

        private void OnLogPtintMessageCanged(object sender, EventArgs e)
        {
            MavlinkTerminal.Invoke(new Action(() =>
            {
                MavlinkTerminal.Text += LogPrint.message + "\n";
            }));
        }
    }
}
