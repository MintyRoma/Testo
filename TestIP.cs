using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Testo
{
    public partial class TestIP : Form
    {
        private Queue<TaskClass> tasks;
        private int amount = 0;

        private int answersamount;
        private TaskClass NOWtask;
        private string NOWLabel="";
        private int NOWamount = 0;
        private string NOWtasktext = "";
        private Dictionary<Image,string> NOWimages;
        private List<string> NOWAnswers;
        private string NOWAnswer;
        private AnswerType NOWatype;
        public TestIP()
        {
            InitializeComponent();

        }

        public TestIP(string path)
        {
            InitializeComponent();
            SubjectClass sub = new SubjectClass(path);
            tasks = new Queue<TaskClass>();
            foreach (TaskClass tk in sub.Tasks)
            {
                tasks.Enqueue(tk);
            }
            if (tasks.Count > 0) Loadtask();
        }

        private void Loadtask()
        {
            NOWtask = tasks.Dequeue();
            NOWtask = tasks.Dequeue();
            NOWamount++;
            NOWLabel = NOWtask.Label;
            NOWtasktext = NOWtask.Text;
            NOWatype = NOWtask.Answer_Type;
            NOWAnswers = NOWtask.Answers;
            NOWAnswer = NOWtask.Answer;
            NOWimages = NOWtask.Images;
            Render();
        }

        private void Render()
        {
            Label.Text = NOWLabel;
            textBox.Text = NOWtasktext;

            foreach (string ans in NOWAnswers)
            {
                AnswerComponent ansc = new AnswerComponent(NOWatype);
                ansc.Text = ans;
                ansc.Size = new Size(AnswersBox.Width, 30);
                ansc.Location = new Point(0, answersamount * 30);
                AnswersBox.Controls.Add(ansc);
                ansc.Show();
            }
        }

        private void TestIP_Load(object sender, EventArgs e)
        {
            
        }

        private void AnswersBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
