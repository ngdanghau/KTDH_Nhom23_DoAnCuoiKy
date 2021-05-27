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
            Point O1 = PhepToan.Cabinet(Center);
            C1 = new Circle(O1, Radius);
            var a = Convert.ToInt32(Radius);
            var b = Convert.ToInt32(Radius * (Math.Sqrt(2) / 4));
            E1 = new Elip(O1, b, a);
            E2 = new Elip(O1, a, b);
        }

        public void Show(Graphics g)
        {
            C1.Show(g);
            E1.ShowElip(g);
            E2.ShowElip(g, false);
        }

        public void Hide(Graphics g)
        {
            C1.Hide(g);
            E1.Hide(g);
            E2.Hide(g);
        }

        public void Scale(double ratio)
        {
            Center = PhepToan.Scale(Center, ratio, ratio, ratio);
            Radius = Radius * ratio;
            Point O1 = PhepToan.Cabinet(Center);
            C1 = new Circle(O1, Radius);
            var a = Convert.ToInt32(Radius);
            var b = Convert.ToInt32(Radius * (Math.Sqrt(2) / 4));
            E1 = new Elip(O1, b, a);
            E2 = new Elip(O1, a, b);
        }

        public void Translation(double trX, double trY, double trZ)
        {
            Center = PhepToan.Translation(Center, trX, trY, trZ);
            Point O1 = PhepToan.Cabinet(Center);
            C1 = new Circle(O1, Radius);

            var a = Convert.ToInt32(Radius);
            var b = Convert.ToInt32(Radius * (Math.Sqrt(2) / 4));
            E1 = new Elip(O1, b, a);
            E2 = new Elip(O1, a, b);
        }
    }
}
