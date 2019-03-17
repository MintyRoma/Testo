using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduAtmo.Elements
{
    class Task
    {
        enum AnswerType
        {
            Textbox,
            Checkbox,
            Radio,
            Order,
            Image,
        };

        #region Private Data
        private string name;
        private string text;
        private int id;
        private int backtimer = -1;
        private List<Answer> answers = new List<Answer>();
        private Answer right;
        private double points;
        #endregion

        #region Fields
        public string Name { get { return name; } }
        public string Text { get { return text; } }
        public int ID { get { return id; } }
        public int Timer { get { return backtimer; } }
        public double Points { get { return points; } }
        #endregion

        #region Funcs
        public void ImportAnswers(List<Answer> ansrs, Answer whatright)
        {
            if(ansrs!=null&&whatright!=null)
            {
                answers = ansrs;
                right = whatright;
            }
        }

        public Task(TaskProperties prop)
        {
            if(prop.IsNotEmpty())
            {
                id = prop.id;
                name = prop.name;
                text = prop.text;
                backtimer = prop.time;
                points = prop.points;
            }
        }
        #endregion
    }
}
