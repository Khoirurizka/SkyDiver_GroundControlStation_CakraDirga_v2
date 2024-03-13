using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyDiver_GCS
{
    public partial class MainWindow : Form
    {
        private void InitializeVarComponent()
        {
            SerialPortService.PortsChanged += (sender, changedArgs) => OnPortChanged(changedArgs.SerialPorts);
            SerialPortConnection.ConnectionChanged += OnSerialConnectionCanged;
            BatteryVar.ValueChanged += batteryOnChangedVal;
            PlaneModeVar.ValueChanged += fightModeOnChangedVal;
            MassageAndCommandVar.mainMenuChanged += mainMenuChanged;
        }

        private bool Initialized;
        private void InitializeVarAfterAllReady()
        {
            PlaneControlVar.ConfigServoToggle(PlaneControlVar.payloadBay1, 5, 1300);
            PlaneControlVar.ConfigServoToggle(PlaneControlVar.payloadBay2, 8, 1300);
            Initialized = true;
        }

        private void OnPortChanged(string[] changedArgs)
        {
            cbSerialPort.Invoke(new Action(() =>
            {
                SerialPortConnection.ReadComListToComboBox(cbSerialPort, serialComVar.serialPort);
            }));
        }
        private void OnSerialConnectionCanged(object sender, EventArgs e)
        {
            SerialPortConnection.ShowStatusOnButton(btnSerialCon, serialComVar.serialPort);
        }
        private void batteryOnChangedVal(object sender, EventArgs e)
        {
            stateOfCharge.Invoke(new Action(() =>
            {
                stateOfCharge.Text = BatteryVar.stateOfCharge.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) + "%";
            }));
            voltMeter.Invoke(new Action(() =>
            {
                voltMeter.Text = BatteryVar.voltage.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) + "V";
            }));
            ampereMeter.Invoke(new Action(() =>
            {
                ampereMeter.Text = BatteryVar.ampere.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture) + "A";
            }));
        }

        private void fightModeOnChangedVal(object sender, EventArgs e)
        {
            engineStatus.Invoke(new Action(() =>
            {
                engineStatus.Text = PlaneModeVar.engineOnCollection[PlaneModeVar.engineOn ? 1 : 0];
            }));
            failsafe.Invoke(new Action(() =>
            {
                failsafe.Text = PlaneModeVar.failsafeModeCollection[PlaneModeVar.failsafeMode];
            }));
            flightMode.Invoke(new Action(() =>
            {
                flightMode.Text = PlaneModeVar.flightModeCollection[PlaneModeVar.flightMode];
            }));
        }

        private void mainMenuChanged(object sender, EventArgs e)
        {
            switch (MassageAndCommandVar.selectedMenu)
            {
                case 0:
                    PanelAndSpliterModify.showFormOnPanel(homePanel, bodyPanel);
                    break;
                case 1:
                    PanelAndSpliterModify.showFormOnPanel(planPanel, bodyPanel);
                    break;
                case 2:
                    PanelAndSpliterModify.showFormOnPanel(configTuning, bodyPanel);
                    break;
                case 3:
                    PanelAndSpliterModify.showFormOnPanel(gcsSetting, bodyPanel);
                    break;
            }
        }
    }
}
