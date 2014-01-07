using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace bdqn05.entity
{
    public class TC
    {
        private string tcName;

        public string TcName
        {
            get { return tcName; }
            set { tcName = value; }
        }
        private List<CheckItem> ckItems = new List<CheckItem>();

        public List<CheckItem> CkItems
        {
            get { return ckItems; }
            set { ckItems = value; }
        }
        private float tcPrice;

        public float TcPrice
        {
            get 
            {
                this.TotalPrice();
                return tcPrice; 
            }
            set { tcPrice = value; }
        }

        private void TotalPrice()
        {
            float sum = 0;
            foreach (CheckItem item in ckItems)
            {
                sum = sum + item.CkPrice;
            }
            this.tcPrice = sum;
        }

    }
}
