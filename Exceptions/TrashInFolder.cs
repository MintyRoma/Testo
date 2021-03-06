﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo.Exceptions
{
    public class TrashInFolder :Exception
    {
        public override string Message => "В папке с файлами предметов присутствуют лишние файлы с зарезервированными именами";
        public override string HelpLink { get => "https://github.com/MintyRoma/Testo"; }

        public override string StackTrace => base.StackTrace;
    }
}
