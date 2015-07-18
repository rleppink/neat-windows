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
            this.trackBarWindowBorder = new System.Windows.Forms.TrackBar();
            this.labelWindowBorder = new System.Windows.Forms.Label();
            this.textBoxWindowBorder = new System.Windows.Forms.TextBox();
            this.settingsIconContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindowBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsIcon
            // 
            this.settingsIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.settingsIcon, "settingsIcon");
            this.settingsIcon.ContextMenuStrip = this.settingsIconContextMenu;
            this.settingsIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SettingsIcon_MouseDoubleClick);
            // 
            // settingsIconContextMenu
            // 
            this.settingsIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSettingsToolStripMenuItem,
            this.exitNeatWindowsToolStripMenuItem});
            this.settingsIconContextMenu.Name = "settingsIconContextMenu";
            resources.ApplyResources(this.settingsIconContextMenu, "settingsIconContextMenu");
            // 
            // openSettingsToolStripMenuItem
            // 
            this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            resources.ApplyResources(this.openSettingsToolStripMenuItem, "openSettingsToolStripMenuItem");
            this.openSettingsToolStripMenuItem.Click += new System.EventHandler(this.OpenSettingsToolStripMenuItem_Click);
            // 
            // exitNeatWindowsToolStripMenuItem
            // 
            this.exitNeatWindowsToolStripMenuItem.Name = "exitNeatWindowsToolStripMenuItem";
            resources.ApplyResources(this.exitNeatWindowsToolStripMenuItem, "exitNeatWindowsToolStripMenuItem");
            this.exitNeatWindowsToolStripMenuItem.Click += new System.EventHandler(this.ExitNeatWindowsToolStripMenuItem_Click);
            // 
            // labelBottomRightQuarter
            // 
            resources.ApplyResources(this.labelBottomRightQuarter, "labelBottomRightQuarter");
            this.labelBottomRightQuarter.Name = "labelBottomRightQuarter";
            // 
            // textBoxBottomRightQuarter
            // 
            this.textBoxBottomRightQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBottomRightQuarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxBottomRightQuarter, "textBoxBottomRightQuarter");
            this.textBoxBottomRightQuarter.Name = "textBoxBottomRightQuarter";
            this.textBoxBottomRightQuarter.ReadOnly = true;
            this.textBoxBottomRightQuarter.ShortcutsEnabled = false;
            this.textBoxBottomRightQuarter.TabStop = false;
            this.textBoxBottomRightQuarter.Tag = "BOTTOM_RIGHT";
            this.textBoxBottomRightQuarter.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxBottomRightQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxBottomRightQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxBottomRightQuarter.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelBottomLeftQuarter
            // 
            resources.ApplyResources(this.labelBottomLeftQuarter, "labelBottomLeftQuarter");
            this.labelBottomLeftQuarter.Name = "labelBottomLeftQuarter";
            // 
            // textBoxBottomLeftQuarter
            // 
            this.textBoxBottomLeftQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBottomLeftQuarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxBottomLeftQuarter, "textBoxBottomLeftQuarter");
            this.textBoxBottomLeftQuarter.Name = "textBoxBottomLeftQuarter";
            this.textBoxBottomLeftQuarter.ReadOnly = true;
            this.textBoxBottomLeftQuarter.ShortcutsEnabled = false;
            this.textBoxBottomLeftQuarter.TabStop = false;
            this.textBoxBottomLeftQuarter.Tag = "BOTTOM_LEFT";
            this.textBoxBottomLeftQuarter.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxBottomLeftQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxBottomLeftQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxBottomLeftQuarter.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelTopRightQuarter
            // 
            resources.ApplyResources(this.labelTopRightQuarter, "labelTopRightQuarter");
            this.labelTopRightQuarter.Name = "labelTopRightQuarter";
            // 
            // textBoxTopRightQuarter
            // 
            this.textBoxTopRightQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTopRightQuarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxTopRightQuarter, "textBoxTopRightQuarter");
            this.textBoxTopRightQuarter.Name = "textBoxTopRightQuarter";
            this.textBoxTopRightQuarter.ReadOnly = true;
            this.textBoxTopRightQuarter.ShortcutsEnabled = false;
            this.textBoxTopRightQuarter.TabStop = false;
            this.textBoxTopRightQuarter.Tag = "TOP_RIGHT";
            this.textBoxTopRightQuarter.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxTopRightQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxTopRightQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxTopRightQuarter.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelTopLeftQuarter
            // 
            resources.ApplyResources(this.labelTopLeftQuarter, "labelTopLeftQuarter");
            this.labelTopLeftQuarter.Name = "labelTopLeftQuarter";
            // 
            // textBoxTopLeftQuarter
            // 
            this.textBoxTopLeftQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTopLeftQuarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxTopLeftQuarter, "textBoxTopLeftQuarter");
            this.textBoxTopLeftQuarter.Name = "textBoxTopLeftQuarter";
            this.textBoxTopLeftQuarter.ReadOnly = true;
            this.textBoxTopLeftQuarter.ShortcutsEnabled = false;
            this.textBoxTopLeftQuarter.TabStop = false;
            this.textBoxTopLeftQuarter.Tag = "TOP_LEFT";
            this.textBoxTopLeftQuarter.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxTopLeftQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxTopLeftQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxTopLeftQuarter.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelPreviousDisplay
            // 
            resources.ApplyResources(this.labelPreviousDisplay, "labelPreviousDisplay");
            this.labelPreviousDisplay.Name = "labelPreviousDisplay";
            // 
            // textBoxPreviousDisplay
            // 
            this.textBoxPreviousDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPreviousDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxPreviousDisplay, "textBoxPreviousDisplay");
            this.textBoxPreviousDisplay.Name = "textBoxPreviousDisplay";
            this.textBoxPreviousDisplay.ReadOnly = true;
            this.textBoxPreviousDisplay.ShortcutsEnabled = false;
            this.textBoxPreviousDisplay.TabStop = false;
            this.textBoxPreviousDisplay.Tag = "PREVIOUS_SCREEN";
            this.textBoxPreviousDisplay.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxPreviousDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxPreviousDisplay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxPreviousDisplay.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelNextDisplay
            // 
            resources.ApplyResources(this.labelNextDisplay, "labelNextDisplay");
            this.labelNextDisplay.Name = "labelNextDisplay";
            // 
            // textBoxNextDisplay
            // 
            this.textBoxNextDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNextDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxNextDisplay, "textBoxNextDisplay");
            this.textBoxNextDisplay.Name = "textBoxNextDisplay";
            this.textBoxNextDisplay.ReadOnly = true;
            this.textBoxNextDisplay.ShortcutsEnabled = false;
            this.textBoxNextDisplay.TabStop = false;
            this.textBoxNextDisplay.Tag = "NEXT_SCREEN";
            this.textBoxNextDisplay.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxNextDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxNextDisplay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxNextDisplay.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelCenter
            // 
            resources.ApplyResources(this.labelCenter, "labelCenter");
            this.labelCenter.Name = "labelCenter";
            // 
            // textBoxCenter
            // 
            this.textBoxCenter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxCenter, "textBoxCenter");
            this.textBoxCenter.Name = "textBoxCenter";
            this.textBoxCenter.ReadOnly = true;
            this.textBoxCenter.ShortcutsEnabled = false;
            this.textBoxCenter.TabStop = false;
            this.textBoxCenter.Tag = "CENTER";
            this.textBoxCenter.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxCenter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxCenter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxCenter.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelFullscreen
            // 
            resources.ApplyResources(this.labelFullscreen, "labelFullscreen");
            this.labelFullscreen.Name = "labelFullscreen";
            // 
            // textBoxFullscreen
            // 
            this.textBoxFullscreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFullscreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxFullscreen, "textBoxFullscreen");
            this.textBoxFullscreen.Name = "textBoxFullscreen";
            this.textBoxFullscreen.ReadOnly = true;
            this.textBoxFullscreen.ShortcutsEnabled = false;
            this.textBoxFullscreen.TabStop = false;
            this.textBoxFullscreen.Tag = "FULLSCREEN";
            this.textBoxFullscreen.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxFullscreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxFullscreen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxFullscreen.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // textBoxLeftHalf
            // 
            this.textBoxLeftHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLeftHalf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxLeftHalf, "textBoxLeftHalf");
            this.textBoxLeftHalf.Name = "textBoxLeftHalf";
            this.textBoxLeftHalf.ReadOnly = true;
            this.textBoxLeftHalf.ShortcutsEnabled = false;
            this.textBoxLeftHalf.TabStop = false;
            this.textBoxLeftHalf.Tag = "LEFT_HALF";
            this.textBoxLeftHalf.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxLeftHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxLeftHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxLeftHalf.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelLeftHalf
            // 
            resources.ApplyResources(this.labelLeftHalf, "labelLeftHalf");
            this.labelLeftHalf.Name = "labelLeftHalf";
            // 
            // textBoxRightHalf
            // 
            this.textBoxRightHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxRightHalf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxRightHalf, "textBoxRightHalf");
            this.textBoxRightHalf.Name = "textBoxRightHalf";
            this.textBoxRightHalf.ReadOnly = true;
            this.textBoxRightHalf.ShortcutsEnabled = false;
            this.textBoxRightHalf.TabStop = false;
            this.textBoxRightHalf.Tag = "RIGHT_HALF";
            this.textBoxRightHalf.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxRightHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxRightHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxRightHalf.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelRightHalf
            // 
            resources.ApplyResources(this.labelRightHalf, "labelRightHalf");
            this.labelRightHalf.Name = "labelRightHalf";
            // 
            // textBoxTopHalf
            // 
            this.textBoxTopHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTopHalf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxTopHalf, "textBoxTopHalf");
            this.textBoxTopHalf.Name = "textBoxTopHalf";
            this.textBoxTopHalf.ReadOnly = true;
            this.textBoxTopHalf.ShortcutsEnabled = false;
            this.textBoxTopHalf.TabStop = false;
            this.textBoxTopHalf.Tag = "TOP_HALF";
            this.textBoxTopHalf.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxTopHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxTopHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxTopHalf.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelTopHalf
            // 
            resources.ApplyResources(this.labelTopHalf, "labelTopHalf");
            this.labelTopHalf.Name = "labelTopHalf";
            // 
            // textBoxBottomHalf
            // 
            this.textBoxBottomHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBottomHalf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxBottomHalf, "textBoxBottomHalf");
            this.textBoxBottomHalf.Name = "textBoxBottomHalf";
            this.textBoxBottomHalf.ReadOnly = true;
            this.textBoxBottomHalf.ShortcutsEnabled = false;
            this.textBoxBottomHalf.TabStop = false;
            this.textBoxBottomHalf.Tag = "BOTTOM_HALF";
            this.textBoxBottomHalf.Enter += new System.EventHandler(this.TextBox_FocusEnter);
            this.textBoxBottomHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxBottomHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            this.textBoxBottomHalf.Leave += new System.EventHandler(this.TextBox_FocusLeave);
            // 
            // labelBottomHalf
            // 
            resources.ApplyResources(this.labelBottomHalf, "labelBottomHalf");
            this.labelBottomHalf.Name = "labelBottomHalf";
            // 
            // buttonFullscreen
            // 
            this.buttonFullscreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonFullscreen, "buttonFullscreen");
            this.buttonFullscreen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFullscreen.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonFullscreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonFullscreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFullscreen.Name = "buttonFullscreen";
            this.buttonFullscreen.TabStop = false;
            this.buttonFullscreen.UseVisualStyleBackColor = false;
            this.buttonFullscreen.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonCenter, "buttonCenter");
            this.buttonCenter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCenter.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonCenter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.TabStop = false;
            this.buttonCenter.UseVisualStyleBackColor = false;
            this.buttonCenter.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonNextDisplay
            // 
            this.buttonNextDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonNextDisplay, "buttonNextDisplay");
            this.buttonNextDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonNextDisplay.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonNextDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonNextDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNextDisplay.Name = "buttonNextDisplay";
            this.buttonNextDisplay.TabStop = false;
            this.buttonNextDisplay.UseVisualStyleBackColor = false;
            this.buttonNextDisplay.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonPreviousDisplay
            // 
            this.buttonPreviousDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonPreviousDisplay, "buttonPreviousDisplay");
            this.buttonPreviousDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPreviousDisplay.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonPreviousDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonPreviousDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPreviousDisplay.Name = "buttonPreviousDisplay";
            this.buttonPreviousDisplay.TabStop = false;
            this.buttonPreviousDisplay.UseVisualStyleBackColor = false;
            this.buttonPreviousDisplay.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonLeftHalf
            // 
            this.buttonLeftHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonLeftHalf, "buttonLeftHalf");
            this.buttonLeftHalf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLeftHalf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonLeftHalf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonLeftHalf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLeftHalf.Name = "buttonLeftHalf";
            this.buttonLeftHalf.TabStop = false;
            this.buttonLeftHalf.UseVisualStyleBackColor = false;
            this.buttonLeftHalf.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonRightHalf
            // 
            this.buttonRightHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonRightHalf, "buttonRightHalf");
            this.buttonRightHalf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRightHalf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonRightHalf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonRightHalf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRightHalf.Name = "buttonRightHalf";
            this.buttonRightHalf.TabStop = false;
            this.buttonRightHalf.UseVisualStyleBackColor = false;
            this.buttonRightHalf.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonTopHalf
            // 
            this.buttonTopHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonTopHalf, "buttonTopHalf");
            this.buttonTopHalf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTopHalf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonTopHalf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonTopHalf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTopHalf.Name = "buttonTopHalf";
            this.buttonTopHalf.TabStop = false;
            this.buttonTopHalf.UseVisualStyleBackColor = false;
            this.buttonTopHalf.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonBottomHalf
            // 
            this.buttonBottomHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonBottomHalf, "buttonBottomHalf");
            this.buttonBottomHalf.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBottomHalf.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonBottomHalf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonBottomHalf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBottomHalf.Name = "buttonBottomHalf";
            this.buttonBottomHalf.TabStop = false;
            this.buttonBottomHalf.UseVisualStyleBackColor = false;
            this.buttonBottomHalf.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonTopLeft
            // 
            this.buttonTopLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonTopLeft, "buttonTopLeft");
            this.buttonTopLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTopLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonTopLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonTopLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTopLeft.Name = "buttonTopLeft";
            this.buttonTopLeft.TabStop = false;
            this.buttonTopLeft.UseVisualStyleBackColor = false;
            this.buttonTopLeft.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonTopRight
            // 
            this.buttonTopRight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonTopRight, "buttonTopRight");
            this.buttonTopRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTopRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonTopRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonTopRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTopRight.Name = "buttonTopRight";
            this.buttonTopRight.TabStop = false;
            this.buttonTopRight.UseVisualStyleBackColor = false;
            this.buttonTopRight.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonBottomLeft
            // 
            this.buttonBottomLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonBottomLeft, "buttonBottomLeft");
            this.buttonBottomLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBottomLeft.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonBottomLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonBottomLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBottomLeft.Name = "buttonBottomLeft";
            this.buttonBottomLeft.TabStop = false;
            this.buttonBottomLeft.UseVisualStyleBackColor = false;
            this.buttonBottomLeft.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // buttonBottomRight
            // 
            this.buttonBottomRight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonBottomRight, "buttonBottomRight");
            this.buttonBottomRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBottomRight.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonBottomRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonBottomRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBottomRight.Name = "buttonBottomRight";
            this.buttonBottomRight.TabStop = false;
            this.buttonBottomRight.UseVisualStyleBackColor = false;
            this.buttonBottomRight.Click += new System.EventHandler(this.UnmapButton_Click);
            // 
            // startupCheckbox
            // 
            resources.ApplyResources(this.startupCheckbox, "startupCheckbox");
            this.startupCheckbox.Name = "startupCheckbox";
            this.startupCheckbox.UseVisualStyleBackColor = true;
            this.startupCheckbox.CheckedChanged += new System.EventHandler(this.CheckBoxStartAtLogin_CheckedChanged);
            // 
            // trackBarWindowBorder
            // 
            resources.ApplyResources(this.trackBarWindowBorder, "trackBarWindowBorder");
            this.trackBarWindowBorder.Maximum = 20;
            this.trackBarWindowBorder.Name = "trackBarWindowBorder";
            this.trackBarWindowBorder.Scroll += new System.EventHandler(this.TrackBarWindowBorder_Scroll);
            // 
            // labelWindowBorder
            // 
            resources.ApplyResources(this.labelWindowBorder, "labelWindowBorder");
            this.labelWindowBorder.Name = "labelWindowBorder";
            // 
            // textBoxWindowBorder
            // 
            this.textBoxWindowBorder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxWindowBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxWindowBorder, "textBoxWindowBorder");
            this.textBoxWindowBorder.Name = "textBoxWindowBorder";
            this.textBoxWindowBorder.ReadOnly = true;
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxWindowBorder);
            this.Controls.Add(this.labelWindowBorder);
            this.Controls.Add(this.trackBarWindowBorder);
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
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseDown);
            this.Resize += new System.EventHandler(this.SettingsForm_Resize);
            this.settingsIconContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWindowBorder)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBarWindowBorder;
        private System.Windows.Forms.Label labelWindowBorder;
        private System.Windows.Forms.TextBox textBoxWindowBorder;

    }
}