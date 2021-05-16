using KTDH_Nhom23_DoAnCuoiKy.Class._2D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy.Class.Animation
{
    class Sun
    {
        public double Radius { get; set; }
        internal Point O { get; set; }
        internal Circle C1 { get; set; }
        internal Triangle T1 { get; set; }
        internal Triangle T2 { get; set; }
        internal Triangle T3 { get; set; }
        internal Triangle T4 { get; set; }
        internal Triangle T5 { get; set; }
        internal Triangle T6 { get; set; }
        internal Triangle T7 { get; set; }
        internal Triangle T8 { get; set; }
        internal Triangle T9 { get; set; }
        internal Triangle T10 { get; set; }
        internal Triangle T11 { get; set; }
        internal Triangle T12 { get; set; }

        public Graphics Graphic { get; set; }
        public Panel Panel { get; set; }
        internal Timer time { get; set; } = new Timer();
        internal bool alreadyAdded { get; set; } = false;
        internal double ticktac { get; set; } = 1;


        private void t_Tick(object sender, EventArgs e)
        {
            ticktac += 0.05;
            Point p = PhepToan.Translation(C1.Center, ticktac, ticktac, 0);
            int r = Convert.ToInt32(Radius);
            C1 = new Circle(p, r);
            T1 = new Triangle(new Point(p.X, p.Y + r + 15), new Point(p.X + 7, p.Y + r + 5), new Point(p.X - 7, p.Y + r + 5));

            double a = PhepToan.ConvertDegreesToRadian(270);
            T2 = new Triangle(
                    PhepToan.CenterRotate(T1.A, C1.Center, a),
                    PhepToan.CenterRotate(T1.B, C1.Center, a),
                    PhepToan.CenterRotate(T1.C, C1.Center, a)
                );

            a = PhepToan.ConvertDegreesToRadian(360);
            T3 = new Triangle(
                    PhepToan.CenterRotate(T1.A, C1.Center, a),
                    PhepToan.CenterRotate(T1.B, C1.Center, a),
                    PhepToan.CenterRotate(T1.C, C1.Center, a)
                );
            a = PhepToan.ConvertDegreesToRadian(90);
            T4 = new Triangle(
                    PhepToan.CenterRotate(T1.A, C1.Center, a),
                    PhepToan.CenterRotate(T1.B, C1.Center, a),
                    PhepToan.CenterRotate(T1.C, C1.Center, a)
                );

            Panel.Invalidate();

        }

        public Sun(Point p, int r = 15)
        {
            Radius = r;
            C1 = new Circle(p, r);
            T1 = new Triangle(new Point(p.X, p.Y + r + 15),new Point(p.X + 7, p.Y + r + 5),new Point(p.X - 7, p.Y + r + 5));

            double a = PhepToan.ConvertDegreesToRadian(270);
            T2 = new Triangle(
                    PhepToan.CenterRotate(T1.A, C1.Center, a),
                    PhepToan.CenterRotate(T1.B, C1.Center, a),
                    PhepToan.CenterRotate(T1.C, C1.Center, a)
                );

            a = PhepToan.ConvertDegreesToRadian(360);
            T3 = new Triangle(
                    PhepToan.CenterRotate(T1.A, C1.Center, a),
                    PhepToan.CenterRotate(T1.B, C1.Center, a),
                    PhepToan.CenterRotate(T1.C, C1.Center, a)
                );
            a = PhepToan.ConvertDegreesToRadian(90);
            T4 = new Triangle(
                    PhepToan.CenterRotate(T1.A, C1.Center, a),
                    PhepToan.CenterRotate(T1.B, C1.Center, a),
                    PhepToan.CenterRotate(T1.C, C1.Center, a)
                );

            //T5 = new Triangle(
            //        new Point(Convert.ToInt32((T1.B.X + T2.C.X) /2), Convert.ToInt32((T1.B.Y + T2.C.) / 2)),
            //        T1.B,
            //        T2.C
            //    );

            //a = PhepToan.ConvertDegreesToRadian(330);
            //T6 = new Triangle(
            //        PhepToan.CenterRotate(T1.A, C1.Center, a),
            //        PhepToan.CenterRotate(T1.B, C1.Center, a),
            //        PhepToan.CenterRotate(T1.C, C1.Center, a)
            //    );
            //a = PhepToan.ConvertDegreesToRadian(360);
            //T7 = new Triangle(
            //        PhepToan.CenterRotate(T1.A, C1.Center, a),
            //        PhepToan.CenterRotate(T1.B, C1.Center, a),
            //        PhepToan.CenterRotate(T1.C, C1.Center, a)
            //    ); 
            //a = PhepToan.ConvertDegreesToRadian(30);
            //T8 = new Triangle(
            //        PhepToan.CenterRotate(T1.A, C1.Center, a),
            //        PhepToan.CenterRotate(T1.B, C1.Center, a),
            //        PhepToan.CenterRotate(T1.C, C1.Center, a)
            //    ); 
            //a = PhepToan.ConvertDegreesToRadian(60);
            //T9 = new Triangle(
            //        PhepToan.CenterRotate(T1.A, C1.Center, a),
            //        PhepToan.CenterRotate(T1.B, C1.Center, a),
            //        PhepToan.CenterRotate(T1.C, C1.Center, a)
            //    );
            //a = PhepToan.ConvertDegreesToRadian(90);
            //T10 = new Triangle(
            //        PhepToan.CenterRotate(T1.A, C1.Center, a),
            //        PhepToan.CenterRotate(T1.B, C1.Center, a),
            //        PhepToan.CenterRotate(T1.C, C1.Center, a)
            //    );
            //a = PhepToan.ConvertDegreesToRadian(120);
            //T11 = new Triangle(
            //        PhepToan.CenterRotate(T1.A, C1.Center, a),
            //        PhepToan.CenterRotate(T1.B, C1.Center, a),
            //        PhepToan.CenterRotate(T1.C, C1.Center, a)
            //    );
            //a = PhepToan.ConvertDegreesToRadian(150);
            //T12 = new Triangle(
            //        PhepToan.CenterRotate(T1.A, C1.Center, a),
            //        PhepToan.CenterRotate(T1.B, C1.Center, a),
            //        PhepToan.CenterRotate(T1.C, C1.Center, a)
            //    );

        }

        public void Show(Graphics g, Panel panel)
        {
            C1.Show(g);
            T1.Show(g);
            T2.Show(g);
            T3.Show(g);
            T4.Show(g);
            //T5.Show(g);
            //T6.Show(g);
            //T7.Show(g);
            //T8.Show(g);
            //T9.Show(g);
            //T10.Show(g);
            //T11.Show(g);
            //T12.Show(g);

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
