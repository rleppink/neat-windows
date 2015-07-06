﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace spectacle_windows
{
    class HotkeyHandler
    {
        private Form form;
        private Dictionary<WindowResizer.WindowSizePosition, Hotkey> hotkeys;
        private WindowResizer windowResizer;


        public HotkeyHandler(Form form)
        {
            this.form = form;
            this.hotkeys = new Dictionary<WindowResizer.WindowSizePosition, Hotkey>();
            this.windowResizer = new WindowResizer();

            // TODO: loadsavedhotkeys() or somesort
        }

        public void MapHotkey(Form form, WindowResizer.WindowSizePosition windowSizePosition, Keys keyCode, bool shift, bool control, bool alt, bool windows)
        {
            Hotkey newHotkey = new Hotkey(keyCode, shift, control, alt, windows);
            this.MapHotkey(form, windowSizePosition, newHotkey);
        }

        public void MapHotkey(Form form, WindowResizer.WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            if (this.hotkeys.ContainsKey(windowSizePosition))
            {
                Hotkey currentHotkey = this.hotkeys[windowSizePosition];
                if (currentHotkey.Registered) currentHotkey.Unregister();
            }

            hotkey.Pressed += delegate { this.windowResizer.ResizeTo(windowSizePosition); };
            if (!hotkey.Registered) hotkey.Register(form);

            this.hotkeys[windowSizePosition] = hotkey;
        }

        public void InitializeDefaultHotkeys() 
        {
            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.FULLSCREEN, new Hotkey(Keys.F, true, true, false, false));
            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.CENTER, new Hotkey(Keys.C, true, true, false, false));

            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.NEXT_SCREEN, new Hotkey(Keys.O, true, true, false, false));
            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.PREVIOUS_SCREEN, new Hotkey(Keys.I, true, true, false, false));

            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.LEFT_HALF, new Hotkey(Keys.H, true, true, false, false));
            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.RIGHT_HALF, new Hotkey(Keys.L, true, true, false, false));
            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.TOP_HALF, new Hotkey(Keys.K, true, true, false, false));
            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.BOTTOM_HALF, new Hotkey(Keys.J, true, true, false, false));

            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.TOP_LEFT, new Hotkey(Keys.U, true, true, false, false));
            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.TOP_RIGHT, new Hotkey(Keys.P, true, true, false, false));
            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.BOTTOM_LEFT, new Hotkey(Keys.M, true, true, false, false));
            this.MapHotkey(this.form, WindowResizer.WindowSizePosition.BOTTOM_RIGHT, new Hotkey(Keys.OemQuestion, true, true, false, false));
        }


    }
}
