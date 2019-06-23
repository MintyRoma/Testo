using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using EduAtmo.Elements;
using System.Xml;

namespace EduAtmo
{
    /// <summary>
    /// Runtime Execution Class. Works like Core.
    /// </summary>
    static class Shell
    {
        #region Data
        /// <summary>
        /// Build Number
        /// </summary>
        public static int BUILD = 14;
        private static Elements.Storage store = new Storage();
        public static string subject = "";
        #endregion

        #region Forms
        static private StartWindow startwindow;
        static private GUI.ActiveTest activetest;
        #endregion

        #region Base Methods
        static Shell()
        {

        }
        public static void FirstWindow()
        {
            startwindow = new StartWindow(FindSubs());
            startwindow.Show();
        }
        public static void Close()
        {
            Application.Exit();
        }
        public static void StartTest(string name, string group)
        {
            Student st = new Student(name.ToLower(), group.ToLower());
            store.student = st;
            //Initial Subject and it's props
            Subject MAINSUB = new Subject(subject);
            MAINSUB.ImportProperties(ImportProps());
            List<Task> tsks = new List<Task>();
            tsks = ImportTasks();
            MAINSUB.ImportTasks(tsks);
            store.subject = MAINSUB;
            activetest = new GUI.ActiveTest();
            activetest.ImportTask(store.subject.PresentLastTask());
            activetest.Show();
        }

        #endregion

        #region Tools
        /// <summary>
        /// Returns list of .fos files
        /// </summary>
        /// <returns>string[]</returns>
        public static string[] FindSubs()
        {
            string[] subs = Directory.GetFiles("Subjects");
            List<string> subjectsInFolder = new List<string>();
            foreach (string sub in subs)
            {
                if (sub.Substring(sub.Count() - 4) == ".fos") subjectsInFolder.Add(sub);
            }
            for (int i = 0; i < subjectsInFolder.Count(); i++)
            {
                string tmp = subjectsInFolder[i].Substring(9);
                tmp = tmp.Remove(tmp.Count() - 4, 4);
                subjectsInFolder[i] = tmp;
            }
            subs = subjectsInFolder.ToArray();
            return subs;
        }
        /// <summary>
        /// Import properties of Subjects from subject file
        /// </summary>
        /// <returns>SubjectProperties</returns>
        private static SubjectProperties ImportProps()
        {
            SubjectProperties TMP = new SubjectProperties();

            //Reading XML
            XmlDocument Doc = new XmlDocument();
            Doc.Load($"Subjects/{subject}.fos");
            XmlNode root = Doc.DocumentElement;
            XmlNode PARAMSNODE = root.SelectSingleNode("PARAMS");
            foreach (XmlNode node in PARAMSNODE.ChildNodes)
            {
                //MessageBox.Show(node.LocalName);
                switch (node.LocalName)
                {
                    case "again":
                        TMP.again = Convert.ToBoolean(node.InnerText);
                        MessageBox.Show(Convert.ToString(node.LocalName + "=" + TMP.again));
                        break;
                    case "random":
                        TMP.random = Convert.ToBoolean(node.InnerText);
                        MessageBox.Show(Convert.ToString(node.LocalName + "=" + TMP.random));
                        break;
                    case "backTimer":
                        TMP.backtimer = Convert.ToBoolean(node.InnerText);
                        MessageBox.Show(Convert.ToString(node.LocalName + "=" + TMP.backtimer));
                        break;
                    case "showRight":
                        TMP.show = Convert.ToBoolean(node.InnerText);
                        MessageBox.Show(Convert.ToString(node.LocalName + "=" + TMP.show));
                        break;
                    default:
                        MessageBox.Show(node.LocalName + "is unuseable");
                        break;
                } //Read Attributes
            }
            //return Properties
            return TMP;
        }

        
        /// <summary>
        /// Return List of Tasks from TaskFile (.fos)
        /// </summary>        
        private static List<Task> ImportTasks()
        {
            try
            {
                List<Task> TMP = new List<Task>();
                XmlDocument Doc = new XmlDocument();
                Doc.Load($"Subjects/{subject}.fos");
                XmlNode root = Doc.DocumentElement;
                XmlNode TasksNode = root.SelectSingleNode("QUESTIONS");
                //Filling all propperties of task
                foreach (XmlNode task in TasksNode)
                {
                    string answersstring = "";
                    TaskProperties props = new TaskProperties();
                    if (task.LocalName != "task") break;
                    props.name = task.Attributes["title"].Value;
                    foreach(XmlNode inside in task)
                    {
                        switch (inside.LocalName)
                        {
                            case "ID": //Reading task ID
                                props.id = Convert.ToInt32(inside.InnerText);
                                break;
                            case "backTime": //Reading back time
                                props.time = Convert.ToInt32(inside.InnerText);
                                break;
                            case "info": //Reading text of task and pictures
                                foreach (XmlNode inside_info in inside)
                                {
                                    switch(inside_info.LocalName)
                                    {
                                        case "text":
                                            props.text += inside_info.InnerText;
                                            break;
                                        case "pic":
                                            props.text += inside_info.OuterXml;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case "choiceType": //Reading variant of choice type
                                props.answertype = (AnswerType)Enum.Parse(typeof(AnswerType), Convert.ToString(inside.InnerText), true);
                                break;
                            case "answers": //Reading answers
                                List<Answer> answers = new List<Answer>(); //Creating answer list for task
                                foreach(XmlNode inside_answer in inside)
                                {
                                    string text="", id="";
                                    if(inside_answer.LocalName=="answer")
                                    {
                                        foreach(XmlNode inside_answer_var in inside_answer)
                                        {
                                            if (inside_answer_var.LocalName == "num") id = inside_answer_var.InnerText;
                                            if (inside_answer_var.LocalName == "text") text = inside_answer_var.InnerText;
                                        }
                                        Answer ans = new Answer(Convert.ToInt32(id), text);
#if DEBUG
                                        answersstring += id +"="+ text + "\n";
#endif
                                        answers.Add(ans);
                                    }
                                }
                                props.answers = answers;
                                break;
                            case "right": //Reading right hash
                                props.righthash = inside.InnerText;
                                break;
                            case "pointScheme":
                                props.pointscheme = (PointScheme)Enum.Parse(typeof(PointScheme), Convert.ToString(inside.InnerText), true);
                                break;
                            case "points":
                                props.points = Convert.ToDouble(inside.InnerText);
                                break;
                            default:
                                MessageBox.Show($"{inside.LocalName}={inside.InnerText} \n Неизвестный параметр");
                                break;
                        }
                    }
                    Task tsk = new Task(props);
#if DEBUG
                    MessageBox.Show($"Название = {tsk.Name}\n" +
                        $"Время = {tsk.Timer}\n" +
                        $"Задание= {tsk.Text}\n" +
                        $"Ответы:\n" +
                        $"{answersstring}\n" +
                        $"Хеш верного =  {tsk.Right}\n" +
                        $"Схема засчитывания баллов = {tsk.Point_Scheme.ToString()}\n" +
                        $"Кол-во баллов за задание = {tsk.Points}");
#endif
                    if (tsk.Check()) TMP.Add(tsk);
                    else continue;
                    
                }
                return TMP;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        #endregion
        #region Errors
        private static void BrokenTaskList()
        {

        }
        #endregion
    }
}