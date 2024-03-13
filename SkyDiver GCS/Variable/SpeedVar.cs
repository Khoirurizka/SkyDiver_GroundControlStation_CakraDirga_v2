using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDiver_GCS
{
    public static class SpeedVar
    {
        private static float _airSpeed;
        private static float _climbRate;
        private static float _groundSpeed;
        private static float _throttle;

        public static event EventHandler ValueChanged;

        public static float airSpeed
        {
            get { return _airSpeed; }
            set
            {
                _airSpeed = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static float climbRate
        {
            get { return _climbRate; }
            set
            {
                _climbRate = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static float groundSpeed
        {
            get { return _groundSpeed; }
            set
            {
                _groundSpeed = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static float throttle
        {
            get { return _throttle; }
            set
            {
                _throttle = value;
                OnValueChanged(null); // raise event for value changed
            }
        }

        private static void OnValueChanged(EventArgs e)
        {
            EventHandler handler = ValueChanged;
            if (handler != null)// Raise the event
                handler(ValueChanged, e);
        }
    }
}
