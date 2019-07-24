using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Testo
{
    class TaskClass
    {
        private string label;
        private string text;
        private int id;
        private 
        private List<Image> imgs = new List<Image>();
        private List<AnswerClass> answers = new List<AnswerClass>();
        private AnswerClass answer;


        public EventHandler LabelChanged;
        public EventHandler TextChanged;
        public EventHandler ImagesListChanged;
        public EventHandler AnswersChanged;
        public EventHandler AnswerChanged;

        public string Label
        {
            get { return label; }
            set
            {
                label = value;
                LabelChanged(this, EventArgs.Empty);
            }
        }
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                TextChanged(this, EventArgs.Empty);
            }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public List<Image> Images
        {
            get { return imgs; }
            set
            {
                imgs = value;
                ImagesListChanged(this, EventArgs.Empty);
            }
        }
        public List<AnswerClass> Answers
        {
            get { return answers; }
            set
            {
                answers = value;
                AnswersChanged(this, EventArgs.Empty);
            }
        }
        public AnswerClass Answer
        {
            get { return answer; }
            set
            {
                answer = value;
                AnswersChanged(this, EventArgs.Empty);
            }
        }

        public bool CheckAnswer(AnswerClass ans)
        {
            if (ans == answer) return true;
            else return false;
        }
    }
}
