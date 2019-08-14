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
    public partial class AddAnswers : Form
    {
        private List<string> answers = new List<string>();
        private string trueAnswer;
        private AnswerType anstype = AnswerType.Radio;
        private TaskClass tsk;
        private Font deffont = new Font("Consolas", (float)12.0);

        public delegate void answerchanged();
        public event answerchanged AnswerChanged;

        public delegate void tskchangeddelegate();
        public event tskchangeddelegate TaskChanged;

        public TaskClass Task
        {
            get { return tsk; }
            set
            {
                tsk = value;
                if (TaskChanged!=null) TaskChanged();
            }
        }
       
        public AnswerType Answer_Type
        {
            get { return anstype; }
            set { anstype = value;
                ReloadPanel();
            }
        }

        public string Answer
        {
            get { return trueAnswer; }
            set { trueAnswer = value;
                AnswerChanged();
            }
        }
              
        public AddAnswers(TaskClass task)
        {
            InitializeComponent();
            Task = task;
            Answer_Type = task.Answer_Type;
            switch(Answer_Type)
            {
                case AnswerType.Radio:
                    AnswerTypeComboBox.SelectedItem = "Один ответ из нескольких вариантов";
                    break;
                case AnswerType.Order:
                    AnswerTypeComboBox.SelectedItem = "Порядок";
                    break;
                case AnswerType.CheckBox:
                    AnswerTypeComboBox.SelectedItem = "Несколько вариантов ответа";
                    break;
                default:
                    AnswerTypeComboBox.SelectedItem = "Строка";
                    Answer_Type = AnswerType.String;
                    break;
            }
            if (Task.Answers.Count<1)
            {
                AnswerComponent ans = new AnswerComponent(Answer_Type);
                ans.Text = "Новый ответ";
                ans.Font = deffont;
                ans.Size = new Size(AnswersPanel.Size.Width, 30);
                ans.Location = new Point(0, 0);
                AnswersPanel.Controls.Add(ans);
            }
            else
            {
                int counter = 0;
                foreach(string answer in task.Answers)
                {
                    AnswerComponent ans = new AnswerComponent(Answer_Type);
                    ans.Text = answer;
                    ans.Size = new Size(AnswersPanel.Size.Width, 30);
                    ans.Location = new Point(0,counter*30);
                    counter++;
                    ans.Font = deffont;
                    if (answer == Task.Answer) ans.Checked = true;
                    AnswersPanel.Controls.Add(ans);
                }
            }
            
        }
        private void AddAnswers_Load(object sender, EventArgs e)
        {
            TaskChanged += ReloadPanel;
        }

        private void ReloadPanel()
        {
            if (Answer_Type == AnswerType.CheckBox || Answer_Type == AnswerType.Radio || Answer_Type == AnswerType.Order)
            {
                stringanswerpanel.Hide();
                foreach (Control ans in AnswersPanel.Controls)
                {
                    if (ans is AnswerComponent)
                    {
                        AnswerComponent an = (AnswerComponent)ans;
                        an.Answer_Type = Answer_Type;
                        ans.Show();
                    }
                }
            }
            else
            {
                foreach (Control ans in AnswersPanel.Controls)
                {
                    if (ans is AnswerComponent) ans.Hide();
                }
                stringanswerpanel.Show();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AnswerTypeComboBox.SelectedItem)
            {
                case "Порядок":
                    Answer_Type = AnswerType.Order;
                    break;
                case "Строка":
                    Answer_Type = AnswerType.String;
                    break;
                case "Несколько вариантов ответа":
                    Answer_Type = AnswerType.CheckBox;
                    break;
                default:
                    Answer_Type = AnswerType.Radio;
                    break;
            } 
        }

    }
}
