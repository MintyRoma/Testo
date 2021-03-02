using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace Testo.Classes
{
    public class Mark
    {
        private string name;
        private double perc;

        public string Name => name;
        public double Percentage => perc;

        public Mark(string nam, double percentage)
        {
            name = nam;
            perc = percentage;
        }
    }
}
