using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDiver_GCS
{
    public static class PlaneModeVar
    {
        private static bool _engineOn;
        private static UInt16 _failsafeMode;
        private static UInt16 _flightMode;

        public static String[] engineOnCollection { set; get; } = { "ENGINE OFF", "ENGINE ON" };
        public static String[] failsafeModeCollection { set; get; } = { "UNINITIALIZED","BOOTING", "CALIBRATING", "STANDBY", "ACTIVE", "FAILSAFE", "EMERGENCY", "POWEROFF", "FLIGHT TERMINATION" };
        public static String[] flightModeCollection { set; get; } = { "MANUAL", "CIRCLE", "STABILIZE", "TRAINING", "ACRO",
                            "FBWA", "FBWB", "CRUISE", "AUTOTUNE", "RTL",
                            "AUTO", "LOITER", "TAKEOFF", "AVOID_ADSSB", "GUIDDED",
                           "QSTABILIZE", "QHOVER", "QLOITER", "QLAND", "QRTL",
                            "QAUTOTUNE", "QACRO", "TERMAL", "INITIALISING" };


        public static bool engineOn
        {
            get { return _engineOn; }
            set
            {
                _engineOn = value;
                OnValueChanged(null); // raise event for value changed
            }
        }

        public static UInt16 failsafeMode
        {
            get { return _failsafeMode; }
            set
            {
                _failsafeMode = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static UInt16 flightMode
        {
            get { return _flightMode; }
            set
            {
                _flightMode = value;
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
