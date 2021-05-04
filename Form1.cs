﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KTDH_Nhom23_DoAnCuoiKy.Class._2D;
using KTDH_Nhom23_DoAnCuoiKy.Class._3D;
using KTDH_Nhom23_DoAnCuoiKy.UI;
using KTDH_Nhom23_DoAnCuoiKy.Variables;
using Rectangle = KTDH_Nhom23_DoAnCuoiKy.Class._2D.Rectangle;

namespace KTDH_Nhom23_DoAnCuoiKy
{
    public partial class Form1 : Form
    {

        internal List<Point> ListDiemTamThoi = new List<Point>();
        internal List<Line> ListLine = new List<Line>();
        internal List<Circle> ListCircle = new List<Circle>();
        internal List<Rectangle> ListRectangle = new List<Rectangle>();
        internal List<Triangle> ListTriangle = new List<Triangle>();
        private Point StartPoint, EndPoint;
        private Graphics g;
        public static List<Label> ListLabel = new List<Label>();
        internal List<Sphere> ListSphere = new List<Sphere>();
        internal List<Cube> ListCube = new List<Cube>();
        internal List<Elip> ListElip = new List<Elip>();
        internal List<Cylinder> ListCylinder = new List<Cylinder>();
        internal List<Cone> ListCone = new List<Cone>();

        public static GroupBox GroupBoxInput;


        public Form1()
        {
            InitializeComponent();
        }


        private void DrawCoordinate()
        {
            Pen pen = new Pen(Constants.Color_Vector_Coordinate_System, 1);
            int i = 0;

                Point O = new Point(Init.NewSize2D.Width, Init.NewSize2D.Height);
                Pen p = new Pen(Constants.Color_Pixel_Grid);

                // Vẽ lưới
                for ( i = O.X; i < panel2.Width; i += Init.zoom) g.DrawLine(p, i, 0, i, panel2.Height);
                for ( i = O.X; i > 0; i -= Init.zoom) g.DrawLine(p, i, 0, i, panel2.Height);
                for ( i = O.Y; i < panel2.Height; i += Init.zoom) g.DrawLine(p, 0, i, panel2.Width, i);
                for ( i = O.Y; i > 0; i -= Init.zoom) g.DrawLine(p, 0, i, panel2.Width, i);


            //// Vẽ mũi tên
            //AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            //pen.CustomStartCap = bigArrow;

            // Vẽ 2 đường Ox và Oy 
            g.DrawLine(pen, panel2.Width, O.Y, 0, O.Y);
            g.DrawLine(pen, O.X, 0, O.X, panel2.Height);
        }

        private void DrawCoordinate3D()
        {
            Pen pen = new Pen(Constants.Color_Vector_Coordinate_System, 1);
            int i = 0;

            Point O = new Point(Init.NewSize3D.Width, Init.NewSize3D.Height);
            Pen p = new Pen(Constants.Color_Pixel_Grid);

            // Vẽ lưới
            for (i = O.X; i < panel2.Width; i += Init.zoom) g.DrawLine(p, i, 0, i, panel2.Height);
            for (i = O.X; i > 0; i -= Init.zoom) g.DrawLine(p, i, 0, i, panel2.Height);
            for (i = O.Y; i < panel2.Height; i += Init.zoom) g.DrawLine(p, 0, i, panel2.Width, i);
            for (i = O.Y; i > 0; i -= Init.zoom) g.DrawLine(p, 0, i, panel2.Width, i);

            //// Vẽ mũi tên
            //AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            //pen.CustomStartCap = bigArrow;

            // Vẽ 3 đường Ox, Oy và Oz
            g.DrawLine(pen, O.X, O.Y, panel2.Width, O.Y);
            g.DrawLine(pen, O.X, 0, O.X, O.Y);
            g.DrawLine(pen, O.X, O.Y, 0 - Convert.ToInt32(panel2.Width / 5), panel2.Width);

        }

        private void VeTrucToaDo()
        {
            
            g.Clear(Constants.Background_Color_Coordinate_System);
            PageSizeLabel.Text = panel2.Width + " x " + panel2.Height;
            if (Init.ModeCurrent == Constants.Mode._2DMode)
            {
                Init.NewSize2D.Width = panel2.Width/2;
                Init.NewSize2D.Height = panel2.Height/2;
                DrawCoordinate();
            }
            else
            {
                Init.NewSize3D.Width = Convert.ToInt32(panel2.Width / 2.5);
                Init.NewSize3D.Height = Convert.ToInt32(panel2.Height /2);
                DrawCoordinate3D();
            }
           
        }

