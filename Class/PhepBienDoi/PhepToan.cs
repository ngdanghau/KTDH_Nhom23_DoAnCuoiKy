﻿using System;
using MathNet.Numerics.LinearAlgebra;
using KTDH_Nhom23_DoAnCuoiKy.Variables;
using KTDH_Nhom23_DoAnCuoiKy.Class.Animation;

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
            Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(Matrix.rotate(alpha));
            Matrix<double> result = GetMatrix(point).Multiply(matrix);
            return new Point(Convert.ToInt32(result[0, 0]), Convert.ToInt32(result[0, 1]));
        }

        public static Point CenterRotate(Point point, Point c, double alpha)
        {
            double sin = Math.Sin(alpha);
            double cos = Math.Cos(alpha);
            int distanceX = (point.X - c.X);
            int distanceY = (point.Y - c.Y);
            return new Point(
                Convert.ToInt32(distanceX * cos) - Convert.ToInt32(distanceY * sin) + c.X,
                Convert.ToInt32(distanceX * sin) - Convert.ToInt32(distanceY * cos) + c.Y
           );
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
            if (Init.ModeCurrent == Constants.Mode._3DMode){
                Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(Matrix.scale3D(Sx, Sy, Sz));
                Matrix<double> result = GetMatrix(p).Multiply(matrix);
                return new Point(
                    Convert.ToInt32(result[0, 0]),
                    Convert.ToInt32(result[0, 1]),
                    Convert.ToInt32(result[0, 2])
                );
            }
            else
            {
                Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(Matrix.scale(Sx, Sy));
                Matrix<double> result = GetMatrix(p).Multiply(matrix);
                return new Point(
                     Convert.ToInt32(result[0, 0]),
                     Convert.ToInt32(result[0, 1])
                 );
            }
        }

        public static Point Translation(Point p, double trX, double trY, double trZ)
        {
            if (Init.ModeCurrent == Constants.Mode._3DMode)

            {
                Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(Matrix.move3d(trX, trY, trZ));
                Matrix<double> result = GetMatrix(p).Multiply(matrix);
                return new Point(
                    Convert.ToInt32(result[0, 0]),
                    Convert.ToInt32(result[0, 1]),
                    Convert.ToInt32(result[0, 2])
                );
            }
            else
            {
                Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(Matrix.move2d(trX, trY));
                Matrix<double> result = GetMatrix(p).Multiply(matrix);
                return new Point(
                     Convert.ToInt32(result[0, 0]),
                     Convert.ToInt32(result[0, 1])
                 );
            }
        }

        // Tính Khoảng cách 2 Điểm
        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public static double ConvertDegreesToRadian(int degrees)
        {
            return (1.0 * degrees / 180) * Math.PI;
        }

        public static double GetAngle(Point p1, Point p2, Point p3)
        {
            double numerator = p2.Y * (p1.X - p3.X) + p1.Y * (p3.X - p2.X) + p3.Y * (p2.X - p1.X);
            double denominator = (p2.X - p1.X) * (p1.X - p3.X) + (p2.Y - p1.Y) * (p1.Y - p3.Y);
            double ratio = numerator / denominator;

            double angleRad = Math.Atan(ratio);
            double angleDeg = (angleRad * 180) / Math.PI;

            if (angleDeg < 0) angleDeg = 180 + angleDeg;
            return angleDeg;
        }
    }
}
