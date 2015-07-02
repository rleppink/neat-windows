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

        private IntPtr foregroundWindowHandle;
        private ScreenSizePosition screenSizePosition;

        public void ResizeTo(WindowConstants.WindowSizePosition windowSizePosition) 
        {
            this.foregroundWindowHandle = GetForegroundWindow();
            this.screenSizePosition = new ScreenSizePosition(this.foregroundWindowHandle);

            switch (windowSizePosition)
            {
                case WindowConstants.WindowSizePosition.FULLSCREEN:
                    this.ResizeActiveWindow(this.screenSizePosition.FullScreen());
                    break;
                case WindowConstants.WindowSizePosition.LEFT_HALF:
                    this.ResizeActiveWindow(this.screenSizePosition.HalfScreenWidthLeft());
                    break;
                case WindowConstants.WindowSizePosition.RIGHT_HALF:
                    this.ResizeActiveWindow(this.screenSizePosition.HalfScreenWidthRight());
                    break;
                case WindowConstants.WindowSizePosition.TOP_HALF:
                    this.ResizeActiveWindow(this.screenSizePosition.HalfScreenHeightTop());
                    break;
                case WindowConstants.WindowSizePosition.BOTTOM_HALF:
                    this.ResizeActiveWindow(this.screenSizePosition.HalfScreenHeightBottom());
                    break;
                case WindowConstants.WindowSizePosition.TOP_LEFT:
                    this.ResizeActiveWindow(this.screenSizePosition.TopLeftQuarter());
                    break;
                case WindowConstants.WindowSizePosition.TOP_RIGHT:
                    this.ResizeActiveWindow(this.screenSizePosition.TopRightQuarter());
                    break;
                case WindowConstants.WindowSizePosition.BOTTOM_LEFT:
                    this.ResizeActiveWindow(this.screenSizePosition.BottomLeftQuarter());
                    break;
                case WindowConstants.WindowSizePosition.BOTTOM_RIGHT:
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
