using KTDH_Nhom23_DoAnCuoiKy.Class._2D;
using System;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._3D
{
    class Sphere
    {

        public double Radius { get; set; }
        internal Point Center { get; set; }
        internal Circle C1 { get; set; }
        internal Elip E1 { get; set; }
        internal Elip E2 { get; set; }

        public Sphere(Point o, double r)
        {
            Center = o;
            Radius = r;
            int x1 = Center.X - Convert.ToInt32(Math.Ceiling(Center.Z * 0.5));
            int y1 = Center.Y - Convert.ToInt32(Math.Ceiling(Center.Z * 0.5));
            Point O1 = new Point(x1, y1);
            C1 = new Circle(O1, Radius);
            E1 = new Elip(O1, Convert.ToInt32(Radius / 3), Convert.ToInt32(Radius));
            E2 = new Elip(O1, Convert.ToInt32(Radius), Convert.ToInt32(Radius / 3));
        }

        public void Show(Graphics g)
        {
            Center.PutPixel(g);
            C1.Show(g);
            E1.ShowElip(g);
            E2.ShowElip(g, false);
        }
    }
}
