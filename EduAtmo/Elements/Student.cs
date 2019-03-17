using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduAtmo.Elements
{
    class Student
    {
        #region Private Data
        private string fio;
        private string group;
        private Mark mark;
        private List<Answer> answers = new List<Answer>();
        private List<Task> tasks;
        private bool[] rights = new bool[] { };
        #endregion

        #region Fields
        public string FIO { get{ return fio; } }
        public string Group { get { return group; } }
        public string MarkName { get { return mark.Name; } }
        #endregion

        #region Funcs
        public Student(string name,string grop)
        {
            if(name!=null && grop != null)
            {
                fio = name;
                group = grop;
            }
        }

        public void CalculateMark(List<Mark> marks)
        {
            double StPoints=0; //Points of Student
            for(int i=0;i<answers.Count();i++)
            {
                if(rights[i]==true)
                {
                    StPoints+=tasks[i].Points;
                }
            }
            double MaxPoints = 0; //Maximum Points
            for (int i = 0; i < answers.Count(); i++)
            {
                MaxPoints += tasks[i].Points;
            }
            double[] pointlist = new double[] { }; //Limits of rates
            for(int i=0;i<marks.Count();i++)
            {
                pointlist[i] = Convert.ToInt32((marks[i].Rate / 100) * MaxPoints);
            }
            for(int i=0;i<pointlist.Count();i++)
            {
                if(pointlist[i]>StPoints)
                {
                    mark = marks[i - 1];
                }
            }
        }
        #endregion
    }
}
