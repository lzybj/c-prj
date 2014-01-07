using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn04.entity
{
    public class YaoKong
    {
        public void TurnOff(TV tv)
        {
            tv.close();
        }
        public void TurnOn(TV tv)
        {
            tv.open(); ;
        }
        public void TurnQuan(TV tv)
        {
            tv.TiaoTai();
        }
    }
}
