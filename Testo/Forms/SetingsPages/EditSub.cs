using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testo.Forms.SetingsPages
{
    public partial class EditSub : SetingsPanel
    {

        private bool allowremake = false;
        private bool showright = false;
        private bool randomstasks = false;
        private bool usetimer = false;
        private bool limittasks = false;

        public bool AllowRemake
        {
            get { return allowremake; }
            set
            {
                allowremake = value;
            }
        }
        public bool ShowRight
        {
            get { return showright; }
            set
            {
                showright = value;
            }
        }
        public bool Randomize
        {
            get { return randomstasks; }
            set
            {
                randomstasks = value;
            }
        }
        public bool UseTimer
        {
            get { return usetimer; }
            set
            {
                usetimer = value;
                if (!value)
                {
                    TimeLabel.Enabled = false;
                    TimeDescription.Enabled = false;
                    TimeUpDown.Enabled = false;
                }
                else
                {
                    TimeLabel.Enabled = true;
                    TimeDescription.Enabled = true;
                    TimeUpDown.Enabled = true;
                }
            }
        }
        public bool LimitTasks
        {
            get { return limittasks; }
            set
            {
                limittasks = value;
                if (!value)
                {
                    AmountLabel.Enabled = false;
                    AmountDescription.Enabled = false;
                    TasksAmountUpDown.Enabled = false;
                }
                else
                {
                    AmountLabel.Enabled = true;
                    AmountDescription.Enabled = true;
                    TasksAmountUpDown.Enabled = true;
                }
            }
        }

        public EditSub()
        {
            InitializeComponent();
            UseTimer = false;
            LimitTasks = false;
        }

        private void EditSub_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            AllowRemake = AllowReamakeChckBox.Checked;
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UseTimeChckBox_CheckedChanged(object sender, EventArgs e)
        {
            UseTimer = UseTimeChckBox.Checked;
        }

        private void ShowRightChckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowRight = ShowRightChckBox.Checked;
        }

        private void RandomTasksChckBox_CheckedChanged(object sender, EventArgs e)
        {
            Randomize = RandomTasksChckBox.Checked;
        }

        private void LimitTasksChckBox_CheckedChanged(object sender, EventArgs e)
        {
            LimitTasks = LimitTasksChckBox.Checked;
        }
    }
}
