using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace neat_windows
{
    public partial class SettingsForm : Form
    {
        private HotkeyHandler hotkeyHandler;

        public SettingsForm() 
        { 
            InitializeComponent();

            this.hotkeyHandler = new HotkeyHandler(this);
            this.MapTextBoxTags();
            this.FillTextBoxes(this.hotkeyHandler.GetHotkeyMap());
        }

        #region Minimizing, notifyicon
        private void settingsIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                this.settingsIcon.ShowBalloonTip(3000);
            }
        }

        private void SettingsForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.settingsIcon.ShowBalloonTip(3000);
            }
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

        public void FillTextBoxes(Dictionary<WindowConstants.WindowSizePosition, Hotkey> hotkeyMap)
        {
            foreach (KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> hotkeyMapping in hotkeyMap) 
            {
                TextBox taggedTextBox = (TextBox) this.GetControlByTag(hotkeyMapping.Key);
                if (taggedTextBox == null)
                {
                    Console.WriteLine("Null found for key: " + hotkeyMapping.Key.ToString());
                    continue;
                }

                taggedTextBox.Text = hotkeyMapping.Value.ToString();
            }
        }

        private Control GetControlByTag(WindowConstants.WindowSizePosition windowSizePosition)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(TextBox))
                    continue;
                if (control.Tag.Equals(windowSizePosition))
                    return control;
            }
            return null;
        }
        #endregion TextBox mapping

        #region Keyhandling
        private void HandleKeyDownEvent(object sender, KeyEventArgs keyEventArgs)
        {
            keyEventArgs.Handled = true;
            TextBox senderTextBox = (TextBox)sender;
            Hotkey hotkey = new Hotkey(keyEventArgs.KeyCode, keyEventArgs.Shift, keyEventArgs.Control, keyEventArgs.Alt, false);
            senderTextBox.Text = hotkey.ToString();
        }

        private void HandleKeyUpEvent(object sender, KeyEventArgs keyEventArgs)
        {
            keyEventArgs.Handled = true;
            TextBox senderTextBox = (TextBox)sender;
            Hotkey hotkey = new Hotkey(keyEventArgs.KeyCode, keyEventArgs.Shift, keyEventArgs.Control, keyEventArgs.Alt, false);
            senderTextBox.Text = hotkey.ToString();

            // We don't want anything to happen when a modifier key up event happened
            if ((keyEventArgs.KeyCode == Keys.ShiftKey) ||
                (keyEventArgs.KeyCode == Keys.ControlKey) ||
                (keyEventArgs.KeyCode == Keys.Menu) ||
                (keyEventArgs.KeyCode == Keys.LWin) ||
                (keyEventArgs.KeyCode == Keys.RWin))
                return;

            labelFullscreen.Focus();

            WindowConstants.WindowSizePosition windowSizePosition = (WindowConstants.WindowSizePosition) senderTextBox.Tag;
            this.hotkeyHandler.MapHotkey(windowSizePosition, hotkey);
        }
        #endregion Keyhandling

    }
}
