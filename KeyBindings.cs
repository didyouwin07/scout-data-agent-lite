using System.Runtime.InteropServices;

namespace KeyBindings
{
    public class Mouse
    {

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out POINT point);
        [DllImport("user32.dll")]
        public static extern bool GetAsyncKeyState(int button);

        public struct POINT
        {
            public int x;
            public int y;
        }

        public static POINT GetMousePosition()
        {
            POINT pos;
            GetCursorPos(out pos);
            return pos;
        }

        public static bool IsMouseButtonPressed(MouseButton button)
        {
            return GetAsyncKeyState((int)button);
        }
        public enum MouseButton
        {
            LeftMouseButton = 0x01,
            RightMouseButton = 0x02,
            MiddleMouseButton = 0x04,
        }
    }
}