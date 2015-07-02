using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
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

    }
}
