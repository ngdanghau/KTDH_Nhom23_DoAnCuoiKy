using KTDH_Nhom23_DoAnCuoiKy.Variables;
using System;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._2D
{
    class Line: Shape
    {
        internal Point First { get; set; }
        internal Point Last { get; set; }

        public Line(Point first, Point last)
        {
            if (Init.ModeCurrent == Constants.Mode._3DMode)
            {
                First = new Point(0, 0, 0);
                Last = new Point(0, 0, 0);
                First.X = first.X - Convert.ToInt32(Math.Ceiling(first.Z * 0.5));
                First.Y = first.Y - Convert.ToInt32(Math.Ceiling(first.Z * 0.5));
                Last.X = last.X - Convert.ToInt32(Math.Ceiling(last.Z * 0.5));
                Last.Y = last.Y - Convert.ToInt32(Math.Ceiling(last.Z * 0.5));
            }
            else
            {
                First = first;
                Last = last;
            }

            if (First == null || Last == null) return;
            if (First.X != Last.X)
            {
                List.Add(First);
                List.Add(Last);
            }
            else
            {
                List.Add(First);
                List.Add(Last);
            }
            Draw(First, Last);
        }

        private void Bresenham(int x1, int x2, int y1, int y2, double k, bool type = false)
        {
            int Dx = x2 - x1;
            int Dy = y2 - y1;
            int P = 2 * Dy - Dx;
            int y = y1;
            double yr = Convert.ToDouble(y);
            for (int i = x1 + 1; i < x2; i++)
            {
                yr += k;
                y = Convert.ToInt32(yr);
                if (P < 0)
                {
                    P += 2 * Dy;
                }
                else
                {
                    P += (2 * Dy - 2 * Dx);
                }
                if (type)
                    List.Add(new Point(y, i));
                else
                    List.Add(new Point(i, y));
            }

        }

        public void Draw(Point first1, Point last1)
        {
            if (first1.X == last1.X)
            {
                int i = first1.Y;
                while (i != last1.Y)
                {
                    if (first1.Y > last1.Y)
                        i--;
                    else
                        i++;
                    List.Add(new Point(first1.X, i));
                }
                return;
            }
            else
            {
                double k = GetK(first1, last1);
                int x1, x2, y1, y2;
                bool type = false;
                if (k > 1)
                {
                    type = true;
                    k = 1.0 / k;
                    if (first1.X > last1.X)
                    {

                        x1 = last1.Y;
                        x2 = first1.Y;
                        y1 = last1.X;
                        y2 = first1.X;
                    }
                    else
                    {
                        x2 = last1.Y;
                        x1 = first1.Y;
                        y2 = last1.X;
                        y1 = first1.X;
                    }
                }
                else if (k >= 0 && k <= 1)
                {
                    //k = 1-k;
                    if (first1.X > last1.X)
                    {

                        y1 = last1.Y;
                        y2 = first1.Y;
                        x1 = last1.X;
                        x2 = first1.X;
                    }
                    else
                    {
                        y2 = last1.Y;
                        y1 = first1.Y;
                        x2 = last1.X;
                        x1 = first1.X;
                    }
                }
                else if (k >= -1 && k < 0)
                {
                    //k = -1* k;
                    if (first1.X > last1.X)
                    {

                        y1 = last1.Y;
                        y2 = first1.Y;
                        x1 = last1.X;
                        x2 = first1.X;
                    }
                    else
                    {
                        y2 = last1.Y;
                        y1 = first1.Y;
                        x2 = last1.X;
                        x1 = first1.X;
                    }
                }
                else
                {
                    type = true;
                    k = 1.0 / k;
                    if (first1.X > last1.X)
                    {

                        x2 = last1.Y;
                        x1 = first1.Y;
                        y2 = last1.X;
                        y1 = first1.X;
                    }
                    else
                    {
                        x1 = last1.Y;
                        x2 = first1.Y;
                        y1 = last1.X;
                        y2 = first1.X;
                    }
                }
                Bresenham(x1, x2, y1, y2, k, type);
            }

        }

        public void Show(Graphics g, bool IsDash = false)
        {
            foreach (Point p in List)
                if(IsDash)
                    p.PutPixel(g, Init.zoom / 2);
                else
                    p.PutPixel(g);
        }

        public void Hide(Graphics g)
        {
            foreach (Point p in List)
                p.RemovePixel(g);
        }

        private double GetK(Point first1, Point last1)
        {
            return Convert.ToDouble(1.0 * (first1.Y - last1.Y) / (first1.X - last1.X));
        }

        public void Rotate(int degrees)
        {
            double a = (1.0 * degrees / 180) * Math.PI;
            List.Clear();
            First = PhepToan.Rotate(First, a);
            Last = PhepToan.Rotate(Last, a);
            List.Add(First);
            List.Add(Last);
            Draw(First, Last);
        }

        public void Scale(double ratio)
        {
            List.Clear();
            First = PhepToan.Scale(First, ratio, ratio, 0);
            Last = PhepToan.Scale(Last, ratio, ratio, 0);
            List.Add(First);
            List.Add(Last);
            Draw(First, Last);
        }

        public void Reflection(int type)
        {
            List.Clear();
            First = PhepToan.Reflection(First, type);
            Last = PhepToan.Reflection(Last, type);
            List.Add(First);
            List.Add(Last);
            Draw(First, Last);
        }

        public void Translation(double trX, double trY)
        {
            List.Clear();
            First = PhepToan.Translation(First, trX, trY, 0);
            Last = PhepToan.Translation(Last, trX, trY, 0);
            List.Add(First);
            List.Add(Last);
            Draw(First, Last);
        }
    }
}
