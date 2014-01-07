using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bdqn021.entity;

namespace bdqn021
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp myEmp = new Emp("JN010006", "LAOZHENG", 32);
            Console.WriteLine(myEmp.Age);
            Console.WriteLine(myEmp.EmpName);
        }
    }
}
