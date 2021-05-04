using KTDH_Nhom23_DoAnCuoiKy.Class._2D;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._3D
{
    class Cylinder
    {
        public int ChieuCao { get; set; }
        public int Radius { get; set; }
        internal Elip E1 { get; set; }
        internal Elip E2 { get; set; }

        internal Point A { get; set; }
        internal Point B { get; set; }
        internal Point C { get; set; }
        internal Point D { get; set; }
        internal Point E { get; set; }
        internal Point F { get; set; }

        private List<Line> nega = new List<Line>();
        private List<Line> pose = new List<Line>();

        public Cylinder(Point O, int chieuCao, int r)
        {
            ChieuCao = chieuCao;
            Radius = r;
            B = O;
            A = new Point(O.X - Radius, O.Y, O.Z, "A");
            C = new Point(O.X + Radius, O.Y, O.Z, "C");
            D = new Point(O.X - Radius, O.Y + ChieuCao, O.Z, "D");
            E = new Point(O.X, O.Y + ChieuCao, O.Z, "E");
            F = new Point(O.X + Radius, O.Y + ChieuCao, O.Z, "F");

            nega.Add(new Line(E, B));
            nega.Add(new Line(B, C));

            pose.Add(new Line(E, F));
            pose.Add(new Line(F, C));
            pose.Add(new Line(A, D));

            E1 = new Elip(B, Convert.ToInt32(Radius), Convert.ToInt32(Radius / 3));
            E2 = new Elip(E, Convert.ToInt32(Radius), Convert.ToInt32(Radius / 3));
        }

        public void Show(Graphics g)
        {
            E1.ShowElip(g, false);
            E2.Show(g);

            foreach (Line n in nega)
            {
                n.Show(g, true);
            }

            foreach (Line n in pose)
            {
                n.Show(g);
            }
        }
    }
}
