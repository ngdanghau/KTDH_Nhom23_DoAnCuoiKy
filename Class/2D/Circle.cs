﻿using System;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._2D
{
    class Circle: Shape
    {
        Point center;
        double radius;
        internal Point Center { get => center; set => center = value; }
        public double Radius { get => radius; set => radius = value; }

        public Circle(Point c, double r)
        {
            center = c;
            radius = r;
            MidPoint();
            Move();
            List.Add(Center);
        }

        private void MidPoint()
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

        public void Hide(Graphics g)
        {
            foreach (var item in List)
            {
                item.RemovePixel(g);
            }
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
            Radius = Radius * ratio;
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
