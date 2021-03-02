using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Ionic.Zip;

namespace Testo.Classes
{
    public class Subject
    {
        private Queue<Task> tasks = new Queue<Task>();
        private bool showans;
        private bool randomtsk;
        private bool allowrem;
        private int time;
        private int limtsk;
        private List<Mark> marks = new List<Mark>();

        public Queue<Task> Tasks => tasks;
        public bool ShowAnswer => showans;
        public bool RandomizeTasks => randomtsk;
        public bool AllowRemake => allowrem;
        public int Time => time;
        public int LimiTasks => limtsk;
        public List<Mark> Marks => marks;

        public void Import(string path)
        {
            List<Task> TMPtasks = new List<Task>();

            byte[] sbj = File.ReadAllBytes(path);
            sbj.Reverse();
            File.WriteAllBytes("TMP.rar", sbj);
            File.SetAttributes("TMP.rar", FileAttributes.Hidden);
            ZipFile zf = new ZipFile("TMP.rar");
            zf.ExtractAll("Runtime");
            DirectoryInfo di = new DirectoryInfo("Runtime");
            di.Attributes = FileAttributes.Hidden;
            
            XmlDocument Doc = new XmlDocument();
            Doc.Load($"Runtime/manifest.xml");
            XmlNode root = Doc.DocumentElement;
            XmlNode PARAMSNODE = root.SelectSingleNode("setup");
            foreach (XmlNode node in PARAMSNODE.ChildNodes)
            {
                try
                {
                    switch (node.LocalName)
                    {
                        case "allowRemake":
                            allowrem = Convert.ToBoolean(node.InnerText);
                            break;
                        case "randomTasks":
                            randomtsk = Convert.ToBoolean(node.InnerText);
                            break;
                        case "useTimer":
                            time = Convert.ToInt32(node.InnerText);
                            break;
                        case "showAnswer":
                            showans = Convert.ToBoolean(node.InnerText);
                            break;
                        default:
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Exception exc = new Exception("Canceled by system: wrong manifest");
                    throw exc;
                }
            }
            XmlNode TasksNode = root.SelectSingleNode("tasks");
            foreach (XmlNode task in TasksNode)
            {
                if (task.LocalName == "task")
                {
                    List<string> images = new List<string>();
                    string name = "";
                    string text = "";
                    TaskType type = TaskType.String;
                    bool randomize = false;
                    string right = "";
                    List<Answer> answers = new List<Answer>();
                    foreach (XmlNode data in task)
                    {
                        if (data.LocalName == "name") name = data.InnerText;
                        if (data.LocalName == "text") text = data.InnerText;
                        if (data.LocalName == "images")
                        {
                            foreach (XmlNode img in data)
                            {
                                string imgpath = img.InnerText;
                                if (File.Exists("Runtime/media" + imgpath)) images.Add(imgpath);
                                else
                                {
                                    if (MessageBox.Show($"В файле заданий был описано наличие изображения \"{imgpath}\", но изображение отсутствует. Перепроверьте наличие изображения в файле задания. \nНажмите \"ОК\" для загрузки задания без изображения, или \"Отмена\" для прекращения загрузки задания.", "Отсутствует изображение", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                                    {
                                        Exception exc = new Exception("Canceled by user: No image");
                                        throw exc;
                                    }
                                    else continue;
                                }
                            }
                        }
                        if (data.LocalName == "type")
                        {
                            switch (data.InnerText)
                            {
                                case "Checkbox":
                                    type = TaskType.Checkbox;
                                    break;
                                case "Order":
                                    type = TaskType.Order;
                                    break;
                                case "Radio":
                                    type = TaskType.Radio;
                                    break;
                                default:
                                    type = TaskType.String;
                                    break;
                            }
                        }
                        if (data.LocalName == "randomizeAnswers")
                        {
                            try
                            {
                                bool random = Convert.ToBoolean(data.InnerText);
                                randomize = random;
                            }
                            catch (Exception ex)
                            {
                                Exception exc = new Exception("Canceled by system: wrong manifest");
                                throw exc;
                            }
                        }
                        if (data.LocalName == "right")
                        {
                            right = data.InnerText;
                        }
                        if (data.LocalName == "answers")
                        {
                            foreach (XmlNode ansnumerator in data)
                            {
                                if (ansnumerator.LocalName == "answer")
                                {
                                    string id = "";
                                    string ans = "";
                                    foreach (XmlNode ansclass in ansnumerator)
                                    {
                                        if (ansclass.LocalName == "id")
                                        {
                                            id = ansclass.InnerText;
                                        }
                                        if (ansclass.LocalName == "text")
                                        {
                                            ans = ansclass.InnerText;
                                        }
                                    }
                                    if (id != "" && ans != "")
                                    {
                                        answers.Add(new Answer(ans, id));
                                    }
                                    else
                                    {
                                        Exception exc = new Exception("Canceled by system: ID or text of answer are empty");
                                    }
                                }
                            }
                        }
                    }
                    if (name == "" || text == "" || right == "")
                    {
                        Exception exc = new Exception("Canceled by system: Some data is empty");
                        throw exc;
                    }
                    if (type != TaskType.String)
                    {
                        bool available = false;
                        foreach (Answer ans in answers)
                        {
                            if (right == ans.ID) available = true;
                        }
                        if (!available)
                        {
                            Exception exc = new Exception("Canceled by system: No answer");
                            throw exc;
                        }
                        if (randomize)
                        {
                            List<Answer> copy = answers;
                            answers = copy.OrderBy(i => Guid.NewGuid()).ToList();
                        }
                    }
                    Task tmpstask = new Task(name, text, type, answers, right, randomize);
                    TMPtasks.Add(tmpstask);
                }
            }
            if (RandomizeTasks)
            {
                List<Task> tksk = TMPtasks.OrderBy(i => Guid.NewGuid()).ToList();
                tasks = new Queue<Task>(tksk);
            }
            XmlNode marking = root.SelectSingleNode("marks");
            foreach (XmlNode markcheck in marking)
            {
                if (markcheck.LocalName == "mark")
                {
                    string markname ="";
                    string markamount = "";
                    foreach(XmlNode markinfo in markcheck)
                    {
                        if (markinfo.LocalName =="name")
                        {
                            markname = markinfo.InnerText;
                        }
                        if (markinfo.LocalName == "amount")
                        {
                            markamount = marking.InnerText;
                        }
                    }
                    if (markname == "" || markamount =="")
                    {
                        throw new Exception("Canceled by system: Wrong marking");
                    }
                    double markamounting = 1;
                    try
                    {
                        int mark = Convert.ToInt32(markamount);
                        markamounting = (double)mark / 100;
                    }
                    catch(Exception ex)
                    {
                        throw new Exception("Canceled by system: Wrong marking filling");
                    }
                    Mark mrk = new Mark(markname, markamounting);
                    marks.Add(mrk);
                }
            }
        }
    }
}
