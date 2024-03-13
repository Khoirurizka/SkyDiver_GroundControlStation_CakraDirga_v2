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
    class TextMarker : GMapMarker
    {
        private PointLatLng pos_;
        private Font font_;
        private Color borderColor_;
        private Color fillColor_;
        private Color textColor_;
        private string text_;
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
        public TextMarker(PointLatLng pos, Font font, Color borderColor, Color fillColor, Color textColor, string text)
            : base(pos)
        {
            pos_ = pos;
            font_ = font;
            borderColor_ = borderColor;
            fillColor_ = fillColor;
            textColor_ = textColor;
            text_ = text;
        }

        public override void OnRender(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Brush FillsolidBrush = new SolidBrush(fillColor_);
            Brush TextsolidBrush = new SolidBrush(textColor_);
            Pen pen = new Pen(borderColor_, 3);
            //rotateAngle
            //g.DrawEllipse(pen, LocalPosition.X - r_, LocalPosition.Y - r_, 2 * r_, 2 * r_);
            //g.FillEllipse(FillsolidBrush, LocalPosition.X - r_, LocalPosition.Y - r_, 2 * r_, 2 * r_);
            g.DrawString(text_, font_, TextsolidBrush, LocalPosition.X, LocalPosition.Y);
        }
    }
}
