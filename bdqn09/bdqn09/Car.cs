using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn09
{
    public class Car : Che
    {
        public Car(string cNo,string cName,string cColor,int cDayNum,float cUnitPrice,int cLoad)
            :base(cNo,cName,cColor,cDayNum,cUnitPrice,cLoad)
        {
        }

        public override float JieSuan()
        {
            this.CUserName = "";
            return this.CUnitPrice * this.CDayNum;
        }

    }
}
