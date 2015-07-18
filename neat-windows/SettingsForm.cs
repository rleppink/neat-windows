namespace NeatWindows
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Microsoft.Win32;
    using System.Globalization;

    public partial class SettingsForm : Form
    {
        private static string registryPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private static string registryValue = @"NeatWindows";
        private HotkeyHandler hotkeyHandler;

        public SettingsForm()
        {
            this.InitializeComponent();

            this.hotkeyHandler = new HotkeyHandler(this);
            this.MapTags();
            this.FillTextBoxes(this.hotkeyHandler.GetHotkeyMap());
            this.InitStartupCheckBox();
            this.SetWindowSize();

            this.trackBarWindowBorder.Value = Properties.Settings.Default.WindowBorder;
            this.textBoxWindowBorder.Text = ((int)Properties.Settings.Default.WindowBorder).ToString(CultureInfo.CurrentCulture);

            labelFullscreen.Focus();
        }

        public void FillTextBoxes(Dictionary<WindowSizePosition, Hotkey> hotkeyMap)
        {
            if (hotkeyMap == null)
            {
                return;
            }

            foreach (KeyValuePair<WindowSizePosition, Hotkey> hotkeyMapping in hotkeyMap)
            {
                TextBox taggedTextBox = this.GetTextBoxByTag(hotkeyMapping.Key);
                if (taggedTextBox == null)
                {
                    continue;
                }

                taggedTextBox.Text = hotkeyMapping.Value.ToString();
            }
        }

        private void CheckBoxStartAtLogin_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(SettingsForm.registryPath, true);
            if (((CheckBox)sender).Checked)
            {
                registryKey.SetValue(registryValue, Application.ExecutablePath.ToString());
            }
            else
            {
                registryKey.DeleteValue(registryValue, false);
            }
        }

        private void ExitNeatWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private TextBox GetTextBoxByTag(WindowSizePosition windowSizePosition)
        {
            foreach (Control control in this.Controls)
            {
                if ((control.GetType() != typeof(TextBox)) || (control.Tag == null))
                {
                    continue;
                }

                if (control.Tag.Equals(windowSizePosition))
                {
                    return (TextBox)control;
                }
            }

            return null;
        }

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

            if ((keyEventArgs.KeyCode == Keys.ShiftKey) ||
                (keyEventArgs.KeyCode == Keys.ControlKey) ||
                (keyEventArgs.KeyCode == Keys.Menu) ||
                (keyEventArgs.KeyCode == Keys.LWin) ||
                (keyEventArgs.KeyCode == Keys.RWin))
            {
                // We don't want anything to happen when a modifier key up event happened
                return;
            }

            WindowSizePosition windowSizePosition = (WindowSizePosition)senderTextBox.Tag;

            if (this.hotkeyHandler.HotkeyExists(windowSizePosition, hotkey))
            {
                senderTextBox.Text = NeatWindows.Properties.Resources.hotkeyAlreadyExistsWarning;
                return;
            }

            this.hotkeyHandler.MapHotkey(windowSizePosition, hotkey);
            labelFullscreen.Focus();
        }

        private void InitStartupCheckBox()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(SettingsForm.registryPath, true);
            if (registryKey.GetValue(registryValue) == null)
            {
                this.startupCheckbox.Checked = false;
            }
            else
            {
                this.startupCheckbox.Checked = true;
            }
        }

        private void MapTags()
        {
            this.textBoxFullscreen.Tag = WindowSizePosition.Fullscreen;
            this.textBoxCenter.Tag = WindowSizePosition.Center;
            this.textBoxNextDisplay.Tag = WindowSizePosition.NextScreen;
            this.textBoxPreviousDisplay.Tag = WindowSizePosition.PreviousScreen;

            this.textBoxLeftHalf.Tag = WindowSizePosition.LeftHalf;
            this.textBoxRightHalf.Tag = WindowSizePosition.RightHalf;
            this.textBoxTopHalf.Tag = WindowSizePosition.TopHalf;
            this.textBoxBottomHalf.Tag = WindowSizePosition.BottomHalf;

            this.textBoxTopLeftQuarter.Tag = WindowSizePosition.TopLeft;
            this.textBoxTopRightQuarter.Tag = WindowSizePosition.TopRight;
            this.textBoxBottomLeftQuarter.Tag = WindowSizePosition.BottomLeft;
            this.textBoxBottomRightQuarter.Tag = WindowSizePosition.BottomRight;

            this.buttonFullscreen.Tag = WindowSizePosition.Fullscreen;
            this.buttonCenter.Tag = WindowSizePosition.Center;
            this.buttonNextDisplay.Tag = WindowSizePosition.NextScreen;
            this.buttonPreviousDisplay.Tag = WindowSizePosition.PreviousScreen;

            this.buttonLeftHalf.Tag = WindowSizePosition.LeftHalf;
            this.buttonRightHalf.Tag = WindowSizePosition.RightHalf;
            this.buttonTopHalf.Tag = WindowSizePosition.TopHalf;
            this.buttonBottomHalf.Tag = WindowSizePosition.BottomHalf;

            this.buttonTopLeft.Tag = WindowSizePosition.TopLeft;
            this.buttonTopRight.Tag = WindowSizePosition.TopRight;
            this.buttonBottomLeft.Tag = WindowSizePosition.BottomLeft;
            this.buttonBottomRight.Tag = WindowSizePosition.BottomRight;
        }

        private void OpenSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void SettingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.labelFullscreen.Focus();
            this.FillTextBoxes(this.hotkeyHandler.GetHotkeyMap());
        }

        private void SettingsForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowBalloonTooltip();
            }
        }

        private void SettingsIcon_MouseDoubleClick(object sender, MouseEventArgs e)
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
                this.ShowBalloonTooltip();
            }
        }

        private void SetWindowSize()
        {
            int width = 0;
            int height = 0;

            foreach (Control c in this.Controls)
            {
                if ((c.Width + c.Location.X) > width)
                {
                    width = c.Width + c.Location.X;
                }

                if ((c.Height + c.Location.Y) > height)
                {
                    height = c.Height + c.Location.Y;
                }
            }

            width += 25;
            height += 35;
            this.MinimumSize = new Size(width, height);
            this.MaximumSize = new Size(width, height);
        }

        private void ShowBalloonTooltip()
        {
            if (Properties.Settings.Default.ShowNotifyIconBalloonInfo)
            {
                this.settingsIcon.ShowBalloonTip(3000);
                Properties.Settings.Default.ShowNotifyIconBalloonInfo = false;
                Properties.Settings.Default.Save();
            }
        }

        private void TextBox_FocusEnter(object sender, EventArgs e)
        {
            TextBox senderTextBox = (TextBox)sender;
            senderTextBox.Text = string.Empty;
            this.hotkeyHandler.UnregisterHotkeys();
        }

        private void TextBox_FocusLeave(object sender, EventArgs e)
        {
            TextBox senderTextBox = (TextBox)sender;
            senderTextBox.Text = string.Empty;
            senderTextBox.TabStop = false;
            this.hotkeyHandler.RegisterHotkeys();
            this.FillTextBoxes(this.hotkeyHandler.GetHotkeyMap());
        }

        private void UnmapButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            WindowSizePosition windowSizePosition = (WindowSizePosition)clickedButton.Tag;
            this.hotkeyHandler.UnmapHotkey(windowSizePosition);
            this.GetTextBoxByTag(windowSizePosition).Text = string.Empty;
        }

        private void TrackBarWindowBorder_Scroll(object sender, EventArgs e)
        {
            TrackBar senderTrackBar = (TrackBar)sender;
            this.textBoxWindowBorder.Text = senderTrackBar.Value.ToString(CultureInfo.CurrentCulture);
            Properties.Settings.Default.WindowBorder = senderTrackBar.Value;
            Properties.Settings.Default.Save();
        }
    }
}