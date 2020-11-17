using System;
using System.Windows.Forms;

namespace KGV_lab_5
{
    class Camera
    {
        public Matrix position, forward, up, right;
        public double horizontal_fov, vertical_fov, near_plane, far_plane, moving_speed, rotation_speed;
        public Camera(double x, double y, double z, double moving_speed, double rotation_speed, PictureBox picCanvas)
        {
            position = new Matrix(x, y, z, 1);
            forward = new Matrix(0, 0, 1, 1);
            up = new Matrix(0, 1, 0, 1);
            right = new Matrix(1, 0, 0, 1);
            horizontal_fov = Math.PI / 3;
            vertical_fov = horizontal_fov * ((double)picCanvas.Height / picCanvas.Width);
            near_plane = 0.1;
            far_plane = 100;
            this.moving_speed = moving_speed;
            this.rotation_speed = rotation_speed;
        }

        public void camera_yaw(double angle)
        {
            Matrix rotate = MatrixFunctions.rotate_y(angle);
            forward.Multiply(rotate.matrix);
            right.Multiply(rotate.matrix);
            up.Multiply(rotate.matrix);
        }
        public void camera_pitch(double angle)
        {
            Matrix rotate = MatrixFunctions.rotate_x(angle);
            forward.Multiply(rotate.matrix);
            right.Multiply(rotate.matrix);
            up.Multiply(rotate.matrix);
        }

        private Matrix translate_matrix()
        {
            return new Matrix(new double[4, 4] {
            { 1, 0, 0 ,0 },
            { 0, 1, 0, 1 },
            { 0, 0, 1, 0 },
            { -position.GetX(), -position.GetY(), -position.GetZ(), 1 }
            });
        }
        private Matrix rotate_matrix()
        {
            return new Matrix(new double[4, 4] {
            { right.GetX(), up.GetX(), forward.GetX(), 0 },
            { right.GetY(), up.GetY(), forward.GetY(), 0 },
            { right.GetZ(), up.GetZ(), forward.GetZ(), 0 },
            { 0, 0, 0, 1 }
            });
        }

        public Matrix camera_matrix()
        {
            Matrix cMatrix = translate_matrix();
            cMatrix.Multiply(rotate_matrix().matrix);
            return cMatrix;
        }
    }
}
