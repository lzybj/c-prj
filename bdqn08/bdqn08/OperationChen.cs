using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn08
{
    public class OperationChen : Opertion
    {
        public OperationChen(int first,int second)
            :base(first,second)
        {
        }
        public OperationChen()
        {
        }


        public override int GetRes()
        {
            return this.First * this.Second;
        }
    }
}
