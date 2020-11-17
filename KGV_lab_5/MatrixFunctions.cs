using System;

namespace KGV_lab_5
{
    class MatrixFunctions
    {
        static public Matrix translate(double x = 0, double y = 0, double z = 0)
        {
            return new Matrix(new double[4, 4] {
            { 1, 0, 0 ,0 },
            { 0, 1, 0, 0 },
            { 0, 0, 1, 0 },
            { x, y, z, 1 }
            });
        }
        static public Matrix rotate_x(double angle)
        {
            return new Matrix(new double[4, 4] {
            { 1, 0, 0 ,0 },
            { 0, Math.Cos(angle), Math.Sin(angle), 0 },
            { 0, -Math.Sin(angle), Math.Cos(angle), 0 },
            { 0, 0, 0, 1 }
            });
        }
        static public Matrix rotate_y(double angle)
        {
            return new Matrix(new double[4, 4] {
            { Math.Cos(angle), 0, -Math.Sin(angle), 0 },
            { 0, 1, 0, 0 },
            { Math.Sin(angle), 0, Math.Cos(angle), 0 },
            { 0, 0, 0, 1 }
            });
        }
        static public Matrix rotate_z(double angle)
        {
            return new Matrix(new double[4, 4] {
            { Math.Cos(angle), Math.Sin(angle), 0, 0 },
            { -Math.Sin(angle), Math.Cos(angle), 0, 0 },
            { 0, 0, 1, 0 },
            { 0, 0, 0, 1 }
            });
        }
        static public Matrix rotate_arbitraryAxis(double angle, double x, double y, double z)
        {
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);
            return new Matrix(new double[4, 4] {
            { cos + (1 - cos)*x*x, (1 - cos)*x*y - sin*z, (1 - cos)*x*z + sin*y, 0 },
            { (1 - cos)*y*x + sin*z, cos + (1 - cos)*y*y, (1 - cos)*y*z - sin*x, 0 },
            { (1 - cos)*z*x - sin*y, (1 - cos)*z*y + sin*x, cos + (1 - cos)*z*z, 0 },
            { 0, 0, 0, 1 }
            });
        }
        static public Matrix scale(double s)
        {
            return new Matrix(new double[4, 4] {
            { s, 0, 0, 0 },
            { 0, s, 0, 0 },
            { 0, 0, s, 0 },
            { 0, 0, 0, 1 }
            });
        }
    }
}
