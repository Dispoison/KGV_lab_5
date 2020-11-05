using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGV_lab_5
{
    public partial class Form1 : Form
    {
        int half_w, half_h;
        Camera camera;
        Projection projection;
        Object3d object3d;
        Axes axes;
        Axes worldAxes;
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
            camera = new Camera(0.5, 1, -4, picCanvas);
            projection = new Projection(camera, half_w, half_h);
            object3d = new Object3d(camera, projection, half_w, half_h);
            object3d.translate(0.2, 0.4, 0.2);
            axes = new Axes(camera, projection, half_w, half_h);
            axes.translate(0.7, 0.9, 0.7);
            worldAxes = new Axes(camera, projection, half_w, half_h);
            worldAxes.movement_flag = false;
            worldAxes.scale(2.5);
            worldAxes.translate(0.0001, 0.0001, 0.0001);

        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            object3d.draw(e.Graphics);
            worldAxes.draw(e.Graphics);
            axes.draw(e.Graphics);
        }
        private void timer_game_Tick(object sender, EventArgs e)
        {
            object3d.rotate_x(0.01);
            object3d.rotate_y(0.01);
            object3d.rotate_z(0.01);
            axes.rotate_x(0.01);
            axes.rotate_y(0.01);
            axes.rotate_z(0.01);
            DoCameraMovement();

            picCanvas.Refresh(); 
            Interlocked.Increment(ref frameCount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
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
            this.Text = ((int)GetFps()).ToString();
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
