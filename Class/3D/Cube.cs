using KTDH_Nhom23_DoAnCuoiKy.Class._2D;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._3D
{
    class Cube
    {
        private Point a, b, c, d, e, f, g, h;
        private int canh;
        private List<Line> nega = new List<Line>();
        private List<Line> pose = new List<Line>();

        public int Edge { get => canh; set => canh = value; }
        internal Point A { get => a; set => a = value; }
        internal Point B { get => b; set => b = value; }
        internal Point C { get => c; set => c = value; }
        internal Point D { get => d; set => d = value; }
        internal Point E { get => e; set => e = value; }
        internal Point F { get => f; set => f = value; }
        internal Point G { get => g; set => g = value; }
        internal Point H { get => h; set => h = value; }

        public Cube(Point a, int canh)
        {
            A = a;
            Edge = canh;
            B = new Point(A.X, A.Y + Edge, A.Z);
            C = new Point(A.X + Edge, A.Y + Edge, A.Z);
            D = new Point(A.X + Edge, A.Y, A.Z);
            E = new Point(A.X, A.Y, A.Z + Edge);
            F = new Point(A.X, A.Y + Edge, A.Z + Edge);
            G = new Point(A.X + Edge, A.Y + Edge, A.Z + Edge);
            H = new Point(A.X + Edge, A.Y, A.Z + Edge);
            nega.Add(new Line(A, E));

            nega.Add(new Line(A, B));
            nega.Add(new Line(A, D));

            pose.Add(new Line(B, C));
            pose.Add(new Line(D, C));

            pose.Add(new Line(B, F));
            pose.Add(new Line(G, C));
            pose.Add(new Line(D, H));

            pose.Add(new Line(E, F));
            pose.Add(new Line(F, G));
            pose.Add(new Line(G, H));
            pose.Add(new Line(H, E));

        }
        public void Show(Graphics g)
        {
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
