using KTDH_Nhom23_DoAnCuoiKy.Class._2D;
using KTDH_Nhom23_DoAnCuoiKy.UI.Animation;
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
            #region Đĩa mặt trời
            PanelSun.Instance.DiscSun = "{X = " + C1.Center.X + ",Y=" + C1.Center.Y + "}";
            #endregion
            #region Ánh mặt trời
            PanelSun.Instance.Sunshine10 = "{X = " + T1.A.X + ",Y=" + T1.A.Y + "}";
            PanelSun.Instance.Sunshine11 = "{X = " + T1.B.X + ",Y=" + T1.B.Y + "}";
            PanelSun.Instance.Sunshine12 = "{X = " + T1.C.X + ",Y=" + T1.C.Y + "}";

            PanelSun.Instance.Sunshine20 = "{X = " + T2.A.X + ",Y=" + T2.A.Y + "}";
            PanelSun.Instance.Sunshine21 = "{X = " + T2.B.X + ",Y=" + T2.B.Y + "}";
            PanelSun.Instance.Sunshine22 = "{X = " + T2.C.X + ",Y=" + T2.C.Y + "}";

            PanelSun.Instance.Sunshine30 = "{X = " + T3.A.X + ",Y=" + T3.A.Y + "}";
            PanelSun.Instance.Sunshine31 = "{X = " + T3.B.X + ",Y=" + T3.B.Y + "}";
            PanelSun.Instance.Sunshine32 = "{X = " + T3.C.X + ",Y=" + T3.C.Y + "}";

            PanelSun.Instance.Sunshine40 = "{X = " + T4.A.X + ",Y=" + T4.A.Y + "}";
            PanelSun.Instance.Sunshine41 = "{X = " + T4.B.X + ",Y=" + T4.B.Y + "}";
            PanelSun.Instance.Sunshine42 = "{X = " + T4.C.X + ",Y=" + T4.C.Y + "}";
            #endregion
            Form1.paintAnimate.Invalidate();

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

        public void Show(Graphics g)
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
            time.Interval = 50;
            time.Tick += new EventHandler(t_Tick);
            time.Start();
        }
    }
}
