namespace NeatWindows
{
    using System;
    using System.Drawing;

    public class WindowResizer : IDisposable
    {
        private Rectangle foregroundWindowBounds;
        private IntPtr foregroundWindowHandle;
        private ScreenSizePosition screenSizePosition;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ResizeTo(WindowSizePosition windowSizePosition)
        {
            this.foregroundWindowHandle = NativeMethods.GetForegroundWindow();
            this.foregroundWindowBounds = this.GetForegroundWindowBounds();
            this.screenSizePosition = new ScreenSizePosition(this.foregroundWindowHandle);

            switch (windowSizePosition)
            {
                case WindowSizePosition.FullScreen:
                    if (this.foregroundWindowBounds == this.screenSizePosition.FullScreen())
                        this.ResizeActiveWindow(this.screenSizePosition.TwoThirdsCenter());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.TwoThirdsCenter())
                        this.ResizeActiveWindow(this.screenSizePosition.QuarterCenter());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.QuarterCenter())
                        this.ResizeActiveWindow(this.screenSizePosition.ThirdCenter());
                    else
                        this.ResizeActiveWindow(this.screenSizePosition.FullScreen());
                    break;

                case WindowSizePosition.Center:
                    this.ResizeActiveWindow(this.screenSizePosition.Center(this.foregroundWindowBounds));
                    break;

                case WindowSizePosition.NextScreen:
                    this.ResizeActiveWindow(this.screenSizePosition.NextScreen(this.foregroundWindowBounds));
                    break;

                case WindowSizePosition.PreviousScreen:
                    this.ResizeActiveWindow(this.screenSizePosition.PreviousScreen(this.foregroundWindowBounds));
                    break;

                case WindowSizePosition.LeftHalf:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfWidthLeft())
                        this.ResizeActiveWindow(this.screenSizePosition.ThirdWidthLeft());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.ThirdWidthLeft())
                        this.ResizeActiveWindow(this.screenSizePosition.TwoThirdsWidthLeft());
                    else
                        this.ResizeActiveWindow(this.screenSizePosition.HalfWidthLeft());
                    break;

                case WindowSizePosition.RightHalf:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfWidthRight())
                        this.ResizeActiveWindow(this.screenSizePosition.ThirdWidthRight());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.ThirdWidthRight())
                        this.ResizeActiveWindow(this.screenSizePosition.TwoThirdsWidthRight());
                    else
                        this.ResizeActiveWindow(this.screenSizePosition.HalfWidthRight());
                    break;

                case WindowSizePosition.TopHalf:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfHeightTop())
                        this.ResizeActiveWindow(this.screenSizePosition.ThirdHeightTop());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.ThirdHeightTop())
                        this.ResizeActiveWindow(this.screenSizePosition.TwoThirdsHeightTop());
                    else
                        this.ResizeActiveWindow(this.screenSizePosition.HalfHeightTop());
                    break;

                case WindowSizePosition.BottomHalf:
                    if (this.foregroundWindowBounds == this.screenSizePosition.HalfHeightBottom())
                        this.ResizeActiveWindow(this.screenSizePosition.ThirdHeightBottom());
                    else if (this.foregroundWindowBounds == this.screenSizePosition.ThirdHeightBottom())
                        this.ResizeActiveWindow(this.screenSizePosition.TwoThirdsHeightBottom());
                    else
                        this.ResizeActiveWindow(this.screenSizePosition.HalfHeightBottom());
                    break;

                case WindowSizePosition.TopLeft:
                    this.ResizeActiveWindow(this.screenSizePosition.TopLeftQuarter());
                    break;

                case WindowSizePosition.TopRight:
                    this.ResizeActiveWindow(this.screenSizePosition.TopRightQuarter());
                    break;

                case WindowSizePosition.BottomLeft:
                    this.ResizeActiveWindow(this.screenSizePosition.BottomLeftQuarter());
                    break;

                case WindowSizePosition.BottomRight:
                    this.ResizeActiveWindow(this.screenSizePosition.BottomRightQuarter());
                    break;
            }
        }

        private Rectangle GetForegroundWindowBounds()
        {
            Rect outRect;
            NativeMethods.GetWindowRect(this.foregroundWindowHandle, out outRect);
            return new Rectangle(
                outRect.Left,
                outRect.Top,
                outRect.Right - outRect.Left,
                outRect.Bottom - outRect.Top);
        }

        private bool ResizeActiveWindow(Rectangle newWindowSize)
        {
            return NativeMethods.SetWindowPos(
                this.foregroundWindowHandle,
                WindowHandles.Top,
                newWindowSize.X,
                newWindowSize.Y,
                newWindowSize.Width,
                newWindowSize.Height,
                SetWindowPos.ShowWindow);
        }
    }
}