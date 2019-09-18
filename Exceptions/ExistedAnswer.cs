using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo.Exceptions
{
    class ExistedAnswer: Exception
    {
        private string message = "Не может быть два одинаковых ответа";
        public override string Message => message;
        public override string HelpLink { get => "https://github.com/MintyRoma/Testo"; }
        public ExistedAnswer(bool Adding = false)
        {
            if (Adding) message = "Не может быть два одинаковых ответа\n Переименуйте добавленный ответ";
        }
    }
}
