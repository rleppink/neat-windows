namespace NeatWindows
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal class ScreenSizePosition
    {
        private readonly int _Border;
        private readonly Screen _ActiveScreen;

        public ScreenSizePosition(IntPtr activeWindow)
        {
            _ActiveScreen = Screen.FromHandle(activeWindow);
            _Border = Properties.Settings.Default.WindowBorder;
        }

        private Rectangle ActiveScreenSize
        {
            get { return _ActiveScreen.WorkingArea; }
        }

        #region Sizes

        private int FullScreenHeight
        {
            get { return ActiveScreenSize.Height - (_Border * 2); }
        }

        private int FullScreenWidth
        {
            get { return ActiveScreenSize.Width - (_Border * 2); }
        }

        private int HalfScreenHeight
        {
            get { return (ActiveScreenSize.Height / 2) - (_Border + (_Border / 2)); }
        }

        private int HalfScreenWidth
        {
            get { return (ActiveScreenSize.Width / 2) - (_Border + (_Border / 2)); }
        }

        private int ThirdScreenHeight
        {
            get { return (ActiveScreenSize.Height / 3) - (_Border + (_Border / 3)); }
        }

        private int ThirdScreenWidth
        {
            get { return (ActiveScreenSize.Width / 3) - (_Border + (_Border / 3)); }
        }

        private int TwoThirdsScreenHeight
        {
            get { return ((ActiveScreenSize.Height / 3) * 2) - (_Border + (_Border / 3)); }
        }

        private int TwoThirdsScreenWidth
        {
            get { return ((ActiveScreenSize.Width / 3) * 2) - (_Border + (_Border / 3)); }
        }

        #endregion Sizes

        #region Positions

        private int LeftX
        {
            get { return ActiveScreenSize.X + _Border; }
        }

        private int MidX
        {
            get { return ActiveScreenSize.X + (ActiveScreenSize.Width / 2) + (_Border / 2); }
        }

        private int MidY
        {
            get { return ActiveScreenSize.Y + (ActiveScreenSize.Height / 2) + (_Border / 2); }
        }

        private int ThirdX
        {
            get { return ActiveScreenSize.X + (ActiveScreenSize.Width / 3) + (_Border / 3); }
        }

        private int ThirdY
        {
            get { return ActiveScreenSize.Y + (ActiveScreenSize.Height / 3) + (_Border / 3); }
        }

        private int TopY
        {
            get { return ActiveScreenSize.Y + _Border; }
        }

        private int TwoThirdsX
        {
            get { return ActiveScreenSize.X + ((ActiveScreenSize.Width / 3) * 2) + (_Border / 3); }
        }

        private int TwoThirdsY
        {
            get { return ActiveScreenSize.Y + ((ActiveScreenSize.Height / 3) * 2) + (_Border / 3); }
        }

        #endregion Positions

        #region Fullscreen, centered

        public Rectangle Center(Rectangle window)
        {
            return new Rectangle(
                ActiveScreenSize.X + ((ActiveScreenSize.Width - window.Width) / 2),
                ActiveScreenSize.Y + ((ActiveScreenSize.Height - window.Height) / 2),
                window.Width,
                window.Height);
        }

        public Rectangle FullScreen()
        {
            return new Rectangle(
                LeftX,
                TopY,
                FullScreenWidth,
                FullScreenHeight);
        }

        public Rectangle QuarterCenter()
        {
            return new Rectangle(
                ActiveScreenSize.X + ((ActiveScreenSize.Width - HalfScreenWidth) / 2),
                ActiveScreenSize.Y + ((ActiveScreenSize.Height - HalfScreenHeight) / 2),
                HalfScreenWidth,
                HalfScreenHeight);
        }

        public Rectangle ThirdCenter()
        {
            return new Rectangle(
                ActiveScreenSize.X + ((ActiveScreenSize.Width - ThirdScreenWidth) / 2),
                ActiveScreenSize.Y + ((ActiveScreenSize.Height - ThirdScreenHeight) / 2),
                ThirdScreenWidth,
                ThirdScreenHeight);
        }

        public Rectangle TwoThirdsCenter()
        {
            return new Rectangle(
                ActiveScreenSize.X + ((ActiveScreenSize.Width - TwoThirdsScreenWidth) / 2),
                ActiveScreenSize.Y + ((ActiveScreenSize.Height - TwoThirdsScreenHeight) / 2),
                TwoThirdsScreenWidth,
                TwoThirdsScreenHeight);
        }

        #endregion Fullscreen, centered

        #region Half sizes

        public Rectangle HalfHeightBottom()
        {
            return new Rectangle(
                LeftX,
                MidY,
                FullScreenWidth,
                HalfScreenHeight);
        }

        public Rectangle HalfHeightTop()
        {
            return new Rectangle(
                LeftX,
                TopY,
                FullScreenWidth,
                HalfScreenHeight);
        }

        public Rectangle HalfWidthLeft()
        {
            return new Rectangle(
                LeftX,
                TopY,
                HalfScreenWidth,
                FullScreenHeight);
        }

        public Rectangle HalfWidthRight()
        {
            return new Rectangle(
                MidX,
                TopY,
                HalfScreenWidth,
                FullScreenHeight);
        }

        #endregion Half sizes

        #region Third sizes

        public Rectangle ThirdHeightBottom()
        {
            return new Rectangle(
                LeftX,
                TwoThirdsY,
                FullScreenWidth,
                ThirdScreenHeight);
        }

        public Rectangle ThirdHeightTop()
        {
            return new Rectangle(
                LeftX,
                TopY,
                FullScreenWidth,
                ThirdScreenHeight);
        }

        public Rectangle ThirdWidthLeft()
        {
            return new Rectangle(
                LeftX,
                TopY,
                ThirdScreenWidth,
                FullScreenHeight);
        }

        public Rectangle ThirdWidthRight()
        {
            return new Rectangle(
                TwoThirdsX,
                TopY,
                ThirdScreenWidth,
                FullScreenHeight);
        }

        public Rectangle TwoThirdsHeightBottom()
        {
            return new Rectangle(
                LeftX,
                ThirdY,
                FullScreenWidth,
                TwoThirdsScreenHeight);
        }

        public Rectangle TwoThirdsHeightTop()
        {
            return new Rectangle(
                LeftX,
                TopY,
                FullScreenWidth,
                TwoThirdsScreenHeight);
        }

        public Rectangle TwoThirdsWidthLeft()
        {
            return new Rectangle(
                LeftX,
                TopY,
                TwoThirdsScreenWidth,
                FullScreenHeight);
        }

        public Rectangle TwoThirdsWidthRight()
        {
            return new Rectangle(
                ThirdX,
                TopY,
                TwoThirdsScreenWidth,
                FullScreenHeight);
        }

        #endregion Third sizes

        #region Quarter sizes

        public Rectangle BottomLeftQuarter()
        {
            return new Rectangle(
                LeftX,
                MidY,
                HalfScreenWidth,
                HalfScreenHeight);
        }

        public Rectangle BottomRightQuarter()
        {
            return new Rectangle(
                MidX,
                MidY,
                HalfScreenWidth,
                HalfScreenHeight);
        }

        public Rectangle TopLeftQuarter()
        {
            return new Rectangle(
                LeftX,
                TopY,
                HalfScreenWidth,
                HalfScreenHeight);
        }

        public Rectangle TopRightQuarter()
        {
            return new Rectangle(
                MidX,
                TopY,
                HalfScreenWidth,
                HalfScreenHeight);
        }

        #endregion Quarter sizes

        #region Multiple screens

        public Rectangle NextScreen(Rectangle window)
        {
            var nextScreenBounds = GetNextScreen().WorkingArea;
            return new Rectangle(
                nextScreenBounds.X + ((nextScreenBounds.Width - window.Width) / 2),
                nextScreenBounds.Y + ((nextScreenBounds.Height - window.Height) / 2),
                window.Width,
                window.Height);
        }

        public Rectangle PreviousScreen(Rectangle window)
        {
            var previousScreenBounds = GetPreviousScreen().WorkingArea;
            return new Rectangle(
                previousScreenBounds.X + ((previousScreenBounds.Width - window.Width) / 2),
                previousScreenBounds.Y + ((previousScreenBounds.Height - window.Height) / 2),
                window.Width,
                window.Height);
        }

        private Screen GetNextScreen()
        {
            var nextScreenIndex = 0;
            for (var i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (!Screen.AllScreens[i].Equals(_ActiveScreen)) 
                    continue;

                nextScreenIndex = i + 1;
                if (nextScreenIndex + 1 > Screen.AllScreens.Length)
                {
                    nextScreenIndex = 0;
                }
            }

            return Screen.AllScreens[nextScreenIndex];
        }

        private Screen GetPreviousScreen()
        {
            var previousScreenIndex = 0;
            for (var i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (!Screen.AllScreens[i].Equals(_ActiveScreen)) 
                    continue;

                previousScreenIndex = i - 1;
                if (previousScreenIndex < 0)
                {
                    previousScreenIndex = Screen.AllScreens.Length - 1;
                }
            }

            return Screen.AllScreens[previousScreenIndex];
        }

        #endregion Multiple screens
    }
}