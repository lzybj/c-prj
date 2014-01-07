using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn06test.entity
{
    public class BenBankCard : BankCard
    {
        public override float QuKuan(float jinEr)
        {
            return base.YMoney - jinEr;
        }
        public override float QuEr()
        {
            return base.YMoney;
        }
        public bool ZhuanZhang(BankCard bankCard,float jiEr)
        {
            if (base.YMoney < jiEr)
            {
                return false;
            }
            base.YMoney = base.YMoney - jiEr;
            bankCard.YMoney = bankCard.YMoney + jiEr;
            return true;
        }
    }
}
