using System;
using System.Drawing;
using System.Windows.Forms;

namespace spectacle_windows
{
    class ScreenSizePosition
    {
        private Rectangle activeScreenSize;


        public ScreenSizePosition(IntPtr activeWindow)
        {
            this.activeScreenSize = Screen.FromHandle(activeWindow).Bounds;
        }

        #region Fullscreen, centered
        public Rectangle FullScreen()
        {
            return this.activeScreenSize;
        }

        public Rectangle TwoThirdsCenter()
        {
            return new Rectangle(
                (this.activeScreenSize.Width - this.TwoThirdsScreenWidth()) / 2,
                (this.activeScreenSize.Height - this.TwoThirdsScreenHeight()) / 2,
                this.TwoThirdsScreenWidth(),
                this.TwoThirdsScreenHeight()
                );
        }

        public Rectangle QuarterCenter()
        {
            return new Rectangle(
                (this.activeScreenSize.Width - this.HalfScreenWidth()) / 2,
                (this.activeScreenSize.Height - this.HalfScreenHeight()) / 2,
                this.HalfScreenWidth(),
                this.HalfScreenHeight()
                );
        }

        public Rectangle ThirdCenter()
        {
            return new Rectangle(
                (this.activeScreenSize.Width - this.ThirdScreenWidth()) / 2,
                (this.activeScreenSize.Height - this.ThirdScreenHeight()) / 2,
                this.ThirdScreenWidth(),
                this.ThirdScreenHeight()
                );
        }

        public Rectangle Center(Rectangle window)
        {
            return new Rectangle(
                (this.activeScreenSize.Width - window.Width) / 2,
                (this.activeScreenSize.Height - window.Height) / 2,
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
                this.FullScreenHeight()
                );
        }

        public Rectangle HalfWidthRight()
        {
            return new Rectangle (
                this.MidX(),
                this.TopY(),
                this.HalfScreenWidth(),
                this.FullScreenHeight()
                );
        }

        public Rectangle HalfHeightTop()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.FullScreenWidth(),
                this.HalfScreenHeight()
                );
        }

        public Rectangle HalfHeightBottom()
        {
            return new Rectangle(
                this.LeftX(),
                this.MidY(),
                this.FullScreenWidth(),
                this.HalfScreenHeight()
                );
        }
        #endregion Half sizes

        #region Third sizes
        public Rectangle ThirdWidthLeft()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.ThirdScreenWidth(),
                this.FullScreenHeight()
                );
        }

        public Rectangle TwoThirdsWidthLeft()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.TwoThirdsScreenWidth(),
                this.FullScreenHeight()
                );
        }

        public Rectangle ThirdWidthRight()
        {
            return new Rectangle(
                this.TwoThirdsX(),
                this.TopY(),
                this.ThirdScreenWidth(),
                this.FullScreenHeight()
                );
        }

        public Rectangle TwoThirdsWidthRight()
        {
            return new Rectangle(
                this.ThirdX(),
                this.TopY(),
                this.TwoThirdsScreenWidth(),
                this.FullScreenHeight()
                );
        }

        public Rectangle ThirdHeightTop()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.FullScreenWidth(),
                this.ThirdScreenHeight()
                );
        }

        public Rectangle TwoThirdsHeightTop()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.FullScreenWidth(),
                this.TwoThirdsScreenHeight()
                );
        }

        public Rectangle ThirdHeightBottom()
        {
            return new Rectangle(
                this.LeftX(),
                this.TwoThirdsY(),
                this.FullScreenWidth(),
                this.ThirdScreenHeight()
                );
        }

        public Rectangle TwoThirdsHeightBottom()
        {
            return new Rectangle(
                this.LeftX(),
                this.ThirdY(),
                this.FullScreenWidth(),
                this.TwoThirdsScreenHeight()
                );
        }
        #endregion Third sizes

        #region Quarter sizes
        public Rectangle TopLeftQuarter()
        {
            return new Rectangle(
                this.LeftX(),
                this.TopY(),
                this.HalfScreenWidth(),
                this.HalfScreenHeight()
                );
        }

        public Rectangle TopRightQuarter()
        {
            return new Rectangle(
                this.MidX(),
                this.TopY(),
                this.HalfScreenWidth(),
                this.HalfScreenHeight()
                );
        }

        public Rectangle BottomLeftQuarter()
        {
            return new Rectangle(
                this.LeftX(),
                this.MidY(),
                this.HalfScreenWidth(),
                this.HalfScreenHeight()
                );
        }

        public Rectangle BottomRightQuarter()
        {
            return new Rectangle(
                this.MidX(),
                this.MidY(),
                this.HalfScreenWidth(),
                this.HalfScreenHeight()
                );
        }
        #endregion Quarter sizes

        #region Sizes
        private int FullScreenWidth() { return this.activeScreenSize.Width; }
        private int FullScreenHeight() { return this.activeScreenSize.Height; }

        private int HalfScreenWidth() { return this.activeScreenSize.Width / 2; }
        private int HalfScreenHeight() { return this.activeScreenSize.Height / 2; }

        private int ThirdScreenWidth() { return this.activeScreenSize.Width / 3;  }
        private int ThirdScreenHeight() { return this.activeScreenSize.Height / 3; }

        private int TwoThirdsScreenWidth() { return this.ThirdScreenWidth() * 2; }
        private int TwoThirdsScreenHeight() { return this.ThirdScreenHeight() * 2; }
        #endregion

        #region Positions
        private int LeftX() { return this.activeScreenSize.X; }
        private int MidX() { return this.activeScreenSize.X + this.HalfScreenWidth(); }
        private int ThirdX() { return this.activeScreenSize.X + this.ThirdScreenWidth(); }
        private int TwoThirdsX() { return this.activeScreenSize.X + (this.ThirdScreenWidth() * 2); }

        private int TopY() { return this.activeScreenSize.Y; }
        private int MidY() { return this.activeScreenSize.Y + this.HalfScreenHeight(); }
        private int ThirdY() { return this.activeScreenSize.Y + this.ThirdScreenHeight(); }
        private int TwoThirdsY() { return this.activeScreenSize.Y + (this.ThirdScreenHeight() * 2); }
        #endregion

    }
}
