using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SkyDiver_GCS
{
    class Altimeter
    {
        public void IndicatorBG1(Graphics g, Point Position, int Height)
        {
            var brush = new SolidBrush(Color.FromArgb(160, 255, 0, 0));//150, 34, 0, 0
            var BGsolidBrush = new SolidBrush(Color.FromArgb(160, 120, 120, 120));
            var solidBrush2 = new SolidBrush(Color.FromArgb(160, 25, 25, 25));
            Pen pen = new Pen(Color.Black, 3);

            Matrix matrix = new Matrix();
            g.ResetTransform();
            matrix.Translate(Position.X - 55, Position.Y - (Height / 2), MatrixOrder.Append);
            g.Transform = matrix;
            //Background
            PointF[] BgrU = new PointF[5];
            PointF[] BgrD = new PointF[5];
            PointF[] Indc = new PointF[6];
            // g.FillRectangle(BGsolidBrush, 0, 0, 110, Height);
            g.FillRectangle(BGsolidBrush, 0, 0, 70, Height);
            BgrU[0].X = 72;
            BgrU[0].Y = Height * 0.1f;
            BgrU[1].X = 92;
            BgrU[1].Y = Height * 0.1f;
            BgrU[2].X = 92;
            BgrU[2].Y = (Height / 2) - 31;
            BgrU[3].X = 77;//
            BgrU[3].Y = Height / 2 - 5;
            BgrU[4].X = 72;
            BgrU[4].Y = Height / 2 - 5;
            g.FillPolygon(BGsolidBrush, BgrU);
            BgrD[0].X = 72;
            BgrD[0].Y = Height * 0.9f;
            BgrD[1].X = 92;
            BgrD[1].Y = Height * 0.9f;
            BgrD[2].X = 92;
            BgrD[2].Y = (Height / 2) + 31;
            BgrD[3].X = 77;//
            BgrD[3].Y = Height / 2 + 5;
            BgrD[4].X = 72;
            BgrD[4].Y = Height / 2 + 5;
            g.FillPolygon(BGsolidBrush, BgrD);
            Indc[0].X = 72;
            Indc[0].Y = (Height / 2) * 0.995f;

            Indc[1].X = 72 + (int)(15 * Math.Cos(30 * Math.PI / 180));
            Indc[1].Y = (Height / 2) - (int)(15 * Math.Sin(30 * Math.PI / 180));
            Indc[2].X = 110;
            Indc[2].Y = (Height / 2) - (int)(15 * Math.Sin(30 * Math.PI / 180));
            Indc[3].X = 110;
            Indc[3].Y = (Height / 2) + (int)(15 * Math.Sin(30 * Math.PI / 180));
            Indc[4].X = 72 + (int)(15 * Math.Cos(30 * Math.PI / 180));
            Indc[4].Y = (Height / 2) + (int)(15 * Math.Sin(30 * Math.PI / 180));

            Indc[5].X = 72;
            Indc[5].Y = (Height / 2) * 1.005f;
            g.FillPolygon(solidBrush2, Indc);
            g.FillRectangle(solidBrush2, 0, Height / 2 - 15, 70, 30);
            //   g.FillRectangle(brush, -10, 0, 20, 30);
            // g.DrawLine(pen, (-Width / 2), 1, (Width / 2), 1);
        }
        public void BG2(Graphics g, Point Position, int Height)
        {
            var BGsolidBrush = new SolidBrush(Color.FromArgb(160, 120, 120, 120));

            var fontFamily = new FontFamily("Times New Roman");
            var font = new Font(fontFamily, 13, FontStyle.Bold, GraphicsUnit.Pixel);
            var fontBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));

            Pen pen = new Pen(Color.Black, 2);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            Matrix matrix = new Matrix();
            g.ResetTransform();
            matrix.Translate(Position.X - 45, Position.Y - (Height / 2), MatrixOrder.Append);
            g.Transform = matrix;
            //Background
            g.FillRectangle(BGsolidBrush, 10, 0, 70, (Height / 2) - 20);
            g.FillRectangle(BGsolidBrush, 10, (Height / 2) + 20, 70, (Height / 2) - 20);
            g.DrawLine(pen, 15, 15, 15, Height-15);
            g.DrawString("m", font, fontBrush, 68, Height / 2, sf);

        }
        public void Indicator2(Graphics g, Point Position, int Height)
        {
            var IndBrush = new SolidBrush(Color.FromArgb(80, 23, 71, 79));
            var WhiteBrush = new SolidBrush(Color.FromArgb(80, 255, 255, 255));

            Pen WhitePen = new Pen(WhiteBrush, 1);

            Matrix matrix = new Matrix();
            g.ResetTransform();
            matrix.Translate(Position.X - 45, Position.Y - (Height / 2), MatrixOrder.Append);
            g.Transform = matrix;
            //Background
            PointF[] Indc = new PointF[10];
            Indc[0].X = 0;
            Indc[0].Y = (Height / 2);

            Indc[1].X = 10;
            Indc[1].Y = (Height / 2) - 10;
            Indc[2].X = 10;
            Indc[2].Y = (Height / 2) - 20;
            Indc[3].X = 80;
            Indc[3].Y = (Height / 2) - 20;
            Indc[4].X = 80;
            Indc[4].Y = (Height / 2) - 10;

            Indc[5].X = 90;
            Indc[5].Y = (Height / 2);

            Indc[6].X = 80;
            Indc[6].Y = (Height / 2) + 10;
            Indc[7].X = 80;
            Indc[7].Y = (Height / 2) + 20;
            Indc[8].X = 10;
            Indc[8].Y = (Height / 2) + 20;
            Indc[9].X = 10;
            Indc[9].Y = (Height / 2) + 10;

            g.FillPolygon(IndBrush, Indc);
            g.DrawPolygon(WhitePen, Indc);
        }
        public void Scale(Graphics g, Point Position, float AltiVal, int Height, int DistScale = 20)
        {
            var fontFamily = new FontFamily("Times New Roman");
            var font = new Font(fontFamily, 13, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            SolidBrush solidBrush;
            Pen pen = new Pen(Color.Black, 3);

            AltiVal *= 2;// untuk kalibrasi skala ketika antara skala +-2.5 nilai skala utama
            Matrix matrix = new Matrix();

            //Background
            g.ResetTransform();
            matrix.Translate(Position.X - 45, Position.Y + ((AltiVal / 10) * DistScale), MatrixOrder.Append);
            g.Transform = matrix;

            int transcount = (int)(AltiVal / 10);
            int DisplayScale = Height / DistScale - 2;
            for (int i = -DisplayScale / 2 + transcount; i < DisplayScale / 2 + 1 + transcount; i++)
            {
                solidBrush = new SolidBrush(Color.FromArgb(255, 3, 30, 37));
                if (i % 2 == 0)
                {
                    g.DrawLine(pen, 16, -(DistScale * i), 28, -(DistScale * i));/// Display scale value
                    g.DrawString((((i / 2) * 10)).ToString(), font, solidBrush, 45, -(DistScale * i), sf);
                }
                else
                {
                    g.DrawLine(pen, 16, -(DistScale * i), 24, -(DistScale * i));// Display half scale
                }
            }
        }
    }
}
