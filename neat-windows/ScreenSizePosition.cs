using System;
using System.Drawing;
using System.Windows.Forms;

namespace NeatWindows
{
    class ScreenSizePosition
    {
        private Screen activeScreen;


        public ScreenSizePosition(IntPtr activeWindow)
        {
            this.activeScreen = Screen.FromHandle(activeWindow);
        }

        private Rectangle ActiveScreenSize()
        {
            return this.activeScreen.WorkingArea;
        }

        #region Fullscreen, centered
        public Rectangle FullScreen()
        {
            return this.ActiveScreenSize();
        }

        public Rectangle TwoThirdsCenter()
        {
            return new Rectangle(
                this.ActiveScreenSize().X + (this.ActiveScreenSize().Width - this.TwoThirdsScreenWidth()) / 2,
                this.ActiveScreenSize().Y + (this.ActiveScreenSize().Height - this.TwoThirdsScreenHeight()) / 2,
                this.TwoThirdsScreenWidth(),
                this.TwoThirdsScreenHeight());
        }

        public Rectangle QuarterCenter()
        {
            return new Rectangle(
                this.ActiveScreenSize().X + (this.ActiveScreenSize().Width - this.HalfScreenWidth()) / 2,
                this.ActiveScreenSize().Y + (this.ActiveScreenSize().Height - this.HalfScreenHeight()) / 2,
                this.HalfScreenWidth(),
                this.HalfScreenHeight());
        }

        public Rectangle ThirdCenter()
        {
            return new Rectangle(
                this.ActiveScreenSize().X + (this.ActiveScreenSize().Width - this.ThirdScreenWidth()) / 2,
                this.ActiveScreenSize().Y + (this.ActiveScreenSize().Height - this.ThirdScreenHeight()) / 2,
                this.ThirdScreenWidth(),
                this.ThirdScreenHeight());
        }

        public Rectangle Center(Rectangle window)
        {
            return new Rectangle(
                this.ActiveScreenSize().X + (this.ActiveScreenSize().Width - window.Width) / 2,
                this.ActiveScreenSize().Y + (this.ActiveScreenSize().Height - window.Height) / 2,
                window.Width,
                window.Height);
        }

        #endregion Fullscreen, centered

        #region Half sizes
        public Rectangle HalfWidthLeft()
        {
            return new Rectangle (
                this.LeftX(),
                this.TopY(),
                this.HalfScreenWidth(),
                this.FullScreenHeight());
        }

        public Rectangle HalfWidthRight()
        {
            return new Rectangle (
                this.MidX(),
                this.TopY(),
                this.HalfScreenWidth(),
                this.FullScreenHeight());
        }

        public Rectangle HalfHeightTop()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.FullScreenWidth(),
                this.HalfScreenHeight());
        }

        public Rectangle HalfHeightBottom()
        {
            return new Rectangle(
                this.LeftX(),
                this.MidY(),
                this.FullScreenWidth(),
                this.HalfScreenHeight());
        }
        #endregion Half sizes

        #region Third sizes
        public Rectangle ThirdWidthLeft()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.ThirdScreenWidth(),
                this.FullScreenHeight());
        }

        public Rectangle TwoThirdsWidthLeft()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.TwoThirdsScreenWidth(),
                this.FullScreenHeight());
        }

        public Rectangle ThirdWidthRight()
        {
            return new Rectangle(
                this.TwoThirdsX(),
                this.TopY(),
                this.ThirdScreenWidth(),
                this.FullScreenHeight());
        }

        public Rectangle TwoThirdsWidthRight()
        {
            return new Rectangle(
                this.ThirdX(),
                this.TopY(),
                this.TwoThirdsScreenWidth(),
                this.FullScreenHeight());
        }

        public Rectangle ThirdHeightTop()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.FullScreenWidth(),
                this.ThirdScreenHeight());
        }

        public Rectangle TwoThirdsHeightTop()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.FullScreenWidth(),
                this.TwoThirdsScreenHeight());
        }

        public Rectangle ThirdHeightBottom()
        {
            return new Rectangle(
                this.LeftX(),
                this.TwoThirdsY(),
                this.FullScreenWidth(),
                this.ThirdScreenHeight());
        }

        public Rectangle TwoThirdsHeightBottom()
        {
            return new Rectangle(
                this.LeftX(),
                this.ThirdY(),
                this.FullScreenWidth(),
                this.TwoThirdsScreenHeight());
        }
        #endregion Third sizes

        #region Quarter sizes
        public Rectangle TopLeftQuarter()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.HalfScreenWidth(),
                this.HalfScreenHeight());
        }

        public Rectangle TopRightQuarter()
        {
            return new Rectangle(
                this.MidX(),
                this.TopY(),
                this.HalfScreenWidth(),
                this.HalfScreenHeight());
        }

        public Rectangle BottomLeftQuarter()
        {
            return new Rectangle(
                this.LeftX(),
                this.MidY(),
                this.HalfScreenWidth(),
                this.HalfScreenHeight());
        }

        public Rectangle BottomRightQuarter()
        {
            return new Rectangle(
                this.MidX(),
                this.MidY(),
                this.HalfScreenWidth(),
                this.HalfScreenHeight());
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
                previousScreenBounds.X + (previousScreenBounds.Width - window.Width) / 2,
                previousScreenBounds.Y + (previousScreenBounds.Height - window.Height) / 2,
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
                        nextScreenIndex = 0;
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
                        previousScreenIndex = Screen.AllScreens.Length - 1;
                }
            }
            return Screen.AllScreens[previousScreenIndex];
        }
        #endregion Multiple screens

        #region Sizes
        private int FullScreenWidth() { return this.ActiveScreenSize().Width; }
        private int FullScreenHeight() { return this.ActiveScreenSize().Height; }

        private int HalfScreenWidth() { return this.ActiveScreenSize().Width / 2; }
        private int HalfScreenHeight() { return this.ActiveScreenSize().Height / 2; }

        private int ThirdScreenWidth() { return this.ActiveScreenSize().Width / 3; }
        private int ThirdScreenHeight() { return this.ActiveScreenSize().Height / 3; }

        private int TwoThirdsScreenWidth() { return this.ThirdScreenWidth() * 2; }
        private int TwoThirdsScreenHeight() { return this.ThirdScreenHeight() * 2; }
        #endregion Sizes

        #region Positions
        private int LeftX() { return this.ActiveScreenSize().X; }
        private int MidX() { return this.ActiveScreenSize().X + this.HalfScreenWidth(); }
        private int ThirdX() { return this.ActiveScreenSize().X + this.ThirdScreenWidth(); }
        private int TwoThirdsX() { return this.ActiveScreenSize().X + (this.ThirdScreenWidth() * 2); }

        private int TopY() { return this.ActiveScreenSize().Y; }
        private int MidY() { return this.ActiveScreenSize().Y + this.HalfScreenHeight(); }
        private int ThirdY() { return this.ActiveScreenSize().Y + this.ThirdScreenHeight(); }
        private int TwoThirdsY() { return this.ActiveScreenSize().Y + (this.ThirdScreenHeight() * 2); }
        #endregion Positions

    }
}
