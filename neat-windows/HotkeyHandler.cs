using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace NeatWindows
{
    class HotkeyHandler
    {
        private Form form;
        private Dictionary<WindowSizePosition, Hotkey> hotkeyMap;
        private WindowResizer windowResizer;
        private KeymapManager keymapManager;

        public HotkeyHandler(Form form)
        {
            this.form = form;
            this.windowResizer = new WindowResizer();
            this.keymapManager = new KeymapManager();

            this.hotkeyMap = keymapManager.GetSavedHotkeys();
            this.RegisterHotkeys();
        }

        public void MapHotkey(WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            this.hotkeyMap[windowSizePosition] = hotkey;
            this.SaveHotkeys();
        }

        public void UnmapHotkey(WindowSizePosition windowSizePosition)
        {
            if (this.hotkeyMap.ContainsKey(windowSizePosition))
            {
                this.hotkeyMap[windowSizePosition].Unregister();
                this.hotkeyMap.Remove(windowSizePosition);
            }
        }

        private void SaveHotkeys()
        {
            this.keymapManager.SaveHotkeyMap(this.hotkeyMap);
        }

        public void UnregisterHotkeys()
        {
            foreach (KeyValuePair<WindowSizePosition, Hotkey> hotkeyMapping in this.hotkeyMap)
            {
                hotkeyMapping.Value.RemoveHandler();
                hotkeyMapping.Value.Unregister();
            }
        }

        public void RegisterHotkeys()
        {
            foreach (KeyValuePair<WindowSizePosition, Hotkey> hotkeyMapping in this.hotkeyMap)
            {
                hotkeyMapping.Value.SetHandler(this.windowResizer.ResizeTo, hotkeyMapping.Key);
                hotkeyMapping.Value.Register(this.form);
            }
        }

        public bool HotkeyExists(WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            foreach (KeyValuePair<WindowSizePosition, Hotkey> mappedHotkeys in this.hotkeyMap)
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

        public Dictionary<WindowSizePosition, Hotkey> GetHotkeyMap()
        {
            return this.hotkeyMap;
        }

    }
}
