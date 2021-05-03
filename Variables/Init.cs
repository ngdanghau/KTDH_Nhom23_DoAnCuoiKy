using System.Drawing;


namespace KTDH_Nhom23_DoAnCuoiKy.Variables
{
    class Init
    {
        public static int zoom = 5;

        /// chế độ làm việc măc định: 2D
        public static Constants.Mode ModeCurrent = Constants.Mode._2DMode;

        /// Size của hệ tòa độ người dùng khi chuyển từ tọa độ máy sang. Hệ tòa độ 2D.
        public static Size NewSize2D;

        /// Size của hệ tòa độ người dùng khi chuyển từ tọa độ máy sang. Hệ tòa độ 3D.
        public static Size NewSize3D;

        public static Constants.Shape ShapeCurrent = Constants.Shape.Default;

        public static bool IsShowNamePoint = false;
    }
}
