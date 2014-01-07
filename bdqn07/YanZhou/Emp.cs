using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YanZhou
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
        private int renQi;

        public int RenQi
        {
            get { return renQi; }
            set { renQi = value; }
        }
        public Emp(string empCode,string empName,int renQi)
        {
            this.empCode = empCode;
            this.empName = empName;
            this.renQi = renQi;
        }

        public string Play(YueQi yueqi)
        {
            string str = "";
            str = this.empName + "进行" + yueqi.YanZou();
            return str;
        }
    }
}
