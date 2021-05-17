
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
    class Plane : Shape
    {
        /**=======================================
                    THÂN TRÊN MÁY BAY
        /**=======================================*/
        internal Point A { get; set; }
        internal Point B { get; set; }
        internal Point C { get; set; }
        internal Point D { get; set; }
        internal Point E { get; set; }
        internal Point F { get; set; }
        internal Point G { get; set; }
        internal Point H { get; set; }
        /**=======================================
                    THÂN DƯỚI MÁY BAY
        /**=======================================*/
        internal Point G1 { get; set; }
        internal Point H1 { get; set; }
        internal Point F1 { get; set; }

        internal Point M { get; set; }
        /**=======================================
                    MŨI MÁY BAY
        /**=======================================*/
        internal Point REC1 { get; set; }
        internal Point REC2 { get; set; }
        internal Point REC3 { get; set; }

        /**=======================================
                    HỌA TIẾT MÁY BAY
        /**=======================================*/
        internal Point REC4 { get; set; }
        internal Point N { get; set; }

        internal Point REC41 { get; set; }
        internal Point N1 { get; set; }

        internal Point CRS1 { get; set; }
        internal Point CRS2 { get; set; }
        internal Point CRS3 { get; set; }


        internal Point CRS4 { get; set; }
        internal Point CRS5 { get; set; }
        internal Point CRS6 { get; set; }


        internal Point CRS7 { get; set; }
        internal Point CRS8 { get; set; }
        internal Point CRS9 { get; set; }


        internal Point CRS10 { get; set; }
        internal Point CRS11 { get; set; }
        internal Point CRS12 { get; set; }

        internal Point CRS13 { get; set; }
        internal Point CRS14 { get; set; }

        internal Point CRS15 { get; set; }
        internal Point CRS16 { get; set; }

        /**=======================================
                    CÁNH MÁY BAY
        /**=======================================*/
        internal Point O { get; set; }
        internal Point P { get; set; }
        internal Point Q { get; set; }
        internal Point R { get; set; }

        internal List<Line> ListEdge { get; set; } = new List<Line>();
        public Graphics Graphic { get; set; }
        internal Timer time { get; set; } = new Timer();
        internal int ticktac { get; set; } = 1;
        internal bool alreadyAdded { get; set; } = false;
        public Panel Panel { get; set; }


        private void t_Tick(object sender, EventArgs e)
        {
            ticktac++;
            // THÂN MÁY BAY
            PanelPlane.Instance.A = "{X = " + A.X + ",Y=" + A.Y + "}";
            PanelPlane.Instance.B = "{X = " + B.X + ",Y=" + B.Y + "}";

            PanelPlane.Instance.C = "{X = " + C.X + ",Y=" + C.Y + "}";
            PanelPlane.Instance.D = "{X = " + D.X + ",Y=" + D.Y + "}";

            PanelPlane.Instance.E = "{X = " + E.X + ",Y=" + E.Y + "}";
            PanelPlane.Instance.F = "{X = " + F.X + ",Y=" + F.Y + "}";

            PanelPlane.Instance.G = "{X = " + G.X + ",Y=" + G.Y + "}";
            PanelPlane.Instance.H = "{X = " + H.X + ",Y=" + H.Y + "}";

            PanelPlane.Instance.M = "{X = " + M.X + ",Y=" + M.Y + "}";
            PanelPlane.Instance.N = "{X = " + N.X + ",Y=" + N.Y + "}";
            // CÁNH MÁY BAY
            PanelPlane.Instance.O = "{X = " + O.X + ",Y=" + O.Y + "}";
            PanelPlane.Instance.P = "{X = " + P.X + ",Y=" + P.Y + "}";

            PanelPlane.Instance.Q = "{X = " + Q.X + ",Y=" + Q.Y + "}";
            PanelPlane.Instance.R = "{X = " + R.X + ",Y=" + R.Y + "}";
            // HỌA TIẾT MÁY BAY
            PanelPlane.Instance.CR1 = "{X = " + CRS1.X + ",Y=" + CRS1.Y + "}";
            PanelPlane.Instance.CR2 = "{X = " + CRS2.X + ",Y=" + CRS2.Y + "}";

            PanelPlane.Instance.CR3 = "{X = " + CRS3.X + ",Y=" + CRS3.Y + "}";
            PanelPlane.Instance.CR4 = "{X = " + CRS4.X + ",Y=" + CRS4.Y + "}";
            Translation(ticktac, 0);
            Panel.Invalidate();
        }


        public Plane(Point iPoint)
        {
            #region nửa thân trên máy bay
            A = iPoint;

            B = new Point(A.X + 13, A.Y);
            C = new Point(B.X + 25, B.Y - 15);

            D = new Point(C.X + 40, C.Y);
            E = new Point(D.X + 10, D.Y + 5);

            F = new Point(E.X + 10, E.Y);
            G = new Point(F.X + 10, F.Y - 5);

            H = new Point(G.X + 12, G.Y);
            M = new Point(A.X, A.Y - 30);
            #endregion 

            #region mũi máy bay
            REC1 = new Point(H.X, H.Y - 3);
            REC2 = new Point(H.X, H.Y - 7);
            REC3 = new Point(H.X + 5, (REC1.Y + REC2.Y) / 2);
            #endregion

            #region nửa thân dưới máy bay
            H1 = new Point(H.X, H.Y - 10);
            G1 = new Point(G.X, H.Y - 10);
            F1 = new Point(G1.X - 10, G1.Y - 5);
            #endregion

            #region họa tiết trang trí
            REC4 = new Point(REC3.X - 10, REC3.Y);
            N = new Point(REC4.X - 10, REC4.Y);

            REC41 = new Point(REC4.X, REC4.Y - 2);
            N1 = new Point(N.X, N.Y - 2);

            CRS1 = new Point(C.X + 25, C.Y - 3);
            CRS2 = new Point(CRS1.X, CRS1.Y - 3);
            CRS3 = new Point(CRS2.X - 3, CRS2.Y);

            CRS4 = new Point(CRS2.X, CRS2.Y - 2);
            CRS5 = new Point(CRS4.X - 3, CRS4.Y);
            CRS6 = new Point(CRS4.X, CRS4.Y - 3);

            CRS7 = new Point(CRS2.X + 2, CRS2.Y);
            CRS8 = new Point(CRS7.X, CRS7.Y + 3);
            CRS9 = new Point(CRS7.X + 3, CRS7.Y);

            CRS10 = new Point(CRS7.X, CRS7.Y - 2);
            CRS11 = new Point(CRS10.X + 3, CRS10.Y);
            CRS12 = new Point(CRS10.X, CRS10.Y - 3);

            CRS13 = new Point(CRS3.X - 35, CRS3.Y);
            CRS14 = new Point(CRS13.X - 10, CRS13.Y);

            CRS15 = new Point(CRS3.X - 35, CRS3.Y - 2);
            CRS16 = new Point(CRS15.X - 10, CRS15.Y);
            #endregion

            #region cánh máy bay
            O = new Point(F1.X - 20, M.Y);
            P = new Point(O.X - 15, O.Y - 7);
            Q = new Point(P.X - 30, P.Y);
            R = new Point(O.X - 25, O.Y);
            #endregion
            /**=======================================
                    THÂN TRÊN MÁY BAY
            /**=======================================*/
            ListEdge.Add(new Line(A, B));
            ListEdge.Add(new Line(B, C));

            ListEdge.Add(new Line(C, D));
            ListEdge.Add(new Line(D, E));

            ListEdge.Add(new Line(E, F));
            ListEdge.Add(new Line(F, G));

            ListEdge.Add(new Line(G, H));
            ListEdge.Add(new Line(A, M));

            ListEdge.Add(new Line(G, D));
            /**=======================================
                    MŨI MÁY BAY
            /**=======================================*/
            ListEdge.Add(new Line(REC1, REC3));
            ListEdge.Add(new Line(REC2, REC3));
            /**=======================================
                    THÂN DƯỚI MÁY BAY
            /**=======================================*/
            ListEdge.Add(new Line(H1, G1));
            ListEdge.Add(new Line(G1, F1));
            ListEdge.Add(new Line(F1, M));
            /**=======================================
                    HỌA TIẾT MÁY BAY
            /**=======================================*/
            ListEdge.Add(new Line(REC4, N));
            ListEdge.Add(new Line(REC41, N1));

            ListEdge.Add(new Line(CRS1, CRS2));
            ListEdge.Add(new Line(CRS2, CRS3));

            ListEdge.Add(new Line(CRS4, CRS5));
            ListEdge.Add(new Line(CRS4, CRS6));

            ListEdge.Add(new Line(CRS7, CRS8));
            ListEdge.Add(new Line(CRS7, CRS9));

            ListEdge.Add(new Line(CRS10, CRS11));
            ListEdge.Add(new Line(CRS10, CRS12));

            ListEdge.Add(new Line(CRS13, CRS14));
            ListEdge.Add(new Line(CRS15, CRS16));
            /**=======================================
                            CÁNH MÁY BAY
            /**=======================================*/
            ListEdge.Add(new Line(O, P));
            ListEdge.Add(new Line(P, Q));
            ListEdge.Add(new Line(Q, R));

        }
        public void Show(Graphics g, Panel panel)
        {
            foreach (var item in ListEdge) item.Show(g);
            if (alreadyAdded) return;
            alreadyAdded = true;
            Panel = panel;
            Graphic = g;
            time.Interval = 1000;
            time.Tick += new EventHandler(t_Tick);
            time.Start();
        }

        public void Translation(double trX, double trY)
        {
            ListEdge.Clear();
            /*
             * *thân trên máy bay
             */
            A = PhepToan.Translation(A, trX, trY, 0);
            B = PhepToan.Translation(B, trX, trY, 0);
            C = PhepToan.Translation(C, trX, trY, 0);
            D = PhepToan.Translation(D, trX, trY, 0);
            E = PhepToan.Translation(E, trX, trY, 0);
            F = PhepToan.Translation(F, trX, trY, 0);
            G = PhepToan.Translation(G, trX, trY, 0);
            H = PhepToan.Translation(H, trX, trY, 0);
            /*
             * *thân dưới máy bay
             */
            G1 = PhepToan.Translation(G1, trX, trY, 0);
            H1 = PhepToan.Translation(H1, trX, trY, 0);
            F1 = PhepToan.Translation(F1, trX, trY, 0);
            M = PhepToan.Translation(M, trX, trY, 0);
            /*
             * *mũi máy bay
             */
            REC1 = PhepToan.Translation(REC1, trX, trY, 0);
            REC2 = PhepToan.Translation(REC2, trX, trY, 0);
            REC3 = PhepToan.Translation(REC3, trX, trY, 0);
            /*
             * *họa tiết máy bay
             */
            REC4 = PhepToan.Translation(REC4, trX, trY, 0);
            N = PhepToan.Translation(N, trX, trY, 0);
            REC41 = PhepToan.Translation(REC41, trX, trY, 0);
            N1 = PhepToan.Translation(N1, trX, trY, 0);

            CRS1 = PhepToan.Translation(CRS1, trX, trY, 0);
            CRS2 = PhepToan.Translation(CRS2, trX, trY, 0);
            CRS3 = PhepToan.Translation(CRS3, trX, trY, 0);
            CRS4 = PhepToan.Translation(CRS4, trX, trY, 0);
            CRS5 = PhepToan.Translation(CRS5, trX, trY, 0);
            CRS6 = PhepToan.Translation(CRS6, trX, trY, 0);
            CRS7 = PhepToan.Translation(CRS7, trX, trY, 0);
            CRS8 = PhepToan.Translation(CRS8, trX, trY, 0);
            CRS9 = PhepToan.Translation(CRS9, trX, trY, 0);
            CRS10 = PhepToan.Translation(CRS10, trX, trY, 0);
            CRS11 = PhepToan.Translation(CRS11, trX, trY, 0);
            CRS12 = PhepToan.Translation(CRS12, trX, trY, 0);
            CRS13 = PhepToan.Translation(CRS13, trX, trY, 0);
            CRS14 = PhepToan.Translation(CRS14, trX, trY, 0);
            CRS15 = PhepToan.Translation(CRS15, trX, trY, 0);
            CRS16 = PhepToan.Translation(CRS16, trX, trY, 0);

            /*
             * *cách máy bay
             */
            O = PhepToan.Translation(O, trX, trY, 0);
            P = PhepToan.Translation(P, trX, trY, 0);
            Q = PhepToan.Translation(Q, trX, trY, 0);
            R = PhepToan.Translation(R, trX, trY, 0);
            /*================================================*/
            ListEdge.Add(new Line(A, B));
            ListEdge.Add(new Line(B, C));

            ListEdge.Add(new Line(C, D));
            ListEdge.Add(new Line(D, E));

            ListEdge.Add(new Line(E, F));
            ListEdge.Add(new Line(F, G));

            ListEdge.Add(new Line(G, H));
            ListEdge.Add(new Line(A, M));

            ListEdge.Add(new Line(G, D));
            /*================================================*/
            ListEdge.Add(new Line(REC1, REC3));
            ListEdge.Add(new Line(REC2, REC3));
            /*================================================*/
            ListEdge.Add(new Line(H1, G1));
            ListEdge.Add(new Line(G1, F1));
            ListEdge.Add(new Line(F1, M));
            /*================================================*/
            ListEdge.Add(new Line(REC4, N));
            ListEdge.Add(new Line(REC41, N1));

            ListEdge.Add(new Line(CRS1, CRS2));
            ListEdge.Add(new Line(CRS2, CRS3));

            ListEdge.Add(new Line(CRS4, CRS5));
            ListEdge.Add(new Line(CRS4, CRS6));

            ListEdge.Add(new Line(CRS7, CRS8));
            ListEdge.Add(new Line(CRS7, CRS9));

            ListEdge.Add(new Line(CRS10, CRS11));
            ListEdge.Add(new Line(CRS10, CRS12));

            ListEdge.Add(new Line(CRS13, CRS14));
            ListEdge.Add(new Line(CRS15, CRS16));
            /*================================================*/
            ListEdge.Add(new Line(O, P));
            ListEdge.Add(new Line(P, Q));
            ListEdge.Add(new Line(Q, R));
        }

    }
}
