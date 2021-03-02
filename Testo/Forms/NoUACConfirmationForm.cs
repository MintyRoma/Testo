using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testo.Forms
{
    public partial class NoUACConfirmationForm : MetroForm
    {

        public delegate void activated();
        //public event activated Activated;
        public NoUACConfirmationForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void Check()
        {
            if (textBox1.Text == "TGTK")
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
            else MessageBox.Show("Неправильный ключ");
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Check();
        }

        private void NoUACConfirmation_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

    }
}
