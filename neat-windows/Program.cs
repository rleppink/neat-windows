using System;
using System.Windows.Forms;

namespace NeatWindows
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
            Application.Run(settingsForm);
        }
    }
}
