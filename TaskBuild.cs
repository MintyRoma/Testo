using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Testo
{
    public partial class TaskBuild : Form
    {
        public TaskBuild()
        {
            this.Hide();
            Form splash = new Form();
            Label tx = new Label();
            tx.Text = "Testo Task Builder";
            tx.Font = new Font("Segoe UI", (float)36);
            tx.Dock = DockStyle.Fill;
            tx.BackColor = Color.FromArgb(21, 23, 28);
            tx.ForeColor = Color.White;
            tx.TextAlign = ContentAlignment.MiddleCenter;
            splash.Controls.Add(tx);
            splash.StartPosition = FormStartPosition.CenterScreen;
            splash.FormBorderStyle = FormBorderStyle.None;
            splash.BackColor = Color.FromArgb(21, 23, 28);
            splash.Size = new Size(572, 218);
            tx.Size = splash.Size;
            splash.Show();
            InitializeComponent();
            Progress.Maximum = tst.steps;
            tst.StatusChanged += ShowStep;
            Application.DoEvents();
            Thread.Sleep(5000);
            splash.Close();
            this.Show();
        }
        TestClass tst = new TestClass();

        private void TaskBuild_Load(object sender, EventArgs e)
        {
            
            
        }

        private void ShowStep()
        {
            stat.Text = tst.Status;
            Application.DoEvents();
            if (stat.Text == "Завершено") End();
            else Progress.Value++;
        }

        private void End()
        {
            Progress.Hide();
            button1.Hide();
            Info.Text = "Запись файла успешно завершена";
            stat.Text = "Для выхода нажмите сочетание Alt+F4";
        }

        private void Stat_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tst.Start();
            button1.Enabled = false;
        }
    }
}
