using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn04.entity
{
    public class SE
    {
        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        private string empLevel;

        public string EmpLevel
        {
            get { return empLevel; }
            set { empLevel = value; }
        }
        private int baseMoney;

        public int BaseMoney
        {
            get { return baseMoney; }
            set { baseMoney = value; }
        }
        private int kaoMoney;

        public int KaoMoney
        {
            get { return kaoMoney; }
            set { kaoMoney = value; }
        }
        public SE(string empName,string empLevel,int baseMoney,int kaoMoney)
        {
            this.empName = empName;
            this.empLevel = empLevel;
            this.baseMoney = baseMoney;
            this.kaoMoney = kaoMoney;
        }
        public SE(string empName,int kaoMoney)
        {
            this.empName = empName;
            this.empLevel = "程序员";
            this.baseMoney = 2000;
            this.kaoMoney = kaoMoney;
        }
    }
}
