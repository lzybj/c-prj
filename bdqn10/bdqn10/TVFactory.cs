using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn10
{
    public class TVFactory
    {
        public static TV getInstances(string tvName)
        {
            TV tv = null;
            switch (tvName)
            {
                case "北京电视台":
                    tv = new TVTypeA();
                    break;
                case "凤凰卫视":
                    tv = new TVTypeB();
                    break;
                default:
                    break;
            }


            return tv;
        }
    }
}
