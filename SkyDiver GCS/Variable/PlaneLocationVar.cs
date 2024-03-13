using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;

namespace SkyDiver_GCS
{
    public static class PlaneLocationVar
    {
        private static float _altitude;
        private static PointLatLng _globalPosition_Earth;
        private static float _heading;

        public static float altitude
        {
            get { return _altitude; }
            set
            {
                _altitude = value;
                OnValueChanged(null); // raise event for value changed
            }
        }

        public static PointLatLng globalPosition_Earth
        {
            get { return _globalPosition_Earth; }
            set
            {
                _globalPosition_Earth = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static float heading
        {
            get { return _heading; }
            set
            {
                _heading = value;
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
