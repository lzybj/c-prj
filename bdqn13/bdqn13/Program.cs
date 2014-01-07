using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn13
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerService cs = new ComputerService();
            //cs.findByBrand("DELL");
            Computer myComputer = cs.findByComputerName("ThinkPad SL400");
            if (myComputer is PC)
            {
                Console.WriteLine((myComputer as PC).HostType);
            }
            else
            {
                Console.WriteLine((myComputer as NoteBook).Battery);
            }
        }
    }
}
