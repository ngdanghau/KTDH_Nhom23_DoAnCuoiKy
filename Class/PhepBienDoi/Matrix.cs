using System;

namespace KTDH_Nhom23_DoAnCuoiKy.Class.Animation
{
    class Matrix
    {
        public static double[,] move2d(double sx, double sy)
        {
            double[,] matrix = new double[,] {    
                {1, 0, 0 },
                {0, 1, 0 },
                {sx, sy, 1} 
            };
            return matrix;
        }

        public static double[,] move3d(double sx, double sy, double sz)
        {
            double[,] matrix = new double[,] {
                 { 1,    0,      0,      0 },
                 { 0,    1,      0,      0 },
                 { 0,    0,      1,      0 },
                 { sx,  sy,     sz,      1 }
            };
            return matrix;
        }

        public static double[,] scale(double Sx, double Sy)
        {
            double[,] matrix = new double[,] {    
                {Sx, 0, 0 },
                {0, Sy, 0 },
                {0, 0,  1  } 
            };
            return matrix;
        }

        public static double[,] scale3D(double Sx, double Sy, double Sz)
        {
            double[,] matrix = new double[,] {
                { Sx,     0,      0,     0 },
                { 0,      Sy,     0,     0 },
                { 0,      0,      Sz,    0 },
                { 0,      0,      0,     1 }
            };
            return matrix;
        }

        public static double[,] rotate(double rad) // độ
        {
            double sin = Math.Sin(rad);
            double cos = Math.Cos(rad);
            double[,] matrix = new double[,] {  {cos,   sin,    0 },
                                                {-sin,  cos,    0 },
                                                {0,     0,      1} };
            return matrix;
        }

        public static double[,] CenterRotate(Point p, double rad) // độ
        {
            double sin = Math.Sin(rad);
            double cos = Math.Cos(rad);
            double[,] matrix = new double[,] {  {cos,   sin,    0 },
                                                {-sin,  cos,    0 },
                                                {-p.X * cos + p.Y * sin + p.X,     -p.X * sin - p.Y * cos + p.Y,      1} };
            return matrix;
        }

        public static double[,] rotate3D(int b, int x, int y) // độ
        {
            double a = (double)b / 180 * Math.PI;
            double sin = Math.Sin(a);
            double cos = Math.Cos(a);
            double[,] matrix = new double[,] {  {cos,   sin,    0 },
                                                {-sin,  cos,    0 },
                                                {-x * cos + y * sin + x,     -x * sin - y * cos + y,      1} };
            return matrix;
        }
        public static int[,] symmetryC(Point c)
        {
            int[,] matrix = new int[,]
            {
                {-1, 0, 0 },
                {0, -1, 0 },
                {2 * c.X, 2 * c.Y, 1 }
            };
            return matrix;
        }
        public static double[,] symmetryO()
        {
            double[,] matrix = new double[,]
            {
                {-1, 0, 0 },
                {0, -1, 0 },
                {0, 0, 1 }
            };
            return matrix;
        }

        public static double[,] symmetryOx()
        {
            double[,] matrix = new double[,]
            {
                {1, 0, 0 },
                {0, -1, 0 },
                {0, 0, 1 }
            };
            return matrix;
        }

        public static double[,] symmetryOy()
        {
            double[,] matrix = new double[,]
            {
                {-1, 0, 0 },
                {0, 1, 0 },
                {0, 0, 1 }
            };
            return matrix;
        }
    }
}
