using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn08
{
    public abstract class PiSa
    {
        private string pName;

        public string PName
        {
            get { return pName; }
            set { pName = value; }
        }
        private string pContent;

        public string PContent
        {
            get { return pContent; }
            set { pContent = value; }
        }
        private float pUnitPrice;

        public float PUnitPrice
        {
            get { return pUnitPrice; }
            set { pUnitPrice = value; }
        }

        public PiSa(string pName,string pContent,float pUnitPrice)
        {
            this.pName = pName;
            this.pContent = pContent;
            this.pUnitPrice = pUnitPrice;
        }

        public abstract string Show();

    }
}
