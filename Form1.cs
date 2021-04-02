using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private Point pointOrg = new Point(-100, -100);
        private List<PolarPoint> polarPoints = new List<PolarPoint>();
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.ScaleTransform(1 / sizePlatform * pictureBox1.Width, -1 / sizePlatform * pictureBox1.Height);
            graphics.TranslateTransform(0, -1 * sizePlatform);
            drawTemplates(graphics);
            if(pointOrg.X > 0 && pointOrg.Y > 0)
            {
                drawOrgPoint(graphics);
            }
            if(polarPoints.Count > 0)
            {
                darwPolarPoints(graphics);
            }
        }
        private void darwPolarPoints(Graphics graphics)
        {
            float r1 = sizePlatform / (float)Math.Sqrt(2);
            for (int i = 0; i < polarPoints.Count; i ++)
            {
                double piAngle = polarPoints[i].AngleArm / 180 * Math.PI;
                float x = (float)Math.Cos(piAngle) * r1;
                float y = (float)Math.Sin(piAngle) * r1;
                graphics.DrawEllipse(penMainFore, x - 5, y - 5, 10, 10);
                graphics.DrawString((i + 1).ToString(), new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(Color.Black), x, y);
                graphics.DrawLine(penPlatformLine, sizePlatform / 2, sizePlatform / 2, x, y);
                graphics.DrawLine(penArmLine, 0, 0, x, y);
            }
        }
        private void drawOrgPoint(Graphics graphics)
        {
            float r2 = (float)Math.Sqrt(Math.Pow(pointOrg.X - sizePlatform / 2, 2) + Math.Pow(pointOrg.Y - sizePlatform / 2, 2));
            graphics.DrawEllipse(penMainTemplate, sizePlatform / 2 - r2, sizePlatform / 2 - r2, r2 * 2, r2 * 2);
            graphics.DrawEllipse(penMainFore, pointOrg.X - 5, pointOrg.Y - 5, 10, 10);
        }
        private void drawTemplates(Graphics graphics)
        {
            graphics.DrawLine(penPlatformTemplate, 0, sizePlatform / 2, sizePlatform, sizePlatform / 2);
            graphics.DrawLine(penPlatformTemplate, sizePlatform / 2, 0, sizePlatform / 2, sizePlatform);
            graphics.DrawEllipse(penPlatformTemplate, 0, 0, sizePlatform, sizePlatform);
            graphics.DrawEllipse(penPlatformFore, sizePlatform / 2 - 5, sizePlatform / 2 - 5, 10, 10);

            float r1 = sizePlatform / (float)Math.Sqrt(2);
            graphics.DrawEllipse(penArmTemplate, -r1, -r1, r1 * 2, r1 * 2);
            graphics.DrawEllipse(penArmFore, -5, -5, 10, 10);
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                sizePlatform = (float)NUDSize.Value;
                labelSize.Text = string.Format("{0} * {0}", sizePlatform);
                pointOrg.X = (int)NUDX.Value;
                pointOrg.Y = (int)NUDY.Value;
                if (pointOrg.X > sizePlatform || pointOrg.Y > sizePlatform)
                    return;
                pictureBox1.Invalidate();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            buttonDraw_Click(sender, e);
            Conversion conversion = new Conversion(sizePlatform / 2);
            polarPoints = conversion.CatisionToPolar(pointOrg);
            pictureBox1.Invalidate();
        }
    }
    public class Conversion
    {
        private double radiusPlatform = 400;
        private double radiusArm;
        private double sqrt2 = Math.Sqrt(2);
        public Conversion(double rPlat = 400)
        {
            radiusPlatform = rPlat;
            radiusArm = sqrt2 * rPlat;
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
            double[] sinPlatAngle = new double[2];
            double sqrtUP = Math.Sqrt(2 - Math.Pow(r2 / r1, 2) / 2);
            sinPlatAngle[0] = (-1 / sqrt2 * r2 / r1 + sqrtUP) / 2;
            sinPlatAngle[1] = (-1 / sqrt2 * r2 / r1 - sqrtUP) / 2;
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
                Console.WriteLine("AngleArm = {0}, AnglePlatform = {1}", polarPoint.AngleArm, polarPoint.AnglePlatform);
                listAngles.Add(polarPoint);
            }
            Console.WriteLine("--------------------------------------------------");
            return listAngles;
        }
    }
    public struct PolarPoint
    {
        public double AngleArm;
        public double AnglePlatform;
    }
}
