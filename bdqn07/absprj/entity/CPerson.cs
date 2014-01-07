using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace absprj.entity
{
    public class CPerson : Person
    {
        public override void talk()
        {
            Console.WriteLine("说中国话！");
        }
        public override void eat()
        {
            Console.WriteLine("用筷子吃饭！");
        }
    }
}
