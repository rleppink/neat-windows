namespace NeatWindows
{
    using System;
    using System.Globalization;
    using System.Runtime.InteropServices;

    public struct Rect
    {
        public int Left { get; set; }

        public int Top { get; set; }

        public int Right { get; set; }

        public int Bottom { get; set; }

        public static bool operator !=(Rect rectA, Rect rectB)
        {
            return !(rectA == rectB);
        }

        public static bool operator ==(Rect rectA, Rect rectB)
        {
            if (Equals(rectA, rectB))
                return true;

            return (rectA.Left == rectB.Left) && (rectA.Top == rectB.Top) && (rectA.Right == rectB.Right) && (rectA.Bottom == rectB.Bottom);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Rect rectObj;
            try
            {
                rectObj = (Rect)obj;
            }
            catch (InvalidCastException)
            {
                return false;
            }

            return (rectObj.Left == Left) && (rectObj.Top == Top) && (rectObj.Right == Right) && (rectObj.Bottom == Bottom);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                // http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
                // http://stackoverflow.com/questions/1835976/what-is-a-sensible-prime-for-hashcode-calculation/2816747#2816747
                const int prime = 92821;
                var hash = (int)2166136261;
                hash = hash * prime ^ Left;
                hash = hash * prime ^ Top;
                hash = hash * prime ^ Right;
                hash = hash * prime ^ Bottom;
                return hash;
            }
        }

        public override string ToString()
        {
            string[] values = {
                    Left.ToString(CultureInfo.CurrentCulture),
                    Top.ToString(CultureInfo.CurrentCulture),
                    Right.ToString(CultureInfo.CurrentCulture),
                    Bottom.ToString(CultureInfo.CurrentCulture)
            };
            return "Rect: (" + string.Join(", ", values) + ")";
        }
    }

    internal static class NativeMethods
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, System.Windows.Forms.Keys vk);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int xPosition, int yPosition, int width, int height, uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int UnregisterHotKey(IntPtr hWnd, int id);
    }
}