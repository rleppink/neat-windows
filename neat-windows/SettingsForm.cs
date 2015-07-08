﻿using System;
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
            this.MapTags();
            this.FillTextBoxes(this.hotkeyHandler.GetHotkeyMap());
            labelFullscreen.Focus();
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

        #region Tag mapping
        private void MapTags()
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

            this.buttonFullscreen.Tag = WindowConstants.WindowSizePosition.FULLSCREEN;
            this.buttonCenter.Tag = WindowConstants.WindowSizePosition.CENTER;
            this.buttonNextDisplay.Tag = WindowConstants.WindowSizePosition.NEXT_SCREEN;
            this.buttonPreviousDisplay.Tag = WindowConstants.WindowSizePosition.PREVIOUS_SCREEN;

            this.buttonLeftHalf.Tag = WindowConstants.WindowSizePosition.LEFT_HALF;
            this.buttonRightHalf.Tag = WindowConstants.WindowSizePosition.RIGHT_HALF;
            this.buttonTopHalf.Tag = WindowConstants.WindowSizePosition.TOP_HALF;
            this.buttonBottomHalf.Tag = WindowConstants.WindowSizePosition.BOTTOM_HALF;

            this.buttonTopLeft.Tag = WindowConstants.WindowSizePosition.TOP_LEFT;
            this.buttonTopRight.Tag = WindowConstants.WindowSizePosition.TOP_RIGHT;
            this.buttonBottomLeft.Tag = WindowConstants.WindowSizePosition.BOTTOM_LEFT;
            this.buttonBottomRight.Tag = WindowConstants.WindowSizePosition.BOTTOM_RIGHT;
        }

        private TextBox GetTextBoxByTag(WindowConstants.WindowSizePosition windowSizePosition)
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() != typeof(TextBox))
                    continue;
                if (control.Tag.Equals(windowSizePosition))
                    return (TextBox)control;
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

        #region Context menu
        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void exitNeatWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion Context menu

        #region Textbox control
        public void FillTextBoxes(Dictionary<WindowConstants.WindowSizePosition, Hotkey> hotkeyMap)
        {
            foreach (KeyValuePair<WindowConstants.WindowSizePosition, Hotkey> hotkeyMapping in hotkeyMap) 
            {
                TextBox taggedTextBox = this.GetTextBoxByTag(hotkeyMapping.Key);
                if (taggedTextBox == null)
                {
                    Console.WriteLine("Null found for key: " + hotkeyMapping.Key.ToString());
                    continue;
                }

                taggedTextBox.Text = hotkeyMapping.Value.ToString();
            }
        }

        private void UnmapButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            WindowConstants.WindowSizePosition windowSizePosition = (WindowConstants.WindowSizePosition)clickedButton.Tag;
            this.hotkeyHandler.UnmapHotkey(windowSizePosition);
            this.GetTextBoxByTag(windowSizePosition).Text = "";
        }

        #endregion Textbox control

    }
}