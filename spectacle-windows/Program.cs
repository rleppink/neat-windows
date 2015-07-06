using System;
using System.Windows.Forms;

namespace spectacle_windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SettingsForm settingsForm = new SettingsForm();

            HotkeyHandler hotkeyHandler = new HotkeyHandler();
            hotkeyHandler.RegisterHotkeys(settingsForm);

            Application.Run(new SettingsForm());
        }
    }
}
