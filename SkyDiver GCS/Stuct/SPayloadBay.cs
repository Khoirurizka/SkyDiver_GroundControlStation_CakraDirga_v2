using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDiver_GCS
{
   public class SPayloadBay
    {
        private int _servoId;
        private int _servoValue;
        private int _threshold;

        public int servoId
        {
            get { return _servoId; }
            set
            {
                _servoId = value;
                OnValueChanged(null); // raise event for value changed

            }
        }
        public int servoValue
        {
            get { return _servoValue; }
            set
            {
                _servoValue = value;
                OnValueChanged(null); // raise event for value changed

            }
        }
        public bool status
        {
            get { return servoValue > threshold ? false : true; }
            set
            {
            }
        }
        public int threshold
        {
            get { return _threshold; }
            set
            {
                _threshold = value;

                OnValueChanged(null); // raise event for value changed

            }
        }
        public event EventHandler ValueChanged;
        private void OnValueChanged(EventArgs e)
        {
            EventHandler handler = ValueChanged;
            if (handler != null)// Raise the event
                handler(ValueChanged, e);
        }
    }
}
