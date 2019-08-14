using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo.Exceptions
{
    class FileExists:Exception
    {
        public override string Message => "Файл уже находится в папке с предметами и его перезапись была запрещена";
        public override string HelpLink { get => "https://github.com/MintyRoma/Testo"; }
    }
}
