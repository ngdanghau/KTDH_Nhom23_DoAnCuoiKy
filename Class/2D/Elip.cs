﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._2D
{
    class Elip: Shape
    {
        private int a;
        private int b;
        Point center;

        internal Point Center { get => center; set => center = value; }
        public int MajorAxis { get => a; set => a = value; }
        public int MinorAxis { get => b; set => b = value; }

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
            Center.PutPixel(g);
            foreach (var item in List)
            {
                item.PutPixel(g);
            }
        }

        public void Hide(Graphics g)
        {
            Center.RemovePixel(g);
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
       
    }
}
