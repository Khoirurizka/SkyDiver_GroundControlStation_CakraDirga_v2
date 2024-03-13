using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;

namespace SkyDiver_GCS
{
    class CircleMarker : GMapMarker
    {
        private PointLatLng pos_;
        private float r_;
        private Font font_;
        private Color borderColor_;
        private Color fillColor_;
        private Color textColor_;
        private string id_;
        private bool showId_;//0=hide,1=show
        public PointLatLng pos
        {
            get
            {
                return pos_;
            }
            set
            {
                pos_ = value;
            }
        }
        public CircleMarker(PointLatLng pos, int r, Font font, Color borderColor, Color fillColor, Color textColor, string id, bool showId)
            : base(pos)
        {
            pos_ = pos;
            r_ = r;
            font_=font;
            borderColor_=borderColor;
            fillColor_=fillColor;
            textColor_ = textColor;
            id_ = id;
            showId_ = showId;
        }

        public override void OnRender(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Brush FillsolidBrush = new SolidBrush(fillColor_);
            Brush TextsolidBrush = new SolidBrush(textColor_);
            Pen pen = new Pen(borderColor_, 3);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            //rotateAngle
            g.DrawEllipse(pen, LocalPosition.X - r_, LocalPosition.Y - r_, 2 * r_, 2 * r_);
            g.FillEllipse(FillsolidBrush, LocalPosition.X - r_, LocalPosition.Y - r_, 2 * r_, 2 * r_);
            if (showId_)
                g.DrawString(id_, font_, TextsolidBrush, LocalPosition.X, LocalPosition.Y, sf);//- (5* r_ * font_.Size / 144),  - (7 * r_ * font_.Size / 144));
        }
    }
}
