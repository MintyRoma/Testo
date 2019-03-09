using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduAtmo.Elements
{
    class Mark
    {
        #region Private Data
        private int rate;
        private string name;
        #endregion

        #region Fields
        public int Rate { get { return rate; } }
        public string Name { get { return name; } }
        #endregion

        #region Funcs
        public Mark(string _Name, int _Rate)
        {
            if (_Name!=null&&_Rate!=null)
            {
                name = _Name;
                rate = _Rate;
            }
        }
        #endregion
    }
}
