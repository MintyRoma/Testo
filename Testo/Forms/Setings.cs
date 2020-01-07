using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Testo.Classes;
using System.Windows.Forms;

namespace Testo.Forms
{
    public partial class Setings : Form
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

        private Color accentColor = Color.FromArgb(119, 0, 255);
        private Font accentFont = new Font("Segoe UI Semibold", 12.0f);
        private Font defFont = new Font("Segoe UI", 12.0f);
        UserControl panel = new UserControl();
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

        public Setings()
        {
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
        }

        private void PreparePanel()
        {
            panel.Dock = DockStyle.Fill;
            ViewerPanel.Controls.Clear();
            foreach (Control btn in menuPanel.Controls)
            {
                if (!(btn is Button)) continue; 
                if (btn.Name == "ExitBtn" || btn.Name == "NotTouch") continue;
                btn.ForeColor = Color.White;
                btn.BackColor = Color.FromArgb(55,55,55) ;
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
    }
}
