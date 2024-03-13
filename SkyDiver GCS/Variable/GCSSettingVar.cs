using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SkyDiver_GCS
{
   public static class GCSSettingVar
    {
        private static float _streamScreenRatio;


        public static float streamScreenRatio
        {
            get { return _streamScreenRatio; }
            set
            {
                _streamScreenRatio = value;
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
