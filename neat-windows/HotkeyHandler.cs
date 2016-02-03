namespace NeatWindows
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Class responsible for handling (loading, saving, regisering) all hotkeys.
    /// </summary>
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

        /// <summary>
        /// Returns the currently in use hotkey map.
        /// </summary>
        /// <returns>The currently in use hotkey map</returns>
        public Dictionary<WindowSizePosition, Hotkey> GetHotkeyMap()
        {
            return _HotkeyMap;
        }

        /// <summary>
        /// Returns whether a hotkey or windowsizeposition exists in the current hotkey map.
        /// </summary>
        /// <param name="windowSizePosition">The windowsizeposition to check</param>
        /// <param name="hotkey">The hotkey to check</param>
        /// <returns>Whether the current hotkey or windowsizeposition exists</returns>
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

        /// <summary>
        /// Adds a new windowsizeposition/hotkey combination to the hotkey map.
        /// </summary>
        /// <param name="windowSizePosition">The windowsizeposition to map</param>
        /// <param name="hotkey">The hotkey to map</param>
        public void MapHotkey(WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            _HotkeyMap[windowSizePosition] = hotkey;
            KeyMapManager.SaveHotkeyMap(_HotkeyMap);
        }

        /// <summary>
        /// Registers all hotkeys in the hotkey map.
        /// </summary>
        public void RegisterHotkeys()
        {
            foreach (var hotkeyMapping in _HotkeyMap)
            {
                hotkeyMapping.Value.SetHandler(_WindowResizer.ResizeTo, hotkeyMapping.Key);
                hotkeyMapping.Value.Register(_SettingsForm);
            }
        }

        /// <summary>
        /// Unmaps (and unregisters) a hotkey for a given windowsizeposition.
        /// </summary>
        /// <param name="windowSizePosition"></param>
        public void UnmapHotkey(WindowSizePosition windowSizePosition)
        {
            if (!_HotkeyMap.ContainsKey(windowSizePosition)) 
                return;

            _HotkeyMap[windowSizePosition].Unregister();
            _HotkeyMap.Remove(windowSizePosition);
        }

        /// <summary>
        /// Unregisters all hotkeys in the hotkey map.
        /// </summary>
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