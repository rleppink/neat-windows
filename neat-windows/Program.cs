using System;
using System.Windows.Forms;

namespace neat_windows
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
            Application.Run(new SettingsForm());
        }
    }
}
