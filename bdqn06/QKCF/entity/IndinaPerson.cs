using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QKCF.entity
{
    public class IndinaPerson : Person
    {
        public override void talk()
        {
            Console.WriteLine("印度人说印度话！");
        }

        public override void eat()
        {
            Console.WriteLine("用手抓吃饭！");
        }
    }
}
