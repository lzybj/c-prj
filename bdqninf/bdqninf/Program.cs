using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bdqninf.inf;
using bdqninf.entity;

namespace bdqninf
{
    class Program
    {
        static void Main(string[] args)
        {
            InkBox caise = new CaiSeInkBox();
            IPaper a4 = new A4Paper();
            Printer mypr = new Printer();
            mypr.print(caise,a4);
        }
    }
}
