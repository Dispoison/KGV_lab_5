using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGV_lab_5
{
    class Object3d
    {
        protected Matrix vertices;
        protected Matrix facets;
        protected List<(Brush, double[])> color_faces;
        Camera camera;
        Projection projection;
        Pen pen;
        Pen dotPen;
        PointF[] polygonPoints;
        Font f;
        Axes axes;
        int half_w, half_h;
        bool isAny;
        public bool movement_flag, draw_vertices;
        protected string label;
        public Object3d(Camera camera, Projection projection, int half_w, int half_h, Axes axes = null)
        {
            this.camera = camera;
            this.projection = projection;
            vertices = new Matrix(new double[,] { {0, 0, 0, 1 }, {0, 1, 0, 1 }, {1, 1, 0, 1 }, {1, 0, 0, 1 },
                { 0, 0, 1, 1 }, {0, 1, 1, 1 }, {1, 1, 1, 1 }, {1, 0, 1, 1 } });
            facets = new Matrix(new double[,] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 0, 4, 5, 1 }, { 2, 3, 7, 6 }, { 1, 2, 6, 5 }, { 0, 3, 7, 4 } });
            this.half_w = half_w;
            this.half_h = half_h;
            pen = new Pen(Color.Green);
            dotPen = new Pen(Color.White);
            f = new Font(new FontFamily("Arial"), 10);
            color_faces = new List<(Brush, double[])>();
            for (int i = 0; i < facets.matrix.GetLength(0); i++)
            {
                int vertices_count = facets.matrix.GetLength(1);
                double[] face = new double[vertices_count];
                for (int j = 0; j < vertices_count; j++)
                    face[j] = facets.matrix[i, j];
                color_faces.Add((Brushes.Orange, face));
            }
            movement_flag = true;
            draw_vertices = true;
            label = "";

            this.axes = axes;
            if (axes != null)
            {
                axes.translate(0.5, 0.5, 0.5);
            }

        }

        public void draw(Graphics g)
        {
            screen_projection(g);
        }

        public void movement()
        {
            if (movement_flag)
            {

            }
        }

        private void screen_projection(Graphics g)
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
                double[] face = color_faces[i].Item2;
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
                        g.DrawString(label[i].ToString(), f, Brushes.White, new PointF((float)vertices_copy.matrix[(int)facets.matrix[i, facets.matrix.GetLength(1)-1], 0], (float)vertices_copy.matrix[(int)facets.matrix[i, facets.matrix.GetLength(1) - 1], 1]));
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

        public void translate(double x = 0, double y = 0, double z = 0)
        {
            vertices.Multiply(MatrixFunctions.translate(x, y, z).matrix);
            if(axes != null)
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

    class Axes : Object3d
    {
        List<Brush> colors;
        public Axes(Camera camera, Projection projection, int half_w, int half_h) : base(camera, projection, half_w, half_h)
        {
            vertices = new Matrix(new double[,] { {0, 0, 0, 1 }, {1, 0, 0, 1 }, {0, 1, 0, 1 }, {0, 0, 1, 1 } });
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

    class Line : Object3d
    {
        private double mX, mY, mZ, nX, nY, nZ;
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

        public void SetMX(double value) { mX = value; vertices.matrix[0, 0] = mX; }
        public void SetMY(double value) { mY = value; vertices.matrix[0, 1] = mY; }
        public void SetMZ(double value) { mZ = value; vertices.matrix[0, 2] = mZ; }
        public void SetNX(double value) { nX = value; vertices.matrix[1, 0] = nX; }
        public void SetNY(double value) { nY = value; vertices.matrix[1, 1] = nY; }
        public void SetNZ(double value) { nZ = value; vertices.matrix[1, 2] = nZ; }
    }
}
