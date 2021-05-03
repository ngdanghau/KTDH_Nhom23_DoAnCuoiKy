using KTDH_Nhom23_DoAnCuoiKy.Variables;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy
{
    class Point
    {
        private int x, y, z;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }

        public Label SetLabel()
        {
            Point temp = ConvertCoordinateSystem2DToPoint(new Point(X, Y));
            int x1, y1;
            if (X >= 0 && Y >= 0){
                x1 = temp.X + 10;
                y1 = temp.Y - 10;
            }
            else if (X >= 0 && Y < 0){
                x1 = temp.X + 10;
                y1 = temp.Y + 10;
            }
            else if (X < 0 && Y < 0){
                x1 = temp.X - 10;
                y1 = temp.Y + 10;
            }
            else {
                x1 = temp.X - 10;
                y1 = temp.Y - 10;
            }

            Label lb = new Label();
            lb.Text = "(" + X + "," + Y + ")"; ;
            lb.Location = new System.Drawing.Point(x1, y1);
            lb.Width = Convert.ToInt32(lb.Font.Size) * lb.Text.Length - 10;
            return lb;
        }

        // Vẽ Điểm Pixel
        public void PutPixel(Graphics g, int zoom = 0)
        {
            if (zoom == 0) zoom = Init.zoom;
            SolidBrush brush = new SolidBrush(Constants.Color_Point_Pixel);
            Point O = new Point(Init.NewSize2D.Width, Init.NewSize2D.Height);
            if (Init.ModeCurrent == Constants.Mode._3DMode)
            {
                O = new Point(Init.NewSize3D.Width, Init.NewSize3D.Height);
                g.FillRectangle(brush, O.X + X * Init.zoom - Init.zoom / 2 - Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Init.zoom, O.Y - Y * Init.zoom - Init.zoom / 2 + Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Init.zoom, zoom, zoom);
            }
            else
            {
                g.FillRectangle(brush, O.X + X * Init.zoom - Init.zoom / 2, O.Y - Y * Init.zoom - Init.zoom / 2, zoom, zoom);
            }

        }

        // Xóa các điểm thừa khi vẽ
        public void RemovePixel(Graphics g)
        {
            Point O = new Point(Init.NewSize2D.Width, Init.NewSize2D.Height);
            if (Init.ModeCurrent == Constants.Mode._3DMode)
            {
                O = new Point(Init.NewSize3D.Width, Init.NewSize3D.Height);
            }
            SolidBrush brush = new SolidBrush(Constants.Background_Color_Coordinate_System);
            g.FillRectangle(brush, O.X + X * Init.zoom - Init.zoom / 2, O.Y - Y * Init.zoom - Init.zoom / 2, Init.zoom / 2, Init.zoom / 2);
            g.FillRectangle(brush, O.X + X * Init.zoom + 1, O.Y - Y * Init.zoom - Init.zoom / 2, Init.zoom / 2, Init.zoom / 2);
            g.FillRectangle(brush, O.X + X * Init.zoom - Init.zoom / 2, O.Y - Y * Init.zoom + 1, Init.zoom / 2, Init.zoom / 2);
            g.FillRectangle(brush, O.X + X * Init.zoom + 1, O.Y - Y * Init.zoom + 1, Init.zoom / 2, Init.zoom / 2);
            g.DrawLine(new Pen(Constants.Color_Pixel_Grid), O.X + X * Init.zoom - Init.zoom / 2, O.Y - Y * Init.zoom, O.X + X * Init.zoom + Init.zoom / 2, O.Y - Y * Init.zoom);
            g.DrawLine(new Pen(Constants.Color_Pixel_Grid), O.X + X * Init.zoom, O.Y - Y * Init.zoom - Init.zoom / 2, O.X + X * Init.zoom, O.Y - Y * Init.zoom + Init.zoom / 2);
           
            // Vẽ lại trục Ox, Oy
            Pen pen = new Pen(Constants.Color_Vector_Coordinate_System);
            if (X == 0)
            {
                g.DrawLine(pen, O.X + X * Init.zoom, O.Y - Y * Init.zoom - Init.zoom / 2, O.X + X * Init.zoom, O.Y - Y * Init.zoom + Init.zoom / 2);
            }
            if (Y == 0)
            {
                g.DrawLine(pen, O.X + X * Init.zoom - Init.zoom / 2, O.Y - Y * Init.zoom, O.X + X * Init.zoom + Init.zoom / 2, O.Y - Y * Init.zoom);
            }

        }

        // Tính Khoảng cách 2 Điểm
        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        //Chuyển đổi điểm từ Hệ Tọa Độ sang Pixel
        public static Point ConvertCoordinateSystem2DToPoint(Point p)
        {
            Point O = new Point(Init.NewSize2D.Width, Init.NewSize2D.Height);
            if (Init.ModeCurrent == Constants.Mode._3DMode)
            {
                O = new Point(Init.NewSize3D.Width, Init.NewSize3D.Height);
            }
            return new Point(p.X * Init.zoom + O.X, O.Y - p.Y * Init.zoom);
        }

        // Chuyển Điểm Từ Điểm Chuột Sang Hệ Tọa Độ
        public static Point ConvertPointToCoordinateSystem2D(Point p)
        {
            Point O = new Point(Init.NewSize2D.Width, Init.NewSize2D.Height);
            if (Init.ModeCurrent == Constants.Mode._3DMode)
            {
                O = new Point(Init.NewSize3D.Width, Init.NewSize3D.Height);
            }
            int x = Convert.ToInt32(Math.Round(1.0 * (p.X - O.X) / Init.zoom)),
                y = Convert.ToInt32(Math.Round(1.0 * (O.Y - p.Y) / Init.zoom));

            return new Point(x, y);
        }
    }
}
