using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduAtmo.Elements
{
    class Answer
    {
        #region Private Data
        private int id;
        private string text;
        #endregion

        #region Fields
        public int ID { get { return id; } }
        public string Text { get { return text} }
        #endregion

        #region Funcs
        public Answer(int _id, string value)
        {
            if((_id>0)&&(value!=null))
            {
                id = _id;
                text = value;
            }
        }
        #endregion
    }
}
