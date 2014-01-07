using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn08
{
    public class OperationChu : Opertion
    {
        public OperationChu(int first,int second)
            :base(first,second)
        {
        }

        public OperationChu()
        {
        }

        public override int GetRes()
        {
            return this.First / this.Second;
        }
    }
}
