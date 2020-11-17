using System.Collections.Generic;
using System.Drawing;

namespace KGV_lab_5
{
    class Line : Object3d
    {
        public double mX, mY, mZ, nX, nY, nZ;
        public Line(Camera camera, Projection projection, int half_w, int half_h, double mX, double mY, double mZ, double nX, double nY, double nZ) : base(camera, projection, half_w, half_h)
        {
            this.mX = mX; this.mY = mY; this.mZ = mZ; this.nX = nX; this.nY = nY; this.nZ = nZ;
            vertices = new Matrix(new double[,] { { mX, mY, mZ, 1 }, { nX, nY, nZ, 1 } });
            facets = new Matrix(new double[,] { { 0, 1 } });


            color_faces = new List<(Brush, double[])>();
            int vertices_count = facets.matrix.GetLength(1);
            double[] face = new double[vertices_count];
            for (int j = 0; j < vertices_count; j++)
                face[j] = facets.matrix[0, j];
            color_faces.Add((Brushes.Yellow, face));
            movement_flag = false;
            draw_vertices = false;
        }

        public void changeColor(Brush color) { color_faces[0] = (color, color_faces[0].Item2); }

        public void SetMX(double value) { mX = value; vertices.matrix[0, 0] = mX; }
        public void SetMY(double value) { mY = value; vertices.matrix[0, 1] = mY; }
        public void SetMZ(double value) { mZ = value; vertices.matrix[0, 2] = mZ; }
        public void SetNX(double value) { nX = value; vertices.matrix[1, 0] = nX; }
        public void SetNY(double value) { nY = value; vertices.matrix[1, 1] = nY; }
        public void SetNZ(double value) { nZ = value; vertices.matrix[1, 2] = nZ; }
    }
}
