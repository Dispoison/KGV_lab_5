using System.Drawing;

namespace KGV_lab_5
{
    class Proj : Object3d
    {
        Object3d parent;
        Matrix vertices_proj_x;
        Matrix vertices_proj_y;
        Matrix vertices_proj_z;
        Line[] line_proj_x;
        Line[] line_proj_y;
        Line[] line_proj_z;
        public Proj(Camera camera, Projection projection, int half_w, int half_h, Object3d parent) : base(camera, projection, half_w, half_h)
        {
            this.camera = camera;
            this.projection = projection;
            this.half_w = half_w;
            this.half_h = half_h;
            this.parent = parent;
            lineColor = new SolidBrush(Color.FromArgb(100, Color.Red));
            create_color_faces();
            init_lines_arrays();
            Update();
        }

        private void Update()
        {
            vertices_proj_x = new Matrix(new double[,] { {0, parent.vertices.matrix[0, 1], parent.vertices.matrix[0, 2], 1 }, {0, parent.vertices.matrix[1, 1], parent.vertices.matrix[1, 2], 1 }, {0, parent.vertices.matrix[2, 1], parent.vertices.matrix[2, 2], 1 }, {0, parent.vertices.matrix[3, 1], parent.vertices.matrix[3, 2], 1 },
                { 0, parent.vertices.matrix[4, 1], parent.vertices.matrix[4, 2], 1 }, {0, parent.vertices.matrix[5, 1], parent.vertices.matrix[5, 2], 1 }, {0, parent.vertices.matrix[6, 1], parent.vertices.matrix[6, 2], 1 }, {0, parent.vertices.matrix[7, 1], parent.vertices.matrix[7, 2], 1 } });

            vertices_proj_y = new Matrix(new double[,] { {parent.vertices.matrix[0, 0], 0, parent.vertices.matrix[0, 2], 1 }, {parent.vertices.matrix[1, 0], 0, parent.vertices.matrix[1, 2], 1 }, {parent.vertices.matrix[2, 0], 0, parent.vertices.matrix[2, 2], 1 }, {parent.vertices.matrix[3, 0], 0, parent.vertices.matrix[3, 2], 1 },
                { parent.vertices.matrix[4, 0], 0, parent.vertices.matrix[4, 2], 1 }, {parent.vertices.matrix[5, 0], 0, parent.vertices.matrix[5, 2], 1 }, {parent.vertices.matrix[6, 0], 0, parent.vertices.matrix[6, 2], 1 }, {parent.vertices.matrix[7, 0], 0, parent.vertices.matrix[7, 2], 1 } });

            vertices_proj_z = new Matrix(new double[,] { {parent.vertices.matrix[0, 0], parent.vertices.matrix[0, 1], 0, 1 }, {parent.vertices.matrix[1, 0], parent.vertices.matrix[1, 1], 0, 1 }, {parent.vertices.matrix[2, 0], parent.vertices.matrix[2, 1], 0, 1 }, {parent.vertices.matrix[3, 0], parent.vertices.matrix[3, 1], 0, 1 },
                { parent.vertices.matrix[4, 0], parent.vertices.matrix[4, 1], 0, 1 }, {parent.vertices.matrix[5, 0], parent.vertices.matrix[5, 1], 0, 1 }, {parent.vertices.matrix[6, 0], parent.vertices.matrix[6, 1], 0, 1 }, {parent.vertices.matrix[7, 0], parent.vertices.matrix[7, 1], 0, 1 } });
            update_lines_arrays();
        }
        public new void draw(Graphics g)
        {
            Update();
            if (Program.form1.cBox_drawProjX.Checked)
                screen_projection(g, vertices_proj_x);
            if (Program.form1.cBox_drawProjY.Checked)
                screen_projection(g, vertices_proj_y);
            if (Program.form1.cBox_drawProjZ.Checked)
                screen_projection(g, vertices_proj_z);
            if (Program.form1.cBox_drawProjConnectLines.Checked)
                draw_lines(g);
        }
        private void draw_lines(Graphics g)
        {
            int vertices_count = parent.vertices.matrix.GetLength(0);

            if (Program.form1.cBox_drawProjX.Checked)
                for (int i = 0; i < vertices_count; i++)
                {
                    line_proj_x[i].screen_projection(g, line_proj_x[i].vertices);
                }
            if (Program.form1.cBox_drawProjY.Checked)
                for (int i = 0; i < vertices_count; i++)
                {
                    line_proj_y[i].screen_projection(g, line_proj_y[i].vertices);
                }
            if (Program.form1.cBox_drawProjZ.Checked)
                for (int i = 0; i < vertices_count; i++)
                {
                    line_proj_z[i].screen_projection(g, line_proj_z[i].vertices);
                }
        }
        private void init_lines_arrays()
        {
            int vertices_count = parent.vertices.matrix.GetLength(0);
            Brush color = new SolidBrush(Color.FromArgb(60, Color.Red));
            line_proj_x = new Line[vertices_count];
            for (int i = 0; i < vertices_count; i++)
            {
                line_proj_x[i] = new Line(camera, projection, half_w, half_h, 0, 0, 0, 0, 0, 0);
                line_proj_x[i].changeColor(color);
            }
            line_proj_y = new Line[vertices_count];
            for (int i = 0; i < vertices_count; i++)
            {
                line_proj_y[i] = new Line(camera, projection, half_w, half_h, 0, 0, 0, 0, 0, 0);
                line_proj_y[i].changeColor(color);
            }
            line_proj_z = new Line[vertices_count];
            for (int i = 0; i < vertices_count; i++)
            {
                line_proj_z[i] = new Line(camera, projection, half_w, half_h, 0, 0, 0, 0, 0, 0);
                line_proj_z[i].changeColor(color);
            }
        }

        private void update_lines_arrays()
        {
            int vertices_count = parent.vertices.matrix.GetLength(0);
            for (int i = 0; i < vertices_count; i++)
            {
                line_proj_x[i].SetMX(0);
                line_proj_x[i].SetMY(parent.vertices.matrix[i, 1]);
                line_proj_x[i].SetMZ(parent.vertices.matrix[i, 2]);
                line_proj_x[i].SetNX(parent.vertices.matrix[i, 0]);
                line_proj_x[i].SetNY(parent.vertices.matrix[i, 1]);
                line_proj_x[i].SetNZ(parent.vertices.matrix[i, 2]);
            }
            for (int i = 0; i < vertices_count; i++)
            {
                line_proj_y[i].SetMX(parent.vertices.matrix[i, 0]);
                line_proj_y[i].SetMY(0);
                line_proj_y[i].SetMZ(parent.vertices.matrix[i, 2]);
                line_proj_y[i].SetNX(parent.vertices.matrix[i, 0]);
                line_proj_y[i].SetNY(parent.vertices.matrix[i, 1]);
                line_proj_y[i].SetNZ(parent.vertices.matrix[i, 2]);
            }
            for (int i = 0; i < vertices_count; i++)
            {
                line_proj_z[i].SetMX(parent.vertices.matrix[i, 0]);
                line_proj_z[i].SetMY(parent.vertices.matrix[i, 1]);
                line_proj_z[i].SetMZ(0);
                line_proj_z[i].SetNX(parent.vertices.matrix[i, 0]);
                line_proj_z[i].SetNY(parent.vertices.matrix[i, 1]);
                line_proj_z[i].SetNZ(parent.vertices.matrix[i, 2]);
            }
        }
    }
}
