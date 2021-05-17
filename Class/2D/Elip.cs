using KTDH_Nhom23_DoAnCuoiKy.Variables;
using System;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._2D
{
    class Elip: Shape
    {
        internal Point Center { get; set; }
        public int MajorAxis { get; set; }
        public int MinorAxis { get; set; }

        public Elip(Point o, int a, int b)
        {
            Center = o;
            MajorAxis = a;
            MinorAxis = b;
            MidPoint();
            Move();
            List.Add(Center);

        }
        private void MidPoint()
        {
            double P = Math.Pow(MinorAxis, 2) - Math.Pow(MajorAxis, 2) * MinorAxis + Math.Pow(MajorAxis, 2) / 4;
            int y = MinorAxis;
            int x = 0;
            int Dx = 0;
            int Dy = 2 * MajorAxis * MajorAxis * y;
            Point p1 = new Point(x, y);
            List.Add(p1);
            Clone(p1);
            while (Dx < Dy)
            {
                x++;
                Dx += 2 * MinorAxis * MinorAxis;
                if (P < 0)
                {
                    P += (Math.Pow(MinorAxis, 2) + Dx);
                }
                else
                {
                    y--;
                    Dy -= 2 * MajorAxis * MajorAxis;
                    P += (Math.Pow(MinorAxis, 2) + Dx - Dy);

                }
                Point p = new Point(x, y);
                List.Add(p);
                Clone(p);
            }
            double Q = Math.Pow(MinorAxis, 2) * Math.Pow((x + 0.5f), 2) + Math.Pow(MajorAxis, 2) * Math.Pow((y - 1), 2) - Math.Pow(MinorAxis, 2) * Math.Pow(MajorAxis, 2);
            while (y > 0)
            {
                y--;
                Dy -= MajorAxis * MajorAxis * 2;
                if (Q < 0)
                {
                    x++;
                    Dx += MinorAxis * MinorAxis * 2;
                    Q += (Math.Pow(MajorAxis, 2) - Dy + Dx);

                }
                else
                {
                    Q += (Math.Pow(MajorAxis, 2) - Dy);

                }
                Point p = new Point(x, y);
                List.Add(p);
                Clone(p);
            }
        }

        public void Move()
        {
            foreach (Point p in List)
            {
                p.X += Center.X;
                p.Y = Center.Y - p.Y;
            }
        }

        public void Show(Graphics g)
        {
            foreach (var item in List)
            {
                item.PutPixel(g);
            }
        }

        public void ShowElip(Graphics g, bool vertical = true)
        {
            foreach (var item in List)
            {
                if (vertical)
                {
                    if (item.X > Center.X)
                        item.PutPixel(g, Init.zoom / 2);
                    else
                        item.PutPixel(g);
                }
                else
                {
                    if (item.Y > Center.Y)
                        item.PutPixel(g, Init.zoom / 2);
                    else
                        item.PutPixel(g);
                }
                
            }
        }

        public void Hide(Graphics g)
        {
            foreach (var item in List)
            {
                item.RemovePixel(g);
            }
        }

        private void Clone(Point p)
        {
            List.Add(new Point(-1 * p.X, p.Y));
            List.Add(new Point(p.X, -1 * p.Y));
            List.Add(new Point(-1 * p.X, -1 * p.Y));
        }

        public void Rotate(int degrees)
        {
            List.Clear();
            double a = (1.0 * degrees / 180) * Math.PI;
            Center = PhepToan.Rotate(Center, a);
            MidPoint();
            Move();
            List.Add(Center);
        }

        public void Scale(double ratio)
        {
            List.Clear();
            Center = PhepToan.Scale(Center, ratio, ratio, 0);
            MajorAxis = Convert.ToInt32(MajorAxis * ratio);
            MinorAxis = Convert.ToInt32(MinorAxis * ratio);
            MidPoint();
            Move();
            List.Add(Center);
        }

        public void Reflection(int type)
        {
            List.Clear();
            Center = PhepToan.Reflection(Center, type);
            MidPoint();
            Move();
            List.Add(Center);
        }

        public void Translation(double trX, double trY)
        {
            List.Clear();
            Center = PhepToan.Translation(Center, trX, trY, 0);
            MidPoint();
            Move();
            List.Add(Center);
        }

    }
}
