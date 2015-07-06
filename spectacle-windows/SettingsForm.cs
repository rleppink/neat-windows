using System.Collections.Generic;
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

        private void HandleKeyDownEvent(object sender, KeyEventArgs keyEventArgs)
        {
            keyEventArgs.Handled = true;
            TextBox senderTextBox = (TextBox)sender;
            senderTextBox.Text = this.GenerateKeyString(keyEventArgs);
        }

        private void HandleKeyUpEvent(object sender, KeyEventArgs keyEventArgs)
        {
            keyEventArgs.Handled = true;
            TextBox senderTextBox = (TextBox)sender;
            senderTextBox.Text = this.GenerateKeyString(keyEventArgs);

            if ((keyEventArgs.KeyCode == Keys.ShiftKey) ||
                (keyEventArgs.KeyCode == Keys.ControlKey) ||
                (keyEventArgs.KeyCode == Keys.Menu) ||
                (keyEventArgs.KeyCode == Keys.LWin) ||
                (keyEventArgs.KeyCode == Keys.RWin))
                return;

            labelBottomHalf.Focus();
            
        }

        private string GenerateKeyString(KeyEventArgs keyEventArgs)
        {
            List<string> keys = new List<string>();

            if (keyEventArgs.Control) keys.Add("Ctrl");
            if (keyEventArgs.Shift) keys.Add("Shift");
            if (keyEventArgs.Alt) keys.Add("Alt");
            // TODO: bool windowsPressed = (Control.ModifierKeys | Keys.LWin) == keyEventArgs.Modifiers;

            if ((keyEventArgs.KeyCode != Keys.ShiftKey) &&
                (keyEventArgs.KeyCode != Keys.ControlKey) &&
                (keyEventArgs.KeyCode != Keys.Menu) &&
                (keyEventArgs.KeyCode != Keys.LWin) &&
                (keyEventArgs.KeyCode != Keys.RWin))
                keys.Add(keyEventArgs.KeyCode.ToString());

            return string.Join(" + ", keys.ToArray());
        }

    }
}
