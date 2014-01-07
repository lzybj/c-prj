using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QKCF.entity
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void talk()
        {
            Console.WriteLine("说人话！");
        }

        public virtual void eat()
        {
            Console.WriteLine("吃饭！");
        }
    }
}
