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
            InitialSubjects(subs);
        }

        private void InitialSubjects(string[] subs)
        {
            foreach (string tmp in subs)
            {
                Button btn = new Button();
                btn.Name = tmp;
                btn.Text = tmp;
                btn.Click += new EventHandler(PresentClick);
                Point position = new Point(ButtonsPanel.Controls.Count % 3 + 1, ButtonsPanel.Controls.Count / 3 + 1);
                btn.Size = new Size((ButtonsPanel.Width - 15) / 3, (ButtonsPanel.Height-15)/3);
                btn.Location = new Point(position.X * 5 + (position.X - 1) * btn.Size.Width, position.Y * 5 + (position.Y - 1) * 50);
                ButtonsPanel.Controls.Add(btn);
            }
        }
        private void StartWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Shell.Close();
        }

        private void PresentClick(object sender, System.EventArgs e)
        {
            Control ctrl = (Control)sender;
            Shell.Subject = ctrl.Name;
            MessageBox.Show(Shell.Subject);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            bool active = false;
            int spacesFIO = 0;
            for (int i = 0; i < FIOBox.Text.Count(); i++)
            {
                if (FIOBox.Text[i] == ' ' && i != 0 && i!=FIOBox.Text.Count()-1)
                {
                    if (FIOBox.Text[i - 1] != ' ' || FIOBox.Text[i + 1] != ' ') spacesFIO++;
                }
            }
            if (spacesFIO >= 1 && spacesFIO < 3 && GroupNameBox.Text != "" && Shell.Subject!="") active = true;
            StartTestBut.Enabled = active;
        }
    }
}
