using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo
{
    class AnswerClass
    {
        private int id;
        private string text;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Text
        {
            get { return text; }
        }

        AnswerClass(string txt, int Id)
        {
            id = Id;
            text = txt;
        }
    }
}
