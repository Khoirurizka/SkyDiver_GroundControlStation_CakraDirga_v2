using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDiver_GCS
{

    public static class MassageAndCommandVar
    {
        private static int _selectedMenu;
        private static string _massageReceived;
        public static bool _hasTakeRequestSession;

        public static event EventHandler mainMenuChanged;
        public static event EventHandler ValueChanged;

        public static int selectedMenu 
        {
            get { return _selectedMenu; } 
            set
            {
                _selectedMenu = value;
                OnMainMenuChanged(null); // raise event for value changed
            }
        }

        private static void OnMainMenuChanged(EventArgs e)
        {
            EventHandler handler = mainMenuChanged;
            if (handler != null)// Raise the event
                handler(mainMenuChanged, e);
        }

        public static string massageReceived
        {
            get { return _massageReceived; }
            set
            {
                _massageReceived = value;
                OnValueChanged(null); // raise event for value changed
            }
        }

        private static void OnValueChanged(EventArgs e)
        {
            EventHandler handler = ValueChanged;
            if (handler != null)// Raise the event
                handler(ValueChanged, e);
        }

        public static bool hasTakeRequestSession
        {
            get { return _hasTakeRequestSession; }
            set
            {
                _hasTakeRequestSession = value;
            }
        }
    }
}
