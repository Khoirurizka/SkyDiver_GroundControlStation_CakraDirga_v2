using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using Microsoft.Win32;

namespace SkyDiver_GCS
{
    public static class SerialPortConnection
    {
        public static SerialCOMs serialCOMs = new SerialCOMs();
        private static bool _isConnected;

        public static bool isConnected
        {
            get { return _isConnected; }
            set
            {
                _isConnected = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static event EventHandler ConnectionChanged;
        private static void OnValueChanged(EventArgs e)
        {
            EventHandler handler = ConnectionChanged;
            if (handler != null)// Raise the event
                handler(ConnectionChanged, e);
        }

        public static void ReadComListToComboBox(ComboBox cb,SerialPort serialPort)
        {
            GetAllSerialCOM();
            isConnected = serialPort.IsOpen;

            List<string> portsShow= new List<string>();

            foreach (SerialCOM sc in serialCOMs.serialCOM) {
                string tempStr = sc.portName.ToString()+" " + sc.caption.ToString();
                portsShow.Add(tempStr);
            }
            cb.Items.Clear();
            if (portsShow.Count > 0)
                cb.Items.AddRange(portsShow.ToArray());
            else
                cb.Items.Add("Not Found");

            if (cb.Items.Count > 0)
                cb.SelectedIndex = cb.Items.Count - 1;
        }
        public static void AddBaudrateListToComboBox(ComboBox cb,int DefaultIndex)
        {
            string[] baudrates = { "9600", "19200", "38400", "57600", "74880", "115200", "230400", "250000", "1000000", "2000000" };
            cb.Items.AddRange(baudrates);
            cb.SelectedIndex = DefaultIndex;
        }
        public static void ShowStatusOnButton(Button btn,SerialPort serialPort)
        {
            if (serialPort.IsOpen)
            {
                btn.BackgroundImage = Properties.Resources.BtnConnectSerial_200;
                btn.Text = "CONNECTED";
            }
            else
            {
                btn.BackgroundImage = Properties.Resources.BtnDisconnectSerial_200;
                btn.Text = "DISCONNECTED";
            }
        }

       public static bool TryConnectToSerialCOM(SerialPort serialPort,string portName,int BaudRate)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    if (MassageAndCommandVar.hasTakeRequestSession)
                        MavlinkServiceCommand.RequestDataSteam(serialPort, (byte)REQUEST_DATA.STOP);
                    serialPort.Close();
                    isConnected = serialPort.IsOpen;
                    return isConnected;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    isConnected = serialPort.IsOpen;
                    return isConnected;
                }
            }
            else
            {
                try
                {
                    serialPort.PortName = portName;
                    serialPort.BaudRate = BaudRate;
                    serialPort.Open();
                    isConnected = serialPort.IsOpen;
                    if (!MassageAndCommandVar.hasTakeRequestSession && isConnected)
                        MavlinkServiceCommand.RequestDataSteam(serialPort, (byte) REQUEST_DATA.START);
                    return isConnected;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    isConnected = serialPort.IsOpen;
                    return isConnected;
                }
            }
        }
        /// <summary>
        /// example output
        /// Port Name:    COM25
        /// Description:  USB-SERIAL CH340
        /// Manufacturer: wch.cn
        /// Device ID:    USB\VID_1A86&PID_7523\5&2499667D&0&3
        /// </summary>
        /// <returns></returns>
        private static void GetAllSerialCOM()
        {
            serialCOMs.serialCOM = new List<SerialCOM>();

            using (ManagementClass i_Entity = new ManagementClass("Win32_PnPEntity"))
            {
                foreach (ManagementObject i_Inst in i_Entity.GetInstances())
                {
                    SerialCOM serialCOM = new SerialCOM();
                    Object o_Guid = i_Inst.GetPropertyValue("ClassGuid");
                    if (o_Guid == null || o_Guid.ToString().ToUpper() != "{4D36E978-E325-11CE-BFC1-08002BE10318}")
                        continue; // Skip all devices except device class "PORTS"

                    serialCOM.caption = i_Inst.GetPropertyValue("Caption").ToString();
                    serialCOM.manufact = i_Inst.GetPropertyValue("Manufacturer").ToString();
                    serialCOM.deviceID = i_Inst.GetPropertyValue("PnpDeviceID").ToString();
                    serialCOM.regPath = "HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Enum\\" + serialCOM.deviceID + "\\Device Parameters";
                    serialCOM.portName = Registry.GetValue(serialCOM.regPath, "PortName", "").ToString();

                    int s32_Pos = serialCOM.caption.IndexOf(" (COM");
                    if (s32_Pos > 0) // remove COM port from description
                        serialCOM.caption = serialCOM.caption.Substring(0, s32_Pos);

                    serialCOMs.serialCOM.Add(serialCOM);
                }
            }
        }
    }
}
