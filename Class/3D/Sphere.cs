using KTDH_Nhom23_DoAnCuoiKy.Class._2D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._3D
{
    class Sphere
    {
        private Point o;
        private double r;
        private Circle c1;
        private Elip e1;
        private Elip e2;

        public double Radius { get => r; set => r = value; }
        internal Point Center { get => o; set => o = value; }
        internal Circle C1 { get => c1; set => c1 = value; }
        internal Elip E1 { get => e1; set => e1 = value; }
        internal Elip E2 { get => e2; set => e2 = value; }

        public Sphere(Point o, double r)
        {
            Center = o;
            Radius = r;
            int x1 = Center.X - Convert.ToInt32(Math.Ceiling(Center.Z * 0.5));
            int y1 = Center.Y - Convert.ToInt32(Math.Ceiling(Center.Z * 0.5));
            Point O1 = new Point(x1, y1);
            c1 = new Circle(O1, Radius);
            E1 = new Elip(O1, Convert.ToInt32(Radius / 3), Convert.ToInt32(Radius));
            E2 = new Elip(O1, Convert.ToInt32(Radius), Convert.ToInt32(Radius / 3));
        }
        public void Show(Graphics g)
        {
            //Center.Show(g);
            C1.Show(g);
            //E1.Show1(g);
            //E2.Show2(g);
        }
    }
}
