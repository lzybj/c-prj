using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mis.entity
{
    public class Emp
    {
        private string empCode;

        public string EmpCode
        {
            get { return empCode; }
            set { empCode = value; }
        }
        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public Emp(string empCode,string empName)
        {
            this.empCode = empCode;
            this.empName = empName;
        }
    }
}
