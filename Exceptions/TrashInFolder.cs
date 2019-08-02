using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo.Exceptions
{
    public class TrashInFolder :Exception
    {
        public string Text { get { return "Some files and directories which was reserved for packaging are in folder of application"; } }
    }
}
