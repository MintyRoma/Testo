using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;
using System.IO.Compression;
using Ionic.Zip;
using System.Windows.Forms;

namespace Testo
{
    public class SubjectClass
    {

        public string Name { get; set; }
        public string Filename { get; set; }


        private StreamReader sr;
        private FileStream fs;

        private string CalculateHash()
        {
            MD5 md=MD5.Create();
            string original = "";
            fs.Position = 0;
            while(!sr.EndOfStream)
            {
                original+= sr.ReadLine();
            }
            
            string has = Convert.ToBase64String(md.ComputeHash(Encoding.UTF8.GetBytes(original)));
            return has;
        }

        public bool ShowRight { get; set; } = false;
        public bool AllowRemake { get; set; } = false;
        public bool Randomtask { get; set; } = false;
        public bool RandomAnswerOrder { get; set; } = false;
        public bool UseTime { get; set; } = false;

        public bool LimitTasks { get; set; } = false;
        public int LimitedTasksAmount = 0;
        public int Time { get; set; } = -1;
        public List<TaskClass> Tasks { get; set; } = new List<TaskClass>();
        public List<MarkClass> Marks { get; set; } = new List<MarkClass>();

        public SubjectClass()
        { }
        public SubjectClass(string path)
        {
            Import(path);
        }

