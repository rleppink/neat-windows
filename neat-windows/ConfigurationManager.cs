using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace neat_windows
{
    class ConfigurationManager
    {
        private string settingsName = "settings.txt";
        private string keyMapName = "keymap.txt";

        public ConfigurationManager()
        {
            Directory.CreateDirectory(Application.UserAppDataPath);
        }

        #region Paths
        private string GetSettingsPath()
        {
            return this.GetCombinedPath(this.settingsName);
        }

        private string GetKeyMapPath()
        {
            return this.GetCombinedPath(this.keyMapName);
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

        #region SettingsConfig
        public void SaveSettings()
        {

        }

        #endregion SettingsConfig

        #region HotkeyMapConfig
        public void SaveHotkeyMap(Dictionary<WindowConstants.WindowSizePosition, Hotkey> hotkeyMap)
        {
            using (StreamWriter configFile = new StreamWriter(this.GetKeyMapPath(), false))
            {
                foreach (KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> entry in hotkeyMap)
                {
                    configFile.WriteLine(this.GenerateHotkeyLine(entry.Key, entry.Value));
                }
            }
        }

        public Dictionary<WindowConstants.WindowSizePosition, Hotkey> GetSavedHotkeys()
        {
            Dictionary<WindowConstants.WindowSizePosition, Hotkey> hotkeyMap = new Dictionary<WindowConstants.WindowSizePosition, Hotkey>();
            if (!File.Exists(this.GetKeyMapPath())) return hotkeyMap;

            string[] lines = File.ReadAllLines(this.GetKeyMapPath());
            foreach (string line in lines) {
                KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> keyValuePair = this.ParseHotkeyLine(line);
                hotkeyMap.Add(keyValuePair.Key, keyValuePair.Value);
            }
            return hotkeyMap;
        }

        private KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> ParseHotkeyLine(string line)
        {
            KeyValuePair<string, string> parsedLine = this.ParseConfigLine(line);
            WindowConstants.WindowSizePosition windowSizePosition = (WindowConstants.WindowSizePosition) Enum.Parse(typeof(WindowConstants.WindowSizePosition), parsedLine.Key);
            Hotkey hotkey = this.ParseHotkeys(parsedLine.Value);
            return new KeyValuePair<WindowConstants.WindowSizePosition,Hotkey>(windowSizePosition, hotkey);
        }

        private string GenerateHotkeyLine(WindowConstants.WindowSizePosition windowSizePosition, Hotkey hotkey) 
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
