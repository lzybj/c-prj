using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn08
{
    public class PiSaFactory
    {
        private static PiSa pisa = null;
        public static PiSa getInstance(string strname)
        {
            if (strname.Equals("意大利"))
            {
                pisa = new YDPiSa("意大利披萨","意大利馅饼",120);
            }
            else
            {
                pisa = new FGPiSa("法国披萨", "法国馅饼", 150);
            }
            return pisa;
        }
    }
}
