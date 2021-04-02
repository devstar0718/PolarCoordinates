using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PolarCoordinates
{
    public partial class Form1 : Form
    {
        private float sizePlatform = 600;
        private Pen penPlatformTemplate = new Pen(Color.Green, 1);
        private Pen penPlatformFore = new Pen(Color.Green, 3);
        private Pen penPlatformLine = new Pen(Color.Green, 2);
        private Pen penArmTemplate = new Pen(Color.Blue, 1);
        private Pen penArmFore = new Pen(Color.Blue, 3);
        private Pen penArmLine = new Pen(Color.Blue, 2);
        private Pen penMainTemplate = new Pen(Color.Red, 1);
        private Pen penMainFore = new Pen(Color.Red, 3);
        private Pen penMainLine = new Pen(Color.Red, 2);
        private Pen penOrgTemplate = new Pen(Color.Black, 1);
        private Pen penOrgFore = new Pen(Color.Black, 3);
        private Pen penOrgLine = new Pen(Color.Black, 2);
        private Point[] orgPoints = new Point[2];
        private List<PolarPoint> polarPoints = new List<PolarPoint>();
        private Point curPoint = new Point();
        public Form1()
        {
            InitializeComponent();
            orgPoints[0] = new Point(-100, -100);
            orgPoints[1] = new Point(-100, -100);
            curPoint = new Point(-100, -100);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.ScaleTransform(1 / sizePlatform * pictureBox1.Width, -1 / sizePlatform * pictureBox1.Height);
            graphics.TranslateTransform(0, -1 * sizePlatform);
            drawTemplates(graphics);
            if(orgPoints[0].X > 0 && orgPoints[0].Y > 0)
            {
                drawOrgPoint(graphics);
            }
            if(polarPoints.Count > 0)
            {
                drawPolarPoints(graphics);
            }
        }
        private void drawPolarPoints(Graphics graphics)
        {
            float r1 = sizePlatform / (float)Math.Sqrt(2);
            for (int i = 0; i < polarPoints.Count; i ++)
            {
                double piAngle = polarPoints[i].AngleArm / 180 * Math.PI;
                float x = (float)Math.Cos(piAngle) * r1;
                float y = (float)Math.Sin(piAngle) * r1;
                graphics.DrawEllipse(penMainFore, x - 5, y - 5, 10, 10);
                //graphics.DrawString((i + 1).ToString(), new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(Color.Black), x, y);
                //graphics.DrawLine(penPlatformLine, sizePlatform / 2, sizePlatform / 2, x, y);
                graphics.DrawLine(penArmLine, 0, 0, x, y);
                labelPlatformAngle.Text = Math.Round(polarPoints[i].AnglePlatform, 2).ToString();
                labelArmAngle.Text = Math.Round(polarPoints[i].AngleArm, 2).ToString();
                drawPolarLine(graphics, polarPoints[i].AnglePlatform);
            }
        }
        private void drawPolarLine(Graphics graphics, double angleCur)
        {
            double angle1_org = calculateAngle(orgPoints[0]);
            double angle2_org = calculateAngle(orgPoints[1]);
            double angleCur_org = calculateAngle(curPoint);
            double angle1 = angle1_org + angleCur - angleCur_org;
            double angle2 = angle2_org + angleCur - angleCur_org;
            Point p1 = rotatedPoint(orgPoints[0], angle1);
            Point p2 = rotatedPoint(curPoint, angleCur);
            Point p3 = rotatedPoint(orgPoints[1], angle2);
            graphics.DrawLine(penMainLine, p1, p2);
            graphics.DrawLine(penOrgLine, p2, p3);
        }
        private int linePointY(int x)
        {
            if (orgPoints[1].X == orgPoints[0].X) return 0;
            double d = (orgPoints[1].Y - orgPoints[0].Y) * 1.0 / (orgPoints[1].X - orgPoints[0].X);
            double y = orgPoints[0].Y + (x - orgPoints[0].X) * d;
            return (int)y;
        }
        private double calculateAngle(Point point)
        {
            int x = point.X - (int)sizePlatform / 2;
            int y = point.Y - (int)sizePlatform / 2;
            double angle = Math.Atan(y * 1.0 / x) / Math.PI * 180;
            if(x < 0 && y >= 0)
            {
                angle = angle + 180;
            }
            if(x > 0 && y < 0)
            {
                angle = angle + 360;
            }
            if(x < 0 && y < 0)
            {
                angle = angle + 180;
            }
            return angle;
        }
        private Point rotatedPoint(Point point, double angle)
        {
            float r = (float)Math.Sqrt(Math.Pow(point.X - sizePlatform / 2, 2) + Math.Pow(point.Y - sizePlatform / 2, 2));
            float x1 = (float)Math.Cos(angle * Math.PI / 180) * r + sizePlatform / 2;
            float y1 = (float)Math.Sin(angle * Math.PI / 180) * r + sizePlatform / 2;
            return new Point((int)x1, (int)y1);
        }
        private void drawOrgPoint(Graphics graphics)
        {
            float r2 = (float)Math.Sqrt(Math.Pow(curPoint.X - sizePlatform / 2, 2) + Math.Pow(curPoint.Y - sizePlatform / 2, 2));
            if (CBMainRange.Checked)
            {
                graphics.DrawEllipse(penOrgTemplate, sizePlatform / 2 - r2, sizePlatform / 2 - r2, r2 * 2, r2 * 2);
                graphics.DrawEllipse(penOrgFore, curPoint.X - 5, curPoint.Y - 5, 10, 10);
                graphics.DrawLine(penOrgLine, orgPoints[0], orgPoints[1]);
            }
        }
        private void drawTemplates(Graphics graphics)
        {
            if (CBPlatformRange.Checked)
            {
                //graphics.DrawLine(penPlatformTemplate, 0, sizePlatform / 2, sizePlatform, sizePlatform / 2);
                //graphics.DrawLine(penPlatformTemplate, sizePlatform / 2, 0, sizePlatform / 2, sizePlatform);
                foreach(PolarPoint polarPoint in polarPoints)
                {
                    double angle = polarPoint.AnglePlatform;
                    float x = (float)Math.Cos(angle / 180 * Math.PI) * sizePlatform / 2 + sizePlatform / 2;
                    float y = (float)Math.Sin(angle / 180 * Math.PI) * sizePlatform / 2 + sizePlatform / 2;
                    graphics.DrawLine(penPlatformLine, x, y, -x + sizePlatform, -y + sizePlatform);

                    angle = polarPoint.AnglePlatform - 90;
                    x = (float)Math.Cos(angle / 180 * Math.PI) * sizePlatform / 2 + sizePlatform / 2;
                    y = (float)Math.Sin(angle / 180 * Math.PI) * sizePlatform / 2 + sizePlatform / 2;
                    graphics.DrawLine(penPlatformLine, x, y, -x + sizePlatform, -y + sizePlatform);
                }
                graphics.DrawEllipse(penPlatformTemplate, 0, 0, sizePlatform, sizePlatform);
                graphics.DrawEllipse(penPlatformFore, sizePlatform / 2 - 5, sizePlatform / 2 - 5, 10, 10);
            }
            float r1 = sizePlatform / (float)Math.Sqrt(2);
            if (CBArmRange.Checked)
            {
                graphics.DrawEllipse(penArmTemplate, -r1, -r1, r1 * 2, r1 * 2);
                graphics.DrawEllipse(penArmFore, -5, -5, 10, 10);
            }
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                readSettings();
                pictureBox1.Invalidate();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void readSettings()
        {
            sizePlatform = (float)NUDSize.Value;
            orgPoints[0].X = (int)NUDX1.Value;
            orgPoints[0].Y = (int)NUDY1.Value;
            if (orgPoints[0].X > sizePlatform || orgPoints[0].Y > sizePlatform)
                return;
            orgPoints[1].X = (int)NUDX2.Value;
            orgPoints[1].Y = (int)NUDY2.Value;
            if (orgPoints[1].X > sizePlatform || orgPoints[1].Y > sizePlatform)
                return;
            if(orgPoints[0].X > orgPoints[1].X)
            {
                Point temp = new Point();
                temp.X = orgPoints[0].X;
                temp.Y = orgPoints[0].Y;
                orgPoints[0].X = orgPoints[1].X;
                orgPoints[0].Y = orgPoints[1].Y;
                orgPoints[1].X = temp.X;
                orgPoints[1].Y = temp.Y;
            }
        }
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                readSettings();
                if(orgPoints[0].X == orgPoints[1].X)
                {
                    MessageBox.Show("Please input different X values");
                    return;
                }
                trackBar1.Minimum = orgPoints[0].X;
                trackBar1.Maximum = orgPoints[1].X;
                trackBar1.Value = trackBar1.Minimum;
                setTrackPos(trackBar1.Minimum);
                buttonSimulate.Enabled = true ;
                trackBar1.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CBSettings_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            setTrackPos(trackBar1.Value);
        }
        private void setTrackPos(int val)
        {
            curPoint.X = val;
            curPoint.Y = linePointY(curPoint.X);
            Conversion conversion = new Conversion(sizePlatform / 2, RBTop.Checked);
            polarPoints = conversion.CatisionToPolar(curPoint);
            pictureBox1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(trackBar1.Value == trackBar1.Maximum)
            {
                timer1.Stop();
                return;
            }
            trackBar1.Value++;
            pictureBox1.Invalidate();
        }

        private void buttonSimulate_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            trackBar1.Value = trackBar1.Minimum;
            timer1.Start();
        }
    }
    public class Conversion
    {
        private double radiusPlatform = 400;
        private double radiusArm;
        private double sqrt2 = Math.Sqrt(2);
        private bool TopShow;
        public Conversion(double rPlat = 400, bool isTop = true)
        {
            radiusPlatform = rPlat;
            radiusArm = sqrt2 * rPlat;
            TopShow = isTop;
        }
        public List<PolarPoint> CatisionToPolar(Point pos)
        {
            double r1 = radiusArm;
            double r2 = Math.Sqrt(Math.Pow(pos.X - radiusPlatform, 2) + Math.Pow(pos.Y - radiusPlatform, 2));
            if (r2 > r1 * 2)
            {
                Console.WriteLine("Platform Radius must be lower than double of Arm Radius");
                return null;
            }
            double[] sinPlatAngle = new double[1];
            double sqrtUP = Math.Sqrt(2 - Math.Pow(r2 / r1, 2) / 2);
            if(TopShow)
                sinPlatAngle[0] = (-1 / sqrt2 * r2 / r1 + sqrtUP) / 2;
            else
                sinPlatAngle[0] = (-1 / sqrt2 * r2 / r1 - sqrtUP) / 2;
            //sinPlatAngle[1] = (-1 / sqrt2 * r2 / r1 - sqrtUP) / 2;
            //sinPlatAngle[2] = (1 / sqrt2 * r2 / r1 + sqrtUP) / 2;
            //sinPlatAngle[3] = (1 / sqrt2 * r2 / r1 - sqrtUP) / 2;
            List<PolarPoint> listAngles = new List<PolarPoint>();
            foreach(double sinP in sinPlatAngle)
            {
                if (Math.Abs(sinP) > 1) continue;
                double sinA = sinP * r2 / r1 + 1 / sqrt2;
                if (Math.Abs(sinA) > 1) continue;
                PolarPoint polarPoint;
                polarPoint.AngleArm = Math.Asin(sinA) * 180 / Math.PI;
                polarPoint.AnglePlatform = Math.Asin(sinP) * 180 / Math.PI;
                if (polarPoint.AnglePlatform > 0)
                    polarPoint.AnglePlatform = 180 - polarPoint.AnglePlatform;
                //Console.WriteLine("AngleArm = {0}, AnglePlatform = {1}", polarPoint.AngleArm, polarPoint.AnglePlatform);
                listAngles.Add(polarPoint);
            }
            //Console.WriteLine("--------------------------------------------------");
            return listAngles;
        }
    }
    public struct PolarPoint
    {
        public double AngleArm;
        public double AnglePlatform;
    }
}
