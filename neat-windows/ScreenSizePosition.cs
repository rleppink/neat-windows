namespace NeatWindows
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    internal class ScreenSizePosition
    {
        private int border = 0;
        private Screen activeScreen;

        public ScreenSizePosition(IntPtr activeWindow)
        {
            this.activeScreen = Screen.FromHandle(activeWindow);
            this.border = Properties.Settings.Default.WindowBorder;
        }

        private Rectangle ActiveScreenSize
        {
            get { return this.activeScreen.WorkingArea; }
        }

        #region Sizes

        private int FullScreenHeight
        {
            get { return this.ActiveScreenSize.Height - (this.border * 2); }
        }

        private int FullScreenWidth
        {
            get { return this.ActiveScreenSize.Width - (this.border * 2); }
        }

        private int HalfScreenHeight
        {
            get { return (this.ActiveScreenSize.Height / 2) - (this.border + (this.border / 2)); }
        }

        private int HalfScreenWidth
        {
            get { return (this.ActiveScreenSize.Width / 2) - (this.border + (this.border / 2)); }
        }

        private int ThirdScreenHeight
        {
            get { return this.ActiveScreenSize.Height / 3; }
        }

        private int ThirdScreenWidth
        {
            get { return this.ActiveScreenSize.Width / 3; }
        }

        private int TwoThirdsScreenHeight
        {
            get { return this.ThirdScreenHeight * 2; }
        }

        private int TwoThirdsScreenWidth
        {
            get { return this.ThirdScreenWidth * 2; }
        }

        #endregion Sizes

        #region Positions

        private int LeftX
        {
            get { return this.ActiveScreenSize.X + this.border; }
        }

        private int MidX
        {
            get { return this.ActiveScreenSize.X + (this.ActiveScreenSize.Width / 2) + (this.border / 2); }
        }

        private int MidY
        {
            get { return this.ActiveScreenSize.Y + (this.ActiveScreenSize.Height / 2) + (this.border / 2); }
        }

        private int ThirdX
        {
            get { return this.ActiveScreenSize.X + this.ThirdScreenWidth; }
        }

        private int ThirdY
        {
            get { return this.ActiveScreenSize.Y + this.ThirdScreenHeight; }
        }

        private int TopY
        {
            get { return this.ActiveScreenSize.Y + this.border; }
        }

        private int TwoThirdsX
        {
            get { return this.ActiveScreenSize.X + (this.ThirdScreenWidth * 2); }
        }

        private int TwoThirdsY
        {
            get { return this.ActiveScreenSize.Y + (this.ThirdScreenHeight * 2); }
        }

        #endregion Positions

        #region Fullscreen, centered

        public Rectangle Center(Rectangle window)
        {
            return new Rectangle(
                this.ActiveScreenSize.X + ((this.ActiveScreenSize.Width - window.Width) / 2),
                this.ActiveScreenSize.Y + ((this.ActiveScreenSize.Height - window.Height) / 2),
                window.Width,
                window.Height);
        }

        public Rectangle FullScreen()
        {
            return new Rectangle(
                this.LeftX,
                this.TopY,
                this.FullScreenWidth,
                this.FullScreenHeight);
        }

        public Rectangle QuarterCenter()
        {
            return new Rectangle(
                this.ActiveScreenSize.X + ((this.ActiveScreenSize.Width - this.HalfScreenWidth) / 2),
                this.ActiveScreenSize.Y + ((this.ActiveScreenSize.Height - this.HalfScreenHeight) / 2),
                this.HalfScreenWidth,
                this.HalfScreenHeight);
        }

        public Rectangle ThirdCenter()
        {
            return new Rectangle(
                this.ActiveScreenSize.X + ((this.ActiveScreenSize.Width - this.ThirdScreenWidth) / 2),
                this.ActiveScreenSize.Y + ((this.ActiveScreenSize.Height - this.ThirdScreenHeight) / 2),
                this.ThirdScreenWidth,
                this.ThirdScreenHeight);
        }

        public Rectangle TwoThirdsCenter()
        {
            return new Rectangle(
                this.ActiveScreenSize.X + ((this.ActiveScreenSize.Width - this.TwoThirdsScreenWidth) / 2),
                this.ActiveScreenSize.Y + ((this.ActiveScreenSize.Height - this.TwoThirdsScreenHeight) / 2),
                this.TwoThirdsScreenWidth,
                this.TwoThirdsScreenHeight);
        }

        #endregion Fullscreen, centered

        #region Half sizes

        public Rectangle HalfHeightBottom()
        {
            return new Rectangle(
                this.LeftX,
                this.MidY,
                this.FullScreenWidth,
                this.HalfScreenHeight);
        }

        public Rectangle HalfHeightTop()
        {
            return new Rectangle(
                this.LeftX,
                this.TopY,
                this.FullScreenWidth,
                this.HalfScreenHeight);
        }

        public Rectangle HalfWidthLeft()
        {
            return new Rectangle(
                this.LeftX,
                this.TopY,
                this.HalfScreenWidth,
                this.FullScreenHeight);
        }

        public Rectangle HalfWidthRight()
        {
            return new Rectangle(
                this.MidX,
                this.TopY,
                this.HalfScreenWidth,
                this.FullScreenHeight);
        }

        #endregion Half sizes

        #region Third sizes

        public Rectangle ThirdHeightBottom()
        {
            return new Rectangle(
                this.LeftX,
                this.TwoThirdsY,
                this.FullScreenWidth,
                this.ThirdScreenHeight);
        }

        public Rectangle ThirdHeightTop()
        {
            return new Rectangle(
                this.LeftX,
                this.TopY,
                this.FullScreenWidth,
                this.ThirdScreenHeight);
        }

        public Rectangle ThirdWidthLeft()
        {
            return new Rectangle(
                this.LeftX,
                this.TopY,
                this.ThirdScreenWidth,
                this.FullScreenHeight);
        }

        public Rectangle ThirdWidthRight()
        {
            return new Rectangle(
                this.TwoThirdsX,
                this.TopY,
                this.ThirdScreenWidth,
                this.FullScreenHeight);
        }

        public Rectangle TwoThirdsHeightBottom()
        {
            return new Rectangle(
                this.LeftX,
                this.ThirdY,
                this.FullScreenWidth,
                this.TwoThirdsScreenHeight);
        }

        public Rectangle TwoThirdsHeightTop()
        {
            return new Rectangle(
                this.LeftX,
                this.TopY,
                this.FullScreenWidth,
                this.TwoThirdsScreenHeight);
        }

        public Rectangle TwoThirdsWidthLeft()
        {
            return new Rectangle(
                this.LeftX,
                this.TopY,
                this.TwoThirdsScreenWidth,
                this.FullScreenHeight);
        }

        public Rectangle TwoThirdsWidthRight()
        {
            return new Rectangle(
                this.ThirdX,
                this.TopY,
                this.TwoThirdsScreenWidth,
                this.FullScreenHeight);
        }

        #endregion Third sizes

        #region Quarter sizes

        public Rectangle BottomLeftQuarter()
        {
            return new Rectangle(
                this.LeftX,
                this.MidY,
                this.HalfScreenWidth,
                this.HalfScreenHeight);
        }

        public Rectangle BottomRightQuarter()
        {
            return new Rectangle(
                this.MidX,
                this.MidY,
                this.HalfScreenWidth,
                this.HalfScreenHeight);
        }

        public Rectangle TopLeftQuarter()
        {
            return new Rectangle(
                this.LeftX,
                this.TopY,
                this.HalfScreenWidth,
                this.HalfScreenHeight);
        }

        public Rectangle TopRightQuarter()
        {
            return new Rectangle(
                this.MidX,
                this.TopY,
                this.HalfScreenWidth,
                this.HalfScreenHeight);
        }

        #endregion Quarter sizes

        #region Multiple screens

        public Rectangle NextScreen(Rectangle window)
        {
            Rectangle nextScreenBounds = this.GetNextScreen().WorkingArea;
            return new Rectangle(
                nextScreenBounds.X + ((nextScreenBounds.Width - window.Width) / 2),
                nextScreenBounds.Y + ((nextScreenBounds.Height - window.Height) / 2),
                window.Width,
                window.Height);
        }

        public Rectangle PreviousScreen(Rectangle window)
        {
            Rectangle previousScreenBounds = this.GetPreviousScreen().WorkingArea;
            return new Rectangle(
                previousScreenBounds.X + ((previousScreenBounds.Width - window.Width) / 2),
                previousScreenBounds.Y + ((previousScreenBounds.Height - window.Height) / 2),
                window.Width,
                window.Height);
        }

        private Screen GetNextScreen()
        {
            int nextScreenIndex = 0;
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (Screen.AllScreens[i].Equals(this.activeScreen))
                {
                    nextScreenIndex = i + 1;
                    if (nextScreenIndex + 1 > Screen.AllScreens.Length)
                    {
                        nextScreenIndex = 0;
                    }
                }
            }

            return Screen.AllScreens[nextScreenIndex];
        }

        private Screen GetPreviousScreen()
        {
            int previousScreenIndex = 0;
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (Screen.AllScreens[i].Equals(this.activeScreen))
                {
                    previousScreenIndex = i - 1;
                    if (previousScreenIndex < 0)
                    {
                        previousScreenIndex = Screen.AllScreens.Length - 1;
                    }
                }
            }

            return Screen.AllScreens[previousScreenIndex];
        }

        #endregion Multiple screens
    }
}