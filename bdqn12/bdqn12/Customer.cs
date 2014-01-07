using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn12
{
    [Serializable]
    public class Customer
    {
        private string cname;

        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }
        private Order myOrder;

        public Order MyOrder
        {
            get { return myOrder; }
            set { myOrder = value; }
        }

    }
}
