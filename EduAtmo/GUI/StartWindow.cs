using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EduAtmo
{
    public partial class StartWindow : Form
    {
        public StartWindow(string[] subs)
        {
            InitializeComponent();
            foreach(string tmp in subs)
            {
                Button btn = new Button();
                btn.Name = tmp;

            }

        }

        private void StartWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
