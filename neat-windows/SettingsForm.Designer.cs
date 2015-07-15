namespace NeatWindows
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.settingsIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.settingsIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitNeatWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBottomRightQuarter = new System.Windows.Forms.Label();
            this.textBoxBottomRightQuarter = new System.Windows.Forms.TextBox();
            this.labelBottomLeftQuarter = new System.Windows.Forms.Label();
            this.textBoxBottomLeftQuarter = new System.Windows.Forms.TextBox();
            this.labelTopRightQuarter = new System.Windows.Forms.Label();
            this.textBoxTopRightQuarter = new System.Windows.Forms.TextBox();
            this.labelTopLeftQuarter = new System.Windows.Forms.Label();
            this.textBoxTopLeftQuarter = new System.Windows.Forms.TextBox();
            this.labelPreviousDisplay = new System.Windows.Forms.Label();
            this.textBoxPreviousDisplay = new System.Windows.Forms.TextBox();
            this.labelNextDisplay = new System.Windows.Forms.Label();
            this.textBoxNextDisplay = new System.Windows.Forms.TextBox();
            this.labelCenter = new System.Windows.Forms.Label();
            this.textBoxCenter = new System.Windows.Forms.TextBox();
            this.labelFullscreen = new System.Windows.Forms.Label();
            this.textBoxFullscreen = new System.Windows.Forms.TextBox();
            this.textBoxLeftHalf = new System.Windows.Forms.TextBox();
            this.labelLeftHalf = new System.Windows.Forms.Label();
            this.textBoxRightHalf = new System.Windows.Forms.TextBox();
            this.labelRightHalf = new System.Windows.Forms.Label();
            this.textBoxTopHalf = new System.Windows.Forms.TextBox();
            this.labelTopHalf = new System.Windows.Forms.Label();
            this.textBoxBottomHalf = new System.Windows.Forms.TextBox();
            this.labelBottomHalf = new System.Windows.Forms.Label();
            this.buttonFullscreen = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonNextDisplay = new System.Windows.Forms.Button();
            this.buttonPreviousDisplay = new System.Windows.Forms.Button();
            this.buttonLeftHalf = new System.Windows.Forms.Button();
            this.buttonRightHalf = new System.Windows.Forms.Button();
            this.buttonTopHalf = new System.Windows.Forms.Button();
            this.buttonBottomHalf = new System.Windows.Forms.Button();
            this.buttonTopLeft = new System.Windows.Forms.Button();
            this.buttonTopRight = new System.Windows.Forms.Button();
            this.buttonBottomLeft = new System.Windows.Forms.Button();
            this.buttonBottomRight = new System.Windows.Forms.Button();
            this.startupCheckbox = new System.Windows.Forms.CheckBox();
            this.settingsIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsIcon
            // 
            this.settingsIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.settingsIcon.BalloonTipText = "Neat Windows will run here when minimized. Double click the icon to reopen the se" +
    "ttings screen.";
            this.settingsIcon.BalloonTipTitle = "Neat Windows";
            this.settingsIcon.ContextMenuStrip = this.settingsIconContextMenu;
            this.settingsIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("settingsIcon.Icon")));
            this.settingsIcon.Text = "Neat Windows";
            this.settingsIcon.Visible = true;
            this.settingsIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.settingsIcon_MouseDoubleClick);
            // 
            // settingsIconContextMenu
            // 
            this.settingsIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSettingsToolStripMenuItem,
            this.exitNeatWindowsToolStripMenuItem});
            this.settingsIconContextMenu.Name = "settingsIconContextMenu";
            this.settingsIconContextMenu.Size = new System.Drawing.Size(173, 48);
            this.settingsIconContextMenu.Text = "asd";
            // 
            // openSettingsToolStripMenuItem
            // 
            this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openSettingsToolStripMenuItem.Text = "Open settings";
            this.openSettingsToolStripMenuItem.Click += new System.EventHandler(this.openSettingsToolStripMenuItem_Click);
            // 
            // exitNeatWindowsToolStripMenuItem
            // 
            this.exitNeatWindowsToolStripMenuItem.Name = "exitNeatWindowsToolStripMenuItem";
            this.exitNeatWindowsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitNeatWindowsToolStripMenuItem.Text = "Exit Neat Windows";
            this.exitNeatWindowsToolStripMenuItem.Click += new System.EventHandler(this.exitNeatWindowsToolStripMenuItem_Click);
            // 
            // labelBottomRightQuarter
            // 
            this.labelBottomRightQuarter.AutoSize = true;
            this.labelBottomRightQuarter.Location = new System.Drawing.Point(16, 355);
            this.labelBottomRightQuarter.Name = "labelBottomRightQuarter";
            this.labelBottomRightQuarter.Size = new System.Drawing.Size(140, 13);
            this.labelBottomRightQuarter.TabIndex = 7;
            this.labelBottomRightQuarter.Text = "Move to bottom right quarter";
            this.labelBottomRightQuarter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxBottomRightQuarter
            // 
            this.textBoxBottomRightQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBottomRightQuarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBottomRightQuarter.Location = new System.Drawing.Point(162, 353);
            this.textBoxBottomRightQuarter.Name = "textBoxBottomRightQuarter";
            this.textBoxBottomRightQuarter.ReadOnly = true;
            this.textBoxBottomRightQuarter.ShortcutsEnabled = false;
            this.textBoxBottomRightQuarter.Size = new System.Drawing.Size(181, 20);
            this.textBoxBottomRightQuarter.TabIndex = 6;
            this.textBoxBottomRightQuarter.TabStop = false;
            this.textBoxBottomRightQuarter.Tag = "BOTTOM_RIGHT";
            this.textBoxBottomRightQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBottomRightQuarter.WordWrap = false;
            this.textBoxBottomRightQuarter.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxBottomRightQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxBottomRightQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxBottomRightQuarter.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelBottomLeftQuarter
            // 
            this.labelBottomLeftQuarter.AutoSize = true;
            this.labelBottomLeftQuarter.Location = new System.Drawing.Point(22, 329);
            this.labelBottomLeftQuarter.Name = "labelBottomLeftQuarter";
            this.labelBottomLeftQuarter.Size = new System.Drawing.Size(134, 13);
            this.labelBottomLeftQuarter.TabIndex = 5;
            this.labelBottomLeftQuarter.Text = "Move to bottom left quarter";
            this.labelBottomLeftQuarter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxBottomLeftQuarter
            // 
            this.textBoxBottomLeftQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBottomLeftQuarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBottomLeftQuarter.Location = new System.Drawing.Point(162, 327);
            this.textBoxBottomLeftQuarter.Name = "textBoxBottomLeftQuarter";
            this.textBoxBottomLeftQuarter.ReadOnly = true;
            this.textBoxBottomLeftQuarter.ShortcutsEnabled = false;
            this.textBoxBottomLeftQuarter.Size = new System.Drawing.Size(181, 20);
            this.textBoxBottomLeftQuarter.TabIndex = 4;
            this.textBoxBottomLeftQuarter.TabStop = false;
            this.textBoxBottomLeftQuarter.Tag = "BOTTOM_LEFT";
            this.textBoxBottomLeftQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBottomLeftQuarter.WordWrap = false;
            this.textBoxBottomLeftQuarter.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxBottomLeftQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxBottomLeftQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxBottomLeftQuarter.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelTopRightQuarter
            // 
            this.labelTopRightQuarter.AutoSize = true;
            this.labelTopRightQuarter.Location = new System.Drawing.Point(33, 303);
            this.labelTopRightQuarter.Name = "labelTopRightQuarter";
            this.labelTopRightQuarter.Size = new System.Drawing.Size(123, 13);
            this.labelTopRightQuarter.TabIndex = 3;
            this.labelTopRightQuarter.Text = "Move to top right quarter";
            this.labelTopRightQuarter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxTopRightQuarter
            // 
            this.textBoxTopRightQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTopRightQuarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTopRightQuarter.Location = new System.Drawing.Point(162, 301);
            this.textBoxTopRightQuarter.Name = "textBoxTopRightQuarter";
            this.textBoxTopRightQuarter.ReadOnly = true;
            this.textBoxTopRightQuarter.ShortcutsEnabled = false;
            this.textBoxTopRightQuarter.Size = new System.Drawing.Size(181, 20);
            this.textBoxTopRightQuarter.TabIndex = 2;
            this.textBoxTopRightQuarter.TabStop = false;
            this.textBoxTopRightQuarter.Tag = "TOP_RIGHT";
            this.textBoxTopRightQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTopRightQuarter.WordWrap = false;
            this.textBoxTopRightQuarter.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxTopRightQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxTopRightQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxTopRightQuarter.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelTopLeftQuarter
            // 
            this.labelTopLeftQuarter.AutoSize = true;
            this.labelTopLeftQuarter.Location = new System.Drawing.Point(39, 277);
            this.labelTopLeftQuarter.Name = "labelTopLeftQuarter";
            this.labelTopLeftQuarter.Size = new System.Drawing.Size(117, 13);
            this.labelTopLeftQuarter.TabIndex = 1;
            this.labelTopLeftQuarter.Text = "Move to top left quarter";
            this.labelTopLeftQuarter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxTopLeftQuarter
            // 
            this.textBoxTopLeftQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTopLeftQuarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTopLeftQuarter.Location = new System.Drawing.Point(162, 275);
            this.textBoxTopLeftQuarter.Name = "textBoxTopLeftQuarter";
            this.textBoxTopLeftQuarter.ReadOnly = true;
            this.textBoxTopLeftQuarter.ShortcutsEnabled = false;
            this.textBoxTopLeftQuarter.Size = new System.Drawing.Size(181, 20);
            this.textBoxTopLeftQuarter.TabIndex = 0;
            this.textBoxTopLeftQuarter.TabStop = false;
            this.textBoxTopLeftQuarter.Tag = "TOP_LEFT";
            this.textBoxTopLeftQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTopLeftQuarter.WordWrap = false;
            this.textBoxTopLeftQuarter.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxTopLeftQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxTopLeftQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxTopLeftQuarter.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelPreviousDisplay
            // 
            this.labelPreviousDisplay.AutoSize = true;
            this.labelPreviousDisplay.Location = new System.Drawing.Point(32, 95);
            this.labelPreviousDisplay.Name = "labelPreviousDisplay";
            this.labelPreviousDisplay.Size = new System.Drawing.Size(124, 13);
            this.labelPreviousDisplay.TabIndex = 7;
            this.labelPreviousDisplay.Text = "Move to previous display";
            this.labelPreviousDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPreviousDisplay
            // 
            this.textBoxPreviousDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPreviousDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPreviousDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreviousDisplay.Location = new System.Drawing.Point(162, 93);
            this.textBoxPreviousDisplay.Name = "textBoxPreviousDisplay";
            this.textBoxPreviousDisplay.ReadOnly = true;
            this.textBoxPreviousDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPreviousDisplay.ShortcutsEnabled = false;
            this.textBoxPreviousDisplay.Size = new System.Drawing.Size(181, 20);
            this.textBoxPreviousDisplay.TabIndex = 6;
            this.textBoxPreviousDisplay.TabStop = false;
            this.textBoxPreviousDisplay.Tag = "PREVIOUS_SCREEN";
            this.textBoxPreviousDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPreviousDisplay.WordWrap = false;
            this.textBoxPreviousDisplay.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxPreviousDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxPreviousDisplay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxPreviousDisplay.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelNextDisplay
            // 
            this.labelNextDisplay.AutoSize = true;
            this.labelNextDisplay.Location = new System.Drawing.Point(52, 69);
            this.labelNextDisplay.Name = "labelNextDisplay";
            this.labelNextDisplay.Size = new System.Drawing.Size(104, 13);
            this.labelNextDisplay.TabIndex = 5;
            this.labelNextDisplay.Text = "Move to next display";
            this.labelNextDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNextDisplay
            // 
            this.textBoxNextDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNextDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNextDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNextDisplay.Location = new System.Drawing.Point(162, 67);
            this.textBoxNextDisplay.Name = "textBoxNextDisplay";
            this.textBoxNextDisplay.ReadOnly = true;
            this.textBoxNextDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxNextDisplay.ShortcutsEnabled = false;
            this.textBoxNextDisplay.Size = new System.Drawing.Size(181, 20);
            this.textBoxNextDisplay.TabIndex = 4;
            this.textBoxNextDisplay.TabStop = false;
            this.textBoxNextDisplay.Tag = "NEXT_SCREEN";
            this.textBoxNextDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNextDisplay.WordWrap = false;
            this.textBoxNextDisplay.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxNextDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxNextDisplay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxNextDisplay.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelCenter
            // 
            this.labelCenter.AutoSize = true;
            this.labelCenter.Location = new System.Drawing.Point(118, 43);
            this.labelCenter.Name = "labelCenter";
            this.labelCenter.Size = new System.Drawing.Size(38, 13);
            this.labelCenter.TabIndex = 3;
            this.labelCenter.Text = "Center";
            this.labelCenter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCenter
            // 
            this.textBoxCenter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCenter.Location = new System.Drawing.Point(162, 41);
            this.textBoxCenter.Name = "textBoxCenter";
            this.textBoxCenter.ReadOnly = true;
            this.textBoxCenter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCenter.ShortcutsEnabled = false;
            this.textBoxCenter.Size = new System.Drawing.Size(181, 20);
            this.textBoxCenter.TabIndex = 2;
            this.textBoxCenter.TabStop = false;
            this.textBoxCenter.Tag = "CENTER";
            this.textBoxCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCenter.WordWrap = false;
            this.textBoxCenter.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxCenter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxCenter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxCenter.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelFullscreen
            // 
            this.labelFullscreen.AutoSize = true;
            this.labelFullscreen.Location = new System.Drawing.Point(101, 17);
            this.labelFullscreen.Name = "labelFullscreen";
            this.labelFullscreen.Size = new System.Drawing.Size(55, 13);
            this.labelFullscreen.TabIndex = 1;
            this.labelFullscreen.Text = "Fullscreen";
            this.labelFullscreen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxFullscreen
            // 
            this.textBoxFullscreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFullscreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullscreen.Location = new System.Drawing.Point(162, 15);
            this.textBoxFullscreen.Name = "textBoxFullscreen";
            this.textBoxFullscreen.ReadOnly = true;
            this.textBoxFullscreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFullscreen.ShortcutsEnabled = false;
            this.textBoxFullscreen.Size = new System.Drawing.Size(181, 20);
            this.textBoxFullscreen.TabIndex = 0;
            this.textBoxFullscreen.TabStop = false;
            this.textBoxFullscreen.Tag = "FULLSCREEN";
            this.textBoxFullscreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFullscreen.WordWrap = false;
            this.textBoxFullscreen.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxFullscreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxFullscreen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxFullscreen.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // textBoxLeftHalf
            // 
            this.textBoxLeftHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLeftHalf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLeftHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLeftHalf.Location = new System.Drawing.Point(162, 145);
            this.textBoxLeftHalf.Name = "textBoxLeftHalf";
            this.textBoxLeftHalf.ReadOnly = true;
            this.textBoxLeftHalf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxLeftHalf.ShortcutsEnabled = false;
            this.textBoxLeftHalf.Size = new System.Drawing.Size(181, 20);
            this.textBoxLeftHalf.TabIndex = 0;
            this.textBoxLeftHalf.TabStop = false;
            this.textBoxLeftHalf.Tag = "LEFT_HALF";
            this.textBoxLeftHalf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLeftHalf.WordWrap = false;
            this.textBoxLeftHalf.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxLeftHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxLeftHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxLeftHalf.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelLeftHalf
            // 
            this.labelLeftHalf.AutoSize = true;
            this.labelLeftHalf.Location = new System.Drawing.Point(73, 147);
            this.labelLeftHalf.Name = "labelLeftHalf";
            this.labelLeftHalf.Size = new System.Drawing.Size(83, 13);
            this.labelLeftHalf.TabIndex = 1;
            this.labelLeftHalf.Text = "Move to left half";
            this.labelLeftHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxRightHalf
            // 
            this.textBoxRightHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxRightHalf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRightHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRightHalf.Location = new System.Drawing.Point(162, 171);
            this.textBoxRightHalf.Name = "textBoxRightHalf";
            this.textBoxRightHalf.ReadOnly = true;
            this.textBoxRightHalf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxRightHalf.ShortcutsEnabled = false;
            this.textBoxRightHalf.Size = new System.Drawing.Size(181, 20);
            this.textBoxRightHalf.TabIndex = 2;
            this.textBoxRightHalf.TabStop = false;
            this.textBoxRightHalf.Tag = "RIGHT_HALF";
            this.textBoxRightHalf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRightHalf.WordWrap = false;
            this.textBoxRightHalf.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxRightHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxRightHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxRightHalf.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelRightHalf
            // 
            this.labelRightHalf.AutoSize = true;
            this.labelRightHalf.Location = new System.Drawing.Point(67, 173);
            this.labelRightHalf.Name = "labelRightHalf";
            this.labelRightHalf.Size = new System.Drawing.Size(89, 13);
            this.labelRightHalf.TabIndex = 3;
            this.labelRightHalf.Text = "Move to right half";
            this.labelRightHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxTopHalf
            // 
            this.textBoxTopHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTopHalf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTopHalf.Location = new System.Drawing.Point(162, 197);
            this.textBoxTopHalf.Name = "textBoxTopHalf";
            this.textBoxTopHalf.ReadOnly = true;
            this.textBoxTopHalf.ShortcutsEnabled = false;
            this.textBoxTopHalf.Size = new System.Drawing.Size(181, 20);
            this.textBoxTopHalf.TabIndex = 4;
            this.textBoxTopHalf.TabStop = false;
            this.textBoxTopHalf.Tag = "TOP_HALF";
            this.textBoxTopHalf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTopHalf.WordWrap = false;
            this.textBoxTopHalf.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxTopHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxTopHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxTopHalf.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelTopHalf
            // 
            this.labelTopHalf.AutoSize = true;
            this.labelTopHalf.Location = new System.Drawing.Point(72, 199);
            this.labelTopHalf.Name = "labelTopHalf";
            this.labelTopHalf.Size = new System.Drawing.Size(84, 13);
            this.labelTopHalf.TabIndex = 5;
            this.labelTopHalf.Text = "Move to top half";
            this.labelTopHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxBottomHalf
            // 
            this.textBoxBottomHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBottomHalf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBottomHalf.Location = new System.Drawing.Point(162, 223);
            this.textBoxBottomHalf.Name = "textBoxBottomHalf";
            this.textBoxBottomHalf.ReadOnly = true;
            this.textBoxBottomHalf.ShortcutsEnabled = false;
            this.textBoxBottomHalf.Size = new System.Drawing.Size(181, 20);
            this.textBoxBottomHalf.TabIndex = 6;
            this.textBoxBottomHalf.TabStop = false;
            this.textBoxBottomHalf.Tag = "BOTTOM_HALF";
            this.textBoxBottomHalf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBottomHalf.WordWrap = false;
            this.textBoxBottomHalf.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxBottomHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxBottomHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxBottomHalf.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelBottomHalf
            // 
            this.labelBottomHalf.AutoSize = true;
            this.labelBottomHalf.Location = new System.Drawing.Point(55, 225);
            this.labelBottomHalf.Name = "labelBottomHalf";
            this.labelBottomHalf.Size = new System.Drawing.Size(101, 13);
            this.labelBottomHalf.TabIndex = 7;
            this.labelBottomHalf.Text = "Move to bottom half";
            this.labelBottomHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonFullscreen
            // 
            this.buttonFullscreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFullscreen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFullscreen.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonFullscreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonFullscreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFullscreen.Image = ((System.Drawing.Image)(resources.GetObject("buttonFullscreen.Image")));
            this.buttonFullscreen.Location = new System.Drawing.Point(349, 15);
            this.buttonFullscreen.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFullscreen.Name = "buttonFullscreen";
            this.buttonFullscreen.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonFullscreen.Size = new System.Drawing.Size(20, 20);
            this.buttonFullscreen.TabIndex = 8;
            this.buttonFullscreen.TabStop = false;
            this.buttonFullscreen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonFullscreen.UseVisualStyleBackColor = false;
            this.buttonFullscreen.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCenter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCenter.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCenter.Image = ((System.Drawing.Image)(resources.GetObject("buttonCenter.Image")));
            this.buttonCenter.Location = new System.Drawing.Point(349, 41);
            this.buttonCenter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonCenter.Size = new System.Drawing.Size(20, 20);
            this.buttonCenter.TabIndex = 9;
            this.buttonCenter.TabStop = false;
            this.buttonCenter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonCenter.UseVisualStyleBackColor = false;
            this.buttonCenter.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonNextDisplay
            // 
            this.buttonNextDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNextDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonNextDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonNextDisplay.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonNextDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonNextDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNextDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextDisplay.Image = ((System.Drawing.Image)(resources.GetObject("buttonNextDisplay.Image")));
            this.buttonNextDisplay.Location = new System.Drawing.Point(349, 67);
            this.buttonNextDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNextDisplay.Name = "buttonNextDisplay";
            this.buttonNextDisplay.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonNextDisplay.Size = new System.Drawing.Size(20, 20);
            this.buttonNextDisplay.TabIndex = 10;
            this.buttonNextDisplay.TabStop = false;
            this.buttonNextDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonNextDisplay.UseVisualStyleBackColor = false;
            this.buttonNextDisplay.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonPreviousDisplay
            // 
            this.buttonPreviousDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPreviousDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPreviousDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPreviousDisplay.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonPreviousDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonPreviousDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPreviousDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousDisplay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPreviousDisplay.Image")));
            this.buttonPreviousDisplay.Location = new System.Drawing.Point(349, 93);
            this.buttonPreviousDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPreviousDisplay.Name = "buttonPreviousDisplay";
            this.buttonPreviousDisplay.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonPreviousDisplay.Size = new System.Drawing.Size(20, 20);
            this.buttonPreviousDisplay.TabIndex = 11;
            this.buttonPreviousDisplay.TabStop = false;
            this.buttonPreviousDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonPreviousDisplay.UseVisualStyleBackColor = false;
            this.buttonPreviousDisplay.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonLeftHalf
            // 
            this.buttonLeftHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLeftHalf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLeftHalf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLeftHalf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonLeftHalf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonLeftHalf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLeftHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeftHalf.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeftHalf.Image")));
            this.buttonLeftHalf.Location = new System.Drawing.Point(349, 145);
            this.buttonLeftHalf.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLeftHalf.Name = "buttonLeftHalf";
            this.buttonLeftHalf.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonLeftHalf.Size = new System.Drawing.Size(20, 20);
            this.buttonLeftHalf.TabIndex = 12;
            this.buttonLeftHalf.TabStop = false;
            this.buttonLeftHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonLeftHalf.UseVisualStyleBackColor = false;
            this.buttonLeftHalf.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonRightHalf
            // 
            this.buttonRightHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRightHalf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRightHalf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRightHalf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonRightHalf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonRightHalf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRightHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRightHalf.Image = ((System.Drawing.Image)(resources.GetObject("buttonRightHalf.Image")));
            this.buttonRightHalf.Location = new System.Drawing.Point(349, 171);
            this.buttonRightHalf.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRightHalf.Name = "buttonRightHalf";
            this.buttonRightHalf.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonRightHalf.Size = new System.Drawing.Size(20, 20);
            this.buttonRightHalf.TabIndex = 13;
            this.buttonRightHalf.TabStop = false;
            this.buttonRightHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonRightHalf.UseVisualStyleBackColor = false;
            this.buttonRightHalf.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonTopHalf
            // 
            this.buttonTopHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTopHalf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTopHalf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTopHalf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonTopHalf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonTopHalf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTopHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTopHalf.Image = ((System.Drawing.Image)(resources.GetObject("buttonTopHalf.Image")));
            this.buttonTopHalf.Location = new System.Drawing.Point(349, 197);
            this.buttonTopHalf.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTopHalf.Name = "buttonTopHalf";
            this.buttonTopHalf.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonTopHalf.Size = new System.Drawing.Size(20, 20);
            this.buttonTopHalf.TabIndex = 14;
            this.buttonTopHalf.TabStop = false;
            this.buttonTopHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonTopHalf.UseVisualStyleBackColor = false;
            this.buttonTopHalf.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonBottomHalf
            // 
            this.buttonBottomHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBottomHalf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBottomHalf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBottomHalf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonBottomHalf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonBottomHalf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBottomHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBottomHalf.Image = ((System.Drawing.Image)(resources.GetObject("buttonBottomHalf.Image")));
            this.buttonBottomHalf.Location = new System.Drawing.Point(349, 223);
            this.buttonBottomHalf.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBottomHalf.Name = "buttonBottomHalf";
            this.buttonBottomHalf.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonBottomHalf.Size = new System.Drawing.Size(20, 20);
            this.buttonBottomHalf.TabIndex = 15;
            this.buttonBottomHalf.TabStop = false;
            this.buttonBottomHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonBottomHalf.UseVisualStyleBackColor = false;
            this.buttonBottomHalf.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonTopLeft
            // 
            this.buttonTopLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTopLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTopLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTopLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonTopLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonTopLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTopLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonTopLeft.Image")));
            this.buttonTopLeft.Location = new System.Drawing.Point(349, 275);
            this.buttonTopLeft.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTopLeft.Name = "buttonTopLeft";
            this.buttonTopLeft.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonTopLeft.Size = new System.Drawing.Size(20, 20);
            this.buttonTopLeft.TabIndex = 16;
            this.buttonTopLeft.TabStop = false;
            this.buttonTopLeft.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonTopLeft.UseVisualStyleBackColor = false;
            this.buttonTopLeft.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonTopRight
            // 
            this.buttonTopRight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTopRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTopRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTopRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonTopRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonTopRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTopRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTopRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonTopRight.Image")));
            this.buttonTopRight.Location = new System.Drawing.Point(349, 301);
            this.buttonTopRight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTopRight.Name = "buttonTopRight";
            this.buttonTopRight.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonTopRight.Size = new System.Drawing.Size(20, 20);
            this.buttonTopRight.TabIndex = 17;
            this.buttonTopRight.TabStop = false;
            this.buttonTopRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonTopRight.UseVisualStyleBackColor = false;
            this.buttonTopRight.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonBottomLeft
            // 
            this.buttonBottomLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBottomLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBottomLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBottomLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonBottomLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonBottomLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBottomLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonBottomLeft.Image")));
            this.buttonBottomLeft.Location = new System.Drawing.Point(349, 327);
            this.buttonBottomLeft.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBottomLeft.Name = "buttonBottomLeft";
            this.buttonBottomLeft.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonBottomLeft.Size = new System.Drawing.Size(20, 20);
            this.buttonBottomLeft.TabIndex = 18;
            this.buttonBottomLeft.TabStop = false;
            this.buttonBottomLeft.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonBottomLeft.UseVisualStyleBackColor = false;
            this.buttonBottomLeft.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonBottomRight
            // 
            this.buttonBottomRight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBottomRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBottomRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBottomRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonBottomRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonBottomRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBottomRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonBottomRight.Image")));
            this.buttonBottomRight.Location = new System.Drawing.Point(349, 353);
            this.buttonBottomRight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBottomRight.Name = "buttonBottomRight";
            this.buttonBottomRight.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.buttonBottomRight.Size = new System.Drawing.Size(20, 20);
            this.buttonBottomRight.TabIndex = 19;
            this.buttonBottomRight.TabStop = false;
            this.buttonBottomRight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonBottomRight.UseVisualStyleBackColor = false;
            this.buttonBottomRight.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // startupCheckbox
            // 
            this.startupCheckbox.AutoSize = true;
            this.startupCheckbox.Location = new System.Drawing.Point(217, 392);
            this.startupCheckbox.Name = "startupCheckbox";
            this.startupCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startupCheckbox.Size = new System.Drawing.Size(152, 17);
            this.startupCheckbox.TabIndex = 20;
            this.startupCheckbox.Text = "Start when Windows starts";
            this.startupCheckbox.UseVisualStyleBackColor = true;
            this.startupCheckbox.CheckedChanged += new System.EventHandler(this.checkBoxStartAtLogin_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 421);
            this.Controls.Add(this.startupCheckbox);
            this.Controls.Add(this.buttonBottomRight);
            this.Controls.Add(this.buttonBottomLeft);
            this.Controls.Add(this.buttonTopRight);
            this.Controls.Add(this.buttonTopLeft);
            this.Controls.Add(this.buttonBottomHalf);
            this.Controls.Add(this.buttonTopHalf);
            this.Controls.Add(this.buttonRightHalf);
            this.Controls.Add(this.buttonLeftHalf);
            this.Controls.Add(this.buttonPreviousDisplay);
            this.Controls.Add(this.buttonNextDisplay);
            this.Controls.Add(this.buttonCenter);
            this.Controls.Add(this.buttonFullscreen);
            this.Controls.Add(this.labelBottomRightQuarter);
            this.Controls.Add(this.labelBottomHalf);
            this.Controls.Add(this.textBoxBottomRightQuarter);
            this.Controls.Add(this.labelPreviousDisplay);
            this.Controls.Add(this.labelBottomLeftQuarter);
            this.Controls.Add(this.textBoxBottomHalf);
            this.Controls.Add(this.textBoxBottomLeftQuarter);
            this.Controls.Add(this.textBoxPreviousDisplay);
            this.Controls.Add(this.labelTopRightQuarter);
            this.Controls.Add(this.labelTopHalf);
            this.Controls.Add(this.textBoxTopRightQuarter);
            this.Controls.Add(this.labelTopLeftQuarter);
            this.Controls.Add(this.textBoxTopLeftQuarter);
            this.Controls.Add(this.textBoxTopHalf);
            this.Controls.Add(this.labelNextDisplay);
            this.Controls.Add(this.labelRightHalf);
            this.Controls.Add(this.textBoxRightHalf);
            this.Controls.Add(this.textBoxNextDisplay);
            this.Controls.Add(this.labelLeftHalf);
            this.Controls.Add(this.textBoxLeftHalf);
            this.Controls.Add(this.labelCenter);
            this.Controls.Add(this.textBoxFullscreen);
            this.Controls.Add(this.textBoxCenter);
            this.Controls.Add(this.labelFullscreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 460);
            this.MinimumSize = new System.Drawing.Size(400, 460);
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neat Windows";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseDown);
            this.Resize += new System.EventHandler(this.SettingsForm_Resize);
            this.settingsIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon settingsIcon;
        private System.Windows.Forms.Label labelBottomRightQuarter;
        private System.Windows.Forms.TextBox textBoxBottomRightQuarter;
        private System.Windows.Forms.Label labelBottomLeftQuarter;
        private System.Windows.Forms.TextBox textBoxBottomLeftQuarter;
        private System.Windows.Forms.Label labelTopRightQuarter;
        private System.Windows.Forms.TextBox textBoxTopRightQuarter;
        private System.Windows.Forms.Label labelTopLeftQuarter;
        private System.Windows.Forms.TextBox textBoxTopLeftQuarter;
        private System.Windows.Forms.Label labelPreviousDisplay;
        private System.Windows.Forms.TextBox textBoxPreviousDisplay;
        private System.Windows.Forms.Label labelNextDisplay;
        private System.Windows.Forms.TextBox textBoxNextDisplay;
        private System.Windows.Forms.Label labelCenter;
        private System.Windows.Forms.TextBox textBoxCenter;
        private System.Windows.Forms.Label labelFullscreen;
        private System.Windows.Forms.TextBox textBoxFullscreen;
        private System.Windows.Forms.TextBox textBoxLeftHalf;
        private System.Windows.Forms.Label labelLeftHalf;
        private System.Windows.Forms.TextBox textBoxRightHalf;
        private System.Windows.Forms.Label labelRightHalf;
        private System.Windows.Forms.TextBox textBoxTopHalf;
        private System.Windows.Forms.Label labelTopHalf;
        private System.Windows.Forms.TextBox textBoxBottomHalf;
        private System.Windows.Forms.Label labelBottomHalf;
        private System.Windows.Forms.Button buttonFullscreen;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button buttonNextDisplay;
        private System.Windows.Forms.Button buttonPreviousDisplay;
        private System.Windows.Forms.Button buttonLeftHalf;
        private System.Windows.Forms.Button buttonRightHalf;
        private System.Windows.Forms.Button buttonTopHalf;
        private System.Windows.Forms.Button buttonBottomHalf;
        private System.Windows.Forms.Button buttonTopLeft;
        private System.Windows.Forms.Button buttonTopRight;
        private System.Windows.Forms.Button buttonBottomLeft;
        private System.Windows.Forms.Button buttonBottomRight;
        private System.Windows.Forms.ContextMenuStrip settingsIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitNeatWindowsToolStripMenuItem;
        private System.Windows.Forms.CheckBox startupCheckbox;

    }
}

