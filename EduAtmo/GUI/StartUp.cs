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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Shell.Run();
            string[] subs = Directory.GetFiles("Subjects");
            for(int i = 0; i<subs.Count();i++)
            {
                string tmp = subs[i].Substring(9);
                tmp = tmp.Remove(tmp.Count() - 4, 4);
                subs[i] = tmp;
            }
            StartWindow startw = new StartWindow(subs);
            startw.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