        public void Import(string path)
        {
            try
            {
                const string filename = "runtime.sft";

                if (!File.Exists(path)) return; //File not exists exception
                if (File.Exists(filename)) File.Delete(filename); //clear last runtime file if exists
                if (Directory.Exists("runtime")) Directory.Delete("runtime", true);
                //revert all bytes in file
                byte[] fl = File.ReadAllBytes(path);
                byte[] res;
                List<byte> tmplist = new List<byte>();
                foreach (byte tmp in fl)
                {
                    var vt = ~tmp;
                    tmplist.Add((byte)vt);
                }
                res = tmplist.ToArray();
                File.WriteAllBytes(filename, res);
                File.SetAttributes(filename, FileAttributes.Hidden); //create new hiden sft file for reading

                //extract all files to hiden folder runtime for reading script and store images if exists
                ZipFile zip = new ZipFile("runtime.sft");
                DirectoryInfo dir = Directory.CreateDirectory("runtime");
                dir.Attributes = FileAttributes.Hidden;
                zip.ExtractAll("runtime", ExtractExistingFileAction.OverwriteSilently);
                zip.Dispose();

                //reading script
                FileStream fs = new FileStream($"runtime/script.ist", FileMode.Open, FileAccess.Read);
                XmlDocument doc = new XmlDocument();

                //comparing hash
                sr = new StreamReader(fs);
                string original = "";
                while (true)
                {
                    if (sr.EndOfStream) throw new Exceptions.WrongFile();
                    string tmp = sr.ReadLine();
                    if (tmp.Contains("<hashMD5>") && tmp.Contains("</hashMD5>"))
                    {
                        int sp = tmp.IndexOf("<hashMD5>");
                        original += tmp.Substring(0, sp);
                        break;
                    }
                    original += tmp;
                }
                MD5 md = MD5.Create();
                string has = Convert.ToBase64String(md.ComputeHash(Encoding.UTF8.GetBytes(original)));

                fs.Position = 0;
                doc.Load(fs);
                XmlNode root = doc.DocumentElement;
                XmlNode HashNode = root.SelectSingleNode("hashMD5");
                if (HashNode.InnerText != has) throw new Exceptions.WrongHash(path);
                Name = root.Attributes.GetNamedItem("name").InnerText;
                XmlNode ParamNode = root.SelectSingleNode("settings");
                foreach (XmlNode nd in ParamNode)
                {
                    if (nd.Name == "showright") ShowRight = nd.InnerText == "True" ? true : false;
                    if (nd.Name == "allowremake") AllowRemake = nd.InnerText == "True" ? true : false;
                    if (nd.Name == "randomtask") Randomtask = nd.InnerText == "True" ? true : false;
                    if (nd.Name == "randomanswer") RandomAnswerOrder = nd.InnerText == "True" ? true : false;
                    if (nd.Name == "usetimer")
                    {
                        UseTime = nd.InnerText == "True" ? true : false;
                        Time = Convert.ToInt32(nd.Attributes.GetNamedItem("time").InnerText);
                    }
                    if (nd.Name == "limittasks")
                    {
                        LimitTasks = nd.InnerText == "True" ? true : false;
                        LimitedTasksAmount = Convert.ToInt32(nd.Attributes.GetNamedItem("tasks").InnerText);
                    }
                }
#if DEBUG
                MessageBox.Show($"Name: {Name}\nshowright: {ShowRight}\n allowremake: {AllowRemake}\n randomtask:{Randomtask}\nrandomanswer:{RandomAnswerOrder}\n usetimer:{UseTime} \ntime:{Time}");
#endif
                XmlNode TasksNode = root.SelectSingleNode("tasks");
                foreach (XmlNode nd in TasksNode)
                {
                    if (nd.Name == "task")
                    {
                        TaskClass task = new TaskClass();
                        foreach (XmlNode taskchild in nd)
                        {

                            if (taskchild.Name == "header") task.Label = taskchild.InnerText;
                            if (taskchild.Name == "text") task.Text = taskchild.InnerText;
                            if (taskchild.Name == "images")
                            {
                                foreach (XmlNode imgaenode in taskchild)
                                {
                                    Image img = Image.FromFile("runtime/" + imgaenode.InnerText);
                                    task.Images.Add(img,"runtime/"+imgaenode.InnerText);
                                }
                            }
                            if (taskchild.Name == "answertype") task.Answer_Type = (AnswerType)Enum.Parse(typeof(AnswerType), taskchild.InnerText, true);
                            if (taskchild.Name == "answers")
                            {
                                foreach (XmlNode answernode in taskchild)
                                {
                                    task.Answers.Add(answernode.InnerText);
                                }
                            }
                            if (taskchild.Name == "right") task.Answer = taskchild.InnerText;
                        }
#if DEBUG
                        string answers = "";
                        foreach (string answer in task.Answers) answers += answer + ";\n";
                        MessageBox.Show($"=Task=\nName: {task.Label}\nText:{task.Text}\nImgs:{task.Images.Count}\nAnswer Type: {task.Answer_Type}\nAnswers:\n{answers}\n" +
                            $"Right: {task.Answer}");
#endif
                        Tasks.Add(task);
                    }
                }
                XmlNode MarksNode = root.SelectSingleNode("marks");
                foreach (XmlNode marknd in MarksNode)
                {
                    if (marknd.Name == "mark")
                    {
                        string name = "Error";
                        double rate = 0.0;
                        foreach (XmlNode atribute in marknd)
                        {
                            if (atribute.Name == "percentage") rate = Convert.ToDouble(atribute.InnerText);
                            if (atribute.Name == "name") name = atribute.InnerText;
                        }
#if DEBUG
                        MessageBox.Show($"=Mark=\nName: {name}\nPercentage:{rate}");
#endif
                        Marks.Add(new MarkClass(name, rate));
                    }
                }
                fs.Close();
                File.Delete("runtime/script.ist");
                File.Delete("runtime.sft");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nПомощь:"+ex.HelpLink);
            }

        }

