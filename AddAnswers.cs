using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        private AnswerComponent selected;

        public delegate void answerchanged();
        public event answerchanged AnswerChanged;

        public delegate void tskchangeddelegate();
        public event tskchangeddelegate TaskChanged;

        public delegate void senddata(List<string> data, string right, AnswerType at);
        public event senddata Send;

        public TaskClass Task
        {
            get { return tsk; }
            set
            {
                tsk = value;
                if (TaskChanged != null) TaskChanged();
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
                AnswerChanged?.Invoke();
            }
        }

        public AddAnswers(TaskClass task)
        {
            InitializeComponent();
            Task = task;
            Answer_Type = task.Answer_Type;
            Answer = task.Answer;
            MessageBox.Show(Answer);
            switch (Answer_Type)
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
            if (Answer_Type == AnswerType.String)
            {
                textbox.Text = Answer;
                AddAnswer.Enabled = false;
                DeleteAnswer.Enabled = false;
            }
            else
            {
                int counter = 0;
                foreach (string answer in task.Answers)
                {
                    AnswerComponent ans = new AnswerComponent(Answer_Type);
                    ans.Text = answer;
                    ans.Size = new Size(AnswersPanel.Size.Width, 40);
                    ans.Location = new Point(0, counter * 40);
                    counter++;
                    ans.Font = deffont;
                    if (answer == Task.Answer) ans.Checked = true;
                    ans.Inactive += CheckAnswerText;
                    ans.Selected += AnswerFocused;
                    //ans.CheckedEvent += UpdateDots;
                    AnswersPanel.Controls.Add(ans);
                    answers.Add(answer);
                }

            }
            if (Answer_Type == AnswerType.CheckBox)
            {
                string[] ans = Answer.Split('|');
                foreach (Control an in AnswersPanel.Controls)
                {
                    if (an is AnswerComponent)
                    {
                        AnswerComponent answer = (AnswerComponent) an;
                        foreach (string st in ans)
                        {
                            if (answer.Text == st)
                            {
                                answer.Checked = true;
                                break;
                            }
                        }
                    }
                }
            }
            if (Answer_Type == AnswerType.Order)
            {
                string[] ans = Answer.Split('|');
                foreach(Control an in AnswersPanel.Controls)
                {
                    if (an is AnswerComponent)
                    {
                        AnswerComponent answer = (AnswerComponent)an;
                        foreach(string st in ans)
                        {
                            string key = st.Substring(st.IndexOf('"')+1, st.Length - 2 - st.IndexOf('"'));
                            int value = Convert.ToInt32(st.Split('-')[0]);
                            if (answer.Text ==key)
                            {
                                answer.OrderNumber = value;
                            }
                        }
                    }
                }
            }
        }

        private void AnswerFocused(object sender, EventArgs e)
        {
            foreach (Control ans in AnswersPanel.Controls)
            {
                if (ans is AnswerComponent)
                {
                    AnswerComponent comp = (AnswerComponent)ans;
                    ans.BackColor = Color.FromKnownColor(KnownColor.Control);
                }
            }
            AnswerComponent component = (AnswerComponent)sender;
            component.BackColor = Color.FromArgb(174, 166, 247);
            selected = component;
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
                        if (Answer_Type == AnswerType.Order) an.MaximumUD = AnswersPanel.Controls.Count;
                    }
                }
                AddAnswer.Enabled = true;
                DeleteAnswer.Enabled = true;
            }
            else
            {
                foreach (Control ans in AnswersPanel.Controls)
                {
                    if (ans is AnswerComponent) ans.Hide();
                }
                stringanswerpanel.Show();
                AddAnswer.Enabled = false;
                DeleteAnswer.Enabled = false;
            }
        }

        private void CheckAnswerText(object sender, EventArgs e)
        {
            try
            {
                AnswerComponent ans = (AnswerComponent)sender;
                int counter = 0;
                answers.Clear();
                foreach (Control ctrls in AnswersPanel.Controls)
                {
                    if (ctrls is AnswerComponent)
                    {
                        string answer = ctrls.Text;
                        answers.Add(answer);
                        if (answer == ans.Text) counter++;
                    }
                }
                if (counter > 1)
                {
                    ans.Text = ans.Text.Substring(0, ans.Text.Length - 1);
                    throw new Exceptions.ExistedAnswer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка правки ответа", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SystemSounds.Asterisk.Play();
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

        private void AddAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                if (answers.Contains("Ответ тут"))
                {
                    throw new Exceptions.ExistedAnswer(true);
                }
                int counter = answers.Count;
                AnswerComponent ans = new AnswerComponent(Answer_Type);
                ans.Text = "Ответ тут";
                ans.Size = new Size(AnswersPanel.Size.Width, 40);
                ans.Location = new Point(0, counter * 40);
                counter++;
                ans.Font = deffont;
                if (counter < 1) ans.Checked = true;
                ans.Inactive += CheckAnswerText;
                ans.Selected += AnswerFocused;
                ans.MaximumUD = AnswersPanel.Controls.Count + 1;
                //ans.CheckedEvent += UpdateDots;
                AnswersPanel.Controls.Add(ans);
                answers.Add(ans.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка добавления ответа", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DeleteAnswer_Click(object sender, EventArgs e)
        {
            answers.Remove(selected.Text);
            AnswersPanel.Controls.Clear();
            int counter = 0;
            foreach(string text in answers)
            {
                AnswerComponent ans = new AnswerComponent(Answer_Type);
                ans.Text = text;
                ans.Size = new Size(AnswersPanel.Size.Width, 40);
                ans.Location = new Point(0, counter * 40);
                counter++;
                ans.Font = deffont;
                if (Answer == Task.Answer) ans.Checked = true;
                ans.Inactive += CheckAnswerText;
                ans.Selected += AnswerFocused;
                //ans.CheckedEvent += UpdateDots;
                AnswersPanel.Controls.Add(ans);
            }
        }

        private void AddAnswers_FormClosing(object sender, FormClosingEventArgs e)
        {
            answers.Clear();
            //switch(AnswerTypeComboBox.SelectedText)
            //{
            //    case "Один ответ из нескольких вариантов":
            //        Answer_Type = AnswerType.Radio;
            //    break;
            //    case "Порядок":
            //        Answer_Type = AnswerType.Order;
            //    break;
            //    case "Несколько вариантов ответа":
            //        Answer_Type = AnswerType.CheckBox;
            //    break;
            //    default:
            //    Answer_Type = AnswerType.String;
            //    break;
            //}
            trueAnswer = "";
            if (Answer_Type == AnswerType.Order)
            {
                int[] used = new int[answers.Count()];
                int i = 0;
                foreach(AnswerComponent ans in AnswersPanel.Controls)
                {
                    if (used.Contains(ans.OrderNumber)) throw new Exceptions.ExistedAnswer();
                    else used[i++]= ans.OrderNumber;
                }
            }
            foreach (AnswerComponent ans in AnswersPanel.Controls)
            {
                try
                {
                    switch (Answer_Type)
                    {
                        case AnswerType.Radio:
                            {
                                if (ans.Checked)
                                {
                                    if (trueAnswer != "") throw new Exceptions.ExistedAnswer();
                                    else trueAnswer = ans.Text;
                                }
                                break;
                            }
                        case AnswerType.CheckBox:
                            {
                                if (ans.Checked)
                                {
                                    if (trueAnswer != "") trueAnswer += "|" + ans.Text;
                                    else trueAnswer = ans.Text;
                                }
                                break;
                            }
                        case AnswerType.Order:
                            {
                                if (trueAnswer == "") trueAnswer += ans.OrderNumber + "-\"" + ans.Text + "\"";
                                else trueAnswer += "|" + ans.OrderNumber + "-\"" + ans.Text + "\"";
                                break;
                            }
                        default:
                            break;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка заполнения ответов", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            Send?.Invoke(answers, Answer, Answer_Type);
        }

        private void AnswersPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
