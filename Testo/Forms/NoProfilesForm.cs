using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using MetroFramework.Forms;

namespace Testo.Forms
{
    public partial class NoProfilesForm : MetroForm
    {
        public NoProfilesForm()
        {
            InitializeComponent();
            textBox1.Text = Classes.DefaultMessages.ERRORNoProfiles;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            NoUACConfirmationForm frm = new NoUACConfirmationForm();
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
