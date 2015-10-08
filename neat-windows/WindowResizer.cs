namespace NeatWindows
{
    using System;
    using System.Drawing;

    public enum WindowSizePosition
    {
        Fullscreen,
        LeftHalf,
        RightHalf,
        TopHalf,
        BottomHalf,
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight,
        Center,
        NextScreen,
        PreviousScreen
    }

    public class WindowResizer
    {
        private static readonly IntPtr InsertTop = new IntPtr(0);
        private static uint showWindowFlag = 0x0040;
        private Rectangle foregroundWindowBounds;
        private ScreenSizePosition screenSizePosition;

        public void ResizeTo(WindowSizePosition windowSizePosition)
        {
            this.foregroundWindowBounds = GetForegroundWindowBounds();
            this.screenSizePosition = new ScreenSizePosition(NativeMethods.GetForegroundWindow());

            switch (windowSizePosition)
            {
                case WindowSizePosition.Fullscreen:
                    if (this.foregroundWindowBounds == this.screenSizePosition.FullScreen())
                    {
                        ResizeActiveWindow(this.screenSizePosition.TwoThirdsCenter());
                    }
                    else if (this.foregroundWindowBounds == this.screenSizePosition.TwoThirdsCenter())
                    {
                        ResizeActiveWindow(this.screenSizePosition.QuarterCenter());
                    }
                    else if (this.foregroundWindowBounds == this.screenSizePosition.QuarterCenter())
                    {
                        ResizeActiveWindow(this.screenSizePosition.ThirdCenter());
                    }
                    else
                    {
                        ResizeActiveWindow(this.screenSizePosition.FullScreen());
                    }

                    break;

                case WindowSizePosition.Center:
                    ResizeActiveWindow(this.screenSizePosition.Center(this.foregroundWindowBounds));
                    break;

                case WindowSizePosition.NextScreen:
                    ResizeActiveWindow(this.screenSizePosition.NextScreen(this.foregroundWindowBounds));
                    break;

                case WindowSizePosition.PreviousScreen:
                    ResizeActiveWindow(this.screenSizePosition.PreviousScreen(this.foregroundWindowBounds));
                    break;

                case WindowSizePosition.LeftHalf:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfWidthLeft())
                    {
                        ResizeActiveWindow(this.screenSizePosition.TwoThirdsWidthLeft());
                    }
                    else if (this.foregroundWindowBounds == this.screenSizePosition.TwoThirdsWidthLeft())
                    {
                        ResizeActiveWindow(this.screenSizePosition.ThirdWidthLeft());
                    }
                    else
                    {
                        ResizeActiveWindow(this.screenSizePosition.HalfWidthLeft());
                    }

                    break;

                case WindowSizePosition.RightHalf:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfWidthRight())
                    {
                        ResizeActiveWindow(this.screenSizePosition.TwoThirdsWidthRight());
                    }
                    else if (this.foregroundWindowBounds == this.screenSizePosition.TwoThirdsWidthRight())
                    {
                        ResizeActiveWindow(this.screenSizePosition.ThirdWidthRight());
                    }
                    else
                    {
                        ResizeActiveWindow(this.screenSizePosition.HalfWidthRight());
                    }

                    break;

                case WindowSizePosition.TopHalf:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfHeightTop())
                    {
                        ResizeActiveWindow(this.screenSizePosition.TwoThirdsHeightTop());
                    }
                    else if (this.foregroundWindowBounds == this.screenSizePosition.TwoThirdsHeightTop())
                    {
                        ResizeActiveWindow(this.screenSizePosition.ThirdHeightTop());
                    }
                    else
                    {
                        ResizeActiveWindow(this.screenSizePosition.HalfHeightTop());
                    }

                    break;

                case WindowSizePosition.BottomHalf:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfHeightBottom())
                    {
                        ResizeActiveWindow(this.screenSizePosition.TwoThirdsHeightBottom());
                    }
                    else if (this.foregroundWindowBounds == this.screenSizePosition.TwoThirdsHeightBottom())
                    {
                        ResizeActiveWindow(this.screenSizePosition.ThirdHeightBottom());
                    }
                    else
                    {
                        ResizeActiveWindow(this.screenSizePosition.HalfHeightBottom());
                    }

                    break;

                case WindowSizePosition.TopLeft:
                    ResizeActiveWindow(this.screenSizePosition.TopLeftQuarter());
                    break;

                case WindowSizePosition.TopRight:
                    ResizeActiveWindow(this.screenSizePosition.TopRightQuarter());
                    break;

                case WindowSizePosition.BottomLeft:
                    ResizeActiveWindow(this.screenSizePosition.BottomLeftQuarter());
                    break;

                case WindowSizePosition.BottomRight:
                    ResizeActiveWindow(this.screenSizePosition.BottomRightQuarter());
                    break;
            }
        }

        private static Rectangle GetForegroundWindowBounds()
        {
            Rect outRect;
            NativeMethods.GetWindowRect(NativeMethods.GetForegroundWindow(), out outRect);
            return new Rectangle(
                outRect.Left,
                outRect.Top,
                outRect.Right - outRect.Left,
                outRect.Bottom - outRect.Top);
        }

        private static bool ResizeActiveWindow(Rectangle newWindowSize)
        {
            return NativeMethods.SetWindowPos(
                NativeMethods.GetForegroundWindow(),
                InsertTop,
                newWindowSize.X,
                newWindowSize.Y,
                newWindowSize.Width,
                newWindowSize.Height,
                showWindowFlag);
        }
    }
}