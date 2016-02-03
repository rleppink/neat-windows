namespace NeatWindows
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public static class KeyMapManager
    {
        private const string KeyMapFileName = "keymap.txt";

        /// <summary>
        /// Returns a dictionary with saved hotkeys from the keymap file, corresponding to their windowsizeposition.
        /// </summary>
        /// <returns>A dictionary containing saved hotkeys</returns>
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

        /// <summary>
        /// Saves the given hotkeymap dictionary to the keymap file.
        /// </summary>
        /// <param name="hotkeyMap">A hotkeymap to save</param>
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

        /// <summary>
        /// Generates a line for the keymap for a given hotkey and windowsizeposition combination.
        /// </summary>
        /// <param name="windowSizePosition">The windowsizeposition to use in generating a hotkeyline</param>
        /// <param name="hotkey">The hotkey to use in generating a hotkeyline</param>
        /// <returns></returns>
        private static string GenerateHotkeyLine(WindowSizePosition windowSizePosition, Hotkey hotkey)
        {
            var line = string.Empty;
            line += windowSizePosition.ToString();
            line += " = ";
            line += hotkey.ToString();
            return line;
        }

        /// <summary>
        /// Returns the path where the keymap is and should be saved.
        /// </summary>
        /// <returns>The keymap path</returns>
        private static string GetKeyMapPath()
        {
            return Path.Combine(Application.UserAppDataPath, KeyMapFileName);
        }

        /// <summary>
        /// Parses a hotkey line from the keymap file into a windowsize position and hotkey keyvaluepair.
        /// </summary>
        /// <param name="line">A line from the keymap file</param>
        /// <returns>A keyvaluepair containing </returns>
        private static KeyValuePair<WindowSizePosition, Hotkey> ParseHotkeyLine(string line)
        {
            var configLineSplit = line.Split('=');
            var parsedLineKeyValuePair = new KeyValuePair<string, string>(configLineSplit[0].Trim(), configLineSplit[1].Trim());

            var windowSizePosition = (WindowSizePosition)Enum.Parse(typeof(WindowSizePosition), parsedLineKeyValuePair.Key);
            var hotkey = ParseHotkeys(parsedLineKeyValuePair.Value);
            return new KeyValuePair<WindowSizePosition, Hotkey>(windowSizePosition, hotkey);
        }

        /// <summary>
        /// Parses hotkeys from the given line string.
        /// </summary>
        /// <param name="line">Line to parse hotkeys from</param>
        /// <returns>A hotkey instance containing the keys from the given line</returns>
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