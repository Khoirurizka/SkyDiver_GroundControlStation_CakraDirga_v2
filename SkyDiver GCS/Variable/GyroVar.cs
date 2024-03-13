using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDiver_GCS
{
    class GyroVar
    {
        private static float _compass;

        private static float _pitch;
        private static float _roll;
        private static float _yaw;

        public static float compass
        {
            get { return _compass; }
            set
            {
                _compass = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static float pitch
        {
            get { return _pitch; }
            set
            {
                _pitch = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static float roll
        {
            get { return _roll; }
            set
            {
                _roll = value;
                OnValueChanged(null); // raise event for value changed
            }
        }

        public static float yaw
        {
            get { return _yaw; }
            set
            {
                _yaw = value;
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
    }
}
