using KTDH_Nhom23_DoAnCuoiKy.Class._2D;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._3D
{
    class Cone
    {
        public int ChieuCao { get; set; }
        public int Radius { get; set; }
        internal Elip E1 { get; set; }

        internal Point A { get; set; }
        internal Point B { get; set; }
        internal Point C { get; set; }
        internal Point D { get; set; }

        private List<Line> nega = new List<Line>();
        private List<Line> pose = new List<Line>();

        public Cone(Point O, int chieuCao, int r)
        {
            ChieuCao = chieuCao;
            Radius = r;
            A = O;
            B = new Point(O.X, O.Y + ChieuCao, O.Z, "B");
            C = new Point(O.X + Radius, O.Y, O.Z, "C");
            D = new Point(O.X - Radius, O.Y, O.Z, "D");

            nega.Add(new Line(A, B));
            nega.Add(new Line(A, C));

            pose.Add(new Line(B, C));
            pose.Add(new Line(B, D));


            Point O1 = PhepToan.Cabinet(O);
            E1 = new Elip(O1, Convert.ToInt32(Radius), Convert.ToInt32(Radius * (Math.Sqrt(2) / 4)));
        }

        public void Show(Graphics g)
        {

            E1.ShowElip(g, false);
            foreach (Line n in nega) n.Show(g, true);
            foreach (Line n in pose) n.Show(g);
        }

        public void Hide(Graphics g)
        {
            E1.Hide(g);
            foreach (Line n in nega) n.Hide(g);
            foreach (Line n in pose) n.Hide(g);
            nega.Clear();
            pose.Clear();
        }

        public void Scale(double ratio)
        {
            nega.Clear();
            pose.Clear();
            ChieuCao = Convert.ToInt32(ChieuCao * ratio);
            Radius = Convert.ToInt32(Radius * ratio);
            Point O = PhepToan.Scale(A, ratio, ratio, ratio);
            A = O;
            B = new Point(O.X, O.Y + ChieuCao, O.Z, "B");
            C = new Point(O.X + Radius, O.Y, O.Z, "C");
            D = new Point(O.X - Radius, O.Y, O.Z, "D");

            nega.Add(new Line(A, B));
            nega.Add(new Line(A, C));

            pose.Add(new Line(B, C));
            pose.Add(new Line(B, D));

            Point O1 = PhepToan.Cabinet(A);
            E1 = new Elip(O1, Convert.ToInt32(Radius), Convert.ToInt32(Radius * (Math.Sqrt(2) / 4)));
        }

        public void Translation(double trX, double trY, double trZ)
        {
            nega.Clear();
            pose.Clear();
            Point O = PhepToan.Translation(A, trX, trY, trZ);
            A = O;
            B = new Point(O.X, O.Y + ChieuCao, O.Z, "B");
            C = new Point(O.X + Radius, O.Y, O.Z, "C");
            D = new Point(O.X - Radius, O.Y, O.Z, "D");

            nega.Add(new Line(A, B));
            nega.Add(new Line(A, C));
            pose.Add(new Line(B, C));
            pose.Add(new Line(B, D));

            Point O1 = PhepToan.Cabinet(A);
            E1 = new Elip(O1, Convert.ToInt32(Radius), Convert.ToInt32(Radius * (Math.Sqrt(2) / 4)));
        }
    }
}
