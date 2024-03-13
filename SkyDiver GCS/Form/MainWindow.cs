using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using MavLink;

namespace SkyDiver_GCS
{
    public partial class MainWindow : Form
    {
        //FormPanel
        static HomePanel homePanel = new HomePanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        static PlanPanel planPanel = new PlanPanel() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        static ConfigTuning configTuning = new ConfigTuning() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        static GCSSetting gcsSetting = new GCSSetting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        //Experimental

        public MainWindow()
        {
            InitializeComponent();
            InitializePanelSpliter();
            InitializeVarComponent();
            serialComVar.InitializeSerialPort();
            MavLinkServiceMessage.InitializeMavlink();
            MavlinkComVar.Mv.PacketReceived += MavLinkServiceMessage.Mv_PacketReceived;
            PanelAndSpliterModify.showFormOnPanel(homePanel, bodyPanel);

            EditStructGroupVar.MapPGroupInitializeListPointLatLng(MapsVar.FZpointGroup);
            EditStructGroupVar.MapPGroupInitializeListPointLatLng(MapsVar.WpointGroup);
            EditStructGroupVar.MapPGroupInitializeListPointLatLng(MapsVar.DZpointGroup);
            EditStructGroupVar.MapPGroupInitializeListPointLatLng(MapsVar.DpointGroup);
            EditStructGroupVar.MapPGroupInitializeListPointLatLng(MapsVar.PpointGroup);
            EditStructGroupVar.MapPGroupInitializeListPointLatLng(MapsVar.RpointGroup);

            ///////////////////SERIAL//////////////////////
            SerialPortConnection.ReadComListToComboBox(cbSerialPort, serialComVar.serialPort);
            SerialPortConnection.AddBaudrateListToComboBox(cbBaudrate, 5);
            SerialPortConnection.ShowStatusOnButton(btnSerialCon, serialComVar.serialPort);

            toolTip.SetToolTip(this.cbSerialPort, "Serial port");
            toolTip.SetToolTip(this.cbBaudrate, "Baudrate");
            toolTip.SetToolTip(this.btnSerialCon, "Connect/Disconnect serial port");
            toolTip.SetToolTip(this.btnEngine, "Turn on/off engine");
            toolTip.SetToolTip(this.failsafe, "Failsafe mode indicator");
            toolTip.SetToolTip(this.flightMode, "Flight mode");
            toolTip.SetToolTip(this.engineStatus, "Engine status");
            toolTip.SetToolTip(this.stateOfCharge, "State of charge");
            toolTip.SetToolTip(this.stateOfChargeIcon, "State of charge");
            toolTip.SetToolTip(this.voltMeter, "Battery volt meter");
            toolTip.SetToolTip(this.ampereMeter, "Battery ampere meter");

            //Experimental
            //MultiThread.RealtimeProcess.Start();
        }
        private void cbSerialPort_DropDown(object sender, EventArgs e)
        {
            cbSerialPort.DropDownWidth = CustomControl.setWidthComboBox(cbSerialPort);
        }
        private void cbBaudrate_DropDown(object sender, EventArgs e)
        {
            cbBaudrate.DropDownWidth = CustomControl.setWidthComboBox(cbBaudrate);

        }
        private void btnSerialCon_Click(object sender, EventArgs e)
        {
            if (!cbSerialPort.Text.Equals("Not Found"))
            {
                SerialPortConnection.TryConnectToSerialCOM(serialComVar.serialPort, SerialPortConnection.serialCOMs.serialCOM[cbSerialPort.SelectedIndex].portName, int.Parse(cbBaudrate.Text));
            }
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            MassageAndCommandVar.selectedMenu = 0;
            MapSystem.OnRefreshGmapOverlay(null);
        }
        private void BtnPlan_Click(object sender, EventArgs e)
        {
            MassageAndCommandVar.selectedMenu = 1;
        }
        private void BtnConfig_Click(object sender, EventArgs e)
        {
            MassageAndCommandVar.selectedMenu = 2;
        }
        private void BtnGCSSetting_Click(object sender, EventArgs e)
        {
            MassageAndCommandVar.selectedMenu = 3;
        }

        //Experimental
        private void btnEngine_Click(object sender, EventArgs e)
        {
            MavlinkServiceCommand.SwitchEngine(serialComVar.serialPort, PlaneModeVar.engineOn);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            InitializeVarAfterAllReady();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  ImageVideoStream.CloseVid();
          //  ImageVideoStream.ClosepCam();
            Thread.Sleep(1000);
        }
        //Experimental
    }
}
