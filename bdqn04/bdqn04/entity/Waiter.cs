using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn04.entity
{
    public class Waiter
    {
        private string wname;
        private Order order;

        public Order Order
        {
            get { return order; }
            set 
            {
                order = value;
                Console.WriteLine(order.ZhuoID + "客人：" + order.Customer.Cname + "点了，一个" + order.CaiName);
            }
        }

        public string Wname
        {
            get { return wname; }
            set { wname = value; }
        }
        public void sendOrder(ChuShi chushi,Order order)
        {
            chushi.chaocai(order);
        }

        public void SongCai(Customer customer,Order order)
        {
            Console.WriteLine("我已经拿到菜了，马上给客户端上去！");
            customer.Eat(order);
        }
    }
}
