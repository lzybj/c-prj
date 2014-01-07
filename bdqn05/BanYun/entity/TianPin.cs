using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BanYun.entity
{
    public class TianPin
    {
        private string tpName;

        public string TpName
        {
            get { return tpName; }
            set { tpName = value; }
        }
        private int tpZhongLiang;

        public int TpZhongLiang
        {
            get { return tpZhongLiang; }
            set { tpZhongLiang = value; }
        }

        public TianPin(string tpName,int tpZhongLiang)
        {
            this.tpName = tpName;
            this.tpZhongLiang = tpZhongLiang;
        }
    }
}
