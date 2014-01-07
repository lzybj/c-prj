using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn06test.entity
{
    public class BankCard
    {
        private string cardid;//卡号

        public string Cardid
        {
            get { return cardid; }
            set { cardid = value; }
        }
        private string cardpwd;//卡密

        public string Cardpwd
        {
            get { return cardpwd; }
            set { cardpwd = value; }
        }
        private string cardAcc;//卡用户名

        public string CardAcc
        {
            get { return cardAcc; }
            set { cardAcc = value; }
        }
        private float yMoney;//余额

        public float YMoney
        {
            get { return yMoney; }
            set { yMoney = value; }
        }
        /// <summary>
        /// 查询余额
        /// </summary>
        /// <returns></returns>
        public virtual float QuEr()
        {
            return 0f;
        }
        /// <summary>
        /// 取款
        /// </summary>
        /// <returns></returns>
        public virtual float QuKuan(float jinEr)
        {
            return 0f;
        }
    }
}
