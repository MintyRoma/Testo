using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace Testo.Forms.Components
{
    public partial class ButtonSelector : UserControl
    {
        public ButtonSelector()
        {
            InitializeComponent();
        }

        public ButtonSelector(string label)
        {
            InitializeComponent();
            But.Text = label;
        }

        private bool choice;
        public bool Choice
        {
            get { return choice; }
            set
            {
                choice = value;
                ChoiceChanged?.Invoke();
            }
        }
        public delegate bool choicech();
        public choicech ChoiceChanged;

        private void But_Click(object sender, EventArgs e)
        {
            Choice = !Choice;
            Indicator.Checked = Choice;
        }
    }
}
