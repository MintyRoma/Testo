using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Testo.Classes
{
    public class Answer
    {
        private string id;
        private string text;

        public string ID
        {
            get { return id; }
        }
        public string Text
        {
            get { return text; }
        }

        /// <summary>
        /// Конструктор для класса Answer
        /// </summary>
        /// <param name="answer">Текст ответа</param>
        /// <param name="Id">ID для ответа</param>
        public Answer(string answer, string Id)
        {
            id = Id;
            text = answer;
        }

        /// <summary>
        /// Конструктор для класса Answers с самостоятельной генерацией ID
        /// </summary>
        /// <param name="answer">Текст ответа</param>
        public Answer(string answer)
        {
            string lib = "ABCDEFGHIJKLMOPQRSTUVWXYZ0123456789";
            string Id = "";
            Random rnd = new Random();
            for (int i = 0; i< 4; i++)
            {
                Id += lib[rnd.Next(lib.Length+i)];
            }
            id = Id;
            text = answer;
        }
    }
}
