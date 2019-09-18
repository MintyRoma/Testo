using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Linq;
using System.Text;

namespace Testo
{
    public class TestClass
    {
        public string filename = "test.sft";
        public string stat = "Подготовка к сборке";
        public int steps = 49;
        public string Status
        {
            get { return stat; }
            set
            {
                stat = value;
                StatusChanged?.Invoke();
            }
        }

        public delegate void stChanged();
        public event stChanged StatusChanged;
        public TestClass()
        {
            
        }

        public void Start()
        {
            //script here
            Status = "Генерация листа оценок";
            Thread.Sleep(100);
            List<MarkClass> marks = new List<MarkClass>();
            Status = "Генерация оценки";
            Thread.Sleep(100);
            MarkClass mrk = new MarkClass("Good", 0.6);
            Status = "Запись оценки в память";
            Thread.Sleep(100);
            marks.Add(mrk);
            Status = "Генерация оценки";
            Thread.Sleep(100);
            MarkClass mrk1 = new MarkClass("Awfull", 0.0);
            Status = "Запись оценки в память";
            Thread.Sleep(100);
            marks.Add(mrk1);

            Status = "Генерация класса задания";
            Thread.Sleep(100);
            TaskClass tsk1 = new TaskClass();
            Status = "Сохранение заголовка задания 1";
            Thread.Sleep(100);
            tsk1.Label = "Lorem label";
            Status = "Сохранение текста задания 1";
            Thread.Sleep(100);
            tsk1.Text = "Lorem ipsum sit dolor amet \n so here is some example text";
            Status = "Сохранение типа ответа задания 1";
            Thread.Sleep(100);
            tsk1.Answer_Type = AnswerType.String;
            Status = "Сохранение ответа задания 1";
            Thread.Sleep(100);
            tsk1.Answer = "Hi";

            Status = "Генерация класса задания";
            Thread.Sleep(100);
            TaskClass tsk2 = new TaskClass();
            Status = "Сохранение заголовка задания 2";
            Thread.Sleep(100);
            tsk2.Label = "Label";
            Status = "Сохранение текста задания 2";
            Thread.Sleep(100);
            tsk2.Text = "Txt";
            Status = "Сохранение типа ответа задания 2";
            Thread.Sleep(100);
            tsk2.Answer_Type = AnswerType.Radio;
            Status = "Сохранение ответа 1 задания 2";
            Thread.Sleep(100);
            tsk2.Answers.Add("Hi");
            Status = "Сохранение ответа 2 задания 2";
            Thread.Sleep(100);
            tsk2.Answers.Add("I'm not the right answer");
            Status = "Сохранение ответа 3 задания 2";
            Thread.Sleep(100);
            tsk2.Answers.Add("I answer");
            Status = "Сохранение верного ответа задания 2";
            Thread.Sleep(100);
            tsk2.Answer = "Hi";
            Status = "Загрузка изображения";
            Thread.Sleep(100);
            Bitmap img = new Bitmap(@"C:\Users\srdhe\OneDrive\Изображения\ПЕ алерт.png");
            Status = "Изображение было сохранено";
            Thread.Sleep(100);
            Status = "Загрузка изображения";
            Thread.Sleep(100);
            Image img1 = Image.FromFile(@"C:\Users\srdhe\OneDrive\Изображения\cs.jpg");
            Status = "Изображение было сохранено";
            Thread.Sleep(100);
            Status = "Сохранение данных о изображениях в памяти";
            Thread.Sleep(100);
            tsk2.Images.Add(img, "");
            tsk2.Images.Add(img1, "");

            Status = "Генерация класса задания";
            Thread.Sleep(100);
            TaskClass tsk3 = new TaskClass();
            Status = "Сохранение заголовка задания 3";
            Thread.Sleep(100);
            tsk3.Label = "Task 3";
            Status = "Сохранение текста задания 3";
            Thread.Sleep(100);
            tsk3.Text = "Данное задание нужно для тестирование поведения работы CheckBox";
            Status = "Сохранение типа ответа задания 3";
            Thread.Sleep(100);
            tsk3.Answer_Type = AnswerType.CheckBox;
            Status = "Сохранение ответа 1 задания 3"; Thread.Sleep(100);
            tsk3.Answers.Add("Answer 1");
            Status = "Сохранение ответа 2 задания 3"; Thread.Sleep(100);
            tsk3.Answers.Add("Not Answer");
            Status = "Сохранение ответа 3 задания 3"; Thread.Sleep(100);
            tsk3.Answers.Add("Answer 2");
            Status = "Сохранение верного ответа"; Thread.Sleep(100);
            tsk3.Answer = "Answer 1|Answer 2";

            Status = "Генерация класса задания"; Thread.Sleep(100);
            TaskClass tsk4 = new TaskClass();
            Status = "Сохранение заголовка задания 4"; Thread.Sleep(100);
            tsk4.Label = "Task 4";
            Status = "Сохранение текста задания 4"; Thread.Sleep(100);
            tsk4.Text = "Данное задание необходимо для тестирования поведения работы Order";
            Status = "Сохранение типа ответа задания 4"; Thread.Sleep(100);
            tsk4.Answer_Type = AnswerType.Order;
            Status = "Сохранение ответа 1 задания 4"; Thread.Sleep(100);
            tsk4.Answers.Add("Это 3 элемент");
            Status = "Сохранение ответа 2 задания 4"; Thread.Sleep(100);
            tsk4.Answers.Add("Это 1 элемент");
            Status = "Сохранение ответа 3 задания 4"; Thread.Sleep(100);
            tsk4.Answers.Add("Это 2 элемент");
            Status = "Сохранение правильного ответа"; Thread.Sleep(100);
            tsk4.Answer = "3-\"Это 3 элемент\"|1-\"Это 1 элемент\"|2-\"Это 2 элемент\"";

            Status = "Генерация основного класса"; Thread.Sleep(100);
            SubjectClass sub = new SubjectClass();
            Status = "Установка параметров класса предмета"; Thread.Sleep(100);
            sub.AllowRemake = true;
            Status = "Запись названия файла предмета"; Thread.Sleep(100);
            sub.Filename = "test";
            Status = "Запись имени предмета"; Thread.Sleep(100);
            sub.Name = "Test1";
            Status = "Запись заданий"; Thread.Sleep(100);
            sub.Tasks.Add(tsk1);
            sub.Tasks.Add(tsk2);
            sub.Tasks.Add(tsk3);
            sub.Tasks.Add(tsk4);
            sub.Marks.Add(mrk);
            sub.Marks.Add(mrk1);
            Status = "Экспорт файла"; Thread.Sleep(100);
            sub.Export(true);
            Status = "Считавние файла для обратной записи"; Thread.Sleep(100);
            byte[] fl = File.ReadAllBytes($"test.sft");
            byte[] res;
            List<byte> tmplist = new List<byte>();
            Status = "Расшифровка файла"; Thread.Sleep(100);
            foreach (byte tmp in fl)
            {
                var vt = ~tmp;
                tmplist.Add((byte)vt);
            }
            res = tmplist.ToArray();
            Status = "Запись резервного файла"; Thread.Sleep(100);
            File.WriteAllBytes($"testinv.sft", res);
            //sub.Import("test.sft");
            Status = "Завершено"; //Thread.Sleep(100);
        }
    }
}
