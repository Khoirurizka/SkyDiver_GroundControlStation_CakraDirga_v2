using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SkyDiver_GCS
{
    class Gyro
    {
        public void BG(Graphics g, Point Position, int size, float rollVal, float pitchVal)
        {
            var skyBrush = new SolidBrush(Color.FromArgb(160, 39, 137, 224));
            var groundBrush = new SolidBrush(Color.FromArgb(160, 124, 73, 30));
            var borderBrush = new SolidBrush(Color.FromArgb(200, 0, 0, 0));
            Pen borderPen = new Pen(borderBrush, 3);

            float anglePitchLine;
            float angleDir;

            Matrix matrix = new Matrix();
            g.ResetTransform();
            matrix.RotateAt(rollVal, new Point(Position.X, Position.Y), MatrixOrder.Append);
            matrix.Translate(Position.X - (size / 2), Position.Y - (size / 2));
            g.Transform = matrix;

            pitchVal = (0 <= pitchVal) ? pitchVal : ((360*(int)(Math.Ceiling(-pitchVal/360))) +pitchVal);
            if ((0 <= pitchVal % 360 && pitchVal % 360 <= 90)/*I*/) 
            {
                anglePitchLine = (float)(Math.Asin(pitchVal / 90) * 57.2957795131);
                angleDir = 180;
            }
            else if((270 < pitchVal % 360 && pitchVal % 360 <= 360)/*IV*/){
                anglePitchLine = (float)(Math.Asin((pitchVal- 360) / 90) * 57.2957795131);
                angleDir = 180;
            }
            else
            {
                anglePitchLine = (float)(Math.Asin((pitchVal - 180) / 90) * 57.2957795131);
                angleDir = -180;
            }
            //Sky
            using (var p = new GraphicsPath())
            {
                p.AddArc(new Rectangle(0, 0, size, size), anglePitchLine, -angleDir - (2 * anglePitchLine));//-(2* -drawAngle)
                p.CloseFigure();
                g.FillPath(skyBrush, p);
            }
            //Ground
            using (var p = new GraphicsPath())
            {
                p.AddArc(new Rectangle(0, 0, size, size), anglePitchLine, angleDir - (2 * anglePitchLine));
                p.CloseFigure();
                g.FillPath(groundBrush, p);
            }
            g.DrawEllipse(borderPen, 0, 0, size, size);
        }
       
        public void Indicator(Graphics g, Point Position, int size, float rollVal)
        {
            var IndBrush = new SolidBrush(Color.FromArgb(200, 187, 0, 0));
            Pen IndPen = new Pen(IndBrush, 3);

            Matrix matrix = new Matrix();
            g.ResetTransform();
            matrix.RotateAt(rollVal, new Point(Position.X, Position.Y), MatrixOrder.Append);
            matrix.Translate(Position.X - (size / 2), Position.Y - (size / 2));

            g.Transform = matrix;

            g.DrawLine(IndPen, new Point(25, size/2), new Point(size / 2 - 20, size / 2));
            g.DrawLine(IndPen, new Point(size / 2 + 20, size / 2), new Point(size - 25, size / 2));
            PointF[] Triangle = new PointF[3];
            Triangle[0].X = size / 2-5;
            Triangle[0].Y = 35;
            Triangle[1].X = size / 2;
            Triangle[1].Y = 25;
            Triangle[2].X = size / 2+5;
            Triangle[2].Y = 35;
            g.FillPolygon(IndBrush, Triangle);
            PointF[] InvV = new PointF[3];
            InvV[0].X = size / 2-15;
            InvV[0].Y = size / 2+7;
            InvV[1].X = size / 2;
            InvV[1].Y = size / 2;
            InvV[2].X = size / 2+15;
            InvV[2].Y = size / 2+7;
            g.DrawLines(IndPen, InvV);
        }
        public void PitchScale(Graphics g, Point Position, int size, float rollVal, float PitchVal, int DistScale = 20)
        {
            var fontFamily = new FontFamily("Times New Roman");
            var font = new Font(fontFamily, 11, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            var scaleBrush = new SolidBrush(Color.FromArgb(200, 0, 0, 0));
            Pen scalePen = new Pen(scaleBrush, 2);

            PitchVal *= 2;// untuk kalibrasi skala ketika antara skala +-2.5 nilai skala utama
            Matrix matrix = new Matrix();

            //Background
            g.ResetTransform();
            matrix.RotateAt(rollVal, new Point(Position.X, Position.Y), MatrixOrder.Append);
            matrix.Translate(Position.X - (size / 2), Position.Y + ((PitchVal / 10) * DistScale));
            g.Transform = matrix;

            int transcount = (int)(PitchVal / 10);
            int DisplayScale = size / DistScale - 10;
            for (int i = -DisplayScale / 2 + transcount; i < DisplayScale / 2 + 1 + transcount; i++)
            {
                scaleBrush = new SolidBrush(Color.FromArgb(255, 3, 30, 37));
                if (i % 2 == 0)
                {
                    g.DrawLine(scalePen, (size / 2)-10, -(DistScale * i), (size / 2)+10, -(DistScale * i));/// Display scale value
                    g.DrawString((((i / 2) * 10)).ToString(), font, scaleBrush, (size / 2) - 25, -(DistScale * i)-6, sf);
                    g.DrawString((((i / 2) * 10)).ToString(), font, scaleBrush, (size / 2) + 25, -(DistScale * i)-6, sf);
                }
                else
                {
                    g.DrawLine(scalePen, (size / 2) - 5, -(DistScale * i), (size / 2) + 5, -(DistScale * i));// Display half scale
                }
            }
        }
        public void RollScale(Graphics g, Point Position, int size, float rollVal)
        {
            int mainScaleLength = 9;
            int halfScaleLength = 5;
            Point textPos = new Point((size / 2),18);

            var fontFamily = new FontFamily("Times New Roman");
            var font = new Font(fontFamily, 11, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            var scaleBrush = new SolidBrush(Color.FromArgb(200, 0, 0, 0));
            Pen scalePen = new Pen(scaleBrush, 2);

            Matrix matrix = new Matrix();
            g.ResetTransform();
            matrix.RotateAt(rollVal, new Point(Position.X, Position.Y), MatrixOrder.Append);
            matrix.Translate(Position.X - (size / 2), Position.Y - (size / 2));
            g.Transform = matrix;

            //RollMeter
            int transcount = (int)(rollVal / 5);
            for (int i = 0; i < 360; i+=5)
            {
                double angleRad=i* (Math.PI/180);
                if (i % 10 == 0)
                {
                    g.DrawLine(scalePen, (int)((((size / 2) - (size / 2)) * Math.Cos(angleRad)) - ((                - (size / 2)) * Math.Sin(angleRad)) + (size / 2)), (int)((((size / 2) - (size / 2)) * Math.Sin(angleRad)) + ((                - (size / 2)) * Math.Cos(angleRad)) + (size / 2))
                                       , (int)((((size / 2) - (size / 2)) * Math.Cos(angleRad)) - ((mainScaleLength - (size / 2)) * Math.Sin(angleRad)) + (size / 2)), (int)((((size / 2) - (size / 2)) * Math.Sin(angleRad)) + ((mainScaleLength - (size / 2)) * Math.Cos(angleRad)) + (size / 2)));// Display main scale
                }
                else
                {
                    g.DrawLine(scalePen, (int)((((size / 2) - (size / 2)) * Math.Cos(angleRad)) - ((               - (size / 2)) * Math.Sin(angleRad)) + (size / 2)), (int)((((size / 2) - (size / 2)) * Math.Sin(angleRad)) + ((                - (size / 2)) * Math.Cos(angleRad)) + (size / 2))
                                      , (int)((((size / 2) - (size / 2)) * Math.Cos(angleRad)) - ((halfScaleLength - (size / 2)) * Math.Sin(angleRad)) + (size / 2)), (int)((((size / 2) - (size / 2)) * Math.Sin(angleRad)) + ((halfScaleLength - (size / 2)) * Math.Cos(angleRad)) + (size / 2)));// Display half scale
                }
                if (i % 30 == 0)
                {
                    g.DrawString((i).ToString(), font, scaleBrush, (int)(((textPos .X- (size / 2)) * Math.Cos(angleRad)) - ((textPos.Y - (size / 2)) * Math.Sin(angleRad)) + (size / 2)), (int)(((textPos .X- (size / 2)) * Math.Sin(angleRad)) + ((textPos.Y - (size / 2)) * Math.Cos(angleRad)) + (size / 2)), sf);
                }
            }
        }
    }
}
