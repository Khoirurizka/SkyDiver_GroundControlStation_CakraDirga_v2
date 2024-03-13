using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDiver_GCS
{
    public static class BatteryVar
    {
        private static float _stateOfCharge;
        private static float _voltage;
        private static float _ampere;

        public static float stateOfCharge {
            get { return _stateOfCharge; }
            set
            {
                _stateOfCharge = value;
                OnValueChanged(null); // raise event for value changed
            }
        }

        public static float voltage {
            get { return _voltage; }
            set
            {
                _voltage = value;
                OnValueChanged(null); // raise event for value changed
            }
        }

        public static float ampere {
            get { return _ampere; }
            set
            {
                _ampere = value;
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
