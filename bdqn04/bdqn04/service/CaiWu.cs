using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bdqn04.entity;

namespace bdqn04.service
{
    public class CaiWu
    {
        public int gongzi(PM pm)
        {
            return pm.BaseMoney + pm.PrjMoney + pm.CompMoney;
        }
        public int gongzi(SE se)
        {
            return se.BaseMoney + se.KaoMoney;
        }
    }
}
