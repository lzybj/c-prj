using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn08
{
    public class OperationFactory
    {
        private static Opertion oper = null;
        public static Opertion getInstance(string stropr)
        {
            switch (stropr)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OpertionJian();
                    break;
                case "/":
                    oper = new OperationChu();
                    break;
                case "*":
                    oper = new OperationChen();
                    break;
                default:
                    break;
            }
            return oper;
        }
    }
}
