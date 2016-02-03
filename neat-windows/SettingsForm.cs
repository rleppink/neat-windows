using System.Linq;

namespace NeatWindows
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;
    using Microsoft.Win32;

    public partial class SettingsForm : Form
    {
        private const string RegistryPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private const string RegistryName = @"NeatWindows";
        private readonly HotkeyHandler _HotkeyHandler;

        public SettingsForm()
        {
            InitializeComponent();

            _HotkeyHandler = new HotkeyHandler(this);
            MapTags();
            FillTextBoxes(_HotkeyHandler.GetHotkeyMap());
            InitStartupCheckBox();
            SetWindowSize();

            trackBarWindowBorder.Value = Properties.Settings.Default.WindowBorder;
            textBoxWindowBorder.Text = Properties.Settings.Default.WindowBorder.ToString(CultureInfo.CurrentCulture);

            if (Environment.GetCommandLineArgs().Count(argument => argument.ToLower(CultureInfo.CurrentCulture).Equals("/startup")) > 0)
                MinimizeWindow();

            labelFullscreen.Focus();
        }

        /// <summary>
        /// Fills the hotkey textboxes according to the given hotkeymap
        /// </summary>
        /// <param name="hotkeyMap">The hotkeymap to fill the textboxes from</param>
        public void FillTextBoxes(Dictionary<WindowSizePosition, Hotkey> hotkeyMap)
        {
            if (hotkeyMap == null)
                return;

            foreach (var hotkeyMapping in hotkeyMap)
            {
                var taggedTextBox = GetTextBoxByTag(hotkeyMapping.Key);
                if (taggedTextBox == null)
                    continue;

                taggedTextBox.Text = hotkeyMapping.Value.ToString();
            }
        }

        /// <summary>
        /// On checked, register this application for automatic startup when Windows starts
        /// </summary>
        private void CheckBoxStartAtLogin_CheckedChanged(object sender, EventArgs e)
        {
            var registryKey = Registry.CurrentUser.OpenSubKey(RegistryPath, true);
            if (((CheckBox)sender).Checked)
            {
                registryKey.SetValue(RegistryName, "\"" + Application.ExecutablePath + "\" /startup");
            }
            else
            {
                registryKey.DeleteValue(RegistryName, false);
            }
        }

        private void ExitNeatWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Returns the textbox that has the given windowsizeposition as a tag.
        /// </summary>
        /// <param name="windowSizePosition">The windowsizeposition that will be used as a tag</param>
        /// <returns>The textbox that has the windowsizeposition tag</returns>
        private TextBox GetTextBoxByTag(WindowSizePosition windowSizePosition)
        {
            foreach (Control control in Controls)
            {
                if ((control.GetType() != typeof(TextBox)) || (control.Tag == null))
                    continue;

                if (control.Tag.Equals(windowSizePosition))
                    return (TextBox)control;
            }

            return null;
        }

        /// <summary>
        /// Handle showing the user which hotkey they are currently pressing.
        /// </summary>
        private void HandleKeyDownEvent(object sender, KeyEventArgs keyEventArgs)
        {
            keyEventArgs.Handled = true;
            var senderTextBox = (TextBox)sender;
            var hotkey = new Hotkey(keyEventArgs.KeyCode, keyEventArgs.Shift, keyEventArgs.Control, keyEventArgs.Alt, false);
            senderTextBox.Text = hotkey.ToString();
        }

        /// <summary>
        /// Register the hotkey when the user lets go of a key, only if that key was not a modifier key.
        /// </summary>
        private void HandleKeyUpEvent(object sender, KeyEventArgs keyEventArgs)
        {
            keyEventArgs.Handled = true;
            var senderTextBox = (TextBox)sender;
            var hotkey = new Hotkey(keyEventArgs.KeyCode, keyEventArgs.Shift, keyEventArgs.Control, keyEventArgs.Alt, false);
            senderTextBox.Text = hotkey.ToString();

            // We don't want anything to happen when a modifier key up event happened
            if ((keyEventArgs.KeyCode == Keys.ShiftKey) ||
                (keyEventArgs.KeyCode == Keys.ControlKey) ||
                (keyEventArgs.KeyCode == Keys.Menu) ||
                (keyEventArgs.KeyCode == Keys.LWin) ||
                (keyEventArgs.KeyCode == Keys.RWin))
                return;

            var windowSizePosition = (WindowSizePosition)senderTextBox.Tag;

            if (_HotkeyHandler.HotkeyExists(windowSizePosition, hotkey))
            {
                senderTextBox.Text = Properties.Resources.hotkeyAlreadyExistsWarning;
                return;
            }

            _HotkeyHandler.MapHotkey(windowSizePosition, hotkey);
            labelFullscreen.Focus();
        }

        /// <summary>
        /// Sets the initial value for the start when windows starts checkbox, based on the registry setting.
        /// </summary>
        private void InitStartupCheckBox()
        {
            var registryKey = Registry.CurrentUser.OpenSubKey(RegistryPath, true);
            if (registryKey.GetValue(RegistryName) == null)
            {
                startupCheckbox.Checked = false;
            }
            else
            {
                registryKey.SetValue(RegistryName, "\"" + Application.ExecutablePath + "\" /startup");
                startupCheckbox.Checked = true;
            }
        }

        /// <summary>
        /// Maps textboxes to windowsizeposition tags, for finding which textbox defines which windowsizeposition.
        /// </summary>
        private void MapTags()
        {
            textBoxFullscreen.Tag = WindowSizePosition.Fullscreen;
            textBoxCenter.Tag = WindowSizePosition.Center;
            textBoxNextDisplay.Tag = WindowSizePosition.NextScreen;
            textBoxPreviousDisplay.Tag = WindowSizePosition.PreviousScreen;

            textBoxLeftHalf.Tag = WindowSizePosition.LeftHalf;
            textBoxRightHalf.Tag = WindowSizePosition.RightHalf;
            textBoxTopHalf.Tag = WindowSizePosition.TopHalf;
            textBoxBottomHalf.Tag = WindowSizePosition.BottomHalf;

            textBoxTopLeftQuarter.Tag = WindowSizePosition.TopLeft;
            textBoxTopRightQuarter.Tag = WindowSizePosition.TopRight;
            textBoxBottomLeftQuarter.Tag = WindowSizePosition.BottomLeft;
            textBoxBottomRightQuarter.Tag = WindowSizePosition.BottomRight;

            buttonFullscreen.Tag = WindowSizePosition.Fullscreen;
            buttonCenter.Tag = WindowSizePosition.Center;
            buttonNextDisplay.Tag = WindowSizePosition.NextScreen;
            buttonPreviousDisplay.Tag = WindowSizePosition.PreviousScreen;

            buttonLeftHalf.Tag = WindowSizePosition.LeftHalf;
            buttonRightHalf.Tag = WindowSizePosition.RightHalf;
            buttonTopHalf.Tag = WindowSizePosition.TopHalf;
            buttonBottomHalf.Tag = WindowSizePosition.BottomHalf;

            buttonTopLeft.Tag = WindowSizePosition.TopLeft;
            buttonTopRight.Tag = WindowSizePosition.TopRight;
            buttonBottomLeft.Tag = WindowSizePosition.BottomLeft;
            buttonBottomRight.Tag = WindowSizePosition.BottomRight;
        }

        /// <summary>
        /// Handle open settings toolstrip
        /// </summary>
        private void OpenSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) 
                return;

            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void SettingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            labelFullscreen.Focus();
            FillTextBoxes(_HotkeyHandler.GetHotkeyMap());
        }

        private void SettingsForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) 
                return;

            MinimizeWindow();
        }

        private void SettingsIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Minimized;
                Show();
                WindowState = FormWindowState.Normal;
            }
            else
            {
                MinimizeWindow();
            }
        }

        private void MinimizeWindow()
        {
            WindowState = FormWindowState.Minimized;
            Hide();
            ShowBalloonTooltip();
        }

        private void SetWindowSize()
        {
            var width = 0;
            var height = 0;

            foreach (Control c in Controls)
            {
                if (c.Width + c.Location.X > width)
                {
                    width = c.Width + c.Location.X;
                }

                if (c.Height + c.Location.Y > height)
                {
                    height = c.Height + c.Location.Y;
                }
            }

            width += 25;
            height += 35;
            MinimumSize = new Size(width, height);
            MaximumSize = new Size(width, height);
        }

        private void ShowBalloonTooltip()
        {
            if (!Properties.Settings.Default.ShowNotifyIconBalloonInfo) 
                return;

            settingsIcon.ShowBalloonTip(3000);
            Properties.Settings.Default.ShowNotifyIconBalloonInfo = false;
            Properties.Settings.Default.Save();
        }

        private void TextBox_FocusEnter(object sender, EventArgs e)
        {
            var senderTextBox = (TextBox)sender;
            senderTextBox.Text = string.Empty;
            _HotkeyHandler.UnregisterHotkeys();
        }

        private void TextBox_FocusLeave(object sender, EventArgs e)
        {
            var senderTextBox = (TextBox)sender;
            senderTextBox.Text = string.Empty;
            senderTextBox.TabStop = false;
            _HotkeyHandler.RegisterHotkeys();
            FillTextBoxes(_HotkeyHandler.GetHotkeyMap());
        }

        private void UnmapButton_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            var windowSizePosition = (WindowSizePosition)clickedButton.Tag;
            _HotkeyHandler.UnmapHotkey(windowSizePosition);
            GetTextBoxByTag(windowSizePosition).Text = string.Empty;
        }

        private void TrackBarWindowBorder_Scroll(object sender, EventArgs e)
        {
            var senderTrackBar = (TrackBar)sender;
            textBoxWindowBorder.Text = senderTrackBar.Value.ToString(CultureInfo.CurrentCulture);
            Properties.Settings.Default.WindowBorder = senderTrackBar.Value;
            Properties.Settings.Default.Save();
        }
    }
}