using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn08
{
    public class FGPiSa : PiSa
    {
        public FGPiSa(string pName,string pContent,float pUnitPrice)
            :base(pName,pContent,pUnitPrice)
        {
        }

        public override string Show()
        {
            return "披萨名称：" + this.PName + ";披萨描述：" + this.PContent + ";披萨价格：" + this.PUnitPrice;
        }
    }
}
