using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefTest.entity
{
    public class TestService
    {
        public void NumAdd(ref int par)
        {
            par = par + 1;
        }
        public void NumAddObj(Emp emp)
        {
            emp.EmpNum = emp.EmpNum + 1;
        }
    }
}
