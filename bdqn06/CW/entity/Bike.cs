using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW.entity
{
    class Bike : JiaoTongTools
    {
        public override void run()
        {
            Console.WriteLine("自行车飘起来了！");
        }
        public override void run(Emp emp)
        {
            Console.WriteLine(emp.EmpName + ":自行车飘起来了！");
        }
    }
}
