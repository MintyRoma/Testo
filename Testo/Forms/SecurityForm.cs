using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using MetroFramework.Forms;
using System.Security.Cryptography;
using Testo.Classes;
using System.Drawing;

namespace Testo.Forms
{
    public partial class SecurityForm : MetroForm
    {
        private List<Classes.Teacher> teachers = new List<Classes.Teacher>();

        public delegate void allowed(object sender, Teacher e);
        public event allowed AccessAllowed;

        public delegate void deny(object sender, EventArgs e);
        public event deny AccessDenied;

        public SecurityForm()
        {
            InitializeComponent();
            ImportTeachers();
        }

        private void ImportTeachers()
        {
            try
            {
                if (!File.Exists("profiles.xml"))
                {
                    MessageBox.Show("Отсутствуют файлы профилей учителей!\nЗапустите средство восстановления программы repair.exe", "Нарушение целостности программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                StreamReader sr = new StreamReader("profiles.xml");
                XmlDocument doc = new XmlDocument();
                doc.Load(sr);
                XmlNode node = doc.GetElementsByTagName("teachers")[0];
                if (node.Name == "teachers")
                {
                    foreach (XmlNode nd in node)
                    {
                        if (nd.Name == "teacher")
                        {
                            string name = "";
                            string hash = "";
                            foreach (XmlNode datanode in nd)
                            {
                                if (datanode.Name == "name") name = datanode.InnerText;
                                if (datanode.Name == "key") hash = datanode.InnerText;
                            }
                            teachers.Add(new Classes.Teacher(name, hash));
                        }
                    }
                }
                sr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Файл профилей учителей поврежден!\nЗапустите средство восстановления программы repair.exe", "Нарушение целостности программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                Check();
            }
        }

        private void Check()
        {
            string pass = passwordTxtBox.Text;
            foreach (Teacher tch in teachers)
            {
                if (tch.Compare(pass))
                {
                    AccessAllowed?.Invoke(this,tch);
                    this.Close();
                    return;
                }
            }
            statuslabel.Text = "Не существует ни одного учителя с подобным паролем!";
            statuslabel.ForeColor = Color.White;
            statuslabel.BackColor = Color.Salmon;
        }

        private void SecurityForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AccessDenied?.Invoke(this,EventArgs.Empty);
        }
    }
}
