using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo.Exceptions
{
    class WrongFile: Exception
    {
        public override string Message => "Файл предмета существует, но был поврежден";
        public override string HelpLink { get => "https://github.com/MintyRoma/Testo"; }
        public override string StackTrace => base.StackTrace;
    }
}
