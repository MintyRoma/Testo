using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Testo
{
    public class TaskClass
    {
        private string label;
        private string text;
        private AnswerType anst;
        private Dictionary<Image,string> imgs = new Dictionary<Image, string>();
        private List<string> answers = new List<string>();
        private string answer;

        public delegate void lblbChanged();
        public delegate void textchanged();
        public delegate void imageschanged();
        public delegate void answerschanged();
        public delegate void answerchanged();

        public event lblbChanged LabelChanged;
        public event textchanged TextChanged;
        public event imageschanged ImagesListChanged;
        public event answerschanged AnswersChanged;
        public event answerchanged AnswerChanged;

        public string Label
        {
            get { return label; }
            set
            {
                label = value;
                if (LabelChanged!=null)LabelChanged();
            }
        }
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                if(TextChanged!=null)TextChanged();
            }
        }
        public Dictionary<Image,string> Images
        {
            get { return imgs; }
            set
            {
                imgs = value;
                if (ImagesListChanged!=null)ImagesListChanged();
            }
        }
        public List<string> Answers
        {
            get { return answers; }
            set
            {
                answers = value;
                if (AnswersChanged!=null)AnswerChanged();
            }
        }
        public string Answer
        {
            get { return answer; }
            set
            {
                answer = value;
                if (AnswersChanged!=null)AnswersChanged();
            }
        }
        public AnswerType Answer_Type
        {
            get { return anst; }
            set { anst = value; }
        }
        public bool CheckAnswer(string ans)
        {
            if (ans == answer) return true;
            else return false;
        }

        public void Dispose()
        {
            foreach(KeyValuePair<Image,string> img in Images)
            {
                img.Key.Dispose();
            }
            Images.Clear();
        }
    }
}
