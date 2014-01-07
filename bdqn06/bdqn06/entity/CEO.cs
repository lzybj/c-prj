using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn06.entity
{
    public class CEO
    {
        public void TingHuiBao(List<Emp> emps)
        {
            foreach (Emp item in emps)
            {
                if (item is SE)
                {
                    SE itemx = (SE)item;
                    itemx.HuiBaoJobs();
                }
                if (item is PM)
                {
                    PM itemx = (PM)item;
                    itemx.HuiBaoJobs();
                }
            }
        }
    }
}
