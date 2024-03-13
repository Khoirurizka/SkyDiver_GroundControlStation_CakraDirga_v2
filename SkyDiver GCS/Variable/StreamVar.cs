using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SkyDiver_GCS
{
    public static class StreamVar
    {
        private static bool _frameIsBusy;
        private static Bitmap _frame= new Bitmap(640, 480);
        private static string _VideoDirectory;
        public static bool frameIsBusy
        {
            get { return _frameIsBusy; }
            set
            {
                _frameIsBusy = value;
             //  ImageVideoStream.OnSourceChanged(null); // raise event for value changed
            }
        }
        public static Bitmap frame
        {
            get { return _frame; }
            set
            {
                _frame = value;
                OnValueChanged(null); // raise event for value changed
            }
        }
        public static string VideoDirectory
        {
            get { return _VideoDirectory; }
            set
            {
                _VideoDirectory = value;
                OnVideoDirChanged(null); // raise event for value changed
            }
        }

        public static event EventHandler VideoDirChanged;
        public static void OnVideoDirChanged(EventArgs e)
        {
            EventHandler handler = VideoDirChanged;
            if (handler != null)// Raise the event
                handler(VideoDirChanged, e);
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
