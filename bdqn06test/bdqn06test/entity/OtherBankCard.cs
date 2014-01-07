using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn06test.entity
{
    public class OtherBankCard : BankCard
    {
        /// <summary>
        /// 非本行卡查询余额，收查询交易费1元
        /// </summary>
        /// <returns></returns>
        public override float QuEr()
        {
            return base.YMoney - 1;
        }
        public override float QuKuan(float jinEr)
        {
            return base.YMoney - jinEr - 2;
        }


    }
}
