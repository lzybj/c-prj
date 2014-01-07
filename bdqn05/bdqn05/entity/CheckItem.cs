using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn05.entity
{
    public class CheckItem
    {
        private string ckName;

        public string CkName
        {
            get { return ckName; }
            set { ckName = value; }
        }
        private string ckContent;

        public string CkContent
        {
            get { return ckContent; }
            set { ckContent = value; }
        }
        private float ckPrice;

        public float CkPrice
        {
            get { return ckPrice; }
            set { ckPrice = value; }
        }

        public CheckItem(string ckName,string ckContent,float ckPrice)
        {
            this.ckName = ckName;
            this.ckContent = ckContent;
            this.ckPrice = ckPrice;
        }
    }
}
