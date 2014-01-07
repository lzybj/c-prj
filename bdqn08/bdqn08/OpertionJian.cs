using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn08
{
    public class OpertionJian : Opertion
    {
        public OpertionJian(int first,int second)
            :base(first,second)
        {
        }

        public OpertionJian()
        {
        }

        public override int GetRes()
        {
            return this.First - this.Second;
        }
    }
}
