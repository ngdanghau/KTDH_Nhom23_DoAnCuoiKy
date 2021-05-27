using KTDH_Nhom23_DoAnCuoiKy.Class._2D;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._3D
{
    class Cube
    {
        private List<Line> nega = new List<Line>();
        private List<Line> pose = new List<Line>();

        public int Edge { get; set; }
        internal Point A { get; set; }
        internal Point B { get; set; }
        internal Point C { get; set; }
        internal Point D { get; set; }
        internal Point E { get; set; }
        internal Point F { get; set; }
        internal Point G { get; set; }
        internal Point H { get; set; }

        public Cube(Point a, int canh)
        {
            A = PhepToan.Cabinet(a);

            Edge = canh;
            B = new Point(A.X, A.Y + Edge, A.Z, "B");
            C = new Point(A.X + Edge, A.Y + Edge, A.Z, "C");
            D = new Point(A.X + Edge, A.Y, A.Z, "D");
            E = new Point(A.X, A.Y, A.Z + Edge, "E");
            F = new Point(A.X, A.Y + Edge, A.Z + Edge, "F");
            G = new Point(A.X + Edge, A.Y + Edge, A.Z + Edge, "G");
            H = new Point(A.X + Edge, A.Y, A.Z + Edge, "H");
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


        public void Hide(Graphics g)
        {
            nega.Clear();
            pose.Clear();
        }

        public void Scale(double ratio)
        {
            Edge = Convert.ToInt32(Edge * ratio);
            A = PhepToan.Scale(A, ratio, ratio, ratio);

            B = new Point(A.X, A.Y + Edge, A.Z, "B");
            C = new Point(A.X + Edge, A.Y + Edge, A.Z, "C");
            D = new Point(A.X + Edge, A.Y, A.Z, "D");
            E = new Point(A.X, A.Y, A.Z + Edge, "E");
            F = new Point(A.X, A.Y + Edge, A.Z + Edge, "F");
            G = new Point(A.X + Edge, A.Y + Edge, A.Z + Edge, "G");
            H = new Point(A.X + Edge, A.Y, A.Z + Edge, "H");
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

        public void Translation(double trX, double trY, double trZ)
        {
            A = PhepToan.Translation(A, trX, trY, trZ);
            B = new Point(A.X, A.Y + Edge, A.Z, "B");
            C = new Point(A.X + Edge, A.Y + Edge, A.Z, "C");
            D = new Point(A.X + Edge, A.Y, A.Z, "D");
            E = new Point(A.X, A.Y, A.Z + Edge, "E");
            F = new Point(A.X, A.Y + Edge, A.Z + Edge, "F");
            G = new Point(A.X + Edge, A.Y + Edge, A.Z + Edge, "G");
            H = new Point(A.X + Edge, A.Y, A.Z + Edge, "H");

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
    }
}
