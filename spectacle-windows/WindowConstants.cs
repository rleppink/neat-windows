using System;

namespace spectacle_windows
{
    /*
     *  Constants kindly taken from:
     *  http://www.pinvoke.net/default.aspx/user32.setwindowpos
     */
    public static class WindowConstants
    {
        /// <summary>
        /// Window handles (HWND) used for hWndInsertAfter
        /// </summary>
        public static class HWND
        {
           public static readonly IntPtr
           NOTOPMOST = new IntPtr(-2),
           TOPMOST = new IntPtr(-1),
           TOP = new IntPtr(0),
           BOTTOM = new IntPtr(1);
        }

        /// <summary>
        /// SetWindowPos Flags
        /// </summary>
        public static class SWP
        {
           public static readonly uint
           NOSIZE = 0x0001,
           NOMOVE = 0x0002,
           NOZORDER = 0x0004,
           NOREDRAW = 0x0008,
           NOACTIVATE = 0x0010,
           DRAWFRAME = 0x0020,
           FRAMECHANGED = 0x0020,
           SHOWWINDOW = 0x0040,
           HIDEWINDOW = 0x0080,
           NOCOPYBITS = 0x0100,
           NOOWNERZORDER = 0x0200,
           NOREPOSITION = 0x0200,
           NOSENDCHANGING = 0x0400,
           DEFERERASE = 0x2000,
           ASYNCWINDOWPOS = 0x4000;
        }

    }

}
