using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo.Exceptions
{
    public class SFTNotExists:Exception
    {
        public override string StackTrace => base.StackTrace;
        public override string Message { get => "Указанный .sft файл не существует. Проверьте правильность указания пути к файлу или перезапустите программу"; }
        public override string HelpLink { get => "https://github.com/MintyRoma/Testo"; }
    }
}
