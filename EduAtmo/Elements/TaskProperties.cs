using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduAtmo.Elements
{
    class TaskProperties
    {
        #region Fields
        public int id;
        public string name;
        public string text;
        public int time=-1;
        public double points;
        #endregion

        public bool IsNotEmpty()
        {
            bool empty = false;
            if (id == null) empty = true;
            if (name == null) empty = true;
            if (text == null) empty = true;
            if (time == null) empty = true;
            if (points == null) empty = true;
            return !empty;
        }
    }
}
