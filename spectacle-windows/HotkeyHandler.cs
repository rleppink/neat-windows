using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spectacle_windows
{
    class HotkeyHandler
    {

        private Hotkey hotkeyFullScreen;
        private Hotkey hotkeyCenter;

        private Hotkey hotkeyLeftHalf;
        private Hotkey hotkeyRightHalf;
        private Hotkey hotkeyTopHalf;
        private Hotkey hotkeyBottomHalf;

        private Hotkey hotkeyTopLeft;
        private Hotkey hotkeyTopRight;
        private Hotkey hotkeyBottomLeft;
        private Hotkey hotkeyBottomRight;

        public HotkeyHandler()
        {
            // TODO: These hotkeys should be read from a config file/db
            this.InitializeDefaultHotkeys();
            this.MapHotkeys(); // Assumes hotkeys have been inited
        }

        public void InitializeDefaultHotkeys() 
        {
            this.hotkeyFullScreen = new Hotkey(Keys.F, true, true, false, false);
            this.hotkeyCenter = new Hotkey(Keys.C, true, true, false, false);

            this.hotkeyLeftHalf = new Hotkey(Keys.H, true, true, false, false);
            this.hotkeyRightHalf = new Hotkey(Keys.L, true, true, false, false);
            this.hotkeyTopHalf = new Hotkey(Keys.K, true, true, false, false);
            this.hotkeyBottomHalf = new Hotkey(Keys.J, true, true, false, false);

            this.hotkeyTopLeft = new Hotkey(Keys.U, true, true, false, false);
            this.hotkeyTopRight = new Hotkey(Keys.P, true, true, false, false);
            this.hotkeyBottomLeft = new Hotkey(Keys.M, true, true, false, false);
            this.hotkeyBottomRight = new Hotkey(Keys.OemQuestion, true, true, false, false);
        }

        public void MapHotkeys()
        {
            WindowResizer windowResizer = new WindowResizer();

            this.hotkeyFullScreen.Pressed +=
                delegate { windowResizer.ResizeTo(WindowResizer.WindowSizePosition.FULLSCREEN); };
            this.hotkeyCenter.Pressed +=
                delegate { windowResizer.ResizeTo(WindowResizer.WindowSizePosition.CENTER); };

            this.hotkeyLeftHalf.Pressed +=
                delegate { windowResizer.ResizeTo(WindowResizer.WindowSizePosition.LEFT_HALF); };
            this.hotkeyRightHalf.Pressed +=
                delegate { windowResizer.ResizeTo(WindowResizer.WindowSizePosition.RIGHT_HALF); };
            this.hotkeyTopHalf.Pressed +=
                delegate { windowResizer.ResizeTo(WindowResizer.WindowSizePosition.TOP_HALF); };
            this.hotkeyBottomHalf.Pressed +=
                delegate { windowResizer.ResizeTo(WindowResizer.WindowSizePosition.BOTTOM_HALF); };

            this.hotkeyTopLeft.Pressed +=
                delegate { windowResizer.ResizeTo(WindowResizer.WindowSizePosition.TOP_LEFT); };
            this.hotkeyTopRight.Pressed +=
                delegate { windowResizer.ResizeTo(WindowResizer.WindowSizePosition.TOP_RIGHT); };
            this.hotkeyBottomLeft.Pressed +=
                delegate { windowResizer.ResizeTo(WindowResizer.WindowSizePosition.BOTTOM_LEFT); };
            this.hotkeyBottomRight.Pressed +=
                delegate { windowResizer.ResizeTo(WindowResizer.WindowSizePosition.BOTTOM_RIGHT); };
        }

        public void RegisterHotkeys(Form form)
        {
            this.hotkeyFullScreen.Register(form);
            this.hotkeyCenter.Register(form);

            this.hotkeyLeftHalf.Register(form);
            this.hotkeyRightHalf.Register(form);
            this.hotkeyTopHalf.Register(form);
            this.hotkeyBottomHalf.Register(form);

            this.hotkeyTopLeft.Register(form);
            this.hotkeyTopRight.Register(form);
            this.hotkeyBottomLeft.Register(form);
            this.hotkeyBottomRight.Register(form);
        }
    }
}
