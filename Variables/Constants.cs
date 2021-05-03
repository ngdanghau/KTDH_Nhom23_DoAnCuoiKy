using System.Drawing;

namespace KTDH_Nhom23_DoAnCuoiKy.Variables
{
    class Constants
    {
        /// <summary>
        /// Chế độ làm việc
        /// </summary>
        public enum Mode { _2DMode, _3DMode };

        /// <summary>
        /// Hình Đang Vẽ
        /// </summary>
        public enum Shape { Default, Line, Circle, Rectangle, Triangle, Cube, Sphere, Cone, Cylinder };

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
    }
}
