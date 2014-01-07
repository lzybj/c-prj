using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW.entity
{
    public class Car : JiaoTongTools
    {
        public override void run()
        {
            Console.WriteLine("私家车跑起来了！");
        }
        public override void run(Emp emp)
        {
            Console.WriteLine(emp.EmpName + ":私家车！");
        }
        public void JiaoYou()
        {
            Console.WriteLine("小轿车得加油！");
        }

    }
}
