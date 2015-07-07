namespace neat_windows
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
            this.groupBoxScreenHalves = new System.Windows.Forms.GroupBox();
            this.labelBottomHalf = new System.Windows.Forms.Label();
            this.textBoxBottomHalf = new System.Windows.Forms.TextBox();
            this.labelTopHalf = new System.Windows.Forms.Label();
            this.textBoxTopHalf = new System.Windows.Forms.TextBox();
            this.labelRightHalf = new System.Windows.Forms.Label();
            this.textBoxRightHalf = new System.Windows.Forms.TextBox();
            this.labelLeftHalf = new System.Windows.Forms.Label();
            this.textBoxLeftHalf = new System.Windows.Forms.TextBox();
            this.groupBoxScreenQuarters = new System.Windows.Forms.GroupBox();
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
            this.groupBoxScreenHalves.SuspendLayout();
            this.groupBoxScreenQuarters.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsIcon
            // 
            this.settingsIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("settingsIcon.Icon")));
            this.settingsIcon.Text = "Neat Windows";
            this.settingsIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.settingsIcon_MouseDoubleClick);
            // 
            // groupBoxScreenHalves
            // 
            this.groupBoxScreenHalves.Controls.Add(this.labelBottomHalf);
            this.groupBoxScreenHalves.Controls.Add(this.textBoxBottomHalf);
            this.groupBoxScreenHalves.Controls.Add(this.labelTopHalf);
            this.groupBoxScreenHalves.Controls.Add(this.textBoxTopHalf);
            this.groupBoxScreenHalves.Controls.Add(this.labelRightHalf);
            this.groupBoxScreenHalves.Controls.Add(this.textBoxRightHalf);
            this.groupBoxScreenHalves.Controls.Add(this.labelLeftHalf);
            this.groupBoxScreenHalves.Controls.Add(this.textBoxLeftHalf);
            this.groupBoxScreenHalves.Location = new System.Drawing.Point(10, 119);
            this.groupBoxScreenHalves.Name = "groupBoxScreenHalves";
            this.groupBoxScreenHalves.Size = new System.Drawing.Size(374, 121);
            this.groupBoxScreenHalves.TabIndex = 0;
            this.groupBoxScreenHalves.TabStop = false;
            this.groupBoxScreenHalves.Text = "Screen halves";
            // 
            // labelBottomHalf
            // 
            this.labelBottomHalf.AutoSize = true;
            this.labelBottomHalf.Location = new System.Drawing.Point(45, 94);
            this.labelBottomHalf.Name = "labelBottomHalf";
            this.labelBottomHalf.Size = new System.Drawing.Size(101, 13);
            this.labelBottomHalf.TabIndex = 7;
            this.labelBottomHalf.Text = "Move to bottom half";
            this.labelBottomHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxBottomHalf
            // 
            this.textBoxBottomHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBottomHalf.Location = new System.Drawing.Point(152, 91);
            this.textBoxBottomHalf.Name = "textBoxBottomHalf";
            this.textBoxBottomHalf.ReadOnly = true;
            this.textBoxBottomHalf.ShortcutsEnabled = false;
            this.textBoxBottomHalf.Size = new System.Drawing.Size(207, 20);
            this.textBoxBottomHalf.TabIndex = 6;
            this.textBoxBottomHalf.TabStop = false;
            this.textBoxBottomHalf.Tag = "BOTTOM_HALF";
            this.textBoxBottomHalf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBottomHalf.WordWrap = false;
            this.textBoxBottomHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxBottomHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // labelTopHalf
            // 
            this.labelTopHalf.AutoSize = true;
            this.labelTopHalf.Location = new System.Drawing.Point(62, 68);
            this.labelTopHalf.Name = "labelTopHalf";
            this.labelTopHalf.Size = new System.Drawing.Size(84, 13);
            this.labelTopHalf.TabIndex = 5;
            this.labelTopHalf.Text = "Move to top half";
            this.labelTopHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxTopHalf
            // 
            this.textBoxTopHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTopHalf.Location = new System.Drawing.Point(152, 65);
            this.textBoxTopHalf.Name = "textBoxTopHalf";
            this.textBoxTopHalf.ReadOnly = true;
            this.textBoxTopHalf.ShortcutsEnabled = false;
            this.textBoxTopHalf.Size = new System.Drawing.Size(207, 20);
            this.textBoxTopHalf.TabIndex = 4;
            this.textBoxTopHalf.TabStop = false;
            this.textBoxTopHalf.Tag = "TOP_HALF";
            this.textBoxTopHalf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTopHalf.WordWrap = false;
            this.textBoxTopHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxTopHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // labelRightHalf
            // 
            this.labelRightHalf.AutoSize = true;
            this.labelRightHalf.Location = new System.Drawing.Point(57, 42);
            this.labelRightHalf.Name = "labelRightHalf";
            this.labelRightHalf.Size = new System.Drawing.Size(89, 13);
            this.labelRightHalf.TabIndex = 3;
            this.labelRightHalf.Text = "Move to right half";
            this.labelRightHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxRightHalf
            // 
            this.textBoxRightHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxRightHalf.Location = new System.Drawing.Point(152, 39);
            this.textBoxRightHalf.Name = "textBoxRightHalf";
            this.textBoxRightHalf.ReadOnly = true;
            this.textBoxRightHalf.ShortcutsEnabled = false;
            this.textBoxRightHalf.Size = new System.Drawing.Size(207, 20);
            this.textBoxRightHalf.TabIndex = 2;
            this.textBoxRightHalf.TabStop = false;
            this.textBoxRightHalf.Tag = "RIGHT_HALF";
            this.textBoxRightHalf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRightHalf.WordWrap = false;
            this.textBoxRightHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxRightHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // labelLeftHalf
            // 
            this.labelLeftHalf.AutoSize = true;
            this.labelLeftHalf.Location = new System.Drawing.Point(63, 16);
            this.labelLeftHalf.Name = "labelLeftHalf";
            this.labelLeftHalf.Size = new System.Drawing.Size(83, 13);
            this.labelLeftHalf.TabIndex = 1;
            this.labelLeftHalf.Text = "Move to left half";
            this.labelLeftHalf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxLeftHalf
            // 
            this.textBoxLeftHalf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLeftHalf.Location = new System.Drawing.Point(152, 13);
            this.textBoxLeftHalf.Name = "textBoxLeftHalf";
            this.textBoxLeftHalf.ReadOnly = true;
            this.textBoxLeftHalf.ShortcutsEnabled = false;
            this.textBoxLeftHalf.Size = new System.Drawing.Size(207, 20);
            this.textBoxLeftHalf.TabIndex = 0;
            this.textBoxLeftHalf.TabStop = false;
            this.textBoxLeftHalf.Tag = "LEFT_HALF";
            this.textBoxLeftHalf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLeftHalf.WordWrap = false;
            this.textBoxLeftHalf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxLeftHalf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // groupBoxScreenQuarters
            // 
            this.groupBoxScreenQuarters.Controls.Add(this.labelBottomRightQuarter);
            this.groupBoxScreenQuarters.Controls.Add(this.textBoxBottomRightQuarter);
            this.groupBoxScreenQuarters.Controls.Add(this.labelBottomLeftQuarter);
            this.groupBoxScreenQuarters.Controls.Add(this.textBoxBottomLeftQuarter);
            this.groupBoxScreenQuarters.Controls.Add(this.labelTopRightQuarter);
            this.groupBoxScreenQuarters.Controls.Add(this.textBoxTopRightQuarter);
            this.groupBoxScreenQuarters.Controls.Add(this.labelTopLeftQuarter);
            this.groupBoxScreenQuarters.Controls.Add(this.textBoxTopLeftQuarter);
            this.groupBoxScreenQuarters.Location = new System.Drawing.Point(10, 246);
            this.groupBoxScreenQuarters.Name = "groupBoxScreenQuarters";
            this.groupBoxScreenQuarters.Size = new System.Drawing.Size(374, 123);
            this.groupBoxScreenQuarters.TabIndex = 8;
            this.groupBoxScreenQuarters.TabStop = false;
            this.groupBoxScreenQuarters.Text = "Screen quarters";
            // 
            // labelBottomRightQuarter
            // 
            this.labelBottomRightQuarter.AutoSize = true;
            this.labelBottomRightQuarter.Location = new System.Drawing.Point(6, 100);
            this.labelBottomRightQuarter.Name = "labelBottomRightQuarter";
            this.labelBottomRightQuarter.Size = new System.Drawing.Size(140, 13);
            this.labelBottomRightQuarter.TabIndex = 7;
            this.labelBottomRightQuarter.Text = "Move to bottom right quarter";
            this.labelBottomRightQuarter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxBottomRightQuarter
            // 
            this.textBoxBottomRightQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBottomRightQuarter.Location = new System.Drawing.Point(152, 97);
            this.textBoxBottomRightQuarter.Name = "textBoxBottomRightQuarter";
            this.textBoxBottomRightQuarter.ReadOnly = true;
            this.textBoxBottomRightQuarter.ShortcutsEnabled = false;
            this.textBoxBottomRightQuarter.Size = new System.Drawing.Size(207, 20);
            this.textBoxBottomRightQuarter.TabIndex = 6;
            this.textBoxBottomRightQuarter.TabStop = false;
            this.textBoxBottomRightQuarter.Tag = "BOTTOM_RIGHT";
            this.textBoxBottomRightQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBottomRightQuarter.WordWrap = false;
            this.textBoxBottomRightQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxBottomRightQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // labelBottomLeftQuarter
            // 
            this.labelBottomLeftQuarter.AutoSize = true;
            this.labelBottomLeftQuarter.Location = new System.Drawing.Point(12, 74);
            this.labelBottomLeftQuarter.Name = "labelBottomLeftQuarter";
            this.labelBottomLeftQuarter.Size = new System.Drawing.Size(134, 13);
            this.labelBottomLeftQuarter.TabIndex = 5;
            this.labelBottomLeftQuarter.Text = "Move to bottom left quarter";
            this.labelBottomLeftQuarter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxBottomLeftQuarter
            // 
            this.textBoxBottomLeftQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxBottomLeftQuarter.Location = new System.Drawing.Point(152, 71);
            this.textBoxBottomLeftQuarter.Name = "textBoxBottomLeftQuarter";
            this.textBoxBottomLeftQuarter.ReadOnly = true;
            this.textBoxBottomLeftQuarter.ShortcutsEnabled = false;
            this.textBoxBottomLeftQuarter.Size = new System.Drawing.Size(207, 20);
            this.textBoxBottomLeftQuarter.TabIndex = 4;
            this.textBoxBottomLeftQuarter.TabStop = false;
            this.textBoxBottomLeftQuarter.Tag = "BOTTOM_LEFT";
            this.textBoxBottomLeftQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBottomLeftQuarter.WordWrap = false;
            this.textBoxBottomLeftQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxBottomLeftQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // labelTopRightQuarter
            // 
            this.labelTopRightQuarter.AutoSize = true;
            this.labelTopRightQuarter.Location = new System.Drawing.Point(23, 48);
            this.labelTopRightQuarter.Name = "labelTopRightQuarter";
            this.labelTopRightQuarter.Size = new System.Drawing.Size(123, 13);
            this.labelTopRightQuarter.TabIndex = 3;
            this.labelTopRightQuarter.Text = "Move to top right quarter";
            this.labelTopRightQuarter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxTopRightQuarter
            // 
            this.textBoxTopRightQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTopRightQuarter.Location = new System.Drawing.Point(152, 45);
            this.textBoxTopRightQuarter.Name = "textBoxTopRightQuarter";
            this.textBoxTopRightQuarter.ReadOnly = true;
            this.textBoxTopRightQuarter.ShortcutsEnabled = false;
            this.textBoxTopRightQuarter.Size = new System.Drawing.Size(207, 20);
            this.textBoxTopRightQuarter.TabIndex = 2;
            this.textBoxTopRightQuarter.TabStop = false;
            this.textBoxTopRightQuarter.Tag = "TOP_RIGHT";
            this.textBoxTopRightQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTopRightQuarter.WordWrap = false;
            this.textBoxTopRightQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxTopRightQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // labelTopLeftQuarter
            // 
            this.labelTopLeftQuarter.AutoSize = true;
            this.labelTopLeftQuarter.Location = new System.Drawing.Point(29, 22);
            this.labelTopLeftQuarter.Name = "labelTopLeftQuarter";
            this.labelTopLeftQuarter.Size = new System.Drawing.Size(117, 13);
            this.labelTopLeftQuarter.TabIndex = 1;
            this.labelTopLeftQuarter.Text = "Move to top left quarter";
            this.labelTopLeftQuarter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxTopLeftQuarter
            // 
            this.textBoxTopLeftQuarter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTopLeftQuarter.Location = new System.Drawing.Point(152, 19);
            this.textBoxTopLeftQuarter.Name = "textBoxTopLeftQuarter";
            this.textBoxTopLeftQuarter.ReadOnly = true;
            this.textBoxTopLeftQuarter.ShortcutsEnabled = false;
            this.textBoxTopLeftQuarter.Size = new System.Drawing.Size(207, 20);
            this.textBoxTopLeftQuarter.TabIndex = 0;
            this.textBoxTopLeftQuarter.TabStop = false;
            this.textBoxTopLeftQuarter.Tag = "TOP_LEFT";
            this.textBoxTopLeftQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTopLeftQuarter.WordWrap = false;
            this.textBoxTopLeftQuarter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxTopLeftQuarter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // labelPreviousDisplay
            // 
            this.labelPreviousDisplay.AutoSize = true;
            this.labelPreviousDisplay.Location = new System.Drawing.Point(32, 96);
            this.labelPreviousDisplay.Name = "labelPreviousDisplay";
            this.labelPreviousDisplay.Size = new System.Drawing.Size(124, 13);
            this.labelPreviousDisplay.TabIndex = 7;
            this.labelPreviousDisplay.Text = "Move to previous display";
            this.labelPreviousDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPreviousDisplay
            // 
            this.textBoxPreviousDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxPreviousDisplay.Location = new System.Drawing.Point(162, 93);
            this.textBoxPreviousDisplay.Name = "textBoxPreviousDisplay";
            this.textBoxPreviousDisplay.ReadOnly = true;
            this.textBoxPreviousDisplay.ShortcutsEnabled = false;
            this.textBoxPreviousDisplay.Size = new System.Drawing.Size(207, 20);
            this.textBoxPreviousDisplay.TabIndex = 6;
            this.textBoxPreviousDisplay.TabStop = false;
            this.textBoxPreviousDisplay.Tag = "PREVIOUS_SCREEN";
            this.textBoxPreviousDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPreviousDisplay.WordWrap = false;
            this.textBoxPreviousDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxPreviousDisplay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // labelNextDisplay
            // 
            this.labelNextDisplay.AutoSize = true;
            this.labelNextDisplay.Location = new System.Drawing.Point(52, 70);
            this.labelNextDisplay.Name = "labelNextDisplay";
            this.labelNextDisplay.Size = new System.Drawing.Size(104, 13);
            this.labelNextDisplay.TabIndex = 5;
            this.labelNextDisplay.Text = "Move to next display";
            this.labelNextDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNextDisplay
            // 
            this.textBoxNextDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxNextDisplay.Location = new System.Drawing.Point(162, 67);
            this.textBoxNextDisplay.Name = "textBoxNextDisplay";
            this.textBoxNextDisplay.ReadOnly = true;
            this.textBoxNextDisplay.ShortcutsEnabled = false;
            this.textBoxNextDisplay.Size = new System.Drawing.Size(207, 20);
            this.textBoxNextDisplay.TabIndex = 4;
            this.textBoxNextDisplay.TabStop = false;
            this.textBoxNextDisplay.Tag = "NEXT_SCREEN";
            this.textBoxNextDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNextDisplay.WordWrap = false;
            this.textBoxNextDisplay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxNextDisplay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // labelCenter
            // 
            this.labelCenter.AutoSize = true;
            this.labelCenter.Location = new System.Drawing.Point(118, 44);
            this.labelCenter.Name = "labelCenter";
            this.labelCenter.Size = new System.Drawing.Size(38, 13);
            this.labelCenter.TabIndex = 3;
            this.labelCenter.Text = "Center";
            this.labelCenter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCenter
            // 
            this.textBoxCenter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxCenter.Location = new System.Drawing.Point(162, 41);
            this.textBoxCenter.Name = "textBoxCenter";
            this.textBoxCenter.ReadOnly = true;
            this.textBoxCenter.ShortcutsEnabled = false;
            this.textBoxCenter.Size = new System.Drawing.Size(207, 20);
            this.textBoxCenter.TabIndex = 2;
            this.textBoxCenter.TabStop = false;
            this.textBoxCenter.Tag = "CENTER";
            this.textBoxCenter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCenter.WordWrap = false;
            this.textBoxCenter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxCenter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // labelFullscreen
            // 
            this.labelFullscreen.AutoSize = true;
            this.labelFullscreen.Location = new System.Drawing.Point(101, 18);
            this.labelFullscreen.Name = "labelFullscreen";
            this.labelFullscreen.Size = new System.Drawing.Size(55, 13);
            this.labelFullscreen.TabIndex = 1;
            this.labelFullscreen.Text = "Fullscreen";
            this.labelFullscreen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxFullscreen
            // 
            this.textBoxFullscreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFullscreen.Location = new System.Drawing.Point(162, 15);
            this.textBoxFullscreen.Name = "textBoxFullscreen";
            this.textBoxFullscreen.ReadOnly = true;
            this.textBoxFullscreen.ShortcutsEnabled = false;
            this.textBoxFullscreen.Size = new System.Drawing.Size(207, 20);
            this.textBoxFullscreen.TabIndex = 0;
            this.textBoxFullscreen.TabStop = false;
            this.textBoxFullscreen.Tag = "FULLSCREEN";
            this.textBoxFullscreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFullscreen.WordWrap = false;
            this.textBoxFullscreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyDownEvent);
            this.textBoxFullscreen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleKeyUpEvent);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 385);
            this.Controls.Add(this.labelPreviousDisplay);
            this.Controls.Add(this.textBoxPreviousDisplay);
            this.Controls.Add(this.groupBoxScreenQuarters);
            this.Controls.Add(this.labelNextDisplay);
            this.Controls.Add(this.groupBoxScreenHalves);
            this.Controls.Add(this.textBoxNextDisplay);
            this.Controls.Add(this.labelCenter);
            this.Controls.Add(this.textBoxFullscreen);
            this.Controls.Add(this.textBoxCenter);
            this.Controls.Add(this.labelFullscreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.Text = "Neat Windows";
            this.groupBoxScreenHalves.ResumeLayout(false);
            this.groupBoxScreenHalves.PerformLayout();
            this.groupBoxScreenQuarters.ResumeLayout(false);
            this.groupBoxScreenQuarters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon settingsIcon;
        private System.Windows.Forms.GroupBox groupBoxScreenHalves;
        private System.Windows.Forms.TextBox textBoxLeftHalf;
        private System.Windows.Forms.Label labelLeftHalf;
        private System.Windows.Forms.Label labelBottomHalf;
        private System.Windows.Forms.TextBox textBoxBottomHalf;
        private System.Windows.Forms.Label labelTopHalf;
        private System.Windows.Forms.TextBox textBoxTopHalf;
        private System.Windows.Forms.Label labelRightHalf;
        private System.Windows.Forms.TextBox textBoxRightHalf;
        private System.Windows.Forms.GroupBox groupBoxScreenQuarters;
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

    }
}

