using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NeatWindows
{
    class KeymapManager
    {
        private static string keyMapName = "keymap.txt";

        public KeymapManager()
        {
            Directory.CreateDirectory(Application.UserAppDataPath);
        }

        #region Paths
        private string GetKeyMapPath()
        {
            return this.GetCombinedPath(keyMapName);
        }

        private string GetCombinedPath(string fileName)
        {
            return Path.Combine(Application.UserAppDataPath, fileName);
        }
        #endregion Paths

        #region General
        private KeyValuePair<string, string> ParseConfigLine(string configLine)
        {
            string[] configLineSplit = configLine.Split('=');
            return new KeyValuePair<string, string>(configLineSplit[0].Trim(), configLineSplit[1].Trim());
        }
        #endregion General

        #region HotkeyMapConfig
        public void SaveHotkeyMap(Dictionary<WindowSizePosition, Hotkey> hotkeyMap)
        {
            using (StreamWriter configFile = new StreamWriter(this.GetKeyMapPath(), false))
            {
                foreach (KeyValuePair<WindowSizePosition, Hotkey> entry in hotkeyMap)
                {
                    configFile.WriteLine(this.GenerateHotkeyLine(entry.Key, entry.Value));
                }
            }
        }

        public Dictionary<WindowSizePosition, Hotkey> GetSavedHotkeys()
        {
            Dictionary<WindowSizePosition, Hotkey> hotkeyMap = new Dictionary<WindowSizePosition, Hotkey>();
            if (!File.Exists(this.GetKeyMapPath())) return hotkeyMap; // If keymap doesn't exist yet, it will be created when user saves keys

            string[] lines = File.ReadAllLines(this.GetKeyMapPath());
            foreach (string line in lines) {
                KeyValuePair<WindowSizePosition, Hotkey> keyValuePair = this.ParseHotkeyLine(line);
                hotkeyMap.Add(keyValuePair.Key, keyValuePair.Value);
            }

            return hotkeyMap;
        }

        private KeyValuePair<WindowSizePosition, Hotkey> ParseHotkeyLine(string line)
        {
            KeyValuePair<string, string> parsedLine = this.ParseConfigLine(line);
            WindowSizePosition windowSizePosition = (WindowSizePosition) Enum.Parse(typeof(WindowSizePosition), parsedLine.Key);
            Hotkey hotkey = this.ParseHotkeys(parsedLine.Value);
            return new KeyValuePair<WindowSizePosition,Hotkey>(windowSizePosition, hotkey);
        }

        private string GenerateHotkeyLine(WindowSizePosition windowSizePosition, Hotkey hotkey) 
        {
            string line = "";
            line += windowSizePosition.ToString();
            line += " = ";
            line += hotkey.ToString();
            return line;
        }

        private Hotkey ParseHotkeys(string line)
        {
            Hotkey hotkey = new Hotkey();

            if (line.Contains("Ctrl")) hotkey.Control = true;
            if (line.Contains("Alt")) hotkey.Alt = true;
            if (line.Contains("Shift")) hotkey.Shift = true;

            hotkey.KeyCode = (Keys)Enum.Parse(typeof(Keys), line.Split(' ').Last());

            return hotkey;
        }
        #endregion HotkeyMapConfig
    }
}
