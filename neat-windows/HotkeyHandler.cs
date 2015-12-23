namespace NeatWindows
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    internal class HotkeyHandler
    {
        private readonly Form _SettingsForm;
        private readonly Dictionary<WindowSizePosition, Hotkey> _HotkeyMap;
        private readonly WindowResizer _WindowResizer;

        public HotkeyHandler(Form settingsForm)
        {
            _SettingsForm = settingsForm;
            _WindowResizer = new WindowResizer();
            _HotkeyMap = KeyMapManager.GetSavedHotkeys();
            RegisterHotkeys();
        }

        public Dictionary<WindowSizePosition, Hotkey> GetHotkeyMap()
        {
            return _HotkeyMap;
        }

        public bool HotkeyExists(WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            foreach (var mappedHotkeys in _HotkeyMap)
            {
                var mappedHotkey = mappedHotkeys.Value;
                if (mappedHotkeys.Key != windowSizePosition &&
                    mappedHotkey.KeyCode == hotkey.KeyCode &&
                    mappedHotkey.Control == hotkey.Control &&
                    mappedHotkey.Alt == hotkey.Alt &&
                    mappedHotkey.Shift == hotkey.Shift)
                    return true;
            }

            return false;
        }

        public void MapHotkey(WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            _HotkeyMap[windowSizePosition] = hotkey;
            KeyMapManager.SaveHotkeyMap(_HotkeyMap);
        }

        public void RegisterHotkeys()
        {
            foreach (var hotkeyMapping in _HotkeyMap)
            {
                hotkeyMapping.Value.SetHandler(_WindowResizer.ResizeTo, hotkeyMapping.Key);
                hotkeyMapping.Value.Register(_SettingsForm);
            }
        }

        public void UnmapHotkey(WindowSizePosition windowSizePosition)
        {
            if (!_HotkeyMap.ContainsKey(windowSizePosition)) 
                return;

            _HotkeyMap[windowSizePosition].Unregister();
            _HotkeyMap.Remove(windowSizePosition);
        }

        public void UnregisterHotkeys()
        {
            foreach (var hotkeyMapping in _HotkeyMap)
            {
                hotkeyMapping.Value.RemoveHandler();
                hotkeyMapping.Value.Unregister();
            }
        }
    }
}