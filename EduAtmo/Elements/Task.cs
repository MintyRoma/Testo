using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduAtmo.Elements
{
    public class Task
    {

        #region Private Data
        private AnswerType answerType=AnswerType.Radio;
        private PointScheme pointScheme=PointScheme.OnlyRight;
        private string name;
        private string text;
        private int id;
        private int backtimer = -1;
        private List<Answer> answers = new List<Answer>();
        private string rightHash;
        private double points;
        #endregion

        #region Fields
        public string Name { get { return name; } }
        public string Text { get { return text; } }
        public int ID { get { return id; } }
        public int Timer { get { return backtimer; } }
        public double Points { get { return points; } }
        public string Right { get { return rightHash; } }
        public PointScheme Point_Scheme { get { return pointScheme; } }

        #endregion

        #region Funcs
        private void ImportAnswers(List<Answer> ansrs)
        {
            if(ansrs!=null)
            {
                answers = ansrs;
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
                rightHash = prop.righthash;
                pointScheme = prop.pointscheme;
                ImportAnswers(prop.answers);
            }
        }

        public bool Check()
        {
            bool allnorm = true;
            if (name == null) allnorm = false;
            if (text == null) allnorm = false;
            if ((Object)id == null) allnorm = false;
            if (answers == null) allnorm = false;
            if (rightHash == null) allnorm = false;
            if ((Object)points == null) allnorm = false;
            return allnorm;
        }
        #endregion
    }
}
