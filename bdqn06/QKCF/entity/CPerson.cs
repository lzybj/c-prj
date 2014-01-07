using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QKCF.entity
{
    public class CPerson : Person
    {
        public override void talk()
        {
            Console.WriteLine("中国人说中国话！");
        }

        public override void eat()
        {
            Console.WriteLine("中国人吃饭用筷子！");
        }
    }
}
