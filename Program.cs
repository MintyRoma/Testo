using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            if (args.Count() > 0)
            {
                if (args[0] == "/b")
                {
                    Application.Run(new TaskBuild());
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new EditSubject());
            }
        }
    }
}
