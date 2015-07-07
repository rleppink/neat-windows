using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spectacle_windows
{
    class ConfigurationManager
    {
        private string configLocation = Application.UserAppDataPath + "\\neat-windows";

        public ConfigurationManager()
        {
            Directory.CreateDirectory(this.configLocation);
        }

        public void SaveHotkey(Hotkey hotkey)
        {
        }



    }
}
