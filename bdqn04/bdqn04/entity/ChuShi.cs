using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn04.entity
{
    public class ChuShi
    {
        //private Order order;
        public void chaocai(Order order)
        {
            Console.WriteLine("我现在在炒" + order.CaiName);
        }

        public void sendOrderForWaiter(Waiter waiter,Order order)
        {
            Console.WriteLine("我已经抄完了，告诉服务员给传菜！");
            waiter.SongCai(order.Customer,order);
        }

    }
}
