using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RefTest.entity;

namespace RefTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp("laozheng",0);
            int par = 10;
            TestService ts = new TestService();
            ts.NumAdd(ref par);
            Console.WriteLine(par);
            ts.NumAddObj(emp);
            Console.WriteLine(emp.EmpNum);

        }
    }
}
