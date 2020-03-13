using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;

namespace Testo.Forms
{
    public partial class NoProfilesForm : Form
    {
        public NoProfilesForm()
        {
            InitializeComponent();
            textBox1.Text = Classes.DefaultMessages.ERRORNoProfiles;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            NoUACConfirmation frm = new NoUACConfirmation();
            frm.Activated+=RepairConfig;
            frm.ShowDialog();
        }

        private void RepairConfig()
        {
            var PSI = new System.Diagnostics.ProcessStartInfo();
            PSI.Arguments = "CreateConfig";
            PSI.FileName = System.Reflection.Assembly.GetExecutingAssembly().Location;
            try
            {
                System.Diagnostics.Process.Start(PSI);
            }
            catch
            {
                return;
            }
            Application.Exit();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Classes.DefaultMessages.ERRORNoProfiles;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var PSI = new System.Diagnostics.ProcessStartInfo();
            PSI.Verb = "runas";
            PSI.Arguments = "CreateConfig";
            PSI.FileName = System.Reflection.Assembly.GetExecutingAssembly().Location;
            try
            {
                System.Diagnostics.Process.Start(PSI);
            }
            catch
            {
                return;
            }
            Application.Exit();
        }

        private void NoProfilesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
