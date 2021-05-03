using System;
using System.Collections.Generic;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._2D
{
    class Rectangle: Shape
    {
        private int width; // chiều dài
        private int height; // chiều rộng
        private Point angleA, angleB, angleC, angleD; // bốn góc A,B,C,D
        private List<Line> listedge = new List<Line>(); // danh sách cạnh AB, BC, CD, DA

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        internal Point A { get => angleA; set => angleA = value; }
        internal Point B { get => angleB; set => angleB = value; }
        internal Point C { get => angleC; set => angleC = value; }
        internal Point D { get => angleD; set => angleD = value; }
        internal List<Line> ListEdge { get => listedge; set => listedge = value; }

        public Rectangle(Point angle, Point p2)
        {
            A = angle;
            width = Math.Abs(p2.X - angle.X);
            height = Math.Abs(p2.Y - angle.Y);
            C = new Point(p2.X, p2.Y);
            B = new Point(A.X, C.Y);
            D = new Point(C.X, A.Y);
            ListEdge.Add(new Line(A, B));
            ListEdge.Add(new Line(B, C));
            ListEdge.Add(new Line(C, D));
            ListEdge.Add(new Line(D, A));
            foreach (Line s in ListEdge)
            {
                List.AddRange(s.List);
            }
            Remove();
        }

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
            List.Remove(D);
        }
        
    }
}
