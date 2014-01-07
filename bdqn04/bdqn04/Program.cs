using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bdqn04.entity;
using bdqn04.service;

namespace bdqn04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student myStu = new Student(19,"白燕");
            //Console.WriteLine(myStu.StuNo);
            //PM laozheng = new PM("老郑",300000,50000000);
            //SE laoli = new SE("老李",500);
            //CaiWu laowang = new CaiWu();
            //Console.WriteLine(laozheng.EmpName + "发工资为：" + laowang.gongzi(laozheng));
            //Console.WriteLine(laoli.EmpName + "发工资为：" + laowang.gongzi(laoli));
            //Car bs = new Car("奔驰","黑色","德国");
            //bs.run();
            //bs.run(450);
            //TV myTv = new TV();
            //YaoKong yk = new YaoKong();
            //yk.TurnOn(myTv);
            //yk.TurnQuan(myTv);
            //yk.TurnOff(myTv);

            Customer customer = new Customer();
            customer.Cname = "老郑";

            Waiter waiter = new Waiter();
            waiter.Wname = "老李";

            ChuShi chushi = new ChuShi();

            Order order = new Order();
            order.Customer = customer;
            order.ZhuoID = 88;
            order.CaiName = "鱼";

            customer.DianCai(waiter,order);

            waiter.sendOrder(chushi,order);

            chushi.sendOrderForWaiter(waiter, order);




            //customer.DianCai(waiter,);

        }
    }
}
