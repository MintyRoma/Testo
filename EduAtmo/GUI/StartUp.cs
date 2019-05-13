using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace EduAtmo
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
            Build.Text += Shell.BUILD;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Shell.FirstWindow();
            this.Hide();
            timer1.Stop();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {

        }
    }
}
