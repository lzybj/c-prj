using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefTest.entity
{
    public class Emp
    {
        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        private int empNum;

        public int EmpNum
        {
            get { return empNum; }
            set { empNum = value; }
        }
        public Emp(string empName,int empNum)
        {
            this.empName = empName;
            this.empNum = empNum;
        }
    }
}
