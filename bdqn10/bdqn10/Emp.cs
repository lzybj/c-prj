using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn10
{
    public class Emp
    {
        private string empcode;

        public string Empcode
        {
            get { return empcode; }
            set { empcode = value; }
        }
        private string empname;

        public string Empname
        {
            get { return empname; }
            set { empname = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Emp(string empcode,string empname,int age)
        {
            this.empcode = empcode;
            this.empname = empname;
            this.age = age;
        }
    }
}
