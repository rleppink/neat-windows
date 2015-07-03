using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace spectacle_windows
{
    class WindowResizer
    {

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError=true)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int xPosition, int yPosition, int width, int height, uint uFlags);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        private struct RECT
        {
            private int Left;
            private int Right;
            private int Top;
            private int Bottom;
        }

        public enum WindowSizePosition
        {
            FULLSCREEN,
            LEFT_HALF,
            RIGHT_HALF,
            TOP_HALF,
            BOTTOM_HALF,
            TOP_LEFT,
            TOP_RIGHT,
            BOTTOM_LEFT,
            BOTTOM_RIGHT
        }


        private IntPtr foregroundWindowHandle;
        private ScreenSizePosition screenSizePosition;

        public void ResizeTo(WindowSizePosition windowSizePosition) 
        {
            this.foregroundWindowHandle = GetForegroundWindow();
            this.screenSizePosition = new ScreenSizePosition(this.foregroundWindowHandle);

            switch (windowSizePosition)
            {
                case WindowSizePosition.FULLSCREEN:
                    this.ResizeActiveWindow(this.screenSizePosition.FullScreen());
                    break;
                case WindowSizePosition.LEFT_HALF:
                    
                    this.ResizeActiveWindow(this.screenSizePosition.HalfWidthLeft());
                    break;
                case WindowSizePosition.RIGHT_HALF:
                    this.ResizeActiveWindow(this.screenSizePosition.HalfWidthRight());
                    break;
                case WindowSizePosition.TOP_HALF:
                    this.ResizeActiveWindow(this.screenSizePosition.HalfHeightTop());
                    break;
                case WindowSizePosition.BOTTOM_HALF:
                    this.ResizeActiveWindow(this.screenSizePosition.HalfHeightBottom());
                    break;
                case WindowSizePosition.TOP_LEFT:
                    this.ResizeActiveWindow(this.screenSizePosition.TopLeftQuarter());
                    break;
                case WindowSizePosition.TOP_RIGHT:
                    this.ResizeActiveWindow(this.screenSizePosition.TopRightQuarter());
                    break;
                case WindowSizePosition.BOTTOM_LEFT:
                    this.ResizeActiveWindow(this.screenSizePosition.BottomLeftQuarter());
                    break;
                case WindowSizePosition.BOTTOM_RIGHT:
                    this.ResizeActiveWindow(this.screenSizePosition.BottomRightQuarter());
                    break;
            }
        }

        private bool ResizeActiveWindow(Rectangle newWindowSize)
        {
            return SetWindowPos(this.foregroundWindowHandle, 
                                WindowConstants.HWND.TOP,
                                newWindowSize.X, 
                                newWindowSize.Y, 
                                newWindowSize.Width, 
                                newWindowSize.Height, 
                                WindowConstants.SWP.SHOWWINDOW);
        }

    }
}
