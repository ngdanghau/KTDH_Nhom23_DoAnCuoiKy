using System;
using MathNet.Numerics.LinearAlgebra;
using KTDH_Nhom23_DoAnCuoiKy.Variables;

namespace KTDH_Nhom23_DoAnCuoiKy
{
    class PhepToan
    {
        
        public static Matrix<double> GetMatrix(Point point)
        {
            if (Init.ModeCurrent == Constants.Mode._3DMode)
            {
                return Matrix<double>.Build.DenseOfRowArrays(new[] { 1.0 * point.X, point.Y, point.Z, 1 });
            }
            else
                return Matrix<double>.Build.DenseOfRowArrays(new[] { 1.0 * point.X, point.Y, 1 });
        }

        public static Point Rotate(Point point, double alpha)
        {
            double sin = Math.Sin(alpha);
            double cos = Math.Cos(alpha);
            Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(
                new[,] { 
                    { cos,    sin, 0 },
                    { -1*sin, cos, 0 },
                    { 0,      0,   1 } 
                }
            );
            Matrix<double> result = GetMatrix(point).Multiply(matrix);
            return new Point(Convert.ToInt32(result[0, 0]), Convert.ToInt32(result[0, 1]));
        }

        // Phép Đối Xứng Qua Ox, Oy
        // Type = -1 - Qua Oy
        // Type = 0 - Qua O - Default
        // Type = 1 - Qua Ox
        public static Point Reflection(Point p, int type = 0)
        {
            switch (type)
            {
                case -1:
                    return new Point(-1 * p.X, p.Y);
                case 1:
                    return new Point( p.X, -1 * p.Y);
                default:
                    return new Point(-1 * p.X, -1 * p.Y);
            }
        }

        // Phép Tỉ Lệ
        public static Point Scale(Point p, double Sx, double Sy, double Sz)
        {
            if (Init.ModeCurrent == Constants.Mode._3DMode)

            {
                Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(new[,] {
                    { Sx,     0,      0,     0 },
                    { 0,      Sy,     0,     0 },
                    { 0,      0,      Sz,    0 },
                    { 0,      0,      0,     1 } 
                });
                Matrix<double> result = GetMatrix(p).Multiply(matrix);
                return new Point(
                    Convert.ToInt32(result[0, 0]),
                    Convert.ToInt32(result[0, 1]),
                    Convert.ToInt32(result[0, 2])
                );
            }
            else
            {
                Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(new[,] { 
                    { Sx,    0,     0 },
                    { 0,     Sy,    0 },
                    { 0,     0,     1 } 
                });
                Matrix<double> result = GetMatrix(p).Multiply(matrix);
                return new Point(
                     Convert.ToInt32(result[0, 0]),
                     Convert.ToInt32(result[0, 1])
                 );
            }
        }
    }
}
