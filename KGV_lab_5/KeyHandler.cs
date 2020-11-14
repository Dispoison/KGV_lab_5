using System.Windows.Forms;

namespace KGV_lab_5
{
    class KeyHandler
    {
        public static bool keyPressed_W = false, keyPressed_S = false, keyPressed_A = false, keyPressed_D = false,
                            keyPressed_Q = false, keyPressed_E = false, keyPressed_Up = false,
                            keyPressed_Down = false, keyPressed_Left = false, keyPressed_Right = false;
        public static bool isMouseFocus = false;
        private static bool keyPressed_F = false;

        public enum KeyState
        {
            Down,
            Up
        }

        public static void KeyEvent(Keys key, KeyState keyState)
        {
            switch(key)
            {
                case Keys.W:
                    if (keyState == KeyState.Down)
                        keyPressed_W = true;
                    else if (keyState == KeyState.Up)
                        keyPressed_W = false;
                    break;
                case Keys.S:
                    if (keyState == KeyState.Down)
                        keyPressed_S = true;
                    else if (keyState == KeyState.Up)
                        keyPressed_S = false;
                    break;
                case Keys.A:
                    if (keyState == KeyState.Down)
                        keyPressed_A = true;
                    else if (keyState == KeyState.Up)
                        keyPressed_A = false;
                    break;
                case Keys.D:
                    if (keyState == KeyState.Down)
                        keyPressed_D = true;
                    else if (keyState == KeyState.Up)
                        keyPressed_D = false;
                    break;
                case Keys.Q:
                    if (keyState == KeyState.Down)
                        keyPressed_Q = true;
                    else if (keyState == KeyState.Up)
                        keyPressed_Q = false;
                    break;
                case Keys.E:
                    if (keyState == KeyState.Down)
                        keyPressed_E = true;
                    else if (keyState == KeyState.Up)
                        keyPressed_E = false;
                    break;
                case Keys.Up:
                    if (keyState == KeyState.Down)
                        keyPressed_Up = true;
                    else if (keyState == KeyState.Up)
                        keyPressed_Up = false;
                    break;
                case Keys.Down:
                    if (keyState == KeyState.Down)
                        keyPressed_Down = true;
                    else if (keyState == KeyState.Up)
                        keyPressed_Down = false;
                    break;
                case Keys.Left:
                    if (keyState == KeyState.Down)
                        keyPressed_Left = true;
                    else if (keyState == KeyState.Up)
                        keyPressed_Left = false;
                    break;
                case Keys.Right:
                    if (keyState == KeyState.Down)
                        keyPressed_Right = true;
                    else if (keyState == KeyState.Up)
                        keyPressed_Right = false;
                    break;
                case Keys.F:
                    if (keyState == KeyState.Down)
                    {
                        if (!keyPressed_F)
                        {
                            if (!isMouseFocus)
                            {
                                keyPressed_F = true;
                                isMouseFocus = true;
                                Cursor.Hide();
                            }
                            else if (isMouseFocus)
                            {
                                isMouseFocus = false;
                                Cursor.Show();
                            }
                        }
                    }
                    else if (keyState == KeyState.Up)
                    {
                        keyPressed_F = false;
                    }
                    break;
            }
        }

    }
}
