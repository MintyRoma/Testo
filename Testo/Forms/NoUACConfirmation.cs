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
    public partial class NoUACConfirmation : Form
    {

        public delegate void activated();
        public event activated Activated;
        public NoUACConfirmation()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void Check()
        {
            if (textBox1.Text == "TGTK") Activated?.Invoke();
            else this.Close();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode) Check();
        }

        private void NoUACConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
