using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace neat_windows
{
    class HotkeyHandler
    {
        private Form form;
        private Dictionary<WindowConstants.WindowSizePosition, Hotkey> hotkeyMap;
        private WindowResizer windowResizer;
        private ConfigurationManager configurationManager;

        public HotkeyHandler(Form form)
        {
            this.form = form;
            this.windowResizer = new WindowResizer();
            this.configurationManager = new ConfigurationManager();

            this.hotkeyMap = configurationManager.GetSavedHotkeys();
            this.RegisterHotkeys();
        }

        public void MapHotkey(WindowConstants.WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            if (this.hotkeyMap.ContainsKey(windowSizePosition))
            {
                Hotkey currentHotkey = this.hotkeyMap[windowSizePosition];
                if (currentHotkey.Registered) currentHotkey.Unregister();
            }

            hotkey.Pressed -= delegate { this.windowResizer.ResizeTo(windowSizePosition); };
            hotkey.Pressed += delegate { this.windowResizer.ResizeTo(windowSizePosition); };
            if (!hotkey.Registered) hotkey.Register(this.form);

            this.hotkeyMap[windowSizePosition] = hotkey;
            this.SaveHotkeys();
        }

        public void UnmapHotkey(WindowConstants.WindowSizePosition windowSizePosition)
        {
            try
            {
                this.UnregisterHotkey(hotkeyMap[windowSizePosition]);
                this.hotkeyMap.Remove(windowSizePosition);
            }
            catch (Exception e)
            {
                // Already unmapped, no need to do anything
            }
        }

        private void SaveHotkeys()
        {
            this.configurationManager.SaveHotkeys(this.hotkeyMap);
        }

        public void UnregisterHotkeys()
        {
            foreach (KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> hotkeyMapping in this.hotkeyMap)
            {
                this.UnregisterHotkey(hotkeyMapping.Value);
            }
            
        }

        private void UnregisterHotkey(Hotkey hotkey)
        {
            if (hotkey.Registered)
                hotkey.Unregister();
        }

        public void RegisterHotkeys()
        {
            foreach (KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> hotkeyMapping in this.hotkeyMap)
            {
                hotkeyMapping.Value.Pressed -= delegate { this.windowResizer.ResizeTo(hotkeyMapping.Key); };
                hotkeyMapping.Value.Pressed += delegate { this.windowResizer.ResizeTo(hotkeyMapping.Key); };
                this.RegisterHotkey(hotkeyMapping.Value);
            }
        }

        private void RegisterHotkey(Hotkey hotkey)
        {
            if (!hotkey.Registered)
                hotkey.Register(this.form);
        }

        public bool HotkeyExists(WindowConstants.WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            foreach (KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> mappedHotkeys in this.hotkeyMap)
            {
                Hotkey mappedHotkey = mappedHotkeys.Value;
                if (mappedHotkeys.Key != windowSizePosition &&
                    mappedHotkey.KeyCode == hotkey.KeyCode &&
                    mappedHotkey.Control == hotkey.Control &&
                    mappedHotkey.Alt == hotkey.Alt &&
                    mappedHotkey.Shift == hotkey.Shift)
                    return true;
            }
            return false;
        }

        public Dictionary<WindowConstants.WindowSizePosition, Hotkey> GetHotkeyMap()
        {
            return this.hotkeyMap;
        }

    }
}
