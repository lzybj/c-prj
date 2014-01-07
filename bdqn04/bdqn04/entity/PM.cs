using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn04.entity
{
    public class PM
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
        private int prjMoney;

        public int PrjMoney
        {
            get { return prjMoney; }
            set { prjMoney = value; }
        }
        private int compMoney;

        public int CompMoney
        {
            get { return compMoney; }
            set { compMoney = value; }
        }
        public PM(string empName,string empLevel,int baseMoney,int prjMoney,int compMoney)
        {
            this.empName = empName;
            this.empLevel = empLevel;
            this.baseMoney = baseMoney;
            this.prjMoney = prjMoney;
            this.compMoney = compMoney;
        }
        public PM(string empName,int prjMoney,int compMoney)
        {
            this.empName = empName;
            this.empLevel = "项目经理";
            this.baseMoney = 3000;
            this.prjMoney = prjMoney;
            this.compMoney = compMoney;
        }
    }
}
