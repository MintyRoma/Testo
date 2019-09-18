using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testo
{
    public partial class AnswerComponent : UserControl
    {
        private Font font = new Font("Consolas", (float)12.0);
        private AnswerType anstype = AnswerType.Radio;
        private string text;
        private bool status = false;
        private int max;
        private int numericvalue;

        public delegate void selected(object sender, EventArgs e);
        public event selected Selected;

        public delegate void fontchanged();
        public new event fontchanged FontChanged;

        public delegate void answertypechanged();
        public event answertypechanged AnswertypeChanged;

        public delegate void textchanged();
        public new event textchanged TextChanged;

        public delegate void statuschangeda(object sender, EventArgs e);
        public event statuschangeda CheckedEvent;

        public delegate void maxchanged();
        public event maxchanged MaximumChanged;

        public delegate void publinactive(object sender, EventArgs e);
        public event publinactive Inactive;

        public int OrderNumber
        {
            get => numericvalue;
            set
            {
                //if (value>max)
                //{
                //    Exception ex = new Exception("Номер ответа больше допустимого числа ответов");
                //    ex.HelpLink = "https://github.com/MintyRoma/Testo";
                //    throw ex;
                //}
                numericvalue = value;
                numUD.Value = value;
                NumUD_ValueChanged(this, EventArgs.Empty);
            }
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                table.BackColor = value;
            }
        }
        public int MaximumUD
        {
            get => max;
            set
            {
                max = value;
                MaximumChanged?.Invoke();
                numUD.Maximum = max;
            }
        }

        public override Font Font
        {
            get => font;
            set
            {
                font = value;
                FontChanged?.Invoke();
            }
        }

        public AnswerType Answer_Type
        {
            get => anstype;
            set
            {
                anstype = value;
                AnswertypeChanged?.Invoke();
            }
        }

        public override string Text
        {
            get => text;
            set
            {
                text = value;
                textBox.Text = text;
                TextChanged?.Invoke();
            }
        }

        public bool Checked
        {
            get => status;
            set
            {
                status = value;
                CheckedEvent?.Invoke(this, EventArgs.Empty);
                if (chkcBox.Checked != value || radbtn.Checked != value)
                {
                    chkcBox.Checked = value;
                    radbtn.Checked = value;
                }
                Application.DoEvents();
            }
        }

        //public void DisableDotWithoutEvent()
        //{
        //    status = false;
        //    if (chkcBox.Checked!= false || radbtn.Checked !=false)
        //    {
        //        chkcBox.Checked = false;
        //        radbtn.Checked = false;
        //    }
        //}

        private void RedrawFonts()
        {
            this.numUD.Font = this.Font;
            this.textBox.Font = this.Font;
        }
        private void CheckProvider(object sender,EventArgs e)
        {
            if (anstype == AnswerType.CheckBox)
            {
                Checked = chkcBox.Checked;
            }
            if (anstype == AnswerType.Radio)
            {
                Checked = radbtn.Checked;
            }
        }

        private void Redraw()
        {
            switch (anstype)
            {
                case AnswerType.CheckBox:
                {
                        HideAll();
                        chkcBox.Show();
                        break;
                }
                case AnswerType.Order:
                    {
                        HideAll();
                        numUD.Show();
                        break;
                    }
                case AnswerType.Radio:
                    {
                        HideAll();
                        radbtn.Show();
                        break;
                    }
                default:
                    HideAll();
                    break;
            }
        }

        private void HideAll()
        {
            foreach (Control comp in table.Controls)
            {
                if (table.GetColumn(comp) == 0)
                {
                    comp.Hide();
                }
            }
        }

        public AnswerComponent(AnswerType type)
        {
            InitializeComponent();
            SecondInit();
            foreach (Control comp in table.Controls)
            {
                if (table.GetColumn(comp)==0)
                {
                    comp.Hide();
                }
            }
            switch(type)
            {
                case AnswerType.Radio:
                    {
                        radbtn.Show();
                        break;
                    }
                case AnswerType.Order:
                    {
                        numUD.Show();
                        break;
                    }
                case AnswerType.CheckBox:
                    {
                        chkcBox.Show();
                        break;
                    }
                default:
                    break;
            }
        }

        private void SecondInit()
        {
            FontChanged += RedrawFonts;
            AnswertypeChanged += Redraw;
            chkcBox.CheckedChanged += CheckProvider;
            radbtn.CheckedChanged += CheckProvider;
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            Inactive?.Invoke(this, e);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            text = this.textBox.Text;

        }

        private void Radbtn_CheckedChanged(object sender, EventArgs e)
        {
             
        }

        private void Radbtn_Click(object sender, EventArgs e)
        {
            Selected?.Invoke(this, EventArgs.Empty);
            if (radbtn.Checked == false) radbtn.Checked = true;
            else radbtn.Checked = false;
        }

        private void NumUD_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void NumUD_Click(object sender, EventArgs e)
        {
            Selected?.Invoke(this, EventArgs.Empty);
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            Selected?.Invoke(this, EventArgs.Empty);
        }

        private void ChkcBox_Click(object sender, EventArgs e)
        {
            Selected?.Invoke(this, EventArgs.Empty);
        }

        private void Table_Click(object sender, EventArgs e)
        {
            Selected?.Invoke(this, EventArgs.Empty);
        }
    }
}
