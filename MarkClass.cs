using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo
{
    public class MarkClass
    {
        private string mark;
        private double percentage;

        public int ID;
        public string Mark { get { return mark; } }
        public double Percentage { get { return percentage; } }

        public MarkClass(string name, double percent)
        {
            mark = name;
            percentage = percent;
        }
    }
}
