using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn09
{
    public class KaChe : Che
    {
        public KaChe(string cNo,string cName,string cColor,int cDayNum,float cUnitPrice,int cLoad)
            :base(cNo,cName,cColor,cDayNum,cUnitPrice,cLoad)
        {
        }

        public override float JieSuan()
        {
            this.CUserName = "";
            return (float)(this.CUnitPrice * this.CDayNum + this.CLoad * 0.1 * this.CUnitPrice * this.CDayNum);
        }
    }
}
