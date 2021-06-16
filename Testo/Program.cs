using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Testo.Forms;

namespace Testo
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Contains("CreateConfig")) Application.Run(new SetUpForm());
            else if (File.Exists("profiles.xml")) Application.Run(new Start());
            else Application.Run(new Forms.NoProfilesForm());
        }
    }
}
