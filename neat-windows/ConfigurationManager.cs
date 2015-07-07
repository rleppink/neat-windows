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
        private string configName = "config.txt";

        public ConfigurationManager()
        {
            Directory.CreateDirectory(Application.UserAppDataPath);
        }

        public void SaveHotkeys(Dictionary<WindowConstants.WindowSizePosition, Hotkey> hotkeyMap)
        {
            using (StreamWriter configFile = new StreamWriter(this.GetFullConfigPath(), false))
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
            if (!File.Exists(this.GetFullConfigPath())) return hotkeyMap;

            string[] lines = File.ReadAllLines(this.GetFullConfigPath());
            foreach (string line in lines) {
                KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> keyValuePair = this.ParseLine(line);
                hotkeyMap.Add(keyValuePair.Key, keyValuePair.Value);
            }
            return hotkeyMap;
        }

        private KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> ParseLine(string line)
        {
            KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> keyValuePair = new KeyValuePair<WindowConstants.WindowSizePosition, Hotkey>();

            string[] keyValueSplit = line.Split('=');
            WindowConstants.WindowSizePosition windowSizePosition = (WindowConstants.WindowSizePosition) Enum.Parse(typeof(WindowConstants.WindowSizePosition), keyValueSplit[0]);
            Hotkey hotkey = this.ParseHotkeys(keyValueSplit[1]);
            if (windowSizePosition != null && hotkey != null)
            {
                keyValuePair = new KeyValuePair<WindowConstants.WindowSizePosition, Hotkey>(windowSizePosition, hotkey);
            }
            return keyValuePair;
        }

        private string GetFullConfigPath()
        {
            return Path.Combine(Application.UserAppDataPath, this.configName);
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
    }
}
