using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn13
{
    public class ComputerFactory
    {
        public static Computer getInstance(string type)
        {
            switch (type)
            {
                case "PC":
                    return new PC();
                case "NoteBook":
                    return new NoteBook();
                default:
                    break;
            }
            return null;
        }
    }
}
