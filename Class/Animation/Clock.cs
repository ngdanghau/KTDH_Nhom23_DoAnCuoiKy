using KTDH_Nhom23_DoAnCuoiKy.UI.Animation;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._2D
{
    class Clock : Shape
    {
        public double Radius { get; set; }
        internal Point O { get; set; }
        internal Circle C1 { get; set; }
        public Line Hour { get; set; }
        public Line Minute { get; set; }
        public Line Second { get; set; }
        public Graphics G { get; set; }
        public Panel Panel { get; set; }


        internal Point A { get; set; }
        internal Point B { get; set; }
        internal Point C { get; set; }
        internal Timer time { get; set; } = new Timer();
        internal bool alreadyAdded { get; set; } = false;


        private void t_Tick(object sender, EventArgs e)
        {
            var CurDate = DateTime.Now;
            DrawClock(CurDate);
            PanelClock.Instance.HourO = "{X = " + Hour.First.X + ", Y = " + Hour.First.Y + "}";
            PanelClock.Instance.HourA = "{X = " + Hour.Last.X + ", Y = " + Hour.Last.Y + "}";
            PanelClock.Instance.MinuteO = "{X = " + Minute.First.X + ", Y = " + Minute.First.Y + "}";
            PanelClock.Instance.MinuteB = "{X = " + Minute.Last.X + ", Y = " + Minute.Last.Y + "}";
            PanelClock.Instance.SecondO = "{X = " + Second.First.X + ", Y = " + Second.First.Y + "}";
            PanelClock.Instance.SecondC = "{X = " + Second.Last.X + ", Y = " + Second.Last.Y + "}";
            Panel.Invalidate();
        }

        public Clock(Point c, double r)
        {
            Radius = r;
            O = c;
            C1 = new Circle(O, r);
            var CurDate = DateTime.Now;

            C = new Point(O.X, Convert.ToInt32(O.Y + Radius / 1.1));
            B = new Point(O.X, Convert.ToInt32(O.Y + Radius / 1.3));
            A = new Point(O.X, Convert.ToInt32(O.Y + Radius / 2));

            DrawClock(CurDate);
        }


        public void DrawClock(DateTime CurDate)
        {
            int h = ((CurDate.Hour + 11) % 12);
            int m = CurDate.Minute;
            int s = CurDate.Second;
            double a, b, c;
            if (-1 < h && h < 6) a = PhepToan.ConvertDegreesToRadian(Convert.ToInt32(210 + h * 30));
            else a = PhepToan.ConvertDegreesToRadian(Convert.ToInt32((h - 5) * 30));

            if ((0 < m && m < 31) || (0 < s && s < 31))
            {
                b = PhepToan.ConvertDegreesToRadian(Convert.ToInt32(186 + m * 6));
                c = PhepToan.ConvertDegreesToRadian(Convert.ToInt32(186 + s * 6));
            }
            else
            {
                b = PhepToan.ConvertDegreesToRadian(Convert.ToInt32((m - 30) * 6));
                c = PhepToan.ConvertDegreesToRadian(Convert.ToInt32((s - 30) * 6));
            }
            Hour = new Line(O, PhepToan.CenterRotate(A, O, a));
            Minute = new Line(O, PhepToan.CenterRotate(B, O, b));
            Second = new Line(O, PhepToan.CenterRotate(C, O, c));
        }
        public void Show(Graphics g, Panel panel)
        {

            C1.Show(g);
            Hour.Show(g);
            Minute.Show(g);
            Second.Show(g);
            if (alreadyAdded) return;
            alreadyAdded = true;
            Panel = panel;
            G = g;
            time.Interval = 1000;
            time.Tick += new EventHandler(t_Tick);
            time.Start();
        }

        public void Scale(double ratio)
        {
            O = PhepToan.Scale(O, ratio, ratio, ratio);
            Radius = Radius * ratio;
            C1 = new Circle(O, Radius);
            var CurDate = DateTime.Now;
            C = new Point(O.X, Convert.ToInt32(O.Y + Radius / 1.1));
            B = new Point(O.X, Convert.ToInt32(O.Y + Radius / 1.3));
            A = new Point(O.X, Convert.ToInt32(O.Y + Radius / 2));
            DrawClock(CurDate);
        }

        public void Translation(double trX, double trY)
        {
            O = PhepToan.Translation(O, trX, trY, 0);
            C1 = new Circle(O, Radius);
            var CurDate = DateTime.Now;
            C = new Point(O.X, Convert.ToInt32(O.Y + Radius / 1.1));
            B = new Point(O.X, Convert.ToInt32(O.Y + Radius / 1.3));
            A = new Point(O.X, Convert.ToInt32(O.Y + Radius / 2));
            DrawClock(CurDate);

        }
    }
}
