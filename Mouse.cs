namespace MouseControl {
    public class Mouse {
        public static void Move(int x, int y) {
            NativeMethods.SetCursorPos(x, y);
        }

        public static void LeftClick(int x, int y) {
            Move(x, y);
            LeftDown();
            LeftUp();
        }

        public static void LeftClick() {
            LeftDown();
            LeftUp();
        }

        public static void RightClick(int x, int y) {
            Move(x, y);
            RightDown();
            RightUp();
        }

        public static void RightClick() {
            RightDown();
            RightUp();
        }

        public static void LeftDown() {
            NativeMethods.mouse_event(NativeMethods.MouseEventFlags.Leftdown, 0u, 0u, 0u, 0);
        }

        public static void LeftUp() {
            NativeMethods.mouse_event(NativeMethods.MouseEventFlags.Leftup, 0u, 0u, 0u, 0);
        }

        public static void RightDown() {
            NativeMethods.mouse_event(NativeMethods.MouseEventFlags.Rightdown, 0u, 0u, 0u, 0);
        }
        public static void RightUp() {
            NativeMethods.mouse_event(NativeMethods.MouseEventFlags.Rightup, 0u, 0u, 0u, 0);
        }
    }
}
