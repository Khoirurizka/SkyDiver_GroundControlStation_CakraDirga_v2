using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MavLink;

namespace SkyDiver_GCS
{
   public static class MavlinkComVar
    {
        public static Mavlink _Mv = new Mavlink();  

         public static int _Systemid { set; get; }
        public static int _Componentid { set; get; }
        public static int _Sequence { set; get; }

        public static event EventHandler ValueChanged;


        public static Mavlink Mv
        {
            get { return _Mv; }
            set
            {
                _Mv = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static int Systemid
        {
            get { return _Systemid; }
            set
            {
                _Systemid = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static int Componentid
        {
            get { return _Componentid; }
            set
            {
                _Componentid = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static int Sequence
        {
            get { return _Sequence; }
            set
            {
                _Sequence = value;
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
