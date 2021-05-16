using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Variables
{
    class Constants
    {
        /// <summary>
        /// Chế độ làm việc
        /// </summary>
        public enum Mode { _2DMode, _3DMode, AnimationMode };

        /// <summary>
        /// Hình Đang Vẽ
        /// </summary>
        public enum Shape { 
            Default, Line, DashLine, Circle, Rectangle, Triangle, Elip, 
            Cube, Sphere, Cone, Cylinder, 
            Car, Clock, Plane, Sun
        };

        /// <summary>
        /// Màu sắc của Đường Ox, Oy của trục tọa độ
        /// </summary>
        public static Color Color_Vector_Coordinate_System = Color.FromArgb(0, 100, 182);

        /// <summary>
        /// Màu sắc của lưới pixel
        /// </summary>
        public static Color Color_Pixel_Grid = Color.FromArgb(240, 242, 243);

        /// <summary>
        /// Màu sắc nền của trục tọa độ
        /// </summary>
        public static Color Background_Color_Coordinate_System = Color.White;

        /// <summary>
        /// Màu sắc của điểm pixel, tức là màu của mấy hình
        /// </summary>
        public static Color Color_Point_Pixel = Color.Black;

        /// <summary>
        /// Màu sắc Khác của điểm pixel - Dùng cho phép tịnh tiến
        /// </summary>
        public static Color Color_Point_Dot_Pixel = Color.MediumVioletRed;

        /// <summary>
        /// Vị trí của bảng vẻ 2D - 3D
        /// </summary>
        public static System.Drawing.Point LocationPaint = new System.Drawing.Point(0, 97);

        /// <summary>
        /// Kích thước của bảng vẽ 2D - 3D
        /// </summary>
        public static Size SizePaint = new Size(1006, 683);
    }
}
