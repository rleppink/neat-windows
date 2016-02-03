namespace NeatWindows
{
    using System;
    using System.Drawing;

    /// <summary>
    /// An enum containing all possible window sizes and positions.
    /// </summary>
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

    /// <summary>
    /// Class responsible for actually resizing a window.
    /// </summary>
    public class WindowResizer
    {
        private static readonly IntPtr InsertTop = new IntPtr(0);
        private const uint ShowWindowFlag = 0x0040;
        private Rectangle _ForegroundWindowBounds;
        private ScreenSizePosition _ScreenSizePosition;

        /// <summary>
        /// Resizes the currently active window to the given window size position.
        /// </summary>
        /// <param name="windowSizePosition">The windowsizeposition to resize to</param>
        public void ResizeTo(WindowSizePosition windowSizePosition)
        {
            _ForegroundWindowBounds = GetForegroundWindowBounds();
            _ScreenSizePosition = new ScreenSizePosition(NativeMethods.GetForegroundWindow());

            switch (windowSizePosition)
            {
                case WindowSizePosition.Fullscreen:
                    if (_ForegroundWindowBounds == _ScreenSizePosition.FullScreen())
                        ResizeActiveWindow(_ScreenSizePosition.TwoThirdsCenter());
                    else if (_ForegroundWindowBounds == _ScreenSizePosition.TwoThirdsCenter())
                        ResizeActiveWindow(_ScreenSizePosition.QuarterCenter());
                    else if (_ForegroundWindowBounds == _ScreenSizePosition.QuarterCenter())
                        ResizeActiveWindow(_ScreenSizePosition.ThirdCenter());
                    else
                        ResizeActiveWindow(_ScreenSizePosition.FullScreen());

                    break;

                case WindowSizePosition.Center:
                    ResizeActiveWindow(_ScreenSizePosition.Center(_ForegroundWindowBounds));
                    break;

                case WindowSizePosition.NextScreen:
                    ResizeActiveWindow(_ScreenSizePosition.NextScreen(_ForegroundWindowBounds));
                    break;

                case WindowSizePosition.PreviousScreen:
                    ResizeActiveWindow(_ScreenSizePosition.PreviousScreen(_ForegroundWindowBounds));
                    break;

                case WindowSizePosition.LeftHalf:
                    if (_ForegroundWindowBounds == _ScreenSizePosition.HalfWidthLeft())
                        ResizeActiveWindow(_ScreenSizePosition.TwoThirdsWidthLeft());
                    else if (_ForegroundWindowBounds == _ScreenSizePosition.TwoThirdsWidthLeft())
                        ResizeActiveWindow(_ScreenSizePosition.ThirdWidthLeft());
                    else
                        ResizeActiveWindow(_ScreenSizePosition.HalfWidthLeft());

                    break;

                case WindowSizePosition.RightHalf:
                    if (_ForegroundWindowBounds == _ScreenSizePosition.HalfWidthRight())
                        ResizeActiveWindow(_ScreenSizePosition.TwoThirdsWidthRight());
                    else if (_ForegroundWindowBounds == _ScreenSizePosition.TwoThirdsWidthRight())
                        ResizeActiveWindow(_ScreenSizePosition.ThirdWidthRight());
                    else
                        ResizeActiveWindow(_ScreenSizePosition.HalfWidthRight());

                    break;

                case WindowSizePosition.TopHalf:
                    if (_ForegroundWindowBounds == _ScreenSizePosition.HalfHeightTop())
                        ResizeActiveWindow(_ScreenSizePosition.TwoThirdsHeightTop());
                    else if (_ForegroundWindowBounds == _ScreenSizePosition.TwoThirdsHeightTop())
                        ResizeActiveWindow(_ScreenSizePosition.ThirdHeightTop());
                    else
                        ResizeActiveWindow(_ScreenSizePosition.HalfHeightTop());

                    break;

                case WindowSizePosition.BottomHalf:
                    if (_ForegroundWindowBounds == _ScreenSizePosition.HalfHeightBottom())
                        ResizeActiveWindow(_ScreenSizePosition.TwoThirdsHeightBottom());
                    else if (_ForegroundWindowBounds == _ScreenSizePosition.TwoThirdsHeightBottom())
                        ResizeActiveWindow(_ScreenSizePosition.ThirdHeightBottom());
                    else
                        ResizeActiveWindow(_ScreenSizePosition.HalfHeightBottom());

                    break;

                case WindowSizePosition.TopLeft:
                    ResizeActiveWindow(_ScreenSizePosition.TopLeftQuarter());
                    break;

                case WindowSizePosition.TopRight:
                    ResizeActiveWindow(_ScreenSizePosition.TopRightQuarter());
                    break;

                case WindowSizePosition.BottomLeft:
                    ResizeActiveWindow(_ScreenSizePosition.BottomLeftQuarter());
                    break;

                case WindowSizePosition.BottomRight:
                    ResizeActiveWindow(_ScreenSizePosition.BottomRightQuarter());
                    break;
            }
        }

        /// <summary>
        /// Returns the current size of the active window.
        /// </summary>
        /// <returns>The current size of the active window</returns>
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

        /// <summary>
        /// Resizes the currently active window to the given new window size.
        /// </summary>
        /// <param name="newWindowSize">The window size to resize to</param>
        private static void ResizeActiveWindow(Rectangle newWindowSize)
        {
            NativeMethods.SetWindowPos(
                NativeMethods.GetForegroundWindow(),
                InsertTop,
                newWindowSize.X,
                newWindowSize.Y,
                newWindowSize.Width,
                newWindowSize.Height,
                ShowWindowFlag);
        }
    }
}