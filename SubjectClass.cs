using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;
using System.IO.Compression;
using Ionic;
namespace Testo
{
    public class SubjectClass
    {

        public string Name { get; set; }
        public string Filename { get; set; }
        public string Hash { get; set; }

        private StreamReader sr;
        private XmlWriter xmlio;

        private string CalculateHash()
        {
            MD5 md=MD5.Create();
            string original;
            original = sr.ReadToEnd();
            
            string has = Convert.ToBase64String(md.ComputeHash(Encoding.UTF8.GetBytes(original)));
            return has;
        }

        public bool ShowRight { get; set; }
        public bool AllowRemake { get; set; }
        public bool Randomtask { get; set; }
        public bool RandomAnswerOrder { get; set; }
        public bool UseTime { get; set; }
        public int Time { get; set; } = -1;
        public List<TaskClass> Tasks { get; set; } = new List<TaskClass>();
        public List<MarkClass> Marks { get; set; } = new List<MarkClass>();
        public Exception FileExistException = new Exception();
        public Exception TrashInDirectory = new Exception();

        public SubjectClass()
        { }
        public SubjectClass(string path)
        {
        }

        public void Export(bool rewrite = false)
        {
            if (File.Exists(Filename+".sft") && rewrite == false)
            {
                throw FileExistException;
            }
            if (!Directory.Exists("res")) Directory.CreateDirectory("res");
                FileStream fs = new FileStream("script.ist", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                xmlio = XmlWriter.Create(fs);
                sr = new StreamReader(fs);

                xmlio.WriteStartElement("subject"); //root
                xmlio.WriteAttributeString("name",Name);

                xmlio.WriteStartElement("setings"); //setings part

                xmlio.WriteStartElement("showright"); //define show right after asking on task
                xmlio.WriteString((ShowRight == true) ? "True": "False");
                xmlio.WriteEndElement();

                xmlio.WriteStartElement("allowremake"); //define can student pass this subject again
                xmlio.WriteString((AllowRemake==true) ? "True" : "False");
                xmlio.WriteEndElement();

                xmlio.WriteStartElement("randomtask"); //define should be task sorted by order or presented randomly
                xmlio.WriteString((Randomtask==true) ? "True" : "False");
                xmlio.WriteEndElement();

                xmlio.WriteStartElement("randomanswer");//define should answers be presented randomly
                xmlio.WriteString((RandomAnswerOrder==true) ? "True" : "False");
                xmlio.WriteEndElement();

                xmlio.WriteStartElement("usetimer");//define time to pass task
                xmlio.WriteAttributeString("time", Convert.ToString(Time)); //write time per task, if time wasn't defined, time = -1
                xmlio.WriteString((UseTime == true) ? "True" : "False");
                xmlio.WriteEndElement();

                xmlio.WriteEndElement();//close setings part

                xmlio.WriteStartElement("tasks");//open tasks part

                foreach(TaskClass task in Tasks)
                {
                    xmlio.WriteStartElement("task");//define task

                    xmlio.WriteStartElement("header"); //write header of task
                    xmlio.WriteString(task.Label);
                    xmlio.WriteEndElement();

                    xmlio.WriteStartElement("text"); //write text of the task
                    xmlio.WriteString(task.Text);
                    xmlio.WriteEndElement();

                    xmlio.WriteStartElement("images"); //write images pathes
                    //if (!Directory.Exists("res")) Directory.CreateDirectory("res");
                    //else
                    //{
                    //    xmlio.Close();
                    //    File.Delete("script.ist");
                    //    //throw TrashInDirectory;
                    //}

                    int counter = 0;
                    foreach(Image img in task.Images)
                    {
                        string path = @"res/img" +task.Label+ counter+".jpg";
                        img.Save(path);
                        xmlio.WriteElementString("image", path);
                        counter++;
                    }
                    xmlio.WriteEndElement();

                    xmlio.WriteStartElement("answertype");
                    xmlio.WriteString(Convert.ToString(task.Answer_Type));
                    xmlio.WriteEndElement();

                    xmlio.WriteStartElement("answers");
                    foreach(string answer in task.Answers)
                    {
                        xmlio.WriteStartElement("answer");
                        xmlio.WriteString(answer);
                        xmlio.WriteEndElement();
                    }
                    xmlio.WriteEndElement();

                    xmlio.WriteStartElement("right");
                    xmlio.WriteString(task.Answer);
                    xmlio.WriteEndElement();

                    xmlio.WriteEndElement();//close task
                }
                xmlio.WriteEndElement();
                xmlio.WriteStartElement("marks");
                foreach(MarkClass mrk in Marks)
                {
                    xmlio.WriteStartElement("mark");
                    xmlio.WriteElementString("percentage", Convert.ToString(mrk.Percentage));
                    xmlio.WriteElementString("name", mrk.Mark);
                    xmlio.WriteEndElement();
                }
                xmlio.WriteEndElement();
                xmlio.Flush();
                string has = CalculateHash();
                xmlio.WriteStartElement("hash");
                xmlio.WriteString(has);
                xmlio.WriteEndElement();


                xmlio.WriteEndElement();

                xmlio.WriteEndDocument();
                xmlio.Close();

                fs.Close();

                Ionic.Zip.ZipFile zp = new Ionic.Zip.ZipFile();
                zp.AddFile("script.ist");
                zp.AddDirectory("res","res");
                zp.Password = "12345678";
                zp.Encryption = Ionic.Zip.EncryptionAlgorithm.WinZipAes128;
                zp.Save($"{Filename}.sft");

                byte[] fl = File.ReadAllBytes($"{Filename}.sft");
                byte[] res;
                List<byte> tmplist = new List<byte>();
                foreach(byte tmp in fl)
                {
                    var vt = ~tmp;
                    tmplist.Add((byte)vt);
                }
                res = tmplist.ToArray();
                File.WriteAllBytes($"{Filename}.sft", res);
        }

    }
}
