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
using MetroFramework.Forms;
using MetroFramework.Controls;
using Testo.Classes;

namespace Testo
{
    public partial class Start : MetroForm
    {
        private SetingsForm set = new SetingsForm();
        private List<MetroTile> tiles = new List<MetroTile>();
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
                if (MetroFramework.MetroMessageBox.Show(this,"Отсутствуют файлы профилей учителей!\nПрограмма будет перезапущена", "Нарушение целостности программы", MessageBoxButtons.OK, MessageBoxIcon.Error)==DialogResult.OK)
                {
                    Application.Restart();
                }
            }
            else
            {
                SecurityForm sc = new SecurityForm();
                sc.AccessAllowed += ShowSettings;
                sc.ShowDialog();
            }
        }

        private void ShowSettings(object sender, Teacher teacher)
        {
            SetingsForm sets = new SetingsForm(teacher);
            sets.Show();
            this.Hide();
            sets.FormClosed += ShowAgain;
        }

        private void ShowAgain(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }



        private void NametxtBox_Enter(object sender, EventArgs e)
        {

        }

        private void GoToGit_MouseMove(object sender, MouseEventArgs e)
        {
            GoToGit.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void GoToGit_MouseLeave(object sender, EventArgs e)
        {
            GoToGit.BackColor = GoToSetings.BackColor = Color.FromArgb(46, 46, 46);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("Subjects")) Directory.CreateDirectory("Subjects");
            ConstructTiles();
        }

        private void ConstructTiles()
        {
            List<string> files = new List<string>();
            try
            {
                files = Directory.GetFiles("Subjects").ToList();
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this, "Отсутствуют файлы", "Ошибка поиска файлов", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> subjects = new List<string>();
            foreach (string filename in files)
            {
                if (filename.EndsWith(".sbj"))
                {
                    subjects.Add(filename.Replace(@"Subjects\","").Replace(".sbj",""));
                }
            }
            if (subjects.Count() < 1)
            {
                MetroLabel label = new MetroLabel();
                label.Text = "Файлы заданий отсутствуют :(";
                label.ForeColor = Color.Gray;
                label.AutoSize = true;
                label.Location = new Point(SubjectSelector.Size.Width / 2 - label.Size.Width / 2, SubjectSelector.Height / 2 - label.Size.Height / 2);
                SubjectSelector.Controls.Add(label);
                return;

            }
            else
            {
                foreach (string filename in subjects)
                {
                    
                    MetroFramework.Controls.MetroTile tile = new MetroFramework.Controls.MetroTile();
                    tile.Text = filename;
                    tile.AutoSize = true;
                    tile.Height = 100;
                    tile.Width = 200;
                    tile.UseCustomBackColor = true;
                    tile.BackColor = MetroFramework.MetroColors.Purple;
                    tiles.Add(tile);
                }
                PlaceTiles(tiles);
            }
        }

        private void PlaceTiles(List<MetroTile> tiles)
        {
            int x = 10;
            int y = 10;
            foreach (Button btn in tiles)
            {
                btn.Location = new Point(x, y);
                SubjectSelector.Controls.Add(btn);
                x = x + 10 + btn.Width;
                if (x+btn.Width+10>=SubjectSelector.Width)
                {
                    x = 10;
                    y = y + 10 + btn.Height;
                }
            }
        }


        private void GoToGit_Click(object sender, EventArgs e)
        {
            AboutForm ab = new AboutForm();
            ab.ShowDialog();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            resizeStatusbar();
        }

        private void resizeStatusbar()
        {
            statusBar.Dock = DockStyle.None;
            statusBar.Location = new Point(0, this.Size.Height - 20);
            statusBar.Size = new Size(this.Size.Width, 20);
        }

        private void Start_Resize(object sender, EventArgs e)
        {
            resizeStatusbar();
        }

        private void SubjectSelector_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Start_SizeChanged(object sender, EventArgs e)
        {
            PlaceTiles(tiles);
        }
    }
}
