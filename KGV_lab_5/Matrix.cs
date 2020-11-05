using System;
using System.Collections.Generic;

namespace KGV_lab_5
{
    class Matrix
    {
        public double[,] matrix { get; set; }

        public Matrix(double x, double y, double z, double w)
        {
            matrix = new double[,] { { x, y, z, w } };
        }
        public double GetX() { return matrix[0, 0]; }
        public double GetY() { return matrix[0, 1]; }
        public double GetZ() { return matrix[0, 2]; }
        public double GetW() { return matrix[0, 3]; }
        public void SetX(double x) { matrix[0, 0] = x; }
        public void SetY(double y) { matrix[0, 1] = y; }
        public void SetZ(double z) { matrix[0, 2] = z; }
        public void SetW(double w) { matrix[0, 3] = w; }
        public Matrix(double[,] _matrix)
        {
            matrix = _matrix;
        }
        public void SetMatrix(double[,] _matrix)
        {
            matrix = _matrix;
        }
        public double[,] GetMatrix() { return matrix; }
        public void Multiply(double[,] _matrix)
        {
            if (matrix.GetLength(1) != _matrix.GetLength(0))
                throw new Exception("Wrong dimensions!");
            int left = matrix.GetLength(0), common = matrix.GetLength(1), right = _matrix.GetLength(1);
            double[,] result = new double[left, right];
            double sum;
            for (int i = 0; i < left; i++)
            {
                for (int j = 0; j < right; j++)
                {
                    sum = 0;
                    for (int c = 0; c < common; c++)
                    {
                        sum += matrix[i, c] * _matrix[c, j];
                    }
                    result[i, j] = sum;
                }
            }

            matrix = result;
        }
        public static Matrix MultSingle(double[,] matrix, double num)
        {
            double[,] result = matrix.Clone() as double[,];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] *= num;
                }
            }
            return new Matrix(result);
        }
        public static Matrix DivSingle(double[,] matrix, double num)
        {
            double[,] result = matrix.Clone() as double[,];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] /= num;
                }
            }
            return new Matrix(result);
        }
        public static Matrix Sub(double[,] matrix, double[,] _matrix)
        {
            double[,] result = matrix.Clone() as double[,];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] - _matrix[i, j];
                }
            }
            return new Matrix(result);
        }
        public static Matrix Add(double[,] matrix, double[,] _matrix)
        {
            double[,] result = matrix.Clone() as double[,];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = matrix[i, j] + _matrix[i, j];
                }
            }
            return new Matrix(result);
        }
    }
}
