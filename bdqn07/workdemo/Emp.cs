using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace workdemo
{
    public class Emp
    {
        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        private List<Job> myJob;

        public List<Job> MyJob
        {
            get { return myJob; }
            set { myJob = value; }
        }
    }
}
