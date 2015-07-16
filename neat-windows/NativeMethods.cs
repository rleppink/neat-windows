namespace NeatWindows
{
    using System;
    using System.Globalization;
    using System.Runtime.InteropServices;

    static class NativeMethods
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int xPosition, int yPosition, int width, int height, uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, System.Windows.Forms.Keys vk);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int UnregisterHotKey(IntPtr hWnd, int id);
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
}
