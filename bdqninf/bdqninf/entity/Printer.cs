using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bdqninf.inf;

namespace bdqninf.entity
{
    public class Printer
    {
        public void print(InkBox inkbox,IPaper paper)
        {
            Console.WriteLine("用" + inkbox.getColor() + "打印" + paper.PaperSize());
        }

    }
}
