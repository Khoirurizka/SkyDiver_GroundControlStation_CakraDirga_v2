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
    class CompassPOV
    {
        public void BG(Graphics g, Point Position, int Width)
        {
            var BGsolidBrush = new SolidBrush(Color.FromArgb(160, 120, 120, 120));
            Pen pen = new Pen(Color.Black, 3);

            Matrix matrix = new Matrix();
            g.ResetTransform();
            matrix.Translate(Position.X, Position.Y - 15, MatrixOrder.Append);
            g.Transform = matrix;
            //Background
            g.FillRectangle(BGsolidBrush, (-Width / 2), -0, (Width / 2) - 10, 30);
            g.FillRectangle(BGsolidBrush, 10, -0, (Width / 2) - 10, 30);
            g.DrawLine(pen, (-Width / 2), 1, (Width / 2), 1);
        }
        public void Indicator(Graphics g, Point Position, int Width)
        {
            var IndBrush = new SolidBrush(Color.FromArgb(80, 23, 71, 79));

            Matrix matrix = new Matrix();
            g.ResetTransform();
            matrix.Translate(Position.X, Position.Y - 15, MatrixOrder.Append);
            g.Transform = matrix;
            //Background
            g.FillRectangle(IndBrush, -10, 0, 20, 30);
        }
        public void Scale(Graphics g, Point Position, float CompassVal, int DistScale = 20, int DisplayScale = 31)
        {
            var fontFamily = new FontFamily("Times New Roman");
            var font = new Font(fontFamily, 13, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            Pen pen = new Pen(Color.Black, 3);
            SolidBrush solidBrush;

            CompassVal *= 2;// untuk kalibrasi skala ketika antara skala +-2.5 nilai skala utama
            Matrix matrix = new Matrix();

            //Background
            g.ResetTransform();
            matrix.Translate( Position.X - ((CompassVal / 10) * DistScale),Position.Y - 15, MatrixOrder.Append);
            g.Transform = matrix;

            int transcount = (int)(CompassVal / 10);
            for (int i = -DisplayScale / 2 + transcount; i < DisplayScale / 2 + 1 + transcount; i++)
            {

                solidBrush = new SolidBrush(Color.FromArgb(255, 3, 30, 37));

                if (i % 2 == 0)
                {                    
                    g.DrawLine(pen,  (DistScale * i),0,  (DistScale * i),12);
                    /// Display scale value
                    if (i >= 0)
                    {
                        if (((i / 2) * 10) % 360 == 0)
                        {
                            g.DrawString("N", font, solidBrush, (DistScale * i), 20, sf);

                        }
                        else if ((((i / 2) * 10) % 360) / 90 == 1 && (((i / 2) * 10) % 360) % 90 == 0)
                        {
                            g.DrawString("E", font, solidBrush, (DistScale * i), 20, sf);

                        }
                        else if ((((i / 2) * 10) % 360) / 180 == 1 && (((i / 2) * 10) % 360) % 180 == 0)
                        {
                            g.DrawString("S", font, solidBrush, (DistScale * i), 20, sf);

                        }
                        else if ((((i / 2) * 10) % 360) / 270 == 1 && (((i / 2) * 10) % 360) % 270 == 0)
                        {
                            g.DrawString("W", font, solidBrush, (DistScale * i), 20, sf);

                        }
                        else
                        {
                            g.DrawString((((i / 2) * 10) % 360).ToString(), font, solidBrush, (DistScale * i), 20, sf);
                        }
                    }
                    else
                    {
                        if (((i / 2) * 10) % 360 == 0)
                        {
                            g.DrawString("N", font, solidBrush, (DistScale * i), 20, sf);

                        }
                        else if ((((i / 2) * 10) % 360) / 90 == -1 && (((i / 2) * 10) % 360) % 90 == 0)
                        {
                            g.DrawString("W", font, solidBrush, (DistScale * i), 20, sf);

                        }
                        else if ((((i / 2) * 10) % 360) / 180 == -1 && (((i / 2) * 10) % 360) % 180 == 0)
                        {
                            g.DrawString("S", font, solidBrush,  (DistScale * i), 20, sf);

                        }
                        else if ((((i / 2) * 10) % 360) / 270 == -1 && (((i / 2) * 10) % 360) % 270 == 0)
                        {
                            g.DrawString("E", font, solidBrush, (DistScale * i), 20, sf);

                        }
                        else
                        {
                            g.DrawString((360 + ((i / 2) * 10) % 360).ToString(), font, solidBrush, (DistScale * i), 20, sf);//- ((CompassVal / 10) * DistScale)
                        }
                    }
                }
                else
                {
                    g.DrawLine(pen, -1 + (DistScale * i), 0, -1 + (DistScale * i), 8);// Display half scale
                }
            }
        }
    }
}
