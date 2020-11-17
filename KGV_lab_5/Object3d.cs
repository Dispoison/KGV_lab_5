using System.Collections.Generic;
using System.Drawing;

namespace KGV_lab_5
{
    class Object3d
    {
        public Matrix vertices;
        public Brush lineColor;
        public bool movement_flag, draw_vertices;
        protected Matrix facets;
        protected List<(Brush, double[])> color_faces;
        protected Camera camera;
        protected Projection projection;
        protected string label;
        protected int half_w, half_h;
        Pen dotPen;
        PointF[] polygonPoints;
        Font f;
        Axes axes;
        bool isAny;
        public Object3d(Camera camera, Projection projection, int half_w, int half_h, Axes axes = null)
        {
            this.camera = camera;
            this.projection = projection;
            vertices = new Matrix(new double[,] { {0, 0, 0, 1 }, {0, 1, 0, 1 }, {1, 1, 0, 1 }, {1, 0, 0, 1 },
                { 0, 0, 1, 1 }, {0, 1, 1, 1 }, {1, 1, 1, 1 }, {1, 0, 1, 1 } });
            facets = new Matrix(new double[,] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 0, 4, 5, 1 }, { 2, 3, 7, 6 }, { 1, 2, 6, 5 }, { 0, 3, 7, 4 } });
            this.half_w = half_w;
            this.half_h = half_h;
            dotPen = new Pen(Color.White);
            lineColor = Brushes.Orange;
            f = new Font(new FontFamily("Arial"), 10);
            create_color_faces();
            movement_flag = true;
            draw_vertices = true;
            label = "";
            
            this.axes = axes;
            if (axes != null)
                axes.translate(0.5, 0.5, 0.5);

        }

        public void draw(Graphics g)
        {
            screen_projection(g, vertices);
        }
        public void screen_projection(Graphics g, Matrix vertices)
        {
            Matrix vertices_copy = new Matrix(vertices.GetMatrix().Clone() as double[,]);
            vertices_copy.Multiply(camera.camera_matrix().matrix);
            vertices_copy.Multiply(projection.projection_matrix.matrix);

            for (int i = 0; i < vertices_copy.matrix.GetLength(0); i++)
            {
                vertices_copy.matrix[i, 0] = vertices_copy.matrix[i, 0] / vertices_copy.matrix[i, 3];
                vertices_copy.matrix[i, 1] = vertices_copy.matrix[i, 1] / vertices_copy.matrix[i, 3];
                vertices_copy.matrix[i, 2] = vertices_copy.matrix[i, 2] / vertices_copy.matrix[i, 3];
                vertices_copy.matrix[i, 3] = vertices_copy.matrix[i, 3] / vertices_copy.matrix[i, 3];

                for (int j = 0; j < vertices_copy.matrix.GetLength(1); j++)
                    if (vertices_copy.matrix[i, j] > 2 || vertices_copy.matrix[i, j] < -2)
                        vertices_copy.matrix[i, j] = 0;
            }
            vertices_copy.Multiply(projection.to_screen_matrix.matrix);

            for (int i = 0; i < color_faces.Count; i++)
            {
                Brush brush = color_faces[i].Item1;
                isAny = false;
                for (int j = 0; j < facets.matrix.GetLength(1); j++)
                {
                    if (vertices_copy.matrix[(int)facets.matrix[i, j], 0] == half_w)
                        isAny = true;
                    if (vertices_copy.matrix[(int)facets.matrix[i, j], 1] == half_h)
                        isAny = true;
                }
                if (!isAny)
                {
                    polygonPoints = new PointF[facets.matrix.GetLength(1)];
                    for (int j = 0; j < facets.matrix.GetLength(1); j++)
                    {
                        vertices_copy.matrix[(int)facets.matrix[i, j], 0] = vertices_copy.matrix[(int)facets.matrix[i, j], 0];
                        vertices_copy.matrix[(int)facets.matrix[i, j], 1] = vertices_copy.matrix[(int)facets.matrix[i, j], 1];
                        polygonPoints[j] = new PointF((float)vertices_copy.matrix[(int)facets.matrix[i, j], 0], (float)vertices_copy.matrix[(int)facets.matrix[i, j], 1]);

                    }

                    if (polygonPoints.Length > 2)
                        //g.FillPolygon(brush, polygonPoints);
                        g.DrawPolygon(new Pen(((SolidBrush)brush).Color), polygonPoints);
                    else
                        g.DrawPolygon(new Pen(((SolidBrush)brush).Color), polygonPoints);
                    if (label.Length > 0)
                    {
                        g.DrawString(label[i].ToString(), f, Brushes.White, new PointF((float)vertices_copy.matrix[(int)facets.matrix[i, facets.matrix.GetLength(1) - 1], 0], (float)vertices_copy.matrix[(int)facets.matrix[i, facets.matrix.GetLength(1) - 1], 1]));
                    }
                }
            }

            if (draw_vertices)
            {
                for (int i = 0; i < vertices_copy.matrix.GetLength(0); i++)
                {
                    if (vertices_copy.matrix[i, 0] != half_w && vertices_copy.matrix[i, 1] != half_h)
                        g.DrawEllipse(dotPen, (float)vertices_copy.matrix[i, 0] - 1, (float)vertices_copy.matrix[i, 1] - 1, 2, 2);
                }
            }
        }

        protected void create_color_faces()
        {
            color_faces = new List<(Brush, double[])>();
            for (int i = 0; i < facets.matrix.GetLength(0); i++)
            {
                int vertices_count = facets.matrix.GetLength(1);
                double[] face = new double[vertices_count];
                for (int j = 0; j < vertices_count; j++)
                    face[j] = facets.matrix[i, j];
                color_faces.Add((lineColor, face));
            }
        }

        public void translate(double x = 0, double y = 0, double z = 0)
        {
            vertices.Multiply(MatrixFunctions.translate(x, y, z).matrix);
            if (axes != null)
                axes.vertices.Multiply(MatrixFunctions.translate(x, y, z).matrix);
        }
        public void rotate_x(double angle)
        {
            vertices.Multiply(MatrixFunctions.rotate_x(angle).matrix);
            if (axes != null)
                axes.vertices.Multiply(MatrixFunctions.rotate_x(angle).matrix);
        }
        public void rotate_y(double angle)
        {
            vertices.Multiply(MatrixFunctions.rotate_y(angle).matrix);
            if (axes != null)
                axes.vertices.Multiply(MatrixFunctions.rotate_y(angle).matrix);
        }
        public void rotate_z(double angle)
        {
            vertices.Multiply(MatrixFunctions.rotate_z(angle).matrix);
            if (axes != null)
                axes.vertices.Multiply(MatrixFunctions.rotate_z(angle).matrix);
        }
        public void rotate_arbitraryAxis(double angle, double x, double y, double z)
        {
            vertices.Multiply(MatrixFunctions.rotate_arbitraryAxis(angle, x, y, z).matrix);
            if (axes != null)
                axes.vertices.Multiply(MatrixFunctions.rotate_arbitraryAxis(angle, x, y, z).matrix);
        }
        public void scale(double s)
        {
            vertices.Multiply(MatrixFunctions.scale(s).matrix);
            if (axes != null)
                axes.vertices.Multiply(MatrixFunctions.scale(s).matrix);
        }
    }
}
