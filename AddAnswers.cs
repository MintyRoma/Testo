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
        private AnswerType anstype;
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
                UpdateAnswer();
            }
        }

        private void UpdateAnswer()
        {
            throw new NotImplementedException();
        }

        private void ReloadPanel()
        {
            List<Control> ctrls = new List<Control>();
            switch (Answer_Type)
            {
                case AnswerType.CheckBox:
                    CheckBox chk = new CheckBox();
                    chk.Size = new Size(20, 20);
                    chk.Font = new Font("Consolas",(float)12.0,FontStyle.Regular);
                    chk.Location = new Point(10, 15);
                    TextBox txtfield = new TextBox();
                    txtfield.Font = new Font("Consolas", (float)12.0, FontStyle.Regular);
                    txtfield.Text = "Новый ответ";
                    txtfield.Location = new Point(30, 10);
                    txtfield.Size = new Size(250, txtfield.Size.Height);
                    txtfield.TextChanged += TextChangedInside;
                    ctrls.Add(chk);
                    ctrls.Add(txtfield);
                    break;
                case AnswerType.Radio:
                    
                    break;
                case AnswerType.String:
                    
                    break;
                default:
                    
                    break;
            }
            answers.Clear();
            AnswersPanel.Controls.Clear();
            foreach (Control ctrl in ctrls) AnswersPanel.Controls.Add(ctrl);
        }

        private void TextChangedInside(object sender, EventArgs e)
        {
            TextBox txtfield;
            if (sender is TextBox) txtfield = (TextBox)sender;
            else return;
            List<TextBox> txtlist = new List<TextBox>();
            foreach (Control ctrl in AnswersPanel.Controls) if (ctrl is TextBox) txtlist.Add((TextBox)ctrl);
            if (txtfield == txtlist.Last()) AddNewAnswer();
        }

        public AddAnswers()
        {
            InitializeComponent();
        }
        
        private void AddNewAnswer()
        {
            List<Control> ctrls = new List<Control>();
            switch (Answer_Type)
            {
                case AnswerType.CheckBox:
                    int num=0;
                    foreach(Control ctrl in AnswersPanel.Controls) if (ctrl is CheckBox) num++;
                    num ++;
                    CheckBox chk = new CheckBox();
                    chk.Size = new Size(20, 20);
                    chk.Font = new Font("Consolas", (float)12.0, FontStyle.Regular);
                    chk.Location = new Point(10, 15*num + (num-1)*20);
                    TextBox txtfield = new TextBox();
                    txtfield.Font = new Font("Consolas", (float)12.0, FontStyle.Regular);
                    txtfield.Text = "Новый ответ";
                    txtfield.Location = new Point(30, 10*num + (num-1)*txtfield.Size.Height);
                    txtfield.Size = new Size(250, txtfield.Size.Height);
                    txtfield.TextChanged += TextChangedInside;
                    ctrls.Add(chk);
                    ctrls.Add(txtfield);
                    break;
                case AnswerType.Radio:

                    break;
                case AnswerType.String:

                    break;
                default:

                    break;
            }
            foreach (Control ctrl in ctrls) AnswersPanel.Controls.Add(ctrl);
        }

        private void AddAnswers_Load(object sender, EventArgs e)
        {
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
