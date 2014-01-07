using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TouPiaoSystem.entity;

namespace TouPiaoSystem.service
{
    public class VoteService
    {
        public static int ticketNum = 5;
        public void vote(Emp emp)
        {
            emp.EmpNum = emp.EmpNum + 1;
            ticketNum = ticketNum - 1;
        }
    }
}
