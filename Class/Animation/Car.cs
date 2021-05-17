using KTDH_Nhom23_DoAnCuoiKy.Class._2D;
using KTDH_Nhom23_DoAnCuoiKy.UI.Animation;
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
            // THÂN XE Ô TÔ
            PanelCar.Instance.A = "{X = " + A.X + ",Y=" + A.Y + "}";
            PanelCar.Instance.B = "{X = " + B.X + ",Y=" + B.Y + "}";

            PanelCar.Instance.C = "{X = " + C.X + ",Y=" + C.Y + "}";
            PanelCar.Instance.D = "{X = " + D.X + ",Y=" + D.Y + "}";

            PanelCar.Instance.E = "{X = " + E.X + ",Y=" + E.Y + "}";
            PanelCar.Instance.F = "{X = " + F.X + ",Y=" + F.Y + "}";

            PanelCar.Instance.G = "{X = " + G.X + ",Y=" + G.Y + "}";
            // BÁNH XE Ô TÔ
            PanelCar.Instance.C1 = "{X = " + C1.Center.X + ",Y=" + C1.Center.Y + "}";
            PanelCar.Instance.C2 = "{X = " + C2.Center.X + ",Y=" + C2.Center.Y + "}";

            PanelCar.Instance.C3 = "{X = " + C3.Center.X + ",Y=" + C3.Center.Y + "}";
            PanelCar.Instance.C4 = "{X = " + C4.Center.X + ",Y=" + C4.Center.Y + "}";

            PanelCar.Instance.C5 = "{X = " + C5.Center.X + ",Y=" + C5.Center.Y + "}";
            // HỌA TIẾT BÁNH XE
            PanelCar.Instance.HT0 = "{X = " + List[0].X + ",Y=" + List[0].Y + "}";
            PanelCar.Instance.HT1 = "{X = " + List[1].X + ",Y=" + List[1].Y + "}";

            PanelCar.Instance.HT2 = "{X = " + List[2].X + ",Y=" + List[2].Y + "}";
            PanelCar.Instance.HT3 = "{X = " + List[3].X + ",Y=" + List[3].Y + "}";

            PanelCar.Instance.HT4 = "{X = " + List[4].X + ",Y=" + List[4].Y + "}";
            PanelCar.Instance.HT5 = "{X = " + List[5].X + ",Y=" + List[5].Y + "}";

            PanelCar.Instance.HT6 = "{X = " + List[6].X + ",Y=" + List[6].Y + "}";
            PanelCar.Instance.HT7 = "{X = " + List[7].X + ",Y=" + List[7].Y + "}";

            PanelCar.Instance.HT8 = "{X = " + List[8].X + ",Y=" + List[8].Y + "}";
            PanelCar.Instance.HT9 = "{X = " + List[9].X + ",Y=" + List[9].Y + "}";
            Form1.paintAnimate.Invalidate();

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

        public void Show(Graphics g)
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
            time.Interval = 50;
            time.Tick += new EventHandler(t_Tick);
            time.Start();
        }
    }
}
