namespace NeatWindows
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    internal class HotkeyHandler
    {
        private Form form;
        private Dictionary<WindowSizePosition, Hotkey> hotkeyMap;
        private WindowResizer windowResizer;

        public HotkeyHandler(Form form)
        {
            this.form = form;
            this.windowResizer = new WindowResizer();
            this.hotkeyMap = KeyMapManager.GetSavedHotkeys();
            this.RegisterHotkeys();
        }

        public Dictionary<WindowSizePosition, Hotkey> GetHotkeyMap()
        {
            return this.hotkeyMap;
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
                {
                    return true;
                }
            }

            return false;
        }

        public void MapHotkey(WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            this.hotkeyMap[windowSizePosition] = hotkey;
            KeyMapManager.SaveHotkeyMap(this.hotkeyMap);
        }

        public void RegisterHotkeys()
        {
            foreach (KeyValuePair<WindowSizePosition, Hotkey> hotkeyMapping in this.hotkeyMap)
            {
                hotkeyMapping.Value.SetHandler(this.windowResizer.ResizeTo, hotkeyMapping.Key);
                hotkeyMapping.Value.Register(this.form);
            }
        }

        public void UnmapHotkey(WindowSizePosition windowSizePosition)
        {
            if (this.hotkeyMap.ContainsKey(windowSizePosition))
            {
                this.hotkeyMap[windowSizePosition].Unregister();
                this.hotkeyMap.Remove(windowSizePosition);
            }
        }

        public void UnregisterHotkeys()
        {
            foreach (KeyValuePair<WindowSizePosition, Hotkey> hotkeyMapping in this.hotkeyMap)
            {
                hotkeyMapping.Value.RemoveHandler();
                hotkeyMapping.Value.Unregister();
            }
        }
    }
}