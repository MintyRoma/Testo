using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testo
{
    public partial class EditSubject : Form
    {
        private SubjectClass subject = new SubjectClass();
        private Mode md = Mode.SubjectEdit;
        private bool usetimer = false;
        public bool UseTimer
        {
            get { return usetimer; }
            set
            {
                usetimer = value;
                refreshTimeUND();
            }
        }

        public Mode MODE
        {
            get { return md; }
            set { md = value;
                changeState();
            }
        }

        private void changeState()
        {
            if (MODE == Mode.SubjectEdit)
            {
                PropsPanel.Show();
                TaskInfoPanel.Hide();
            }
            if (MODE == Mode.TaskEdit)
            {
                PropsPanel.Hide();
                TaskInfoPanel.Show();
            }
        }


        private void refreshTimeUND()
        {
            TimeForTaskNUD.Enabled = usetimer;
        }

        public EditSubject()
        {
            InitializeComponent();
            UseTimer = false;
            TreeNode RootNode = TaskTree.Nodes[0];
            TaskTree.SelectedNode = RootNode;
        }

        private void SubjectNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (SubjectFileNameTxtBox.Text == "" || SubjectNameTxtBox.Text.Contains(SubjectFileNameTxtBox.Text)) SubjectFileNameTxtBox.Text = SubjectNameTxtBox.Text;

        }

        private void SetupTimerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UseTimer = !UseTimer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestClass tst = new TestClass();
            TaskTree.ExpandAll();
        }

        private void TaskTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selected = e.Node;
            if (selected.Text == "Добавить задание") MODE = Mode.TaskEdit;
            if (selected.Text == "Параметры") MODE = Mode.SubjectEdit;
        }

        private void AnswersBtn_Click(object sender, EventArgs e)
        {
            AddAnswers form = new AddAnswers();
            form.Show();
        }
    }
}
