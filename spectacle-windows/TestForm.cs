using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace spectacle_windows
{
    public partial class TestForm : Form
    {

        public TestForm() 
        { 
            InitializeComponent();
            HotkeyHandler hotkeyHandler = new HotkeyHandler();
            hotkeyHandler.RegisterHotkeys(this);
        }

        public void WriteSomething()
        {
            Console.WriteLine("Hello");
        }

        public void WriteSomethingElse()
        {
            Console.WriteLine("Halla");
        }
    }
}
