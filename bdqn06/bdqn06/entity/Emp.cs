using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace bdqn06.entity
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
        private float baseMoney;

        public float BaseMoney
        {
            get { return baseMoney; }
            set { baseMoney = value; }
        }
        public void DaKa()
        {
            Console.WriteLine("上下班打卡！");
        }

        /// <summary>
        /// 父类显示无参构造方法
        /// </summary>
        private List<Job> jobs = new List<Job>();

        public List<Job> Jobs
        {
            get { return jobs; }
            set { jobs = value; }
        }


        public Emp()
        {
            Console.WriteLine("这是父类显示声明无参构造方法！");
        }
        
        public Emp(string empCode,string empName,string empSex,int empAge)
        {
            Console.WriteLine("调用了有参构造方法！");
            this.empCode = empCode;
            this.empName = empName;
            this.empSex = empSex;
            this.empAge = empAge;
        }
    }
}
