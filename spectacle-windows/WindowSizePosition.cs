using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spectacle_windows
{
    class WindowSizePosition
    {

        private Rectangle activeScreenSize;


        public WindowSizePosition(IntPtr activeWindow)
        {
            this.activeScreenSize = Screen.FromHandle(activeWindow).Bounds;
        }

        public Rectangle FullScreenRect()
        {
            return this.activeScreenSize;
        }

        public Rectangle HalfScreenWidthLeft()
        {
            return new Rectangle (
                this.TopLeft().Item1,
                this.TopLeft().Item2,
                this.HalfScreenWidth(),
                this.FullScreenHeight()
                );
        }

        public Rectangle HalfScreenWidthRight()
        {
            return new Rectangle (
                this.TopMid().Item1,
                this.TopMid().Item2,
                this.FullScreenWidth(),
                this.HalfScreenHeight()
                );
        }

        public Rectangle TopLeftQuarter()
        {
            return new Rectangle(
                this.TopLeft().Item1,
                this.TopLeft().Item2,
                this.HalfScreenWidth(),
                this.HalfScreenHeight()
                );
        }

        public Rectangle TopRightQuarter()
        {
            return new Rectangle(
                this.TopMid().Item1,
                this.TopMid().Item2,
                this.HalfScreenWidth(),
                this.HalfScreenHeight()
                );
        }

        public Rectangle BottomLeftQuarter()
        {
            return new Rectangle(
                this.MidLeft().Item1,
                this.MidLeft().Item2,
                this.HalfScreenWidth(),
                this.HalfScreenHeight()
                );
        }

        public Rectangle BottomRightQuarter()
        {
            return new Rectangle(
                this.Mid().Item1,
                this.Mid().Item2,
                this.HalfScreenWidth(),
                this.HalfScreenHeight()
                );
        }

        #region Sizes
        private int FullScreenWidth() { return this.activeScreenSize.Width; }
        private int FullScreenHeight() { return this.activeScreenSize.Height; }

        private int HalfScreenWidth() { return this.activeScreenSize.Width / 2; }
        private int HalfScreenHeight() { return this.activeScreenSize.Height / 2; }

        private int ThirdScreenWidth() { return this.activeScreenSize.Width / 3;  }
        private int ThirdScreenHeight() { return this.activeScreenSize.Width / 3; }
        #endregion


        #region Positions
        private Tuple<int, int> TopLeft() 
        {
            int xPosition = this.activeScreenSize.X;
            int yPosition = this.activeScreenSize.Y;
            return new Tuple<int, int>(xPosition, yPosition);
        }

        private Tuple<int, int> MidLeft() 
        {
            int xPosition = this.activeScreenSize.X;
            int yPosition = this.HalfScreenHeight();
            return new Tuple<int, int>(xPosition, yPosition);
        }

        private Tuple<int, int> TopMid() 
        {
            int xPosition = this.HalfScreenWidth();
            int yPosition = this.activeScreenSize.Y;
            return new Tuple<int, int>(xPosition, yPosition);
        }

        private Tuple<int, int> Mid()
        {
            int xPosition = this.HalfScreenWidth();
            int yPosition = this.HalfScreenHeight();
            return new Tuple<int, int>(xPosition, yPosition);
        }
        #endregion

    }
}
