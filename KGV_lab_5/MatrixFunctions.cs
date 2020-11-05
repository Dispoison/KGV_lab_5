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
