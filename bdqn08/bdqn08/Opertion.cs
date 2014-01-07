using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn08
{
    public abstract class Opertion
    {
        private int first;

        public int First
        {
            get { return first; }
            set { first = value; }
        }
        private int second;

        public int Second
        {
            get { return second; }
            set { second = value; }
        }

        public Opertion(int first,int second)
        {
            this.first = first;
            this.second = second;
        }

        public Opertion()
        {
        }

        public abstract int GetRes();

        public virtual void Test()
        {
        }

    }
}
