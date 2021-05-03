using System;
using System.Collections.Generic;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._2D
{
    class Triangle : Shape
    {
        private int edge;
        private Point angleA, angleB, angleC;
        private List<Line> listedge = new List<Line>();

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

        public int Edge { get => edge; set => edge = value; }
        internal Point A { get => angleA; set => angleA = value; }
        internal Point B { get => angleB; set => angleB = value; }
        internal Point C { get => angleC; set => angleC = value; }
        internal List<Line> ListEdge { get => listedge; set => listedge = value; }

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

    }
}
