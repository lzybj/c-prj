using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn08
{
    class OperationAdd : Opertion
    {
        public OperationAdd(int first,int second)
            :base(first,second)
        {
        }

        public OperationAdd()
        {
        }

        public override int GetRes()
        {
            return this.First + this.Second;
        }
    }
}
