using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn12
{
    [Serializable]
    public class Product
    {
        private int productID;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private float unitPrice;

        public float UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public Product(int productID,string productName,float unitPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.unitPrice = unitPrice;
        }

    }
}
