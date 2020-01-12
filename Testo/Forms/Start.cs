using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Testo.Forms;

namespace Testo
{
    public partial class Start : Form
    {
        Setings set = new Setings();
        public Start()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void GoToSetings_MouseMove(object sender, MouseEventArgs e)
        {
            GoToSetings.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void GoToSetings_MouseLeave(object sender, EventArgs e)
        {
            GoToSetings.BackColor = Color.FromArgb(46, 46, 46);
        }

        private void GoToSetings_Click(object sender, EventArgs e)
        {
            if (!File.Exists("profiles.xml"))
            {
                MessageBox.Show("Отсутствуют файлы профилей учителей!\nЗапустите средство восстановления программы repair.exe", "Нарушение целостности программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                set = new Setings();
                Security sc = new Security(set);
                sc.FormClosing += SecurityClosing;
                sc.SecurityCanceled += SecurityCanceled;
                sc.TeacherValidated += SendTeacherToSetings;
                sc.Size = this.Size;
                sc.Show();
                sc.Location = this.Location;
                System.Threading.Thread.Sleep(10);
                this.Hide();
            }
        }

        private void SendTeacherToSetings(object sender, Classes.Teacher tch)
        {
            set.EditableTeacher = tch;
        }

        private void SecurityCanceled(object sender, EventArgs e)
        {
            Form frm = (Form)sender;
            this.Size = frm.Size;
            this.Show();
            this.Location = frm.Location;
            Security sc = (Security)frm;
            sc.FormClosing -= SecurityClosing;
            frm.Close();
        }

        private void SecurityClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void NametxtBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void GoToGit_MouseMove(object sender, MouseEventArgs e)
        {
            GoToGit.BackColor= Color.FromArgb(60, 60, 60);
        }

        private void GoToGit_MouseLeave(object sender, EventArgs e)
        {
            GoToGit.BackColor = GoToSetings.BackColor = Color.FromArgb(46, 46, 46);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("Subjects")) Directory.CreateDirectory("Subjects");
            string[] files = Directory.GetFiles("Subjects");

        }

        private void GoToGit_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
    }
}
