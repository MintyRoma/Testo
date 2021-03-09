using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Testo.Classes;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Testo.Forms
{
    public partial class SetingsForm : MetroForm
    {
        private Teacher tch = new Teacher("", "");
        public Teacher EditableTeacher
        {
            get { return tch; }
            set
            {
                tch = value;
                RewriteProfiles();
                ChangeMode(this, "");
            }
        }

        private Font defFont = new Font("Segoe UI", 12.0f);
        SetingsPages.SetingsPanel panel;
        public enum mode_selecter
        {
            profile,
            tasks,
            history,
            graph,
            users,
        };

        public delegate void mdchanged(object sender, string arg);
        public event mdchanged ModeChanged;
        private mode_selecter md = mode_selecter.profile;
        public mode_selecter Mode
        {
            get { return md; }
            set
            {
                md = value;
                ModeChanged?.Invoke(this,"");
            }
        }

        public SetingsForm()
        {
            InitializeComponent();
            ModeChanged += ChangeMode;
            Mode = mode_selecter.profile;
        }

        public SetingsForm(Teacher teacher)
        {
            tch = teacher;
            InitializeComponent();
            ModeChanged += ChangeMode;
            Mode = mode_selecter.profile;
        }

        private void UpdateData(object sender, EventArgs e)
        {
            ChangeMode(this,"");
        }

        private void RewriteProfiles()
        {
            
        }

        private void ChangeMode(object sender, string arg)
        {
            switch (Mode)
            {
                case mode_selecter.tasks:
                    panel = new SetingsPages.TasksSettingsPanel();
                    PreparePanel();
                    ActivateButton(SubjectsBtn);
                    ViewerPanel.Controls.Add(panel);
                    break;
                default:
                    panel = new SetingsPages.ProfileSettingsPanel(EditableTeacher);
                    PreparePanel();
                    ActivateButton(ProfileBtn);
                    ViewerPanel.Controls.Add(panel);
                    break;
            }
        }

        private void ActivateButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(55, 16, 105);
            btn.ForeColor = Color.White;
        }

        private void PreparePanel()
        {
            panel.Dock = DockStyle.Fill;
            ViewerPanel.Controls.Clear();
            foreach (Control btn in menuPanel.Controls)
            {
                if (!(btn is Button)) continue; 
                if (btn.Name == "ExitBtn" || btn.Name == "NotTouch") continue;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White ;
                btn.Font = defFont;
            }
        }

        private void Setings_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            Mode = mode_selecter.profile;
        }

        private void SubjectsBtn_Click(object sender, EventArgs e)
        {
            Mode = mode_selecter.tasks;
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
