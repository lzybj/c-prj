using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QKCF.entity
{
    public class JPerson : Person
    {
        public override void talk()
        {
            Console.WriteLine("日本人说日语！");
        }

        public override void eat()
        {
            Console.WriteLine("用脚吃饭！");
        }
    }
}
