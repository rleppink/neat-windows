namespace NeatWindows
{
    using System;
    using System.Globalization;

    public enum WindowSizePosition
    {
        FullScreen,
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

    public struct Rect
    {
        private int bottom;
        private int left;
        private int right;
        private int top;

        public int Bottom
        {
            get { return this.bottom; }
            set { this.bottom = value; }
        }

        public int Left
        {
            get { return this.left; }
            set { this.left = value; }
        }

        public int Right
        {
            get { return this.right; }
            set { this.right = value; }
        }

        public int Top
        {
            get { return this.top; }
            set { this.top = value; }
        }

        public static bool operator !=(Rect rectA, Rect rectB)
        {
            return !(rectA == rectB);
        }

        public static bool operator ==(Rect rectA, Rect rectB)
        {
            if (object.ReferenceEquals(rectA, rectB))
            {
                return true;
            }

            if (((object)rectA == null) || ((object)rectB == null))
            {
                return false;
            }

            return (rectA.Left == rectB.Left) && (rectA.Top == rectB.Top) && (rectA.Right == rectB.Right) && (rectA.Bottom == rectB.Bottom);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Rect rectObj;
            try
            {
                rectObj = (Rect)obj;
            }
            catch (InvalidCastException)
            {
                return false;
            }

            return (rectObj.Left == this.Left) && (rectObj.Top == this.Top) && (rectObj.Right == this.Right) && (rectObj.Bottom == this.Bottom);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                // http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
                // http://stackoverflow.com/questions/1835976/what-is-a-sensible-prime-for-hashcode-calculation/2816747#2816747
                int prime = 92821;
                int hash = (int)2166136261;
                hash = hash * prime ^ this.Left;
                hash = hash * prime ^ this.Top;
                hash = hash * prime ^ this.Right;
                hash = hash * prime ^ this.Bottom;
                return hash;
            }
        }

        public override string ToString()
        {
            string[] values = new string[]
            {
                    this.Left.ToString(CultureInfo.CurrentCulture),
                    this.Top.ToString(CultureInfo.CurrentCulture),
                    this.Right.ToString(CultureInfo.CurrentCulture),
                    this.Bottom.ToString(CultureInfo.CurrentCulture)
            };
            return "Rect: (" + string.Join(", ", values) + ")";
        }
    }

    public static class SetWindowPos
    {
        public static readonly uint
        NoSize = 0x0001,
        NoMove = 0x0002,
        NoZOrder = 0x0004,
        NoRedraw = 0x0008,
        NoActivate = 0x0010,
        DrawFrame = 0x0020,
        FrameChanged = 0x0020,
        ShowWindow = 0x0040,
        HideWindow = 0x0080,
        NoCopyBits = 0x0100,
        NoOwnerZOrder = 0x0200,
        NoReposition = 0x0200,
        NoSendChanging = 0x0400,
        DeferErase = 0x2000,
        AsyncWindowPos = 0x4000;
    }

    public static class WindowHandles
    {
        public static readonly IntPtr
        NoTopmost = new IntPtr(-2),
        Topmost = new IntPtr(-1),
        Top = new IntPtr(0),
        Bottom = new IntPtr(1);
    }
}