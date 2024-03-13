using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SkyDiver_GCS
{
    public partial class HomePanel : Form
    {
        private Point initializeStreamScreenPosition;
        private Point initializeStreamScreenSize;

        private void InitializeVarComponent()
        {
            InitializeStreamSceneVal();
            GCSSettingVar.ValueChanged += GCSSettingChangeVal;
            GyroVar.ValueChanged += GyroVarVal;
            SpeedVar.ValueChanged += SpeeddVarVal;
            PlaneLocationVar.ValueChanged += PlaneLocationVarVal;
            PlaneControlVar.payloadBay1.ValueChanged += payloadBay1val;
            PlaneControlVar.payloadBay2.ValueChanged += payloadBay2val;
            PlaneControlVar.ValueChanged += PlaneModeVal;
           // ImageVideoStream.StartStreamVar += StartStreamVarHandler;
           // ImageVideoStream.CloseStreamVar += StopStreamVarHandler;
        }

        private void InitializeStreamSceneVal()
        {
            initializeStreamScreenPosition = streamVideo.Location;
            initializeStreamScreenSize = new Point(streamVideo.Width, streamVideo.Height);
        }

        private void GCSSettingChangeVal(object sender, EventArgs e)
        {
            panelScaller = PanelAndSpliterModify.ScalerConstByWindow(this.Size.Width, this.Size.Height, initScreenSize.Width, initScreenSize.Height);
            streamVideo.Invoke(new Action(() =>
            {
                streamVideo.Height = (int)(streamVideo.Width * GCSSettingVar.streamScreenRatio);
                streamVideo.Location = new Point(0, (int)((initializeStreamScreenPosition.Y * panelScaller.WidthScaller) + ((initializeStreamScreenSize.Y * panelScaller.WidthScaller) - streamVideo.Height) / 2));
            }));
        }

        private void GyroVarVal(object sender, EventArgs e)
        {
            this.Invalidate();

            if (MassageAndCommandVar.selectedMenu == 0)
            {
                rollVal.Invoke(new Action(() =>
                {
                    rollVal.Text = GyroVar.roll.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "\u00B0";
                }));
                pitchVal.Invoke(new Action(() =>
                {
                    pitchVal.Text = GyroVar.pitch.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "\u00B0";
                }));
                yawVal.Invoke(new Action(() =>
                {
                    yawVal.Text = GyroVar.yaw.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "\u00B0";
                }));
            }
        }
        private void PlaneLocationVarVal(object sender, EventArgs e)
        {
            if (MassageAndCommandVar.selectedMenu == 0)
            {
                altitudeVal.Invoke(new Action(() =>
                {
                    altitudeVal.Text = PlaneLocationVar.altitude.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "m";
                }));
            }
        }
        private void SpeeddVarVal(object sender, EventArgs e)
        {
            if (MassageAndCommandVar.selectedMenu == 0)
            {
                airSpeedVal.Invoke(new Action(() =>
                {
                    airSpeedVal.Text = SpeedVar.airSpeed.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "m/s";
                }));
                climbRateVal.Invoke(new Action(() =>
                {
                    climbRateVal.Text = SpeedVar.climbRate.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "m/s";
                }));
                groundSpeedVal.Invoke(new Action(() =>
                {
                    groundSpeedVal.Text = SpeedVar.groundSpeed.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "m/s";
                }));
                throttleVal.Invoke(new Action(() =>
                {
                    throttleVal.Text = SpeedVar.throttle.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + "%";
                }));

            }
        }

        private void StartStreamVarHandler(object sender, EventArgs e)
        {
            StreamVar.frameIsBusy = true;
            StreamVar.ValueChanged += streamChanged;
        }
        private void StopStreamVarHandler(object sender, EventArgs e)
        {
            StreamVar.frameIsBusy = false;
            StreamVar.ValueChanged -= streamChanged;

        }
        private void streamChanged(object sender, EventArgs e)
        {
            //    this.Invoke(new MethodInvoker(delegate () { streamVideo.Image.Dispose(); }));
            if (StreamVar.frame != null)
            {
                streamVideo.Invoke(new Action(() =>
            {
                streamVideo.Image = StreamVar.frame;
            }));
            }
            else
            {
                return;
            }
        }
        private void payloadBay1val(object sender, EventArgs e)
        {
            payloadbay1Status.Invoke(new Action(() => {
                payloadbay1Status.Text = PlaneControlVar.payloadBay1.status ? "Opened" : "Closed";
            }));
        }
        private void payloadBay2val(object sender, EventArgs e)
        {
            payloadbay2Status.Invoke(new Action(() => {
                payloadbay2Status.Text = PlaneControlVar.payloadBay2.status ? "Opened" : "Closed";
            }));
        }
        private void PlaneModeVal(object sender, EventArgs e)
        {
            switch (PlaneControlVar.payloadBay1.servoId)
            {
                case 1:
                    PlaneControlVar.payloadBay1.servoValue = PlaneControlVar.servo1;
                    break;
                case 2:
                    PlaneControlVar.payloadBay1.servoValue = PlaneControlVar.servo2;
                    break;
                case 3:
                    PlaneControlVar.payloadBay1.servoValue = PlaneControlVar.servo3;
                    break;
                case 4:
                    PlaneControlVar.payloadBay1.servoValue = PlaneControlVar.servo4;
                    break;
                case 5:
                    PlaneControlVar.payloadBay1.servoValue = PlaneControlVar.servo5;
                    break;
                case 6:
                    PlaneControlVar.payloadBay1.servoValue = PlaneControlVar.servo6;
                    break;
                case 7:
                    PlaneControlVar.payloadBay1.servoValue = PlaneControlVar.servo7;
                    break;
                case 8:
                    PlaneControlVar.payloadBay1.servoValue = PlaneControlVar.servo8;
                    break;
            }
            switch (PlaneControlVar.payloadBay2.servoId)
            {
                case 1:
                    PlaneControlVar.payloadBay2.servoValue = PlaneControlVar.servo1;
                    break;
                case 2:
                    PlaneControlVar.payloadBay2.servoValue = PlaneControlVar.servo2;
                    break;
                case 3:
                    PlaneControlVar.payloadBay2.servoValue = PlaneControlVar.servo3;
                    break;
                case 4:
                    PlaneControlVar.payloadBay2.servoValue = PlaneControlVar.servo4;
                    break;
                case 5:
                    PlaneControlVar.payloadBay2.servoValue = PlaneControlVar.servo5;
                    break;
                case 6:
                    PlaneControlVar.payloadBay2.servoValue = PlaneControlVar.servo6;
                    break;
                case 7:
                    PlaneControlVar.payloadBay2.servoValue = PlaneControlVar.servo7;
                    break;
                case 8:
                    PlaneControlVar.payloadBay2.servoValue = PlaneControlVar.servo8;
                    break;
            }
        }
    }
}
