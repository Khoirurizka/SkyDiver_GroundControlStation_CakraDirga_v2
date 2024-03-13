using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace SkyDiver_GCS
{
    public static class serialComVar
    {
        public static SerialPort serialPort= new SerialPort();

        public static void InitializeSerialPort()
        {
            serialComVar.serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
        }
        private static void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialComVar.serialPort != null)
            {
                int x = serialComVar.serialPort.BytesToRead;
                byte[] b = new byte[x];
                for (int i = 0; i < x; i++)
                    b[i] = (byte)serialComVar.serialPort.ReadByte();
                MavLinkServiceMessage.BitReceived = b;
                MavlinkComVar.Mv.ParseBytes(b);
            }
        }
    }
}
