using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using otherprj2.entity;

namespace otherprj2.service
{
    public class VoteSerivce
    {
        public void vote(ref Emp emp)
        {
            emp.empNum = emp.empNum + 1;
        }
    }
}
