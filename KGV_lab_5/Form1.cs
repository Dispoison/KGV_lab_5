using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGV_lab_5
{
    public partial class Form1 : Form
    {
        const float ROTATE_SPEED = 0.01F;
        const float TRANSLATE_DISTANCE = 0.1F;
        const float CAMERA_MOVING_SPEED = 0.03F;
        const float CAMERA_ROTATION_SPEED = 0.0008F;
        int half_w, half_h;
        Camera camera;
        Projection projection;
        Object3d object3d;
        Axes axes;
        Axes worldAxes;
        Proj proj;
        Line arbitraryAxes;
        DateTime lastCheckTime = DateTime.Now;
        long frameCount = 0;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            picCanvas.BackColor = Color.FromArgb(30,30,30);
            half_w = picCanvas.Width / 2;
            half_h = picCanvas.Height / 2;
            CreateObjects();
        }

        private void CreateObjects()
        {
            camera = new Camera(0.5, 1, -4, CAMERA_MOVING_SPEED, CAMERA_ROTATION_SPEED, picCanvas);
            projection = new Projection(camera, half_w, half_h);
            axes = new Axes(camera, projection, half_w, half_h);
            object3d = new Object3d(camera, projection, half_w, half_h, axes);
            object3d.translate(0.2, 0.4, 0.2);
            proj = new Proj(camera, projection, half_w, half_h, object3d);
            worldAxes = new Axes(camera, projection, half_w, half_h);
            worldAxes.movement_flag = false;
            worldAxes.scale(2.5);
            worldAxes.translate(0.0001, 0.0001, 0.0001);
            arbitraryAxes = new Line(camera, projection, half_w, half_h, Convert.ToDouble(tBox_mX.Text), Convert.ToDouble(tBox_mY.Text), Convert.ToDouble(tBox_mZ.Text), 
                                                                         Convert.ToDouble(tBox_nX.Text), Convert.ToDouble(tBox_nY.Text), Convert.ToDouble(tBox_nZ.Text));
            
        }


        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            object3d.draw(e.Graphics);
            if (cBox_drawProj.Checked)
                proj.draw(e.Graphics);
            if (cBox_drawWorldAxis.Checked)
                worldAxes.draw(e.Graphics);
            if (cBox_drawObjectAxis.Checked)
                axes.draw(e.Graphics);
            if (cBox_rotateArbitAxis.Checked)
                arbitraryAxes.draw(e.Graphics);
        }
        private void timer_game_Tick(object sender, EventArgs e)
        {
            if (cBox_rotateX.Checked)
                object3d.rotate_x(ROTATE_SPEED);
            if (cBox_rotateY.Checked)
                object3d.rotate_y(ROTATE_SPEED);
            if (cBox_rotateZ.Checked)
                object3d.rotate_z(ROTATE_SPEED);

            if (cBox_rotateArbitAxis.Checked)
            {
                try
                {
                    double mX = Convert.ToDouble(tBox_mX.Text);
                    double mY = Convert.ToDouble(tBox_mY.Text);
                    double mZ = Convert.ToDouble(tBox_mZ.Text);
                    double nX = Convert.ToDouble(tBox_nX.Text);
                    double nY = Convert.ToDouble(tBox_nY.Text);
                    double nZ = Convert.ToDouble(tBox_nZ.Text);
                    arbitraryAxes.SetMX(mX);
                    arbitraryAxes.SetMY(mY);
                    arbitraryAxes.SetMZ(mZ);
                    arbitraryAxes.SetNX(nX);
                    arbitraryAxes.SetNY(nY);
                    arbitraryAxes.SetNZ(nZ);
                    double x = nX - mX;
                    double y = nY - mY;
                    double z = nZ - mZ;

                    object3d.rotate_arbitraryAxis(ROTATE_SPEED, x, y, z);
                }
                catch(Exception)
                {
                    cBox_rotateArbitAxis.Checked = false;
                    MessageBox.Show("Format Exception of values");
                }
            }
            DoCameraMovement();

            picCanvas.Refresh(); 
            Interlocked.Increment(ref frameCount);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyHandler.KeyEvent(e.KeyCode, KeyHandler.KeyState.Down);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            KeyHandler.KeyEvent(e.KeyCode, KeyHandler.KeyState.Up);
        }

        private void DoCameraMovement()
        {
            if (KeyHandler.keyPressed_W) camera.position = Matrix.Add(camera.position.matrix, Matrix.MultSingle(camera.forward.matrix, camera.moving_speed).matrix);
            if (KeyHandler.keyPressed_S) camera.position = Matrix.Sub(camera.position.matrix, Matrix.MultSingle(camera.forward.matrix, camera.moving_speed).matrix);
            if (KeyHandler.keyPressed_A) camera.position = Matrix.Sub(camera.position.matrix, Matrix.MultSingle(camera.right.matrix, camera.moving_speed).matrix);
            if (KeyHandler.keyPressed_D) camera.position = Matrix.Add(camera.position.matrix, Matrix.MultSingle(camera.right.matrix, camera.moving_speed).matrix);
            if (KeyHandler.keyPressed_Q) camera.position = Matrix.Sub(camera.position.matrix, Matrix.MultSingle(camera.up.matrix, camera.moving_speed).matrix);
            if (KeyHandler.keyPressed_E) camera.position = Matrix.Add(camera.position.matrix, Matrix.MultSingle(camera.up.matrix, camera.moving_speed).matrix); 

            if (KeyHandler.keyPressed_Up) camera.camera_pitch(-camera.rotation_speed);
            if (KeyHandler.keyPressed_Down) camera.camera_pitch(camera.rotation_speed);
            if (KeyHandler.keyPressed_Left) camera.camera_yaw(-camera.rotation_speed);
            if (KeyHandler.keyPressed_Right) camera.camera_yaw(camera.rotation_speed);
        }
        private void timer_fpsUpdate_Tick(object sender, EventArgs e)
        {
            string fps = ((int)GetFps()).ToString();
            string mouseFocusMode = KeyHandler.isMouseFocus ? "Press F to disable mouselook" : "Press F to enable mouselook";

            this.Text = $"{fps} - {mouseFocusMode}";
        }

        private void btn_scale_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text.EndsWith("down"))
                object3d.scale(0.9);
            else if (button.Text.EndsWith("up"))
                object3d.scale(1.1);
        }
        private void btn_transfer_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int sign = 1;
            if (button.Text.StartsWith("-")) sign = -1;


            if (button.Text.EndsWith("X"))
                object3d.translate(x: sign * TRANSLATE_DISTANCE);
            else if (button.Text.EndsWith("Y"))
                object3d.translate(y: sign * TRANSLATE_DISTANCE);
            else if (button.Text.EndsWith("Z"))
                object3d.translate(z: sign * TRANSLATE_DISTANCE);
        }

        private void tBox_arbitCoord_TextChanged(object sender, EventArgs e)
        {
            cBox_rotateArbitAxis.Checked = false;
        }

        private void tBox_arbitCoord_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsControl(e.KeyChar);
        }

        private void cBox_rotateArbitAxis_CheckedChanged(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (KeyHandler.isMouseFocus)
            {
                Point picCanvasCenterPosRelativeScreen = picCanvas.PointToScreen(Point.Empty);
                Cursor.Position = new Point(picCanvasCenterPosRelativeScreen.X + picCanvas.Width / 2, picCanvasCenterPosRelativeScreen.Y + picCanvas.Height / 2);

                Point delta = new Point(e.Location.X - half_w, e.Location.Y - half_h);

                camera.camera_yaw(camera.rotation_speed * delta.X);
                //camera.camera_pitch(camera.rotation_speed * delta.Y);
            }
            label1.Text = e.Location.ToString();
        }

        private void cBox_drawProj_CheckedChanged(object sender, EventArgs e)
        {
            bool isVisible = cBox_drawProj.Checked;

            cBox_drawProjConnectLines.Visible = isVisible;
            cBox_drawProjX.Visible = isVisible;
            cBox_drawProjY.Visible = isVisible;
            cBox_drawProjZ.Visible = isVisible;
        }

        private double GetFps()
        {
            double secondsElapsed = (DateTime.Now - lastCheckTime).TotalSeconds;
            long count = Interlocked.Exchange(ref frameCount, 0);
            double fps = count / secondsElapsed;
            lastCheckTime = DateTime.Now;
            return fps;
        }
    }
}
