using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduAtmo.Elements
{
    class Subject
    {
        #region Private Data
        private string name;
        private bool again = false;
        private bool random = false;
        private bool backtimer = false;
        private bool show = false;
        private List<Mark> marks = new List<Mark>();
        private Queue<Task> tasks = new Queue<Task>();
        #endregion

        #region Fields
        public string Name { get { return name; } }
        public bool Again { get { return again; } }
        public bool Random { get { return random; } }
        public bool BackTimer { get { return backtimer; } }
        public bool ShowAnswers { get { return show; } }
        #endregion

        #region Funcs
        public Subject(string nam)
        {
            if (name != null) name = nam;
            else name = "EduAtmo";
        }

        public void ImportProperties(SubjectProperties props)
        {
            if(props!=null)
            {
                again = props.again;
                random = props.random;
                backtimer = props.backtimer;
                show = props.show;
            }
        }

        public void ImportMarks(List<Mark> mrks)
        {
            if (mrks != null) marks = mrks;
            else throw new NullMarksImported();
        }

        public void ImportTasks(List<Task> tsks)
        {
            if (tsks != null)
            {
                foreach (Task TMPTask in tsks)
                {
                    tasks.Enqueue(TMPTask);
                }
            }
            else throw new NullTasksImported();
        }

        public Task PresentLastTask()
        {
            Task tsk = tasks.Dequeue();
            return tsk;
        }
        #endregion

        #region Exceptions
        public class NullTasksImported:Exception
        {
            private string message = "Был передан лист заданий который равен null";
            public override string Message { get { return message; } }
        }
        public class NullMarksImported : Exception
        {
            private string message = "Был передан лист оценок который равен null";
            public override string Message { get { return message; } }
        }
        #endregion
    }
}
