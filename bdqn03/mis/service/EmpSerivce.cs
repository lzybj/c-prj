using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using mis.entity;

namespace mis.service
{
    public class EmpSerivce
    {
        public bool AddEmp(List<Emp> data,Emp emp)
        {
            foreach (Emp empx in data)
            {
                if (empx.EmpCode.Equals(emp.EmpCode))
                {
                    return false;
                }
            }
            data.Add(emp);
            return true;
        }
        public bool DelEmp(List<Emp> data,string empcode)
        {
            foreach (Emp empx in data)
            {
                if (empx.EmpCode.Equals(empcode))
                {
                    data.Remove(empx);
                    return true;
                }
            }
            return false;
        }
        public bool UpdataEmp(List<Emp> data, Emp emp)
        {
            foreach (Emp empx in data)
            {
                if (empx.EmpCode.Equals(emp.EmpCode))
                {
                    empx.EmpName = emp.EmpName;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 根据员工号查询员工信息
        /// </summary>
        /// <param name="data">员工集合</param>
        /// <param name="empcode">员工工号</param>
        /// <returns>查询结果</returns>
        public List<Emp> FindByEmpCode(List<Emp> data,string empcode)
        {
            List<Emp> res = new List<Emp>();
            foreach (Emp emp in data)
            {
                if (emp.EmpCode.IndexOf(empcode) != -1)
                {
                    res.Add(emp);
                }
            }
            return res;
        }
    }
}
