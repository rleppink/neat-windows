namespace NeatWindows
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public static class KeyMapManager
    {
        private const string KeyMapName = "keymap.txt";

        public static Dictionary<WindowSizePosition, Hotkey> GetSavedHotkeys()
        {
            var hotkeyMap = new Dictionary<WindowSizePosition, Hotkey>();
            if (!File.Exists(GetKeyMapPath()))
                return hotkeyMap; // If keymap doesn't exist yet, it will be created when user saves keys

            var lines = File.ReadAllLines(GetKeyMapPath());
            foreach (var keyValuePair in lines.Select(ParseHotkeyLine))
            {
                hotkeyMap.Add(keyValuePair.Key, keyValuePair.Value);
            }

            return hotkeyMap;
        }

        public static void SaveHotkeyMap(Dictionary<WindowSizePosition, Hotkey> hotkeyMap)
        {
            if (hotkeyMap == null)
                return;

            Directory.CreateDirectory(Application.UserAppDataPath);
            using (var configFile = new StreamWriter(GetKeyMapPath(), false))
            {
                foreach (var entry in hotkeyMap)
                {
                    configFile.WriteLine(GenerateHotkeyLine(entry.Key, entry.Value));
                }
            }
        }

        private static string GenerateHotkeyLine(WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            var line = string.Empty;
            line += windowSizePosition.ToString();
            line += " = ";
            line += hotkey.ToString();
            return line;
        }

        private static string GetKeyMapPath()
        {
            return Path.Combine(Application.UserAppDataPath, KeyMapName);
        }

        private static KeyValuePair<string, string> ParseConfigLine(string configLine)
        {
            var configLineSplit = configLine.Split('=');
            return new KeyValuePair<string, string>(configLineSplit[0].Trim(), configLineSplit[1].Trim());
        }

        private static KeyValuePair<WindowSizePosition, Hotkey> ParseHotkeyLine(string line)
        {
            var parsedLine = ParseConfigLine(line);
            var windowSizePosition = (WindowSizePosition)Enum.Parse(typeof(WindowSizePosition), parsedLine.Key);
            var hotkey = ParseHotkeys(parsedLine.Value);
            return new KeyValuePair<WindowSizePosition, Hotkey>(windowSizePosition, hotkey);
        }

        private static Hotkey ParseHotkeys(string line)
        {
            var hotkey = new Hotkey();

            if (line.Contains("Ctrl"))
                hotkey.Control = true;

            if (line.Contains("Alt"))
                hotkey.Alt = true;

            if (line.Contains("Shift"))
                hotkey.Shift = true;

            hotkey.KeyCode = (Keys)Enum.Parse(typeof(Keys), line.Split(' ').Last());

            return hotkey;
        }
    }
}