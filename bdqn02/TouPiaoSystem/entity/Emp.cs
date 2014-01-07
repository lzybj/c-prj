using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TouPiaoSystem.entity
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
        private string empSex;

        public string EmpSex
        {
            get { return empSex; }
            set { empSex = value; }
        }
        private int empAge;

        public int EmpAge
        {
            get { return empAge; }
            set { empAge = value; }
        }
        private int empNum;//票数

        public int EmpNum
        {
            get { return empNum; }
            set { empNum = value; }
        }
        public Emp(string empCode,string empName,string empSex,int empAge,int empNum)
        {
            this.empCode = empCode;
            this.empName = empName;
            this.empSex = empSex;
            this.empAge = empAge;
            this.empNum = empNum;
        }
    }
}
