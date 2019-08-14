using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo.Exceptions
{
    class WrongHash: Exception
    {
        private string message = "Файл был перезаписан, изменен или поврежден. Хеши не совпадают!\nЗамените файл";
        public override string Message => message;

        public WrongHash(string filename)
        {
            message = $"Файл {filename} был перезаписан, изменен или поврежден. Хеши не совпадают!\nЗамените файл";
        }
    }
}
