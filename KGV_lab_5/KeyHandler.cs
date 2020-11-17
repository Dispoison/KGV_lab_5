using System.Collections.Generic;
using System.Windows.Forms;

namespace KGV_lab_5
{
    class KeyHandler
    {
        public static bool isMouseFocus = false;

        public enum KeyState
        {
            Down,
            Up
        }

        private readonly static Dictionary<KeyState, bool> dictKeyState = new Dictionary<KeyState, bool>() { { KeyState.Down, true }, { KeyState.Up, false } };
        public static Dictionary<Keys, bool> KeysPressed = new Dictionary<Keys, bool>() 
        { 
            { Keys.W, false },
            { Keys.S, false },
            { Keys.A, false },
            { Keys.D, false },
            { Keys.Q, false },
            { Keys.E, false },
            { Keys.Up, false },
            { Keys.Down, false },
            { Keys.Left, false },
            { Keys.Right, false },
            { Keys.F, false },
        };

        public static void KeyEvent(Keys key, KeyState keyState)
        {
            if (!KeysPressed.ContainsKey(key))
                return;

            if (key == Keys.F)
                MouseLook(keyState);
            else
                KeysPressed[key] = dictKeyState[keyState];

        }

        private static void MouseLook(KeyState keyState)
        {
            if (keyState == KeyState.Down)
            {
                if (!KeysPressed[Keys.F])
                {
                    if (!isMouseFocus)
                    {
                        KeysPressed[Keys.F] = true;
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
                KeysPressed[Keys.F] = false;
            }
        }

    }
}
