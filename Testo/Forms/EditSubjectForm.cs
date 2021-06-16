using MetroFramework.Forms;
using System;
using Testo.Forms.SetingsPages;


namespace Testo.Forms
{
    public partial class EditSubjectForm : MetroForm
    {
        public EditSubjectForm()
        {
            InitializeComponent();
            mode = Mode.setup;
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
                case Mode.setup:
                    EditSub es = new EditSub();
                    TaskDetails.Controls.Add(es);
                    break;
                case Mode.marks:
                    MarksSetup mk = new MarksSetup();
                    TaskDetails.Controls.Add(mk);
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

        private void SubjectsBtn_Click(object sender, EventArgs e)
        {
            mode = Mode.setup;
        }

        private void History_Click(object sender, EventArgs e)
        {
            mode = Mode.marks;
        }
    }
}
