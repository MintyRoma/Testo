using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Testo
{
    public class TestClass
    {
        public TestClass()
        {
            //script here
            List<MarkClass> marks = new List<MarkClass>();
            MarkClass mrk = new MarkClass("Good",0.6);
            MarkClass mrk1 = new MarkClass("Awfull", 0.0);
            marks.Add(mrk);
            marks.Add(mrk1);

            TaskClass tsk1 = new TaskClass();
            tsk1.Label = "Lorem label";
            tsk1.Text = "Lorem ipsum sit dolor amet \n so here is some example text";
            tsk1.Answer_Type = AnswerType.String;
            tsk1.Answer = "Hi";

            TaskClass tsk2 = new TaskClass();
            tsk2.Label = "Label";
            tsk2.Text = "Txt";
            tsk2.Answer_Type = AnswerType.Radio;
            tsk2.Answers.Add("Hi");
            tsk2.Answers.Add("I'm not the right answer");
            tsk2.Answers.Add("I answer");
            tsk2.Answer="Hi";
            Bitmap img = new Bitmap(@"C:\Users\srdhe\OneDrive\Изображения\ПЕ алерт.png");
            tsk2.Images.Add(img);

            SubjectClass sub = new SubjectClass();
            sub.AllowRemake = true;
            sub.Filename = "test";
            sub.Name = "Test1";
            sub.Tasks.Add(tsk1);
            sub.Tasks.Add(tsk2);
            sub.Marks.Add(mrk);
            sub.Marks.Add(mrk1);
            sub.Export(true);
            byte[] fl = File.ReadAllBytes($"test.sft");
            byte[] res;
            List<byte> tmplist = new List<byte>();
            foreach (byte tmp in fl)
            {
                var vt = ~tmp;
                tmplist.Add((byte)vt);
            }
            res = tmplist.ToArray();
            File.WriteAllBytes($"testinv.sft", res);
            sub.Import("test.sft"); 
        }
    }
}
