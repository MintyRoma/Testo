using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Drawing;

namespace Testo
{
    class SubjectClass
    {

        public string Name { get; set; }
        public string Filename { get; set; }
        public string Hash { get; set; }
        public bool ShowRight { get; set; }
        public bool AllowRemake { get; set; }
        public bool Randomtask { get; set; }
        public bool RandomAnswerOrder { get; set; }
        public bool UseTime { get; set; }
        public int Time { get; set; } = -1;
        public List<TaskClass> Tasks { get; set; }
        public List<MarkClass> Marks { get; set; }

        SubjectClass()
        { }
        SubjectClass(string path)
        {
        }

        public void Export(bool rewrite = false)
        {
            if (File.Exists(Filename) && rewrite == false)
            {
                throw new Exception("File with such filename exists. Use Export(bool rewrite=true) to rewrite this file");
            }
            if(File.Exists(Filename)&& rewrite==true)
            {
                File.Delete(Filename);
                XmlWriter xmlio = XmlWriter.Create("script");
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

                    xmlio.WriteStartElement("images");
                    if (!Directory.Exists("res")) Directory.CreateDirectory("res");
                    int counter = 0;
                    foreach(Image img in task.Images)
                    {
                        string path = @"res/img" +task.Label+ counter+".jpg";
                        img.Save(path);
                        xmlio.WriteElementString("image", path);
                        counter++;
                    }
                    xmlio.WriteEndElement();

                    xmlio.WriteStartElement("answers");
                    foreach(AnswerClass answer in task.Answers)
                    {
                        
                    }
                }
            }
        }

    }
}
