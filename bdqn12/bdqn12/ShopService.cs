using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace bdqn12
{
    public class ShopService
    {
        private Customer myCust = new Customer();
        /// <summary>
        /// 获取用户相关信息,用户名,订单等等
        /// </summary>
        public void Init()
        {
            Console.WriteLine("请输入用户名：");
            string cname = Console.ReadLine();
            myCust.Cname = cname;
            List<Product> productList = new List<Product>();
            Order myOrder = new Order("sf21324",DateTime.Now);
            myCust.MyOrder = myOrder;
            while (true)
            {
                Console.WriteLine("请输入产品ID：");
                string productID = Console.ReadLine();
                Console.WriteLine("产品名称：");
                string productName = Console.ReadLine();
                Console.WriteLine("产品价格：");
                string unitPrice = Console.ReadLine();
                Product temp = new Product(int.Parse(productID),productName,float.Parse(unitPrice));
                productList.Add(temp);
                Console.WriteLine("是否继续(Y/N)");
                string yorn = Console.ReadLine();
                if (yorn.Equals("N"))
                {
                    break;
                }
            }
            myCust.MyOrder.ProductsList = productList;

        }
        /// <summary>
        /// 将customer对象序列化
        /// 注意：序列化对象一定要保证其对象以及相关对象可以被序列化（也就是添加序列化标示）
        /// </summary>
        public void save()
        {
            FileStream fs = new FileStream("../../customer.bin",FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,myCust);
            fs.Close();
        }

        public void load()
        {
            FileStream fs = new FileStream("../../customer.bin",FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Customer cust = bf.Deserialize(fs) as Customer;
            float sum = 0f;
            foreach (Product item in cust.MyOrder.ProductsList)
            {
                sum = sum + item.UnitPrice;
            }
            Console.WriteLine("尊敬" + cust.Cname + ":您的订单价格为：" + sum);

        }

    }
}
