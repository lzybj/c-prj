using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace otherprj2.entity
{
    public class Demo
    {
        private Demo()
        {
        }
        public static Demo getInstance()
        {
            return new Demo();
        }
        public void ttt()
        {
            Console.WriteLine("非静态方法");
        }
        public static void yyyy()
        {
            Console.WriteLine("静态方法");
        }
    }
}
