using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGeogeoLibrarie
{
    internal class TheGeogeo
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        private const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        // https://docs.microsoft.com/fr-fr/windows/win32/inputdev/virtual-key-codes?redirectedfrom=MSDN list des keys en byte

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        public static void mouseEventMove(int x, int y)
        {
            mouse_event(MOUSEEVENTF_MOVE, x, y, 0, UIntPtr.Zero);
        }

        public static void mouseEventMoveTo(int x, int y)
        {
            var screenBounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            var outputX = x * 65535 / screenBounds.Width;
            var outputY = y * 65535 / screenBounds.Height;
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, outputX, outputY, 0, UIntPtr.Zero);
        }

        /// <summary>
        /// Event click
        /// </summary>
        /// <param name="justOne">Set true if you want just click up or click down</param>
        /// <param name="upOrDown">True = click up / False = click Down</param>
        public static void mouseEventLeftClick(bool justOne = false, bool upOrDown = true)
        {
            if (justOne)
            {
                if (upOrDown)
                {
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
                }
                else
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, UIntPtr.Zero);
                }
            }
            else
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
            }
        }

        /// <summary>
        /// Event click
        /// </summary>
        /// <param name="justOne">Set true if you want just click up or click down</param>
        /// <param name="upOrDown">True = click up / False = click Down</param>
        public static void mouseEventRightClick(bool justOne = false, bool upOrDown = true)
        {
            if (justOne)
            {
                if (upOrDown)
                {
                    mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, UIntPtr.Zero);
                }
                else
                {
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, UIntPtr.Zero);
                }
            }
            else
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, UIntPtr.Zero);
            }
        }
    }
}