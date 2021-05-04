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
            Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(new[,] { { cos, sin, 0 },
                                                                                   { -1*sin, cos, 0 },
                                                                                   { 0,0, 1 } });
            Matrix<double> result = GetMatrix(point).Multiply(matrix);
            return new Point(Convert.ToInt32(result[0, 0]), Convert.ToInt32(result[0, 1]));
        }
    }
}
