﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Testo.Forms
{
    public partial class Security : Form
    {
        private Form nxt = new Form();
        private List<Classes.Teacher> teachers = new List<Classes.Teacher>();

        public delegate void canceled(object sender,EventArgs e);
        public event canceled SecurityCanceled;

        public delegate void allowed(object sender, EventArgs e);
        public event allowed AccessAllowed;

        public delegate void deny(object sender, EventArgs e);
        public event deny AccessDenied;

        public delegate void validteacher(object sender, Classes.Teacher teacher);
        public event validteacher TeacherValidated;

        public Security(Form NextForm)
        {
            InitializeComponent();
            ImportTeachers();
            nxt = NextForm;
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

        private void Security_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SecurityCanceled(this, EventArgs.Empty);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void Confirm()
        {
            string pas = textBox1.Text;
            foreach(Classes.Teacher tch in teachers)
            {
                if (tch.Compare(pas))
                {
                    nxt.Show();
                    nxt.Size = this.Size;
                    nxt.Location = this.Location;
                    nxt.FormClosing += ClosingChildForm;
                    TeacherValidated?.Invoke(this,tch);
                    this.Hide();
                    return;
                }
                else
                {
                    textBox1.Text = "";
                    statuslabel.ForeColor = Color.OrangeRed;
                    statuslabel.Text = "Не существует ни одного пользователя с таким паролем!\nПовторите попытку снова!";
                }
            }
        }

        private void ClosingChildForm(object sender, FormClosingEventArgs e)
        {
            SecurityCanceled?.Invoke(this,EventArgs.Empty);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Confirm();
            }
        }
    }
}