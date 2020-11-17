using System.Collections.Generic;
using System.Drawing;

namespace KGV_lab_5
{
    class Axes : Object3d
    {
        List<Brush> colors;
        public Axes(Camera camera, Projection projection, int half_w, int half_h) : base(camera, projection, half_w, half_h)
        {
            vertices = new Matrix(new double[,] { { 0, 0, 0, 1 }, { 1, 0, 0, 1 }, { 0, 1, 0, 1 }, { 0, 0, 1, 1 } });
            facets = new Matrix(new double[,] { { 0, 1 }, { 0, 2 }, { 0, 3 } });
            colors = new List<Brush>() { Brushes.Red, Brushes.Green, Brushes.Blue };


            color_faces = new List<(Brush, double[])>();
            int vertices_count = facets.matrix.GetLength(1);
            double[] face = new double[vertices_count];
            for (int i = 0; i < facets.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < vertices_count; j++)
                    face[j] = facets.matrix[i, j];
                color_faces.Add((colors[i], face));
            }
            movement_flag = false;
            draw_vertices = false;
            label = "XYZ";
        }
    }
}
