using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn12
{
    [Serializable]
    public class Order
    {
        private string orderid;

        public string Orderid
        {
            get { return orderid; }
            set { orderid = value; }
        }
        private List<Product> productsList = new List<Product>();

        public List<Product> ProductsList
        {
            get { return productsList; }
            set { productsList = value; }
        }
        private DateTime orderTime;

        public DateTime OrderTime
        {
            get { return orderTime; }
            set { orderTime = value; }
        }

        public Order(string orderid,List<Product> productsList,DateTime orderTime)
        {
            this.orderid = orderid;
            this.productsList = productsList;
            this.orderTime = orderTime;
        }

        public Order(string orderid,DateTime orderTime)
        {
            this.orderid = orderid;
            this.orderTime = orderTime;
        }

    }
}
