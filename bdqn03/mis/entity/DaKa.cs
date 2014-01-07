using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mis.entity
{
    public class DaKa
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

        private Emp emp;

        public Emp Emp
        {
            get { return emp; }
            set { emp = value; }
        }
        private DateTime qianDaoTime;

        public DateTime QianDaoTime
        {
            get { return qianDaoTime; }
            set { qianDaoTime = value; }
        }
        private DateTime qianTuiTime;

        public DateTime QianTuiTime
        {
            get { return qianTuiTime; }
            set { qianTuiTime = value; }
        }
    }
}