        private void Btn_3D_Click(object sender, EventArgs e)
        {
            Init.ModeCurrent = Constants.Mode._3DMode;
            Init.ShapeCurrent = Constants.Shape.Sphere;
            Btn_2D.Image = Properties.Resources._2d;
            Btn_3D.Image = Properties.Resources._3d_selected;

            if (!panel3.Controls.Contains(Panel3DModel.Instance))
            {
                panel3.Controls.Add(Panel3DModel.Instance);
                Panel3DModel.Instance.Dock = DockStyle.Fill;
                Panel3DModel.Instance.BringToFront();
            }
            else Panel3DModel.Instance.BringToFront();

            Panel3DModel.reset();
            BtnClearAll_Click(null, EventArgs.Empty);
        }

        private void Btn_2D_Click(object sender, EventArgs e)
        {
            Init.ModeCurrent = Constants.Mode._2DMode;
            Btn_2D.Image = Properties.Resources._2d_selected;
            Btn_3D.Image = Properties.Resources._3d;
            if (!panel3.Controls.Contains(Panel2DModel.Instance))
            {
                panel3.Controls.Add(Panel2DModel.Instance);
                Panel2DModel.Instance.Dock = DockStyle.Fill;
                Panel2DModel.Instance.BringToFront();
            }
            else Panel2DModel.Instance.BringToFront();

            Panel2DModel.reset();
            BtnClearAll_Click(null, EventArgs.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Controls.Add(Panel2DModel.Instance);
            Panel2DModel.Instance.Dock = DockStyle.Fill;
            Panel2DModel.Instance.BringToFront();

            groupBox2.Controls.Add(PanelLine.Instance);
            PanelLine.Instance.Dock = DockStyle.Fill;
            PanelLine.Instance.BringToFront();

            GroupBoxInput = groupBox2;
            g = panel2.CreateGraphics();
        }

        private void AnToaDoTamThoi()
        {
            foreach (Point p in ListDiemTamThoi)
            {
                p.RemovePixel(g);
            }
        }

        private void HienToaDoChinh()
        {
            foreach (Point p in ListDiemTamThoi)
            {
                p.PutPixel(g);
            }
        }


        //Hành Động Kéo Rê Chuột
        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Point cursor = Point.ConvertPointToCoordinateSystem2D(new Point(e.X, e.Y));
            Lable_Cursor.Text = cursor.X + ", " + cursor.Y;

            if (e.Button == MouseButtons.Left)
            {
                // Xóa các điểm tạm thời, chỉ lấy điểm đầu và cuối. Chỗ này khó hiểu. Hãy đóng hàm //AnToaDoTamThoi rồi chạy lại sẽ hiểu. 
                AnToaDoTamThoi();

                // lấy điểm của chuột đang rê tới bỏ vào Endpoint (Chỉ là điểm cuối tạm thời chưa phải là chính thức)
                EndPoint = Point.ConvertPointToCoordinateSystem2D(new Point(e.X, e.Y));
                if (Init.ModeCurrent == Constants.Mode._2DMode)
                {
                    // kiểm tra hình đang vẽ là gì
                    switch (Init.ShapeCurrent)
                    {
                        case Constants.Shape.Line:
                            ListDiemTamThoi = new Line(StartPoint, EndPoint).List;
                            break;
                        case Constants.Shape.Circle:
                            ListDiemTamThoi = new Circle(StartPoint, Point.Distance(StartPoint, EndPoint)).List;
                            break;
                        case Constants.Shape.Rectangle:
                            ListDiemTamThoi = new Rectangle(StartPoint, EndPoint).List;
                            break;
                        case Constants.Shape.Triangle:
                            ListDiemTamThoi = new Triangle(StartPoint, EndPoint).List;
                            break;
                        case Constants.Shape.Elip:
                            ListDiemTamThoi = new Elip(StartPoint, Math.Abs(EndPoint.X - StartPoint.X), Math.Abs(EndPoint.Y - StartPoint.Y)).List;
                            break;
                        case Constants.Shape.Default:
                            break;
                    }
                }
                // Hiện Tọa Độ Đầu Và cuối của mỗi hình, sau khi đã lọc hết các tọa độ tạm thời
                HienToaDoChinh();

            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            VeTrucToaDo();
        }

        private void ShowAllShape()
        {
            // vẽ lại tất cả hình 2D
            foreach (Line p in ListLine) p.Show(g);
            foreach (Circle p in ListCircle) p.Show(g);
            foreach (Rectangle p in ListRectangle) p.Show(g);
            foreach (Triangle p in ListTriangle) p.Show(g);
            foreach (Elip p in ListElip) p.Show(g);

            // vẽ lại tất cả hình 3D
            foreach (Cube p in ListCube) p.Show(g);
            foreach (Sphere p in ListSphere) p.Show(g);
            foreach (Cylinder p in ListCylinder) p.Show(g);
            foreach (Cone p in ListCone) p.Show(g);
        }


        // Hành Động Sau khi Thả Chuột
        private void StopDraw(object sender, MouseEventArgs e)
        {
            // Nếu mode = 2D thì làm
            if (Init.ModeCurrent == Constants.Mode._2DMode)
            {
                ListLabel.Add(StartPoint.SetLabel());
                switch (Init.ShapeCurrent)
                {
                    case Constants.Shape.Line:
                        ListLine.Add(new Line(StartPoint, EndPoint));
                        ListLabel.Add(EndPoint.SetLabel());
                        PanelLine.Instance.X2 = EndPoint.X;
                        PanelLine.Instance.Y2 = EndPoint.Y;
                        break;
                    case Constants.Shape.Circle:
                        Circle htron = new Circle(StartPoint, Point.Distance(StartPoint, EndPoint));
                        ListCircle.Add(htron);
                        PanelCircle.Instance.Radius = Convert.ToDecimal(htron.Radius);
                        break;
                    case Constants.Shape.Rectangle:
                        Rectangle hinhcn = new Rectangle(StartPoint, EndPoint);
                        ListRectangle.Add(hinhcn);
                        PanelRectangle.Instance.A_Edge = hinhcn.Width;
                        PanelRectangle.Instance.B_Edge = hinhcn.Height;

                        ListLabel.Add(EndPoint.SetLabel());
                        ListLabel.Add(hinhcn.B.SetLabel());
                        ListLabel.Add(hinhcn.D.SetLabel());
                        break;
                    case Constants.Shape.Triangle:
                        Triangle hinhtamgiac = new Triangle(StartPoint, EndPoint);
                        ListTriangle.Add(hinhtamgiac);

                        PanelTriangle.Instance.X2 = hinhtamgiac.B.X;
                        PanelTriangle.Instance.Y2 = hinhtamgiac.B.Y;

                        PanelTriangle.Instance.X3 = EndPoint.X;
                        PanelTriangle.Instance.Y3 = EndPoint.Y;

                        ListLabel.Add(EndPoint.SetLabel());
                        ListLabel.Add(hinhtamgiac.B.SetLabel());
                        break;
                    case Constants.Shape.Default:
                        break;
                }
                // Hiện thị hình ảnh
                ShowAllShape();
                // Hiện thị Label Của Point
                ShowLabel();
            }
            
        }

        private void ClearLabel()
        {
            foreach (Label ctrl in ListLabel)
            {
                panel2.Controls.Remove(ctrl);
            }
            panel2.Refresh();
        }

        private void ShowLabel()
        {
            if (!Init.IsShowNamePoint) return;
            foreach (Control ctrl in ListLabel)
            {
                ctrl.BackColor = Color.Empty;
                if (!panel2.Controls.Contains(ctrl))
                    panel2.Controls.Add(ctrl);
                ctrl.Visible = true;
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            ListLine.Clear(); // Xóa Hết Danh Sách Điểm Của Đường Thẳng
            ListCircle.Clear(); // Xóa Hết Danh Sách Điểm Của Hinh Tròn
            ListTriangle.Clear(); // Xóa Hết Danh Sách Điểm Của Tam Giac
            ListRectangle.Clear(); // Xóa Hết Danh Sách Điểm Của Hinh Cn/Vuong
            ListDiemTamThoi.Clear(); // Xóa Hết Danh Sách Điểm Dư Thừa Khi Vẽ
            ListElip.Clear();
            ListSphere.Clear();
            ListCube.Clear();
            ListCylinder.Clear();
            ListCone.Clear();
            ClearLabel();
            ListLabel.Clear();
            VeTrucToaDo();
        }

        private void ShowPointName_Click(object sender, EventArgs e)
        {
            Init.IsShowNamePoint = !Init.IsShowNamePoint;
            if (Init.IsShowNamePoint)
            {
                ShowPointName.Image = Properties.Resources.switch_on;
                ShowLabel();
            }
            else
            {
                ShowPointName.Image = Properties.Resources.switch_off;
                ClearLabel();
                ShowAllShape();
            }
           
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            if (Init.ModeCurrent == Constants.Mode._2DMode)
            {
                switch (Init.ShapeCurrent)
                {
                    case Constants.Shape.Line:
                        StartPoint = new Point(Convert.ToInt32(PanelLine.Instance.X1), Convert.ToInt32(PanelLine.Instance.Y1));
                        EndPoint = new Point(Convert.ToInt32(PanelLine.Instance.X2), Convert.ToInt32(PanelLine.Instance.Y2));

                        ListLabel.Add(StartPoint.SetLabel());
                        ListLabel.Add(EndPoint.SetLabel());
                        ListLine.Add(new Line(StartPoint, EndPoint));
                        break;
                    case Constants.Shape.Circle:
                        StartPoint = new Point(Convert.ToInt32(PanelCircle.Instance.X), Convert.ToInt32(PanelCircle.Instance.Y));
                        EndPoint = new Point(
                            Convert.ToInt32(PanelCircle.Instance.X) + Convert.ToInt32(PanelCircle.Instance.Radius),
                            Convert.ToInt32(PanelCircle.Instance.Y)
                        );
                        ListLabel.Add(StartPoint.SetLabel());
                        ListCircle.Add(new Circle(StartPoint, Point.Distance(StartPoint, EndPoint)));
                        break;
                    case Constants.Shape.Elip:
                        StartPoint = new Point(Convert.ToInt32(PanelElip.Instance.X), Convert.ToInt32(PanelElip.Instance.Y));
                        ListElip.Add(
                            new Elip(StartPoint, 
                            Convert.ToInt32(PanelElip.Instance.MajorAxis), 
                            Convert.ToInt32(PanelElip.Instance.MinorAxis)
                            )
                        );
                        ListLabel.Add(StartPoint.SetLabel());
                        break;
                    case Constants.Shape.Rectangle:
                        StartPoint = new Point(Convert.ToInt32(PanelRectangle.Instance.X), Convert.ToInt32(PanelRectangle.Instance.Y));
                        EndPoint = new Point(
                            Convert.ToInt32(PanelRectangle.Instance.X) + Convert.ToInt32(PanelRectangle.Instance.A_Edge),
                            Convert.ToInt32(PanelRectangle.Instance.Y) + Convert.ToInt32(PanelRectangle.Instance.B_Edge)
                        );
                        Rectangle hinhcn = new Rectangle(StartPoint, EndPoint);
                        ListRectangle.Add(hinhcn);
                        ListLabel.Add(StartPoint.SetLabel());
                        ListLabel.Add(EndPoint.SetLabel());
                        ListLabel.Add(hinhcn.B.SetLabel());
                        ListLabel.Add(hinhcn.D.SetLabel());
                        break;
                    case Constants.Shape.Triangle:
                        StartPoint = new Point(Convert.ToInt32(PanelTriangle.Instance.X1), Convert.ToInt32(PanelTriangle.Instance.Y1));
                        EndPoint = new Point(Convert.ToInt32(PanelTriangle.Instance.X3), Convert.ToInt32(PanelTriangle.Instance.Y3));
                        Triangle hinhtamgiac = new Triangle(StartPoint, EndPoint);
                        ListTriangle.Add(hinhtamgiac);
                        ListLabel.Add(EndPoint.SetLabel());
                        ListLabel.Add(hinhtamgiac.B.SetLabel());
                        break;
                    case Constants.Shape.Default:
                        break;
                }
            }

            // Nếu Mode = 3D
            else
            {
                switch (Init.ShapeCurrent)
                {
                    case Constants.Shape.Cube:
                        StartPoint = new Point(
                            Convert.ToInt32(PanelCube.Instance.X), 
                            Convert.ToInt32(PanelCube.Instance.Y), 
                            Convert.ToInt32(PanelCube.Instance.Z),
                            "A"
                        );
                        StartPoint.PutPixel(g);

                        Cube newCube = new Cube(StartPoint, Convert.ToInt32(PanelCube.Instance.Edge));
                        ListCube.Add(newCube);

                        ListLabel.Add(newCube.A.SetLabel());
                        ListLabel.Add(newCube.B.SetLabel());
                        ListLabel.Add(newCube.C.SetLabel());
                        ListLabel.Add(newCube.D.SetLabel());
                        ListLabel.Add(newCube.E.SetLabel());
                        ListLabel.Add(newCube.F.SetLabel());
                        ListLabel.Add(newCube.G.SetLabel());
                        ListLabel.Add(newCube.H.SetLabel());
                        break;
                    case Constants.Shape.Sphere:
                        StartPoint = new Point(
                            Convert.ToInt32(PanelSphere.Instance.X),
                            Convert.ToInt32(PanelSphere.Instance.Y),
                            Convert.ToInt32(PanelSphere.Instance.Z)
                        );
                        Sphere hinhcau = new Sphere(StartPoint, Convert.ToInt32(PanelSphere.Instance.Radius));
                        ListSphere.Add(hinhcau);
                        ListLabel.Add(StartPoint.SetLabel());
                        break;
                    case Constants.Shape.Cone:
                        StartPoint = new Point(
                            Convert.ToInt32(PanelSphere.Instance.X),
                            Convert.ToInt32(PanelSphere.Instance.Y),
                            Convert.ToInt32(PanelSphere.Instance.Z),
                            "A"
                        );
                        Cone hinhnon = new Cone(
                            StartPoint, 
                            Convert.ToInt32(PanelCone.Instance.ChieuCao), 
                            Convert.ToInt32(PanelCone.Instance.Radius)
                        );
                        ListCone.Add(hinhnon);
                        ListLabel.Add(StartPoint.SetLabel());
                        ListLabel.Add(hinhnon.B.SetLabel());
                        ListLabel.Add(hinhnon.C.SetLabel());
                        ListLabel.Add(hinhnon.D.SetLabel());
                        break;
                    case Constants.Shape.Cylinder:
                        StartPoint = new Point(
                            Convert.ToInt32(PanelSphere.Instance.X),
                            Convert.ToInt32(PanelSphere.Instance.Y),
                            Convert.ToInt32(PanelSphere.Instance.Z),
                            "B"
                        );
                        Cylinder hinhtru = new Cylinder(
                            StartPoint, 
                            Convert.ToInt32(PanelCylinder.Instance.ChieuCao), 
                            Convert.ToInt32(PanelCylinder.Instance.Radius)
                        );
                        ListCylinder.Add(hinhtru);
                        ListLabel.Add(hinhtru.A.SetLabel());
                        ListLabel.Add(hinhtru.B.SetLabel());
                        ListLabel.Add(hinhtru.C.SetLabel());
                        ListLabel.Add(hinhtru.D.SetLabel());
                        ListLabel.Add(hinhtru.E.SetLabel());
                        ListLabel.Add(hinhtru.F.SetLabel());
                        break;
                    case Constants.Shape.Default:
                        break;
                }
            }

            ShowAllShape();
            ShowLabel();
        }

        // Hành Động bắt đầu Click chuột để vẽ
        private void StartDraw(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Xóa Hết Điểm Tạm Thời Đi
                ListDiemTamThoi.Clear();
                // Lấy điểm bắt đâu khi click chuột. và đổi tọa độ chuột sang tọa độ Oxy
                StartPoint = Point.ConvertPointToCoordinateSystem2D(new Point(e.X, e.Y));

                if (Init.ModeCurrent == Constants.Mode._2DMode)
                {
                    switch (Init.ShapeCurrent)
                    {
                        case Constants.Shape.Line:
                            PanelLine.Instance.X1 = StartPoint.X;
                            PanelLine.Instance.Y1 = StartPoint.Y;
                            break;
                        case Constants.Shape.Circle:
                            PanelCircle.Instance.X = StartPoint.X;
                            PanelCircle.Instance.Y = StartPoint.Y;
                            break;
                        case Constants.Shape.Rectangle:
                            PanelRectangle.Instance.X = StartPoint.X;
                            PanelRectangle.Instance.Y = StartPoint.Y;
                            break;
                        case Constants.Shape.Triangle:
                            PanelTriangle.Instance.X1 = StartPoint.X;
                            PanelTriangle.Instance.Y1 = StartPoint.Y;
                            break;
                        case Constants.Shape.Default:
                            break;
                    }
                }
            }
        }
    }
}
