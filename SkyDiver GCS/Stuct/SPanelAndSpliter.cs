using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SkyDiver_GCS
{
    public struct PanelRangeSize
    {
        public int Size { set; get; }//Current Size
        public float MinSF { set; get; }//Minimum Scale Faktor Panel
        public float MaxSF { set; get; }//Maximum Scale Faktor  Panel
        public int MinSize { set; get; }//Minimum Size Panel
        public int MaxSize { set; get; }//Maximum Size Panel
    }
    public struct PanelSizeAndPosition
    {
        public Size panelSize { set; get; }
        public Point panelPosition { set; get; }
    }

    public struct PanelScaller
    {
        public float WidthScaller { set; get; }
        public float HeightScaller { set; get; }
    }
}
