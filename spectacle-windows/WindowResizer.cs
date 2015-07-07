using System;
using System.Drawing;

namespace spectacle_windows
{
    class WindowResizer
    {

        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        private IntPtr foregroundWindowHandle;
        private Rectangle foregroundWindowBounds;
        private ScreenSizePosition screenSizePosition;

        public void ResizeTo(WindowConstants.WindowSizePosition windowSizePosition) 
        {
            this.foregroundWindowHandle = NativeMethods.GetForegroundWindow();
            this.foregroundWindowBounds = this.GetForegroundWindowBounds();
            this.screenSizePosition = new ScreenSizePosition(this.foregroundWindowHandle);

            switch (windowSizePosition)
            {
                case WindowConstants.WindowSizePosition.FULLSCREEN:
                    if (this.foregroundWindowBounds == this.screenSizePosition.FullScreen())
                        this.ResizeActiveWindow(this.screenSizePosition.TwoThirdsCenter());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.TwoThirdsCenter())
                        this.ResizeActiveWindow(this.screenSizePosition.QuarterCenter());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.QuarterCenter())
                        this.ResizeActiveWindow(this.screenSizePosition.ThirdCenter());
                    else
                        this.ResizeActiveWindow(this.screenSizePosition.FullScreen());
                    break;

                case WindowConstants.WindowSizePosition.CENTER:
                    this.ResizeActiveWindow(this.screenSizePosition.Center(this.foregroundWindowBounds));
                    break;

                case WindowConstants.WindowSizePosition.NEXT_SCREEN:
                    this.ResizeActiveWindow(this.screenSizePosition.NextScreen(this.foregroundWindowBounds));
                    break;
                case WindowConstants.WindowSizePosition.PREVIOUS_SCREEN:
                    this.ResizeActiveWindow(this.screenSizePosition.PreviousScreen(this.foregroundWindowBounds));
                    break;

                case WindowConstants.WindowSizePosition.LEFT_HALF:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfWidthLeft())
                        this.ResizeActiveWindow(this.screenSizePosition.ThirdWidthLeft());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.ThirdWidthLeft())
                        this.ResizeActiveWindow(this.screenSizePosition.TwoThirdsWidthLeft());
                    else
                        this.ResizeActiveWindow(this.screenSizePosition.HalfWidthLeft());
                    break;

                case WindowConstants.WindowSizePosition.RIGHT_HALF:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfWidthRight())
                        this.ResizeActiveWindow(this.screenSizePosition.ThirdWidthRight());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.ThirdWidthRight())
                        this.ResizeActiveWindow(this.screenSizePosition.TwoThirdsWidthRight());
                    else
                        this.ResizeActiveWindow(this.screenSizePosition.HalfWidthRight());
                    break;

                case WindowConstants.WindowSizePosition.TOP_HALF:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfHeightTop())
                        this.ResizeActiveWindow(this.screenSizePosition.ThirdHeightTop());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.ThirdHeightTop())
                        this.ResizeActiveWindow(this.screenSizePosition.TwoThirdsHeightTop());
                    else
                        this.ResizeActiveWindow(this.screenSizePosition.HalfHeightTop());
                    break;

                case WindowConstants.WindowSizePosition.BOTTOM_HALF:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfHeightBottom())
                        this.ResizeActiveWindow(this.screenSizePosition.ThirdHeightBottom());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.ThirdHeightBottom())
                        this.ResizeActiveWindow(this.screenSizePosition.TwoThirdsHeightBottom());
                    else
                        this.ResizeActiveWindow(this.screenSizePosition.HalfHeightBottom());
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
            return NativeMethods.SetWindowPos(this.foregroundWindowHandle, 
                                WindowConstants.HWND.TOP,
                                newWindowSize.X, 
                                newWindowSize.Y, 
                                newWindowSize.Width, 
                                newWindowSize.Height, 
                                WindowConstants.SWP.SHOWWINDOW);
        }

        private Rectangle GetForegroundWindowBounds()
        {
            RECT outRect;
            NativeMethods.GetWindowRect(this.foregroundWindowHandle, out outRect);
            return new Rectangle(
                outRect.Left,
                outRect.Top,
                outRect.Right - outRect.Left,
                outRect.Bottom - outRect.Top
                );
        }

    }
}
