using System;
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

        #region Hành Động Khi Load xong Form chính
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

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            VeTrucToaDo();
        }
        #endregion

        #region Hàm cho Hệ Trục Tọa Độ: Zoom, Vẽ Oxy, Vẽ Oxyz
        private void ZoomOut(object sender, EventArgs e)
        {
            if (Init.zoom - 1 < 2) return;
            Init.zoom--;
            label2.Text = Init.zoom.ToString();
            VeTrucToaDo();
            // Hiện thị hình ảnh
            ShowAllShape();
            // Hiện thị Label Của Point
            ShowLabel();
        }

        private void ZoomIn(object sender, EventArgs e)
        {
            if (Init.zoom + 1 > 10) return;
            Init.zoom++;
            label2.Text = Init.zoom.ToString();
            VeTrucToaDo();
            // Hiện thị hình ảnh
            ShowAllShape();
            // Hiện thị Label Của Point
            ShowLabel();
        }
        private void DrawCoordinate()
        {
            Pen pen = new Pen(Constants.Color_Vector_Coordinate_System, 1);
            int i = 0;

            Point O = new Point(Init.NewSize2D.Width, Init.NewSize2D.Height);
            Pen p = new Pen(Constants.Color_Pixel_Grid);

            // Vẽ lưới
            for (i = O.X; i < panel2.Width; i += Init.zoom) g.DrawLine(p, i, 0, i, panel2.Height);
            for (i = O.X; i > 0; i -= Init.zoom) g.DrawLine(p, i, 0, i, panel2.Height);
            for (i = O.Y; i < panel2.Height; i += Init.zoom) g.DrawLine(p, 0, i, panel2.Width, i);
            for (i = O.Y; i > 0; i -= Init.zoom) g.DrawLine(p, 0, i, panel2.Width, i);


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
            g.DrawLine(pen, O.X, O.Y, 0 - Convert.ToInt32(panel2.Width / 3.5), panel2.Width);

        }

        private void VeTrucToaDo()
        {

            g.Clear(Constants.Background_Color_Coordinate_System);
            PageSizeLabel.Text = panel2.Width + " x " + panel2.Height;
            if (Init.ModeCurrent == Constants.Mode._2DMode)
            {
                Init.NewSize2D.Width = panel2.Width / 2;
                Init.NewSize2D.Height = panel2.Height / 2;
                DrawCoordinate();
            }
            else
            {
                Init.NewSize3D.Width = Convert.ToInt32(panel2.Width / 2.5);
                Init.NewSize3D.Height = Convert.ToInt32(panel2.Height / 2);
                DrawCoordinate3D();
            }

        }
        #endregion

        #region Hành Động Thay Đổi Mode 2D <-> 3D
        private void Btn_3D_Click(object sender, EventArgs e)
        {
            panel7.Enabled = false;
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
            panel7.Enabled = true;
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
        #endregion

        #region Hàm Bổ Trợ Lúc Vẽ
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

        private void ClearLabelAt(string name)
        {
            ListLabel.RemoveAt(ListLabel.FindIndex(item => item.Name == name));
        }
        #endregion



        #region Hành Động Chuột
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
                        case Constants.Shape.Elip:
                            PanelElip.Instance.X = StartPoint.X;
                            PanelElip.Instance.Y = StartPoint.Y;
                            break;
                        case Constants.Shape.Default:
                            break;
                    }
                }
            }
        }

        // Hành Động Sau khi Thả Chuột
        private void StopDraw(object sender, MouseEventArgs e)
        {
            if (EndPoint == null) return;

            // Nếu mode = 2D thì làm
            if (Init.ModeCurrent == Constants.Mode._2DMode)
            {
                switch (Init.ShapeCurrent)
                {
                    case Constants.Shape.Line:
                        ListLabel.Add(StartPoint.SetLabel("line_" + ListLine.Count + "_1"));
                        ListLabel.Add(EndPoint.SetLabel("line_" + ListLine.Count + "_2"));
                        ListLine.Add(new Line(StartPoint, EndPoint));
                        PanelLine.Instance.X2 = EndPoint.X;
                        PanelLine.Instance.Y2 = EndPoint.Y;
                        break;
                    case Constants.Shape.Circle:
                        ListLabel.Add(StartPoint.SetLabel("circle_" + ListCircle.Count + "_1"));
                        Circle htron = new Circle(StartPoint, Point.Distance(StartPoint, EndPoint));
                        ListCircle.Add(htron);
                        PanelCircle.Instance.Radius = Convert.ToDecimal(htron.Radius);
                        break;
                    case Constants.Shape.Elip:
                        ListLabel.Add(StartPoint.SetLabel("elip_"+ListElip.Count + "_1"));
                        Elip elip = new Elip(StartPoint, Math.Abs(EndPoint.X - StartPoint.X), Math.Abs(EndPoint.Y - StartPoint.Y));
                        ListElip.Add(elip);
                        PanelElip.Instance.X = elip.Center.X;
                        PanelElip.Instance.Y = elip.Center.Y;
                        PanelElip.Instance.MajorAxis = elip.MajorAxis;
                        PanelElip.Instance.MinorAxis = elip.MinorAxis;
                        break;
                    case Constants.Shape.Rectangle:
                        Rectangle hinhcn = new Rectangle(StartPoint, EndPoint);
                        ListLabel.Add(StartPoint.SetLabel("rectangle_" + ListRectangle.Count + "_1"));
                        ListLabel.Add(EndPoint.SetLabel("rectangle_" + ListRectangle.Count + "_2"));
                        ListLabel.Add(hinhcn.B.SetLabel("rectangle_" + ListRectangle.Count + "_3"));
                        ListLabel.Add(hinhcn.D.SetLabel("rectangle_" + ListRectangle.Count + "_4"));
                        ListRectangle.Add(hinhcn);
                        PanelRectangle.Instance.A_Edge = hinhcn.Width;
                        PanelRectangle.Instance.B_Edge = hinhcn.Height;
                       
                        break;
                    case Constants.Shape.Triangle:
                        Triangle hinhtamgiac = new Triangle(StartPoint, EndPoint);
                        ListLabel.Add(StartPoint.SetLabel("triangle_" + ListTriangle.Count + "_1"));
                        ListLabel.Add(EndPoint.SetLabel("triangle_" + ListTriangle.Count + "_2"));
                        ListLabel.Add(hinhtamgiac.B.SetLabel("triangle_" + ListTriangle.Count + "_3"));
                        ListTriangle.Add(hinhtamgiac);

                        PanelTriangle.Instance.X2 = hinhtamgiac.B.X;
                        PanelTriangle.Instance.Y2 = hinhtamgiac.B.Y;

                        PanelTriangle.Instance.X3 = EndPoint.X;
                        PanelTriangle.Instance.Y3 = EndPoint.Y;

                        
                        break;
                    case Constants.Shape.Default:
                        break;
                }
                // Hiện thị hình ảnh
                ShowAllShape();
                // Hiện thị Label Của Point
                ShowLabel();
                EndPoint = StartPoint = null;
            }
            
        }

        #endregion


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
            StartPoint = null;
            EndPoint = null;
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

                        ListLabel.Add(StartPoint.SetLabel("line_" + ListLine.Count + "_1"));
                        ListLabel.Add(EndPoint.SetLabel("line_" + ListLine.Count + "_2"));
                        ListLine.Add(new Line(StartPoint, EndPoint));
                        break;
                    case Constants.Shape.Circle:
                        StartPoint = new Point(Convert.ToInt32(PanelCircle.Instance.X), Convert.ToInt32(PanelCircle.Instance.Y));
                        EndPoint = new Point(
                            Convert.ToInt32(PanelCircle.Instance.X) + Convert.ToInt32(PanelCircle.Instance.Radius),
                            Convert.ToInt32(PanelCircle.Instance.Y)
                        );
                        ListLabel.Add(StartPoint.SetLabel("circle_" + ListLine.Count + "_1"));
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
                        ListLabel.Add(StartPoint.SetLabel("elip_" + ListLine.Count + "_1"));
                        break;
                    case Constants.Shape.Rectangle:
                        StartPoint = new Point(Convert.ToInt32(PanelRectangle.Instance.X), Convert.ToInt32(PanelRectangle.Instance.Y));
                        EndPoint = new Point(
                            Convert.ToInt32(PanelRectangle.Instance.X) + Convert.ToInt32(PanelRectangle.Instance.A_Edge),
                            Convert.ToInt32(PanelRectangle.Instance.Y) + Convert.ToInt32(PanelRectangle.Instance.B_Edge)
                        );
                        Rectangle hinhcn = new Rectangle(StartPoint, EndPoint);
                        ListLabel.Add(StartPoint.SetLabel("rectangle_" + ListRectangle.Count + "_1"));
                        ListLabel.Add(EndPoint.SetLabel("rectangle_" + ListRectangle.Count + "_2"));
                        ListLabel.Add(hinhcn.B.SetLabel("rectangle_" + ListRectangle.Count + "_3"));
                        ListLabel.Add(hinhcn.D.SetLabel("rectangle_" + ListRectangle.Count + "_4"));
                        ListRectangle.Add(hinhcn);
                        break;
                    case Constants.Shape.Triangle:
                        StartPoint = new Point(Convert.ToInt32(PanelTriangle.Instance.X1), Convert.ToInt32(PanelTriangle.Instance.Y1));
                        EndPoint = new Point(Convert.ToInt32(PanelTriangle.Instance.X3), Convert.ToInt32(PanelTriangle.Instance.Y3));
                        Triangle hinhtamgiac = new Triangle(StartPoint, EndPoint);
                        ListLabel.Add(StartPoint.SetLabel("triangle_" + ListTriangle.Count + "_1"));
                        ListLabel.Add(EndPoint.SetLabel("triangle_" + ListTriangle.Count + "_2"));
                        ListLabel.Add(hinhtamgiac.B.SetLabel("triangle_" + ListTriangle.Count + "_3"));
                        ListTriangle.Add(hinhtamgiac);
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

                        //ListLabel.Add(newCube.A.SetLabel());
                        //ListLabel.Add(newCube.B.SetLabel());
                        //ListLabel.Add(newCube.C.SetLabel());
                        //ListLabel.Add(newCube.D.SetLabel());
                        //ListLabel.Add(newCube.E.SetLabel());
                        //ListLabel.Add(newCube.F.SetLabel());
                        //ListLabel.Add(newCube.G.SetLabel());
                        //ListLabel.Add(newCube.H.SetLabel());
                        break;
                    case Constants.Shape.Sphere:
                        StartPoint = new Point(
                            Convert.ToInt32(PanelSphere.Instance.X),
                            Convert.ToInt32(PanelSphere.Instance.Y),
                            Convert.ToInt32(PanelSphere.Instance.Z)
                        );
                        Sphere hinhcau = new Sphere(StartPoint, Convert.ToInt32(PanelSphere.Instance.Radius));
                        ListSphere.Add(hinhcau);
                        //ListLabel.Add(StartPoint.SetLabel());
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
                        //ListLabel.Add(StartPoint.SetLabel());
                        //ListLabel.Add(hinhnon.B.SetLabel());
                        //ListLabel.Add(hinhnon.C.SetLabel());
                        //ListLabel.Add(hinhnon.D.SetLabel());
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
                        //ListLabel.Add(hinhtru.A.SetLabel());
                        //ListLabel.Add(hinhtru.B.SetLabel());
                        //ListLabel.Add(hinhtru.C.SetLabel());
                        //ListLabel.Add(hinhtru.D.SetLabel());
                        //ListLabel.Add(hinhtru.E.SetLabel());
                        //ListLabel.Add(hinhtru.F.SetLabel());
                        break;
                    case Constants.Shape.Default:
                        break;
                }
            }

            ShowAllShape();
            ShowLabel();
        }

        #region Phép Toán Cho Hinh 2D
        private void RotateAllShape(int degrees)
        {
            ClearLabel();
            int index = 0;
            foreach (Line item in ListLine)
            {
                ClearLabelAt("line_" + index + "_1");
                ClearLabelAt("line_" + index + "_2");
                item.Hide(g);
                item.Rotate(degrees);
                item.Show(g);
                ListLabel.Add(item.First.SetLabel("line_" + index + "_1"));
                ListLabel.Add(item.Last.SetLabel("line_" + index + "_2"));
                index++;
            }
            index = 0;
            foreach (Circle item in ListCircle)
            {
                ClearLabelAt("circle_" + index + "_1");
                item.Hide(g);
                item.Rotate(degrees);
                item.Show(g);
                ListLabel.Add(item.Center.SetLabel("circle_" + index + "_1"));
                index++;
            }
            index = 0;
            foreach (Rectangle item in ListRectangle)
            {
                ClearLabelAt("rectangle_" + index + "_1");
                ClearLabelAt("rectangle_" + index + "_2");
                ClearLabelAt("rectangle_" + index + "_3");
                ClearLabelAt("rectangle_" + index + "_4");
                item.Hide(g);
                item.Rotate(degrees);
                item.Show(g);
                ListLabel.Add(item.A.SetLabel("rectangle_" + index + "_1"));
                ListLabel.Add(item.B.SetLabel("rectangle_" + index + "_2"));
                ListLabel.Add(item.C.SetLabel("rectangle_" + index + "_3"));
                ListLabel.Add(item.D.SetLabel("rectangle_" + index + "_4"));
                index++;
            }
            index = 0;
            foreach (Triangle item in ListTriangle)
            {
                ClearLabelAt("triangle_" + index + "_1");
                ClearLabelAt("triangle_" + index + "_2");
                ClearLabelAt("triangle_" + index + "_3");
                item.Hide(g);
                item.Rotate(degrees);
                item.Show(g);
                ListLabel.Add(item.A.SetLabel("triangle_" + index + "_1"));
                ListLabel.Add(item.B.SetLabel("triangle_" + index + "_2"));
                ListLabel.Add(item.C.SetLabel("triangle_" + index + "_3"));
                index++;
            }
            index = 0;
            foreach (Elip item in ListElip)
            {
                ClearLabelAt("elip_" + index + "_1");
                item.Hide(g);
                item.Rotate(degrees);
                item.Show(g);
                ListLabel.Add(item.Center.SetLabel("elip_" + index + "_1"));
                index++;
            }
            ShowLabel();
        }

        private void FlipAllShape(int type)
        {
            ClearLabel();
            int index = 0;
            foreach (Line item in ListLine)
            {
                ClearLabelAt("line_" + index + "_1");
                ClearLabelAt("line_" + index + "_2");
                item.Hide(g);
                item.Reflection(type);
                item.Show(g);
                ListLabel.Add(item.First.SetLabel("line_" + index + "_1"));
                ListLabel.Add(item.Last.SetLabel("line_" + index + "_2"));
                index++;
            }
            index = 0;
            foreach (Circle item in ListCircle)
            {
                ClearLabelAt("circle_" + index + "_1");
                item.Hide(g);
                item.Reflection(type);
                item.Show(g);
                ListLabel.Add(item.Center.SetLabel("circle_" + index + "_1"));
                index++;
            }
            index = 0;
            foreach (Rectangle item in ListRectangle)
            {
                ClearLabelAt("rectangle_" + index + "_1");
                ClearLabelAt("rectangle_" + index + "_2");
                ClearLabelAt("rectangle_" + index + "_3");
                ClearLabelAt("rectangle_" + index + "_4");
                item.Hide(g);
                item.Reflection(type);
                item.Show(g);
                ListLabel.Add(item.A.SetLabel("rectangle_" + index + "_1"));
                ListLabel.Add(item.B.SetLabel("rectangle_" + index + "_2"));
                ListLabel.Add(item.C.SetLabel("rectangle_" + index + "_3"));
                ListLabel.Add(item.D.SetLabel("rectangle_" + index + "_4"));
                index++;
            }
            index = 0;
            foreach (Triangle item in ListTriangle)
            {
                ClearLabelAt("triangle_" + index + "_1");
                ClearLabelAt("triangle_" + index + "_2");
                ClearLabelAt("triangle_" + index + "_3");
                item.Hide(g);
                item.Reflection(type);
                item.Show(g);
                ListLabel.Add(item.A.SetLabel("triangle_" + index + "_1"));
                ListLabel.Add(item.B.SetLabel("triangle_" + index + "_2"));
                ListLabel.Add(item.C.SetLabel("triangle_" + index + "_3"));
                index++;
            }
            index = 0;
            foreach (Elip item in ListElip)
            {
                ClearLabelAt("elip_" + index + "_1");
                item.Hide(g);
                item.Reflection(type);
                item.Show(g);
                ListLabel.Add(item.Center.SetLabel("elip_" + index + "_1"));
                index++;
            }
            ShowLabel();
        }

        private void RotateRight90_Click(object sender, EventArgs e)
        {
            RotateAllShape(-90);
        }

        private void RotateLeft90_Click(object sender, EventArgs e)
        {
            RotateAllShape(90);
        }

        private void FlipVertical_Click(object sender, EventArgs e)
        {
            FlipAllShape(-1);
        }

        private void FlipHorizontal_Click(object sender, EventArgs e)
        {
            FlipAllShape(1);
        }
        #endregion


        #region Phép Toán Cho Hinh 3D
        private void ScaleAllShape(double ratio)
        {
            ClearLabel();
            if (Init.ModeCurrent == Constants.Mode._2DMode)
            {
                int index = 0;
                foreach (Line item in ListLine)
                {
                    ClearLabelAt("line_" + index + "_1");
                    ClearLabelAt("line_" + index + "_2");
                    item.Hide(g);
                    item.Scale(ratio);
                    item.Show(g);
                    ListLabel.Add(item.First.SetLabel("line_" + index + "_1"));
                    ListLabel.Add(item.Last.SetLabel("line_" + index + "_2"));
                    index++;
                }
                index = 0;
                foreach (Circle item in ListCircle)
                {
                    ClearLabelAt("circle_" + index + "_1");
                    item.Hide(g);
                    item.Scale(ratio);
                    item.Show(g);
                    ListLabel.Add(item.Center.SetLabel("circle_" + index + "_1"));
                    index++;
                }
                index = 0;
                foreach (Rectangle item in ListRectangle)
                {
                    ClearLabelAt("rectangle_" + index + "_1");
                    ClearLabelAt("rectangle_" + index + "_2");
                    ClearLabelAt("rectangle_" + index + "_3");
                    ClearLabelAt("rectangle_" + index + "_4");
                    item.Hide(g);
                    item.Scale(ratio);
                    item.Show(g);
                    ListLabel.Add(item.A.SetLabel("rectangle_" + index + "_1"));
                    ListLabel.Add(item.B.SetLabel("rectangle_" + index + "_2"));
                    ListLabel.Add(item.C.SetLabel("rectangle_" + index + "_3"));
                    ListLabel.Add(item.D.SetLabel("rectangle_" + index + "_4"));
                    index++;
                }
                index = 0;
                foreach (Triangle item in ListTriangle)
                {
                    ClearLabelAt("triangle_" + index + "_1");
                    ClearLabelAt("triangle_" + index + "_2");
                    ClearLabelAt("triangle_" + index + "_3");
                    item.Hide(g);
                    item.Scale(ratio);
                    item.Show(g);
                    ListLabel.Add(item.A.SetLabel("triangle_" + index + "_1"));
                    ListLabel.Add(item.B.SetLabel("triangle_" + index + "_2"));
                    ListLabel.Add(item.C.SetLabel("triangle_" + index + "_3"));
                    index++;
                }
                index = 0;
                foreach (Elip item in ListElip)
                {
                    ClearLabelAt("elip_" + index + "_1");
                    item.Hide(g);
                    item.Scale(ratio);
                    item.Show(g);
                    ListLabel.Add(item.Center.SetLabel("elip_" + index + "_1"));
                    index++;
                }
            }
            else
            {
                VeTrucToaDo();
                foreach (Sphere item in ListSphere)
                {
                    item.Scale(ratio);
                    item.Show(g);
                }
                foreach (Cube item in ListCube)
                {
                    item.Hide(g);
                    item.Scale(ratio);
                    item.Show(g);
                }
                foreach (Cone item in ListCone)
                {
                    item.Hide(g);
                    item.Scale(ratio);
                    item.Show(g);
                }
                foreach (Cylinder item in ListCylinder)
                {
                    item.Hide(g);
                    item.Scale(ratio);
                    item.Show(g);
                }
            }
            ShowLabel();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            ScaleAllShape(0.75);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            ScaleAllShape(0.25);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            ScaleAllShape(0.5);
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            ScaleAllShape(2);
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScaleAllShape(4);
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScaleAllShape(5);
        }

        #endregion
    }
}
