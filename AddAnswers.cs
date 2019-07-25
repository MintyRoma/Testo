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
        private AnswerType anstype;
        public AnswerType Answer_Type
        {
            get { return anstype; }
            set { anstype = value;
                ReloadPanel();
            }
        }

        private void ReloadPanel()
        {
            Control ctrl;
            switch(Answer_Type)
            {
                case AnswerType.CheckBox:
                    ctrl = new CheckBox();
                    break;
                case AnswerType.Radio:
                    ctrl = new RadioButton();
                    break;
                case AnswerType.String:
                    ctrl = new TextBox();
                    break;
                default:
                    ctrl = new NumericUpDown();
                    break;
            }
            ctrl.Font = new Font("Consolas", 12,0);

            AnswersPanel;
        }

        public AddAnswers()
        {
            InitializeComponent();
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
