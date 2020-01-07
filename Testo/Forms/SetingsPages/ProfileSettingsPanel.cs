using System;
using System.Collections.Generic;
using Testo.Classes;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Security.Cryptography;
using System.Text;

namespace Testo.Forms.SetingsPages
{
    public partial class ProfileSettingsPanel : UserControl
    {
        private bool changepas = false;
        private Classes.Teacher teacher;
        public bool ChangingPassword
        {
            get { return changepas; }
            set
            {
                changepas = value;
                ChangeStyle();
            }
        }

        private void ChangeStyle()
        {
            if (ChangingPassword==true)
            {
                ChangepasPanel.Visible = true;
                changepasBtn.Visible = false;
            }
            else
            {
                ChangepasPanel.Visible = false;
                changepasBtn.Visible = true;
            }
        }

        public ProfileSettingsPanel(Classes.Teacher tchr)
        {
            InitializeComponent();
            teacher = tchr;
            Nametxtbox.Text = teacher.Name;
            Application.DoEvents();
        }

        private void ProfileSettingsPanel_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Nametxtbox.ReadOnly = false;
            Nametxtbox.BorderStyle = BorderStyle.Fixed3D;
            Nametxtbox.Focus();
            Nametxtbox.SelectAll();
            Nametxtbox.KeyDown += SaveChanges;
            Nametxtbox.LostFocus += CancelNameChanging;
        }

        private void CancelNameChanging(object sender, EventArgs e)
        {
            Nametxtbox.Text = teacher.Name;
            Nametxtbox.ReadOnly = true;
            Nametxtbox.BorderStyle = BorderStyle.None;
        }

        private void SaveChanges(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Teacher TMP = teacher;
                Teacher tchr = new Teacher(Nametxtbox.Text, teacher.Key);
                teacher = tchr;
                UpdateFile(TMP);
                MessageBox.Show("Имя успешно изменено!\nИзменение вступит в силу после перезахода в настройки", "Смена имени", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nametxtbox.ReadOnly = true;
                Nametxtbox.BorderStyle = BorderStyle.None;
            }
            if (e.KeyData == Keys.Escape)
            {
                Nametxtbox.Text = teacher.Name;
                Nametxtbox.ReadOnly = true;
                Nametxtbox.BorderStyle = BorderStyle.None;
            }
        }

        private void UpdateFile(Teacher TMP)
        {
            List<Classes.Teacher> teachers = new List<Classes.Teacher>();
            if (!File.Exists("profiles.xml"))
            {
                MessageBox.Show("Отсутствуют файлы профилей учителей!\nЗапустите средство восстановления программы repair.exe", "Нарушение целостности программы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StreamReader sr = new StreamReader("profiles.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(sr);
            XmlNode node = doc.FirstChild;
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
            File.Delete("profiles.xml");
            teachers.Remove(TMP);
            teachers.Add(teacher);
            StreamWriter sw = new StreamWriter("profiles.xml");
            XmlWriter xmlio = XmlWriter.Create(sw);
            xmlio.WriteStartElement("teachers");
            foreach (Classes.Teacher tchr in teachers)
            {
                xmlio.WriteStartElement("teacher");
                xmlio.WriteElementString("name", tchr.Name);
                xmlio.WriteElementString("key", tchr.Key);
                xmlio.WriteEndElement();
            }
            xmlio.WriteEndElement();
            xmlio.WriteEndDocument();
            xmlio.Close();
            sw.Close(); ;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ChangingPassword = false ;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ChangingPassword = true;
        }

        private void SavePasBtn_Click(object sender, EventArgs e)
        {
            if ((newpasTxtBox.Text == confirmpasTxtBox.Text) && (!teacher.Compare(newpasTxtBox.Text)))
            {
                Teacher TMP = teacher;
                MD5 md = MD5.Create();
                byte[] hash = md.ComputeHash(Encoding.ASCII.GetBytes(newpasTxtBox.Text));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                string passwordhash = sb.ToString().ToLower();
                Teacher tchr = new Teacher(teacher.Name, passwordhash);
                teacher = tchr;
                UpdateFile(TMP);
                MessageBox.Show("Пароль успешно изменен", "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ChangingPassword = false;
            }
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
