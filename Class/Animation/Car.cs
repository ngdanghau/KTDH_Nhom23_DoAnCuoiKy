using KTDH_Nhom23_DoAnCuoiKy.Class._2D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.Class.Animation
{
    class Car: Shape
    {
        public double Radius { get; set; }
        public int Distance { get; set; } = 2;

        internal Circle C1 { get; set; }
        internal Circle C2 { get; set; }
        internal Circle C3 { get; set; }
        internal Circle C4 { get; set; }
        internal Circle C5 { get; set; }

        internal Point A { get; set; }
        internal Point B { get; set; }
        internal Point C { get; set; }
        internal Point D { get; set; }
        internal Point E { get; set; }
        internal Point F { get; set; }
        internal Point G { get; set; }

        internal List<Line> ListEdge { get; set; } = new List<Line>();
        public Graphics Graphic { get; set; }
        public Panel Panel { get; set; }
        internal Timer time { get; set; } = new Timer();
        internal bool alreadyAdded { get; set; } = false;
        internal double Angle = 30;
        internal int ticktac { get; set; } = 1;


        private void t_Tick(object sender, EventArgs e)
        {
            ListEdge.Clear();
            ticktac++;
            A = PhepToan.Translation(A, 1, 0, 0);
            B = new Point(A.X, A.Y + 10);
            C = new Point(A.X + 10, A.Y + 20);
            D = new Point(A.X + 40, A.Y + 20);
            E = new Point(A.X + 50, A.Y + 10);
            F = new Point(A.X + 70, A.Y + 10);
            G = new Point(A.X + 70, A.Y);

            C1 = new Circle(new Point(A.X + 5, A.Y - 6), Radius);
            C2 = new Circle(new Point(A.X + 20, A.Y - 6), Radius);
            C3 = new Circle(new Point(A.X + 35, A.Y - 6), Radius);
            C4 = new Circle(new Point(A.X + 50, A.Y - 6), Radius);
            C5 = new Circle(new Point(A.X + 65, A.Y - 6), Radius);


            ListEdge.Add(new Line(A, B));
            ListEdge.Add(new Line(B, C));
            ListEdge.Add(new Line(C, D));
            ListEdge.Add(new Line(D, E));
            ListEdge.Add(new Line(E, F));
            ListEdge.Add(new Line(F, G));
            ListEdge.Add(new Line(G, A));
            double a = PhepToan.ConvertDegreesToRadian(Convert.ToInt32(Angle * ticktac));
            List[0] = PhepToan.CenterRotate(new Point(C1.Center.X - Distance, C1.Center.Y), C1.Center, -a);
            List[1] = PhepToan.CenterRotate(new Point(C1.Center.X + Distance, C1.Center.Y), C1.Center, -a);

            List[2] = PhepToan.CenterRotate(new Point(C2.Center.X - Distance, C2.Center.Y), C2.Center, -a);
            List[3] = PhepToan.CenterRotate(new Point(C2.Center.X + Distance, C2.Center.Y), C2.Center, -a);

            List[4] = PhepToan.CenterRotate(new Point(C3.Center.X - Distance, C3.Center.Y), C3.Center, -a);
            List[5] = PhepToan.CenterRotate(new Point(C3.Center.X + Distance, C3.Center.Y), C3.Center, -a);

            List[6] = PhepToan.CenterRotate(new Point(C4.Center.X - Distance, C4.Center.Y), C4.Center, -a);
            List[7] = PhepToan.CenterRotate(new Point(C4.Center.X + Distance, C4.Center.Y), C4.Center, -a);

            List[8] = PhepToan.CenterRotate(new Point(C5.Center.X - Distance, C5.Center.Y), C5.Center, -a);
            List[9] = PhepToan.CenterRotate(new Point(C5.Center.X + Distance, C5.Center.Y), C5.Center, -a);

            Panel.Invalidate();

        }

        public Car(Point p, double r = 5)
        {
            Radius = r;
            A = p;
            B = new Point(A.X, A.Y + 10);
            C = new Point(A.X + 10, A.Y + 20);
            D = new Point(A.X + 40, A.Y + 20);
            E = new Point(A.X + 50, A.Y + 10);
            F = new Point(A.X + 70, A.Y + 10);
            G = new Point(A.X + 70, A.Y);

            C1 = new Circle(new Point(A.X + 5, A.Y - 6), r);
            C2 = new Circle(new Point(A.X + 20, A.Y - 6), r);
            C3 = new Circle(new Point(A.X + 35, A.Y - 6), r);
            C4 = new Circle(new Point(A.X + 50, A.Y - 6), r);
            C5 = new Circle(new Point(A.X + 65, A.Y - 6), r);


            ListEdge.Add(new Line(A, B));
            ListEdge.Add(new Line(B, C));
            ListEdge.Add(new Line(C, D));
            ListEdge.Add(new Line(D, E));
            ListEdge.Add(new Line(E, F));
            ListEdge.Add(new Line(F, G));
            ListEdge.Add(new Line(G, A));

            List.AddRange(new List<Point>() {  
                new Point(C1.Center.X - Distance, C1.Center.Y),
                new Point(C1.Center.X + Distance, C1.Center.Y),

                new Point(C2.Center.X - Distance, C2.Center.Y),
                new Point(C2.Center.X + Distance, C2.Center.Y),

                new Point(C3.Center.X - Distance, C3.Center.Y),
                new Point(C3.Center.X + Distance, C3.Center.Y),

                new Point(C4.Center.X - Distance, C4.Center.Y),
                new Point(C4.Center.X + Distance, C4.Center.Y),

                new Point(C5.Center.X - Distance, C5.Center.Y),
                new Point(C5.Center.X + Distance, C5.Center.Y),
            });
        }

        public void Show(Graphics g, Panel panel)
        {
            foreach (var item in ListEdge) item.Show(g);
            foreach (var item in List) item.PutPixel(g);
            C1.Show(g);
            C2.Show(g);
            C3.Show(g);
            C4.Show(g);
            C5.Show(g);
            if (alreadyAdded) return;
            alreadyAdded = true;
            Panel = panel;
            Graphic = g;
            time.Interval = 50;
            time.Tick += new EventHandler(t_Tick);
            time.Start();
        }
    }
}
