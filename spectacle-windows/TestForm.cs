using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace spectacle_windows
{
    public partial class TestForm : Form
    {

        [DllImport("user32.dll", SetLastError=true)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int xPosition, int yPosition, int width, int height, uint uFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetActiveWindow();

        private const uint SHOWWINDOW = 0x0040;

        public TestForm() 
        { 
            InitializeComponent();
            Hotkey hotkey = new Hotkey();
            hotkey.KeyCode = Keys.H;
            hotkey.Shift = true;
            hotkey.Control = true;
            hotkey.Pressed += delegate { this.ResizeWindow(); };
            hotkey.Register(this);
        }

        private void ResizeWindow()
        {
            IntPtr activeWindowHandle = GetActiveWindow();
            WindowSizePosition windowSizeHandler = new WindowSizePosition(activeWindowHandle);
            Rectangle newWindowSize = windowSizeHandler.BottomRightQuarter();
            SetWindowPos(activeWindowHandle, 
                            WindowConstants.HWND.TOP,
                            newWindowSize.X, 
                            newWindowSize.Y, 
                            newWindowSize.Width, 
                            newWindowSize.Height, 
                            WindowConstants.SWP.SHOWWINDOW);
        }

    }
}
