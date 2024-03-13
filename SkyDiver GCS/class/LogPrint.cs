using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyDiver_GCS
{
    public static class LogPrint
    {
        public static bool isRunning { set; get; }
        private static string _message;

        public static string message
        {
            get { return _message; }
            set
            {
                _message = value;
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
