using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingFenSystem.entity
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

        private int empAge;

        public int EmpAge
        {
            get { return empAge; }
            set { empAge = value; }
        }
        private int empTotal;//评分

        public int EmpTotal
        {
            get { return empTotal; }
            set { empTotal = value; }
        }

        private string empContent;//评价

        public string EmpContent
        {
            get { return empContent; }
            set { empContent = value; }
        }

        public Emp(string empCode,string empName,int empAge,int empTotal,string empContent)
        {
            this.empCode = empCode;
            this.empName = empName;
            this.empAge = empAge;
            this.empTotal = empTotal;
            this.empContent = empContent;
        }

    }
}
