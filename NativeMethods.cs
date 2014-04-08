using System;
using System.Runtime.InteropServices;

namespace MouseControl {
    internal class NativeMethods {
        [Flags]
        public enum MouseEventFlags : uint {
            Leftdown = 2u,
            Leftup = 4u,
            Middledown = 32u,
            Middleup = 64u,
            Move = 1u,
            Absolute = 32768u,
            Rightdown = 8u,
            Rightup = 16u,
            Wheel = 2048u,
            Xdown = 128u,
            Xup = 256u
        }

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(MouseEventFlags dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
    }
}
