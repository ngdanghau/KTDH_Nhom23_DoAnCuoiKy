using System;
using System.Collections.Generic;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._2D
{
    class Triangle : Shape
    {
        public Triangle(Point angle, Point p2)
        {
            A = angle;
            C = new Point(p2.X, p2.Y);
            double AC = Point.Distance(A, C);
            double xB = C.X - AC;
            B = new Point(Convert.ToInt32(xB), C.Y);

            ListEdge.Add(new Line(A, B));
            ListEdge.Add(new Line(B, C));
            ListEdge.Add(new Line(C, A));
            foreach (Line s in ListEdge)
            {
                List.AddRange(s.List);
            }
            Remove();
        }

        public int Edge { get; set; }
        internal Point A { get; set; }
        internal Point B { get; set; }
        internal Point C { get; set; }
        internal List<Line> ListEdge { get; set; } = new List<Line>();

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

        private void Remove()
        {
            List.Remove(A);
            List.Remove(B);
            List.Remove(C);
        }

        public void Rotate(int degrees)
        {
            double a = (1.0 * degrees / 180) * Math.PI;
            List.Clear();
            ListEdge.Clear();
            A = PhepToan.Rotate(A, a);
            B = PhepToan.Rotate(B, a);
            C = PhepToan.Rotate(C, a);
            ListEdge.Add(new Line(A, B));
            ListEdge.Add(new Line(B, C));
            ListEdge.Add(new Line(C, A));
            foreach (Line canh in ListEdge)
            {
                List.AddRange(canh.List);
            }
            Remove();
        }

    }
}
