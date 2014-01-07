using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn021.entity
{
    class Emp
    {
        //默认构造方法
        public Emp()
        {
        }
        //有参构造方法
        public Emp(string empCode,string empName,int age)
        {
            this.empCode = empCode;
            this.empName = empName;
            this.age = age;
        }
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


        private int age;

        public int Age
        {
            get { return age; }
        }


    }
}
