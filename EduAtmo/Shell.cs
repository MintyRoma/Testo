using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace EduAtmo
{
    static class Shell
    {
        #region Data
        public static int BUILD = 12;
        private static Elements.Storage store;
        public static string Subject = "";
        #endregion

        #region Forms
        static private StartWindow startwindow;
        #endregion

        #region Base Operators
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
        public static void StartTest(string name, string group, string subject)
        {

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
        #endregion
    }
}