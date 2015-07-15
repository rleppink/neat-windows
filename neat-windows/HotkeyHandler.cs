using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace NeatWindows
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
            this.hotkeyMap[windowSizePosition] = hotkey;
            this.SaveHotkeys();
        }

        public void UnmapHotkey(WindowConstants.WindowSizePosition windowSizePosition)
        {
            if (this.hotkeyMap.ContainsKey(windowSizePosition))
            {
                this.hotkeyMap[windowSizePosition].Unregister();
                this.hotkeyMap.Remove(windowSizePosition);
            }
        }

        private void SaveHotkeys()
        {
            this.configurationManager.SaveHotkeyMap(this.hotkeyMap);
        }

        public void UnregisterHotkeys()
        {
            foreach (KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> hotkeyMapping in this.hotkeyMap)
            {
                hotkeyMapping.Value.RemoveHandler();
                hotkeyMapping.Value.Unregister();
            }
        }

        public void RegisterHotkeys()
        {
            foreach (KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> hotkeyMapping in this.hotkeyMap)
            {
                hotkeyMapping.Value.SetHandler(this.windowResizer.ResizeTo, hotkeyMapping.Key);
                hotkeyMapping.Value.Register(this.form);
            }
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
