using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyDiver_GCS
{
    class PlaneControlVar
    {
        private static UInt16 _servo1;
        private static UInt16 _servo2;
        private static UInt16 _servo3;
        private static UInt16 _servo4;
        private static UInt16 _servo5;
        private static UInt16 _servo6;
        private static UInt16 _servo7;
        private static UInt16 _servo8;

        public static SPayloadBay payloadBay1 = new SPayloadBay();
        public static SPayloadBay payloadBay2 = new SPayloadBay();
        public static UInt16 servo1
        {
            get { return _servo1; }
            set
            {
                _servo1 = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static UInt16 servo2
        {
            get { return _servo2; }
            set
            {
                _servo2 = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static UInt16 servo3
        {
            get { return _servo3; }
            set
            {
                _servo3 = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static UInt16 servo4
        {
            get { return _servo4; }
            set
            {
                _servo4 = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static UInt16 servo5
        {
            get { return _servo5; }
            set
            {
                _servo5 = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static UInt16 servo6
        {
            get { return _servo6; }
            set
            {
                _servo6 = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static UInt16 servo7
        {
            get { return _servo7; }
            set
            {
                _servo7 = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static UInt16 servo8
        {
            get { return _servo8; }
            set
            {
                _servo8 = value;
                OnValueChanged(null); // raise event for value changed
            }
        }

        public static event EventHandler ValueChanged;
        private static void OnValueChanged(EventArgs e)
        {
            EventHandler handler = ValueChanged;
            if (handler != null)// Raise the event
                handler(ValueChanged, e);
        }
        public static void ConfigServoToggle(SPayloadBay payloadBay, ComboBox servoId, ComboBox Threshold)
        {
            payloadBay.servoId = int.Parse(servoId.Text);
            payloadBay.threshold = int.Parse(Threshold.Text);
        }
        public static void ConfigServoToggle(SPayloadBay payloadBay, int servoId, int Threshold)
        {
            payloadBay.servoId = servoId;
            payloadBay.threshold = Threshold;
        }
    }
}
