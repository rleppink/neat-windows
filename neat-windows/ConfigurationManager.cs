using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

        public void SaveHotkeys(Dictionary<WindowConstants.WindowSizePosition, Hotkey> hotkeys)
        {
            using (StreamWriter configFile = new StreamWriter(this.GetFullConfigPath(), false))
            {
                foreach (KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> entry in hotkeys)
                {
                    configFile.WriteLine(this.GenerateHotkeyLine(entry.Key, entry.Value));
                }
            }
        }

        public Dictionary<WindowConstants.WindowSizePosition, Hotkey> GetSavedHotkeys()
        {
            Dictionary<WindowConstants.WindowSizePosition, Hotkey> hotkeys = new Dictionary<WindowConstants.WindowSizePosition, Hotkey>();
            string[] lines = File.ReadAllLines(this.GetFullConfigPath());
            foreach (string line in lines) {
                KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> keyValuePair = this.ParseLine(line);
                hotkeys.Add(keyValuePair.Key, keyValuePair.Value);
            }
            return hotkeys;
        }

        private KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> ParseLine(string line)
        {
            KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> keyValuePair = new KeyValuePair<WindowConstants.WindowSizePosition, Hotkey>();

            string[] keyValueSplit = line.Split('=');
            WindowConstants.WindowSizePosition windowSizePosition = (WindowConstants.WindowSizePosition) Enum.Parse(typeof(WindowConstants.WindowSizePosition), keyValueSplit[0]);
            foreach (stringkeyValueSplit.Skip(1);

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

    }
}
