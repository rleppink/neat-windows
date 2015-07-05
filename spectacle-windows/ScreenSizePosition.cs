using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public Rectangle FullScreen()
        {
            return this.activeScreenSize;
        }

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
                this.ThirdScreenWidth() * 2,
                this.FullScreenHeight()
                );
        }

        public Rectangle ThirdWidthRight()
        {
            return new Rectangle(
                this.ThirdX() * 2,
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
                this.ThirdScreenWidth() * 2,
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
                this.ThirdScreenHeight() * 2
                );
        }

        public Rectangle ThirdHeightBottom()
        {
            return new Rectangle(
                this.LeftX(),
                this.ThirdY() * 2,
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
                this.ThirdScreenHeight() * 2
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
        #endregion

        #region Positions
        private int LeftX() { return this.activeScreenSize.X; }
        private int MidX() { return this.activeScreenSize.X + this.HalfScreenWidth(); }
        private int ThirdX() { return this.activeScreenSize.X + this.ThirdScreenWidth(); }

        private int TopY() { return this.activeScreenSize.Y; }
        private int MidY() { return this.activeScreenSize.Y + this.HalfScreenHeight(); }
        private int ThirdY() { return this.activeScreenSize.Y + this.ThirdScreenHeight(); }
        #endregion

    }
}
