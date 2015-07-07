using System.Collections.Generic;
using System.Windows.Forms;

namespace spectacle_windows
{
    public partial class SettingsForm : Form
    {
        private HotkeyHandler hotkeyHandler;

        public SettingsForm() 
        { 
            InitializeComponent();

            this.hotkeyHandler = new HotkeyHandler(this);
            //this.hotkeyHandler.InitializeDefaultHotkeys();
            this.Resize += delegate { this.SettingsForm_Resize(); };

            this.MapTextBoxTags();
        }

        #region Minimizing, notifyicon
        private void SettingsForm_Resize()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.settingsIcon.Visible = true;
                this.ShowInTaskbar = false;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.settingsIcon.Visible = false;
                this.ShowInTaskbar = true;
                this.Show();
            }
        }

        private void settingsIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.settingsIcon.Visible = false;
            this.ShowInTaskbar = true;
            this.Show();
        }
        #endregion Minimizing, notifyicon

        #region TextBox mapping
        private void MapTextBoxTags()
        {
            this.textBoxFullscreen.Tag = WindowConstants.WindowSizePosition.FULLSCREEN;
            this.textBoxCenter.Tag = WindowConstants.WindowSizePosition.CENTER;
            this.textBoxNextDisplay.Tag = WindowConstants.WindowSizePosition.NEXT_SCREEN;
            this.textBoxPreviousDisplay.Tag = WindowConstants.WindowSizePosition.PREVIOUS_SCREEN;

            this.textBoxLeftHalf.Tag = WindowConstants.WindowSizePosition.LEFT_HALF;
            this.textBoxRightHalf.Tag = WindowConstants.WindowSizePosition.RIGHT_HALF;
            this.textBoxTopHalf.Tag = WindowConstants.WindowSizePosition.TOP_HALF;
            this.textBoxBottomHalf.Tag = WindowConstants.WindowSizePosition.BOTTOM_HALF;

            this.textBoxTopLeftQuarter.Tag = WindowConstants.WindowSizePosition.TOP_LEFT;
            this.textBoxTopRightQuarter.Tag = WindowConstants.WindowSizePosition.TOP_RIGHT;
            this.textBoxBottomLeftQuarter.Tag = WindowConstants.WindowSizePosition.BOTTOM_LEFT;
            this.textBoxBottomRightQuarter.Tag = WindowConstants.WindowSizePosition.BOTTOM_RIGHT;
        }
        #endregion TextBox mapping

        #region Keyhandling
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

            // We don't want anything to happen when a modifier key up event happened
            if ((keyEventArgs.KeyCode == Keys.ShiftKey) ||
                (keyEventArgs.KeyCode == Keys.ControlKey) ||
                (keyEventArgs.KeyCode == Keys.Menu) ||
                (keyEventArgs.KeyCode == Keys.LWin) ||
                (keyEventArgs.KeyCode == Keys.RWin))
                return;

            labelFullscreen.Focus();

            WindowConstants.WindowSizePosition windowSizePosition = (WindowConstants.WindowSizePosition) senderTextBox.Tag;
            this.hotkeyHandler.MapHotkey(this, windowSizePosition, keyEventArgs.KeyCode, keyEventArgs.Shift, keyEventArgs.Control, keyEventArgs.Alt, false);
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
        #endregion Keyhandling

    }
}
