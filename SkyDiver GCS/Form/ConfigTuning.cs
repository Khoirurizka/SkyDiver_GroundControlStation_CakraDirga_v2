using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MavLink;

namespace SkyDiver_GCS
{
    public partial class ConfigTuning : Form
    {

        public ConfigTuning()
        {
            InitializeComponent();
            InitializePaypoadParam();
            toolTip.SetToolTip(this.cBPayloadBay1Servo, "Payload bay 1 Servo ID");
            toolTip.SetToolTip(this.cBPayloadBay2Servo, "Payload bay 2 Servo ID");
            toolTip.SetToolTip(this.payload1ThresholdVal, "Payload bay 1 threshold open/close threshold");
            toolTip.SetToolTip(this.payload2ThresholdVal, "Payload bay 2 threshold open/close threshold");
            toolTip.SetToolTip(this.btnSwitchPB1, "Open/close payload bay 1");
            toolTip.SetToolTip(this.btnSwitchPB2, "Open/close payload bay 2");
            toolTip.SetToolTip(this.PayloadBayConfigSet, "Calibrate HUD payloadbay");
            toolTip.SetToolTip(this.btnCalibrateAccel, "Level your Autopilot to set default accelerometer Min/Max (3 axis).\n"+
                                                        " This will ask you to place your autopilot on each edge.");
            toolTip.SetToolTip(this.btnCalibrateLevel, "Level your Autopilot to set default accelerometer offsets (1 axis/AHRS trims).\n"+
                                                        "This requires you to place your autopilot flat and level.");

            MavLinkServiceMessage.AckRecived += EncodeACKRecive;
            MavLinkServiceMessage.MsgRecived += EncodeMesssageRecive;
        }
        private void InitializePaypoadParam()
        {
            cBPayloadBay1Servo.Items.AddRange(ConfigTuningVar.servoIdList);
            cBPayloadBay1Servo.SelectedIndex = 4;
            payload1ThresholdVal.Text = (1300).ToString();

            cBPayloadBay2Servo.Items.AddRange(ConfigTuningVar.servoIdList);
            cBPayloadBay2Servo.SelectedIndex = 7;
            payload2ThresholdVal.Text = (1300).ToString();
        }
        private void PayloadBayConfigSet_Click(object sender, EventArgs e)
        {
            PlaneControlVar.ConfigServoToggle(PlaneControlVar.payloadBay1, int.Parse(cBPayloadBay1Servo.Text), int.Parse(payload1ThresholdVal.Text));
            PlaneControlVar.ConfigServoToggle(PlaneControlVar.payloadBay2, int.Parse(cBPayloadBay2Servo.Text), int.Parse(payload2ThresholdVal.Text));
        }

        private void btnSwitchPB1_Click(object sender, EventArgs e)
        {
            MavlinkServiceCommand.SwitchServo(serialComVar.serialPort, PlaneControlVar.payloadBay1, 400, 400);
        }

        private void btnSwitchPB2_Click(object sender, EventArgs e)
        {
            MavlinkServiceCommand.SwitchServo(serialComVar.serialPort, PlaneControlVar.payloadBay2, 400, 400);
        }
        private void btnCalibrateAccel_Click(object sender, EventArgs e)
        {
            if (serialComVar.serialPort.IsOpen)
            {
                MavlinkServiceCommand.CalibrateAccel(serialComVar.serialPort);
            }
            else
            {
                StatusLog.Invoke(new Action(() =>
                {
                    StatusLog.Text = "Level accel failed\n[Error COM port]";
                }));
            }

        }
        private void btnCalibrateLevel_Click(object sender, EventArgs e)
        {
            if (serialComVar.serialPort.IsOpen) {
                StatusLog.Text = MavlinkServiceCommand.CalibrateLavel(serialComVar.serialPort);
            }
            else
            {
                StatusLog.Invoke(new Action(() =>
                {
                    StatusLog.Text = "Level calibration failed\n[Error COM port]";
                }));
            }
        }
        private void EncodeACKRecive(object sender, EventArgs e)
        {
            if (MavLinkServiceMessage.msg_command_ack.command == (ushort)MavlinkServiceCommand.lastMsg_command_long.command)
            {
                if ( MavLinkServiceMessage.msg_command_ack.command == (ushort)MAV_CMD.MAV_CMD_PREFLIGHT_CALIBRATION &&
                    MavlinkServiceCommand.lastMsg_command_long.param5 == 1)
                {
                    if (MavLinkServiceMessage.msg_command_ack.result != (byte)MAV_RESULT.MAV_RESULT_ACCEPTED)
                    {
                        StatusLog.Invoke(new Action(() =>
                        {
                            StatusLog.Text = "Accel calibration failed";
                        }));
                    }
                    else if (MavLinkServiceMessage.lastStepCallibration)
                    {
                        StatusLog.Invoke(new Action(() =>
                        {
                            StatusLog.Text = "Accel calibration success";
                        }));
                    }
                }else if (MavLinkServiceMessage.msg_command_ack.command == (ushort)MAV_CMD.MAV_CMD_PREFLIGHT_CALIBRATION &&
                    MavlinkServiceCommand.lastMsg_command_long.param5 == 2)
                {
                    if (MavLinkServiceMessage.msg_command_ack.result == (byte)MAV_RESULT.MAV_RESULT_ACCEPTED)
                    {
                        StatusLog.Invoke(new Action(() =>
                        {
                            StatusLog.Text = "Level calibration success";
                        }));
                    }
                    else
                    {
                        StatusLog.Invoke(new Action(() =>
                        {
                            StatusLog.Text = "Level calibration failed";
                        }));
                    }
                }
            }
        }
        private void EncodeMesssageRecive(object sender, EventArgs e)
        {
            if (MassageAndCommandVar.massageReceived.Contains("Place vehicle level and press any key"))
            {
                StatusLog.Invoke(new Action(() =>
                {
                    //  Place vehicle level and press any key
                    StatusLog.Text = "Place vehicle level and press any key";// "Level accel success";
                }));
            }
            else if (MassageAndCommandVar.massageReceived.Contains("Please place vehicle LEFT"))
            {
                StatusLog.Invoke(new Action(() =>
                {
                    //  Place vehicle level and press any key
                    StatusLog.Text = "Please place vehicle Left and press any key";// "Level accel success";
                }));
            }
            else if (MassageAndCommandVar.massageReceived.Contains("Please place vehicle RIGHT"))
            {
                StatusLog.Invoke(new Action(() =>
                {
                    //  Place vehicle level and press any key
                    StatusLog.Text = "Please place vehicle Right and press any key";// "Level accel success";
                }));
            }
            else if (MassageAndCommandVar.massageReceived.Contains("Please place vehicle NOSEDOWN"))
            {
                StatusLog.Invoke(new Action(() =>
                {
                    //  Place vehicle level and press any key
                    StatusLog.Text = "Please place vehicle Nose Down and press any key";// "Level accel success";
                }));
            }
            else if (MassageAndCommandVar.massageReceived.Contains("Please place vehicle NOSEUP"))
            {
                StatusLog.Invoke(new Action(() =>
                {
                    //  Place vehicle level and press any key
                    StatusLog.Text = "Please place vehicle Nose Up and press any key";// "Level accel success";
                }));
            }
            else if (MassageAndCommandVar.massageReceived.Contains("Please place vehicle BACK"))
            {
                MavLinkServiceMessage.lastStepCallibration = true;
                StatusLog.Invoke(new Action(() =>
                {
                    //  Place vehicle level and press any key
                    StatusLog.Text = "Please place vehicle Back and press any key";// "Level accel success";
                }));
            }
        }
    }
}
