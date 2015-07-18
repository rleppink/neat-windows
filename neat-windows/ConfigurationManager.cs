namespace NeatWindows
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public static class KeyMapManager
    {
        private static string keyMapName = "keymap.txt";

        public static Dictionary<WindowSizePosition, Hotkey> GetSavedHotkeys()
        {
            Dictionary<WindowSizePosition, Hotkey> hotkeyMap = new Dictionary<WindowSizePosition, Hotkey>();
            if (!File.Exists(GetKeyMapPath()))
            {
                return hotkeyMap; // If keymap doesn't exist yet, it will be created when user saves keys
            }

            string[] lines = File.ReadAllLines(GetKeyMapPath());
            foreach (string line in lines)
            {
                KeyValuePair<WindowSizePosition, Hotkey> keyValuePair = ParseHotkeyLine(line);
                hotkeyMap.Add(keyValuePair.Key, keyValuePair.Value);
            }

            return hotkeyMap;
        }

        public static void SaveHotkeyMap(Dictionary<WindowSizePosition, Hotkey> hotkeyMap)
        {
            if (hotkeyMap == null)
            {
                return; // Why try to save an empty hotkeyMap?
            }

            Directory.CreateDirectory(Application.UserAppDataPath);
            using (StreamWriter configFile = new StreamWriter(GetKeyMapPath(), false))
            {
                foreach (KeyValuePair<WindowSizePosition, Hotkey> entry in hotkeyMap)
                {
                    configFile.WriteLine(GenerateHotkeyLine(entry.Key, entry.Value));
                }
            }
        }

        private static string GenerateHotkeyLine(WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            string line = string.Empty;
            line += windowSizePosition.ToString();
            line += " = ";
            line += hotkey.ToString();
            return line;
        }

        private static string GetKeyMapPath()
        {
            return Path.Combine(Application.UserAppDataPath, keyMapName);
        }

        private static KeyValuePair<string, string> ParseConfigLine(string configLine)
        {
            string[] configLineSplit = configLine.Split('=');
            return new KeyValuePair<string, string>(configLineSplit[0].Trim(), configLineSplit[1].Trim());
        }

        private static KeyValuePair<WindowSizePosition, Hotkey> ParseHotkeyLine(string line)
        {
            KeyValuePair<string, string> parsedLine = ParseConfigLine(line);
            WindowSizePosition windowSizePosition = (WindowSizePosition)Enum.Parse(typeof(WindowSizePosition), parsedLine.Key);
            Hotkey hotkey = ParseHotkeys(parsedLine.Value);
            return new KeyValuePair<WindowSizePosition, Hotkey>(windowSizePosition, hotkey);
        }

        private static Hotkey ParseHotkeys(string line)
        {
            Hotkey hotkey = new Hotkey();

            if (line.Contains("Ctrl"))
            {
                hotkey.Control = true;
            }

            if (line.Contains("Alt"))
            {
                hotkey.Alt = true;
            }

            if (line.Contains("Shift"))
            {
                hotkey.Shift = true;
            }

            hotkey.KeyCode = (Keys)Enum.Parse(typeof(Keys), line.Split(' ').Last());

            return hotkey;
        }
    }
}