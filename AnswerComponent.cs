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
        private Point location;
        private Font font = new Font("Consolas", (float)12.0);
        private AnswerType anstype = AnswerType.Radio;
        private int numudstatus= 0;
        private string text;
        private bool status = false;

        public delegate void sizechanged();
        public event sizechanged SizeChanged;

        public delegate void locationchanged();
        public event locationchanged LocationChanged;

        public delegate void fontchanged();
        public new event fontchanged FontChanged;

        public delegate void answertypechanged();
        public event answertypechanged AnswertypeChanged;

        public delegate void textchanged();
        public event textchanged TextChanged;

        public delegate void statuschanged();
        public event statuschanged CheckedEvent;

        public new Point Location
        {
            get => location;
            set
            {
                location = value;
                LocationChanged?.Invoke();
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
                CheckedEvent?.Invoke();
            }
        }

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
                        chkcBox.Show();
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
    }
}
