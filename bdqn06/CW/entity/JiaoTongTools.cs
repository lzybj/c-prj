using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW.entity
{
    public class JiaoTongTools
    {
        public virtual void run()
        {
            Console.WriteLine("交通工具运行！");
        }
        public virtual void run(Emp emp)
        {
            Console.WriteLine(emp.EmpName + ":交通工具运行！");
        }
    }
}
