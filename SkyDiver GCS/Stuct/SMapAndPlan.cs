using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;

namespace SkyDiver_GCS
{
    public class BtnGroup
    {
        public List<Bitmap> Actived { set; get; }
        public List<Bitmap> Disactived { set; get; }
        public int activedId { set; get; }
        public List<Button> button { set; get; }
    }
    public class MapPointGroup
    {
        public List<PointLatLng> EdgePoint { set; get; }
    }

}
