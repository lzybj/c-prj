using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn04.entity
{
    public class Order
    {
        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        private int zhuoID;

        public int ZhuoID
        {
            get { return zhuoID; }
            set { zhuoID = value; }
        }
        private string caiName;

        public string CaiName
        {
            get { return caiName; }
            set { caiName = value; }
        }
    }
}
