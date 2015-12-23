namespace NeatWindows
{
    using System;
    using System.Windows.Forms;

    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var settingsForm = new SettingsForm();
            Application.Run(settingsForm);
        }
    }
}