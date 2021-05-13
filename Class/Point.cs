using KTDH_Nhom23_DoAnCuoiKy.Variables;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KTDH_Nhom23_DoAnCuoiKy
{
    class Point
    {
        private int x, y, z;
        private string name;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(int x, int y, int z, string name = "")
        {
            Name = name;
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
        public string Name { get => name; set => name = value; }

        public Label SetLabel(string name)
        {
            Point temp = ConvertCoordinateSystem2DToPoint(new Point(X, Y));
            Label lb = new Label();
            int x1, y1;
            if (Init.ModeCurrent == Constants.Mode._3DMode) {
                lb.Text = Name + "(" + X + ", " + Y + ", " + Z+ ")"; ;
                if (X >= 0 && Y >= 0){
                    x1 = temp.X + 10 - Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Init.zoom;
                    y1 = temp.Y - 10 + Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Init.zoom;
                }
                else if (X >= 0 && Y < 0){
                    x1 = temp.X + 10 - Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Init.zoom;
                    y1 = temp.Y + 10 + Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Init.zoom;
                }
                else if (X < 0 && Y < 0){
                    x1 = temp.X - 10 - Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Init.zoom;
                    y1 = temp.Y + 10 + Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Init.zoom;
                }
                else{
                    x1 = temp.X - 10 - Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Init.zoom;
                    y1 = temp.Y - 10 + Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Init.zoom;
                }
            }
            else
            {
                lb.Text = "(" + X + ", " + Y + ")"; ;
                if (X >= 0 && Y >= 0)
                {
                    x1 = temp.X + 10;
                    y1 = temp.Y - 10;
                }
                else if (X >= 0 && Y < 0)
                {
                    x1 = temp.X + 10;
                    y1 = temp.Y + 10;
                }
                else if (X < 0 && Y < 0)
                {
                    x1 = temp.X - 10;
                    y1 = temp.Y + 10;
                }
                else
                {
                    x1 = temp.X - 10;
                    y1 = temp.Y - 10;
                }
            }

            lb.Location = new System.Drawing.Point(x1, y1);
            lb.AutoSize = true;
            lb.Name = name;
            return lb;
        }

        // Vẽ Điểm Pixel
        public void PutPixel(Graphics g, int zoom = 0, bool isDot = false)
        {
            if (zoom == 0) zoom = Init.zoom;
            SolidBrush brush = new SolidBrush(isDot ? Constants.Color_Point_Dot_Pixel : Constants.Color_Point_Pixel);
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
            if (Init.ModeCurrent == Constants.Mode.AnimationMode)
            {
                RemovePixelAnimation(g);
                return;
            }
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

        public void RemovePixelAnimation(Graphics g)
        {
            Point O = new Point(Init.NewSize2D.Width, Init.NewSize2D.Height);
            SolidBrush brush = new SolidBrush(Constants.Background_Color_Coordinate_System);
            g.FillRectangle(brush, O.X + X * Init.zoom - Init.zoom / 2, O.Y - Y * Init.zoom - Init.zoom / 2, Init.zoom / 2, Init.zoom / 2);
            g.FillRectangle(brush, O.X + X * Init.zoom + 1, O.Y - Y * Init.zoom - Init.zoom / 2, Init.zoom / 2, Init.zoom / 2);
            g.FillRectangle(brush, O.X + X * Init.zoom - Init.zoom / 2, O.Y - Y * Init.zoom + 1, Init.zoom / 2, Init.zoom / 2);
            g.FillRectangle(brush, O.X + X * Init.zoom + 1, O.Y - Y * Init.zoom + 1, Init.zoom / 2, Init.zoom / 2);
            g.DrawLine(new Pen(Constants.Background_Color_Coordinate_System), O.X + X * Init.zoom - Init.zoom / 2, O.Y - Y * Init.zoom, O.X + X * Init.zoom + Init.zoom / 2, O.Y - Y * Init.zoom);
            g.DrawLine(new Pen(Constants.Background_Color_Coordinate_System), O.X + X * Init.zoom, O.Y - Y * Init.zoom - Init.zoom / 2, O.X + X * Init.zoom, O.Y - Y * Init.zoom + Init.zoom / 2);
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
