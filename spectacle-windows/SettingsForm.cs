using System.Windows.Forms;

namespace spectacle_windows
{
    public partial class SettingsForm : Form
    {

        public SettingsForm() 
        { 
            InitializeComponent();
            this.Resize += delegate { this.SettingsForm_Resize(); };
        }

        private void SettingsForm_Resize()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.settingsIcon.Visible = true;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.settingsIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void settingsIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.settingsIcon.Visible = false;
        }

        private void handleKeyInput(object sender, KeyEventArgs keyEventArgs)
        {
            keyEventArgs.Handled = true;
            TextBox senderTextBox = (TextBox)sender;

            bool controlPressed = keyEventArgs.Control;
            bool shiftPressed = keyEventArgs.Shift;
            bool altPressed = keyEventArgs.Alt;
            // TODO: bool windowsPressed = (Control.ModifierKeys | Keys.LWin) == keyEventArgs.Modifiers;

            string keysPressedText = "";
            if (controlPressed)
                keysPressedText += "Ctrl + ";
            if (altPressed)
                keysPressedText += "Alt + ";
            if (shiftPressed)
                keysPressedText += "Shift + ";
            keysPressedText += keyEventArgs.KeyValue;
            senderTextBox.Text = keysPressedText;

            // TODO: Register hotkeys
        }

    }
}
