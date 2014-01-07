using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn04.entity
{
    public class Customer
    {
        private string cname;

        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }
        public void DianCai(Waiter waiter,Order myorder)
        {
            waiter.Order = myorder;
        }

        public void Eat(Order order)
        {
            Console.WriteLine(order.Customer.cname + "吃：" + order.CaiName);
        }
    }
}
