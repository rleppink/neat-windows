using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace neat_windows
{
    class HotkeyHandler
    {
        private Form form;
        private Dictionary<WindowConstants.WindowSizePosition, Hotkey> hotkeys;
        private WindowResizer windowResizer;
        private ConfigurationManager configurationManager;

        public HotkeyHandler(Form form)
        {
            this.form = form;
            this.windowResizer = new WindowResizer();
            this.configurationManager = new ConfigurationManager();

            this.hotkeys = configurationManager.GetSavedHotkeys();
        }

        public void MapHotkey(Form form, WindowConstants.WindowSizePosition windowSizePosition, Keys keyCode, bool shift, bool control, bool alt, bool windows)
        {
            Hotkey newHotkey = new Hotkey(keyCode, shift, control, alt, windows);
            this.MapHotkey(form, windowSizePosition, newHotkey);
        }

        public void MapHotkey(Form form, WindowConstants.WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            if (this.hotkeys.ContainsKey(windowSizePosition))
            {
                Hotkey currentHotkey = this.hotkeys[windowSizePosition];
                if (currentHotkey.Registered) currentHotkey.Unregister();
            }

            hotkey.Pressed += delegate { this.windowResizer.ResizeTo(windowSizePosition); };
            if (!hotkey.Registered) hotkey.Register(form);

            this.hotkeys[windowSizePosition] = hotkey;
            this.SaveHotkeys();
        }

        private void SaveHotkeys()
        {
            this.configurationManager.SaveHotkeys(this.hotkeys);
        }

    }
}
