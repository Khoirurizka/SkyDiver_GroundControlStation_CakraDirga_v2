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
    public class PlanePoint : GMapMarker
    {
        private PointLatLng pos_;
        private float size_;
        private float YawAngle_;
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
        public PlanePoint(PointLatLng pos, int size, float YawAngle)
            : base(pos)
        {
            pos_ = pos;
            size_ = size;
            YawAngle_ = YawAngle;
        }

        public override void OnRender(Graphics g)
        {
            double rollValrad = YawAngle_ * Math.PI / 180;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            PointF[] NavDraw = new PointF[4];

            NavDraw[0].X = LocalPosition.X + (-size_ / 2) * (float)Math.Cos(rollValrad) - (size_ / 2) * (float)(Math.Sin(rollValrad));
            NavDraw[0].Y = LocalPosition.Y + (-size_ / 2) * (float)Math.Sin(rollValrad) + (size_ / 2) * (float)(Math.Cos(rollValrad));
            NavDraw[1].X = LocalPosition.X - (-size_ / 2) * (float)(Math.Sin(rollValrad));
            NavDraw[1].Y = LocalPosition.Y + (-size_ / 2) * (float)(Math.Cos(rollValrad));
            NavDraw[2].X = LocalPosition.X + (size_ / 2) * (float)Math.Cos(rollValrad) - (size_ / 2) * (float)(Math.Sin(rollValrad));
            NavDraw[2].Y = LocalPosition.Y + (size_ / 2) * (float)Math.Sin(rollValrad) + (size_ / 2) * (float)(Math.Cos(rollValrad));
            NavDraw[3].X = LocalPosition.X - (size_ / 4) * (float)(Math.Sin(rollValrad));
            NavDraw[3].Y = LocalPosition.Y + (size_ / 4) * (float)(Math.Cos(rollValrad));
            Brush solidBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 0));

            //rotateAngle
            g.FillPolygon(solidBrush, NavDraw);
        }
    }
}
