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
        internal List<Triangle> ListT { get; set; } = new List<Triangle>();

        internal Timer time { get; set; } = new Timer();
        internal bool alreadyAdded { get; set; } = false;
        internal double ticktac { get; set; } = 1;


        private void t_Tick(object sender, EventArgs e)
        {
            ListT.Clear();
            ticktac += 0.05;
            Point p = PhepToan.Translation(C1.Center, ticktac, ticktac, 0);
            int r = Convert.ToInt32(Radius);
            C1 = new Circle(p, r);
            T1 = new Triangle(new Point(p.X, p.Y + r + 15), new Point(p.X + 7, p.Y + r + 5), new Point(p.X - 7, p.Y + r + 5));
            ListT.Add(T1);
            for (int i = 0; i< 11; i++)
            {
                double a = PhepToan.ConvertDegreesToRadian(330);
                ListT.Add(new Triangle(
                        PhepToan.CenterRotate(ListT[i].A, C1.Center, a),
                        PhepToan.CenterRotate(ListT[i].B, C1.Center, a),
                        PhepToan.CenterRotate(ListT[i].C, C1.Center, a)
                    ));
            }

            #region Đĩa mặt trời
            PanelSun.Instance.DiscSun = "{X = " + C1.Center.X + ",Y=" + C1.Center.Y + "}";
            #endregion
            #region Ánh mặt trời

            for (int i = 0; i < 12; i++)
            {
                if (i == 0)
                {
                    PanelSun.Instance.Sunshine1_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine1_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine1_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
                else if (i == 1)
                {
                    PanelSun.Instance.Sunshine2_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine2_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine2_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
                else if (i == 2)
                {
                    PanelSun.Instance.Sunshine3_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine3_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine3_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
                else if (i == 3)
                {
                    PanelSun.Instance.Sunshine4_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine4_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine4_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
                else if (i == 4)
                {
                    PanelSun.Instance.Sunshine5_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine5_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine5_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
                else if (i == 5)
                {
                    PanelSun.Instance.Sunshine6_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine6_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine6_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
                else if (i == 6)
                {
                    PanelSun.Instance.Sunshine7_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine7_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine7_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
                else if (i == 7)
                {
                    PanelSun.Instance.Sunshine8_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine8_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine8_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
                else if (i == 8)
                {
                    PanelSun.Instance.Sunshine9_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine9_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine9_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
                else if (i == 9)
                {
                    PanelSun.Instance.Sunshine10_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine10_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine10_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
                else if (i == 10)
                {
                    PanelSun.Instance.Sunshine11_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine11_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine11_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
                else if (i == 11)
                {
                    PanelSun.Instance.Sunshine12_1 = "{X = " + ListT[i].A.X + ",Y=" + ListT[i].A.Y + "}";
                    PanelSun.Instance.Sunshine12_2 = "{X = " + ListT[i].B.X + ",Y=" + ListT[i].B.Y + "}";
                    PanelSun.Instance.Sunshine12_3 = "{X = " + ListT[i].C.X + ",Y=" + ListT[i].C.Y + "}";
                }
            }
            #endregion
            Form1.paintAnimate.Invalidate();

        }

        public Sun(Point p, int r = 15)
        {
            Radius = r;
            C1 = new Circle(p, r);
            T1 = new Triangle(new Point(p.X, p.Y + r + 15),new Point(p.X + 7, p.Y + r + 5),new Point(p.X - 7, p.Y + r + 5));
            ListT.Add(T1);
            for (int i = 0; i < 11; i++)
            {
                double a = PhepToan.ConvertDegreesToRadian(330);
                ListT.Add(new Triangle(
                        PhepToan.CenterRotate(ListT[i].A, C1.Center, a),
                        PhepToan.CenterRotate(ListT[i].B, C1.Center, a),
                        PhepToan.CenterRotate(ListT[i].C, C1.Center, a)
                    ));
            }
        }

        public void Show(Graphics g)
        {
            C1.Show(g);
            T1.Show(g);
            foreach (Triangle tri in ListT) tri.Show(g);

            if (alreadyAdded) return;
            alreadyAdded = true;
            time.Interval = 50;
            time.Tick += new EventHandler(t_Tick);
            time.Start();
        }
    }
}
