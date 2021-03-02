using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Security.Cryptography;
using MetroFramework.Forms;

namespace Testo.Forms
{
    public partial class SetUp : MetroForm
    {
        private bool pasnotnul = false;
        public bool PassNotNull
        {
            get { return pasnotnul; }
            set
            {
                pasnotnul = value;
                UpdateStats();
            }
        }

        private void UpdateStats()
        {
            ErrMsg.Text = "";
            if (!PassNotNull || !PassConfirmation)
            {
                PassTxtboxStat.Image = Testo.Properties.Resources.Alert;
                ConfirmTxtboxStat.Image = Properties.Resources.Alert;
                if (!PassConfirmation) ErrMsg.Text = Classes.DefaultMessages.ERRORWrongPassConfirmation;
                if (!PassNotNull) ErrMsg.Text = Classes.DefaultMessages.ERRORPassIsNull;
            }
            else
            {
                PassTxtboxStat.Image = Testo.Properties.Resources.Check;
                ConfirmTxtboxStat.Image = Properties.Resources.Check;
            }
        }

        private bool pasconf = false;
        bool PassConfirmation
            {
            get { return pasconf; }
            set { pasconf = value;
                UpdateStats();
                UpdateGoButton();
            }
            }

        private void UpdateGoButton()
        {
            if (PassConfirmation)
            {
                button1.BackColor = Color.FromArgb(0, 174, 219);
                button1.ForeColor = Color.White;
                button1.Enabled = true;
            }
            else
            {
                button1.BackColor = Color.FromKnownColor(KnownColor.Control);
                button1.ForeColor = Color.Gray;
                button1.Enabled = false;
            }
        }

        public SetUp()
        {
            InitializeComponent();
            UpdateGoButton();
            UpdateStats();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ConfirmTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (PassTxtBox.Text == ConfirmTxtBox.Text) PassConfirmation = true;
            else PassConfirmation = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (PassConfirmation) WriteConfig();
        }

        private void WriteConfig()
        {
            FileStream fs = new FileStream("profiles.xml", FileMode.Create, FileAccess.Write);
            XmlWriter xml = XmlWriter.Create(fs);
            xml.WriteStartElement("teachers");
            xml.WriteStartElement("teacher");

            xml.WriteStartElement("name");
            xml.WriteString(NameTxtBox.Text);
            xml.WriteEndElement();

            xml.WriteStartElement("key");
            MD5 md = MD5.Create();
            byte[] hash = md.ComputeHash(Encoding.ASCII.GetBytes(PassTxtBox.Text));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string passwordhash = sb.ToString().ToLower();
            xml.WriteString(passwordhash);
            xml.WriteEndElement();

            xml.WriteEndElement();

            xml.WriteEndElement();

            xml.Close();
            fs.Close();

            var PSI = new System.Diagnostics.ProcessStartInfo();
            PSI.FileName = System.Reflection.Assembly.GetExecutingAssembly().Location;
            try
            {
                System.Diagnostics.Process.Start(PSI);
            }
            catch
            {
                return;
            }
            Application.Exit();
        }

        private void PassTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (PassTxtBox.Text == ConfirmTxtBox.Text) PassConfirmation = true;
            else PassConfirmation = false;
            if (PassTxtBox.Text == "") PassNotNull = false;
            else PassNotNull = true;
        }

        private void FirstStartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
