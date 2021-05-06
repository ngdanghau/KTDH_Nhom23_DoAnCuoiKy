using System;
using System.Collections.Generic;
using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Class._2D
{
    class Rectangle: Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        internal Point A { get; set; }
        internal Point B { get; set; }
        internal Point C { get; set; }
        internal Point D { get; set; }
        internal List<Line> ListEdge { get; set; } = new List<Line>();

        public Rectangle(Point angle, Point p2)
        {
            A = angle;
            Width = Math.Abs(p2.X - angle.X);
            Height = Math.Abs(p2.Y - angle.Y);
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

        public void Rotate(int degrees)
        {
            double a = (1.0 * degrees / 180) * Math.PI;
            List.Clear();
            ListEdge.Clear();
            A = PhepToan.Rotate(A, a);
            B = PhepToan.Rotate(B, a);
            C = PhepToan.Rotate(C, a);
            D = PhepToan.Rotate(D, a);
            ListEdge.Add(new Line(A, B));
            ListEdge.Add(new Line(B, C));
            ListEdge.Add(new Line(C, D));
            ListEdge.Add(new Line(D, A));
            foreach (Line canh in ListEdge)
            {
                List.AddRange(canh.List);
            }
            Remove();
        }

        public void Scale(double ratio)
        {
            List.Clear();
            ListEdge.Clear();
            A = PhepToan.Scale(A, ratio, ratio, 0);
            B = PhepToan.Scale(B, ratio, ratio, 0);
            C = PhepToan.Scale(C, ratio, ratio, 0);
            D = PhepToan.Scale(D, ratio, ratio, 0);
            ListEdge.Add(new Line(A, B));
            ListEdge.Add(new Line(B, C));
            ListEdge.Add(new Line(C, D));
            ListEdge.Add(new Line(D, A));
            foreach (Line canh in ListEdge)
            {
                List.AddRange(canh.List);
            }
            Remove();
        }

        public void Reflection(int type)
        {
            List.Clear();
            ListEdge.Clear();
            A = PhepToan.Reflection(A, type);
            B = PhepToan.Reflection(B, type);
            C = PhepToan.Reflection(C, type);
            D = PhepToan.Reflection(D, type);
            ListEdge.Add(new Line(A, B));
            ListEdge.Add(new Line(B, C));
            ListEdge.Add(new Line(C, D));
            ListEdge.Add(new Line(D, A));
            foreach (Line canh in ListEdge)
            {
                List.AddRange(canh.List);
            }
            Remove();
        }
        public void Translation(double trX, double trY)
        {
            List.Clear();
            ListEdge.Clear();
            A = PhepToan.Translation(A, trX, trY, 0);
            B = PhepToan.Translation(B, trX, trY, 0);
            C = PhepToan.Translation(C, trX, trY, 0);
            D = PhepToan.Translation(D, trX, trY, 0);
            ListEdge.Add(new Line(A, B));
            ListEdge.Add(new Line(B, C));
            ListEdge.Add(new Line(C, D));
            ListEdge.Add(new Line(D, A));
            foreach (Line canh in ListEdge)
            {
                List.AddRange(canh.List);
            }
            Remove();
        }
    }
}
