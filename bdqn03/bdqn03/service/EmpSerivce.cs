using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using bdqn03.entity;

namespace bdqn03.service
{
    public class EmpSerivce
    {
        //添加,注意员工编号唯一
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
        //修改
        public bool UpdateEmp(List<Emp> data,Emp emp)
        {
            foreach (Emp empx in data)
            {
                if (empx.EmpCode.Equals(emp.EmpCode))
                {
                    empx.EmpName = emp.EmpName;
                    empx.EmpSex = emp.EmpSex;
                    empx.EmpAge = emp.EmpAge;
                    return true;
                }
            }
            return false;
        }
        //查询
        public List<Emp> FindByEmpCode(List<Emp> data,string parEmpCode)
        {
            List<Emp> selData = new List<Emp>();
            foreach (Emp empx in data)
            {
                if (empx.EmpCode.IndexOf(parEmpCode) != -1)
                {
                    selData.Add(empx);
                }
            }

            return selData;
        }
        //删除
        public bool DelEmp(List<Emp> data,string parEmpCode)
        {
            foreach (Emp empx in data)
            {
                if (empx.EmpCode.Equals(parEmpCode))
                {
                    data.Remove(empx);
                    return true;
                }
            }
            return false;
        }
    }
}

