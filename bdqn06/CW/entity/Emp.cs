using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW.entity
{
    public class Emp
    {
        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        public void ShangBan(JiaoTongTools tools)
        {
            tools.run();
        }
        public void ShangBan2(JiaoTongTools tools)
        {
            tools.run();
        }
    }
}
