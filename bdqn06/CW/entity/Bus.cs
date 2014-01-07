using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW.entity
{
    public class Bus :JiaoTongTools
    {
        public override void run()
        {
            Console.WriteLine("公交车票起来了！");
        }
        public override void run(Emp emp)
        {
            Console.WriteLine(emp.EmpName + ":公交车！");
        }
    }
}
