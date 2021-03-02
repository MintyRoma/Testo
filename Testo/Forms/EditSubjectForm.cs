using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testo.Forms.SetingsPages;
using Testo.Properties;

namespace Testo.Forms
{
    public partial class EditSubjectForm : Form
    {
        public EditSubjectForm()
        {
            InitializeComponent();
        }
        public EditSubjectForm(Classes.Subject sub)
        {
            InitializeComponent();
            mode = Mode.setup;
        }

        public delegate void statechanged();
        public event statechanged ModeChanged;
        public enum Mode 
        {
            setup,
            marks,
            task
        };
        private Mode md;
        public Mode mode
        {
            get { return md; }
            set
            {
                md = value;
                ModeChanged?.Invoke();
                UpdateForm();
            }
        }

        private void UpdateForm()
        {
            TaskDetails.Controls.Clear();
            switch (mode)
            {
                case Mode.marks:
                    break;
                default:
                    TaskDetails.Controls.Add(new EditSub());
                    break;
            }
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            mode = Mode.setup;

        }

        private void SubEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
