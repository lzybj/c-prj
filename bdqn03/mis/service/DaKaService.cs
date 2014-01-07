using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using mis.entity;

namespace mis.service
{
    public class DaKaService
    {
        public bool QianDao(Dictionary<string,DaKa> daKaData,Emp emp)
        {
            foreach (string key in daKaData.Keys)
            {
                if (key.Equals(emp.EmpCode))
                {
                    return false;
                }
            }
            DaKa myLog = new DaKa();
            myLog.Emp = emp;
            myLog.EmpCode = emp.EmpCode;
            myLog.EmpName = emp.EmpName;
            myLog.QianDaoTime = DateTime.Now;
            daKaData.Add(emp.EmpCode, myLog);
            return true;
        }
        public bool QianTui(Dictionary<string,DaKa> daKaData,Emp emp)
        {
            foreach (string empcode in daKaData.Keys)
            {
                if (empcode.Equals(emp.EmpCode))
                {
                    DaKa daka = daKaData[empcode];
                    daka.QianTuiTime = DateTime.Now;
                    return true;
                }
            }
            return false;
        }
    }
}
