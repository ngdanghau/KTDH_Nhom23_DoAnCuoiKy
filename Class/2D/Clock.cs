using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._2D
{
    class Clock : Shape
    {

        internal Point O { get; set; }
        public double Radius { get; set; }
        public List<Line> Hour = new List<Line>();
        public List<Line> Minute = new List<Line>();
        public List<Line> Second = new List<Line>();
        public Graphics G { get; set; }


        internal Point A { get; set; }
        internal Point B { get; set; }
        internal Point C { get; set; }
        internal Timer time { get; set; } = new Timer();

        //timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            foreach (Line n in Hour) n.Hide(G);
            foreach (Line n in Minute) n.Hide(G);
            foreach (Line n in Second) n.Hide(G);
            DrawClock();
            foreach (Line n in Hour) n.Show(G);
            foreach (Line n in Minute) n.Show(G);
            foreach (Line n in Second) n.Show(G);
        }

        public Clock(Point c, double r)
        {
            O = c;
            Radius = r;
            MidPoint();
            Move();
            List.Add(O);

            DrawClock();

            foreach (Line line in Hour) List.AddRange(line.List);
            foreach (Line line in Minute) List.AddRange(line.List);
            foreach (Line line in Second) List.AddRange(line.List);
            Remove();
        }

        public void MidPoint()
        {
            int x = 0;
            int y = Convert.ToInt32(Radius);
            int maxX = Convert.ToInt32(Math.Sqrt(2) / 2 * Radius);
            double P = 1 - Radius;

            while (x <= maxX)
            {
                if (P < 0)
                    P += 2 * x + 3;
                else
                {
                    P += 2 * (x - y) + 5;
                    y--;
                }
                Point p = new Point(x, y);
                List.Add(p);
                Clone(p);
                x++;

            }
        }

        private void Clone(Point p)
        {
            List.Add(new Point(-1 * p.X, p.Y));
            List.Add(new Point(p.X, -1 * p.Y));
            List.Add(new Point(-1 * p.X, -1 * p.Y));
            List.Add(new Point(p.Y, p.X));
            List.Add(new Point(-1 * p.Y, p.X));
            List.Add(new Point(p.Y, -1 * p.X));
            List.Add(new Point(-1 * p.Y, -1 * p.X));

        }
        public void Move()
        {
            foreach (Point p in List)
            {
                p.X += O.X;
                p.Y = O.Y - p.Y;
            }
        }


        public void DrawClock()
        {
            var CurDate = DateTime.Now;
            int h = ((CurDate.Hour + 11) % 12);
            int m = CurDate.Minute;
            int s = CurDate.Second;
            double a, b, c;
            if (-1 < h && h < 6) a = PhepToan.ConvertDegreesToRadian(Convert.ToInt32(210 + h * 30));
            else a = PhepToan.ConvertDegreesToRadian(Convert.ToInt32((h - 5) * 30));

            if (0 < m && m < 31)
            {
                b = PhepToan.ConvertDegreesToRadian(Convert.ToInt32(186 + m * 6));
                c = PhepToan.ConvertDegreesToRadian(Convert.ToInt32(186 + s * 6));
            }
            else
            {
                b = PhepToan.ConvertDegreesToRadian(Convert.ToInt32((m - 30) * 6));
                c = PhepToan.ConvertDegreesToRadian(Convert.ToInt32((s - 30) * 6));
            }

            A = new Point(O.X, Convert.ToInt32(O.Y + Radius / 2));
            B = new Point(O.X, Convert.ToInt32(O.Y + Radius / 1.3));
            C = new Point(O.X, Convert.ToInt32(O.Y + Radius));
            Hour.Add(new Line(O, PhepToan.CenterRotate(A, O, a)));
            Minute.Add(new Line(O, PhepToan.CenterRotate(B, O, b)));
            Second.Add(new Line(O, PhepToan.CenterRotate(C, O, c)));
        }
        public void Show(Graphics g)
        {
            foreach (Line n in Hour) n.Show(g);
            foreach (Line n in Minute) n.Show(g);
            foreach (Line n in Second) n.Show(g);

            G = g;
            time.Interval = 1000;
            time.Tick += new EventHandler(t_Tick);
        }

        public void Hide(Graphics g)
        {

            foreach (var item in List)
            {
                item.RemovePixel(g);
            }
        }

        private void Remove()
        {
            List.Remove(A);
            List.Remove(B);
            List.Remove(C);
        }
    }
}
