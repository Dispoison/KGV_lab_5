using System;

namespace KGV_lab_5
{
    class Projection
    {
        double near, far, right, left, top, bottom,
                m00, m11, m22, m32;
        public Matrix projection_matrix;
        public Matrix to_screen_matrix;
        public Projection(Camera camera, int half_w, int half_h)
        {
            near = camera.near_plane;
            far = camera.far_plane;
            right = Math.Tan(camera.horizontal_fov / 2);
            left = -right;
            top = Math.Tan(camera.vertical_fov / 2);
            bottom = -top;

            m00 = 2 / (right - left);
            m11 = 2 / (top - bottom);
            m22 = (far + near) / (far - near);
            m32 = -2 * near * far / (far - near);

            projection_matrix = new Matrix(new double[4, 4] {
            { m00, 0, 0 ,0 },
            { 0, m11, 0, 0 },
            { 0, 0, m22, 1 },
            { 0, 0, m32, 0 }
            });


            to_screen_matrix = new Matrix(new double[4, 4] {
            { half_w, 0, 0 ,0 },
            { 0, -half_h, 0, 0 },
            { 0, 0, 1, 0 },
            { half_w, half_h, 0, 1 }
            });
        }
    }
}