        public void Export(bool rewrite = false)
        {
            try
            {
                XmlWriter xmlio;
                if (File.Exists(Filename + ".sft") && rewrite == false)
                {
                    throw new Exceptions.FileExists();
                }
                if (!Directory.Exists("res")) Directory.CreateDirectory("res");
                fs = new FileStream("script.ist", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                xmlio = XmlWriter.Create(fs);
                sr = new StreamReader(fs);

                xmlio.WriteStartElement("subject"); //root
                xmlio.WriteAttributeString("name", Name);

                xmlio.WriteStartElement("settings"); //setings part

                xmlio.WriteStartElement("showright"); //define show right after asking on task
                xmlio.WriteString((ShowRight == true) ? "True" : "False");
                xmlio.WriteEndElement();

                xmlio.WriteStartElement("allowremake"); //define can student pass this subject again
                xmlio.WriteString((AllowRemake == true) ? "True" : "False");
                xmlio.WriteEndElement();

                xmlio.WriteStartElement("randomtask"); //define should be task sorted by order or presented randomly
                xmlio.WriteString((Randomtask == true) ? "True" : "False");
                xmlio.WriteEndElement();

                xmlio.WriteStartElement("randomanswer");//define should answers be presented randomly
                xmlio.WriteString((RandomAnswerOrder == true) ? "True" : "False");
                xmlio.WriteEndElement();

                xmlio.WriteStartElement("usetimer");//define time to pass task
                xmlio.WriteAttributeString("time", Convert.ToString(Time)); //write time per task, if time wasn't defined, time = -1
                xmlio.WriteString((UseTime == true) ? "True" : "False");
                xmlio.WriteEndElement();

                xmlio.WriteStartElement("limittasks");//define task limitation in one test
                xmlio.WriteAttributeString("tasks", Convert.ToString(LimitedTasksAmount));
                xmlio.WriteString((LimitTasks == true) ? "True" : "False");
                xmlio.WriteEndElement();

                xmlio.WriteEndElement();//close setings part

                xmlio.WriteStartElement("tasks");//open tasks part

                foreach (TaskClass task in Tasks)
                {
                    xmlio.WriteStartElement("task");//define task

                    xmlio.WriteStartElement("header"); //write header of task
                    xmlio.WriteString(task.Label);
                    xmlio.WriteEndElement();

                    xmlio.WriteStartElement("text"); //write text of the task
                    xmlio.WriteString(task.Text);
                    xmlio.WriteEndElement();

                    xmlio.WriteStartElement("images"); //write images pathes

                    int counter = 0;
                    foreach (KeyValuePair<Image,string> img in task.Images)
                    {
                        string path = @"res/img" + task.Label + counter + ".jpg";
                        Image image = img.Key;
                        image.Save(path);
                        xmlio.WriteElementString("image", path);
                        counter++;
                    }
                    xmlio.WriteEndElement();

                    xmlio.WriteStartElement("answertype");
                    xmlio.WriteString(Convert.ToString(task.Answer_Type));
                    xmlio.WriteEndElement();

                    xmlio.WriteStartElement("answers");
                    foreach (string answer in task.Answers)
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
                foreach (MarkClass mrk in Marks)
                {
                    xmlio.WriteStartElement("mark");
                    xmlio.WriteElementString("percentage", Convert.ToString(mrk.Percentage));
                    xmlio.WriteElementString("name", mrk.Mark);
                    xmlio.WriteEndElement();
                }
                xmlio.WriteEndElement();
                xmlio.Flush();
                long position = fs.Position;
                string has = CalculateHash();
                fs.Position = position;
                xmlio.WriteStartElement("hashMD5");
                xmlio.WriteString(has);
                xmlio.WriteEndElement();


                xmlio.WriteEndElement();

                xmlio.WriteEndDocument();
                xmlio.Close();

                fs.Close();

                Ionic.Zip.ZipFile zp = new Ionic.Zip.ZipFile();
                zp.AddFile("script.ist");
                zp.AddDirectory("res", "res");
                zp.Save($"{Filename}.sft");

                byte[] fl = File.ReadAllBytes($"{Filename}.sft");
                byte[] res;
                List<byte> tmplist = new List<byte>();
                foreach (byte tmp in fl)
                {
                    var vt = ~tmp;
                    tmplist.Add((byte)vt);
                }
                res = tmplist.ToArray();
                File.WriteAllBytes($"{Filename}.sft", res);
                File.Delete("script.ist");
                Directory.Delete("res", true);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"При загрузке .sft файла произошла ошибка \nОписаие ошибки:{ex.Message}");
            }
        }

    }
}
