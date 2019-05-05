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
        public static int BUILD = 12;
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
        }

        #endregion

        #region Tools
        public static string[] FindSubs()
        {
            string[] subs = Directory.GetFiles("Subjects"); ;
            for (int i = 0; i < subs.Count(); i++)
            {
                string tmp = subs[i].Substring(9);
                tmp = tmp.Remove(tmp.Count() - 4, 4);
                subs[i] = tmp;
            }
            return subs;
        }
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
                MessageBox.Show(node.LocalName);
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
                foreach (XmlNode task in TasksNode)
                {
                    switch (task.LocalName)
                    {
                        case "":

                            break;
                    }
                }
                return TMP;
            }
            catch (Exception ex)
            {
                BrokenTaskList();
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