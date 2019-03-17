using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EduAtmo
{
    static class Shell
    {

        static Elements.Storage store;

        public static void Run()
        {

            StartWindow window = new StartWindow(InitialSubjects());
        }

        private static string[] InitialSubjects()
        {
            string[] subs = new string[] { };
            if (Directory.Exists("Subjects"))
            {
                if (Directory.GetFiles("Subjects").Count() != 0)
                {
                    subs = Directory.GetFiles("Subjects");
                    return subs;

                }
                else
                {
                    subs[0] = "!EMPTY!";
                    return subs;
                }
            }
            else
            {
                return InitialSubjects();
            }
        }

        public static void StartTest(string name, string group, string subject)
        {

        }
    }
}
