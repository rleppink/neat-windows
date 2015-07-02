namespace spectacle_windows
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
            this.SuspendLayout();
            // 
            // settingsIcon
            // 
            this.settingsIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("settingsIcon.Icon")));
            this.settingsIcon.Text = "Spectacle Settings";
            this.settingsIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.settingsIcon_MouseDoubleClick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 392);
            this.Name = "SettingsForm";
            this.Text = "Spectacle Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon settingsIcon;

    }
}

