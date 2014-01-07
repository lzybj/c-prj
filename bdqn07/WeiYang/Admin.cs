using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeiYang
{
    public class Admin
    {
        private string adminName;

        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }

        public void WeiYang(DongWu dongwu)
        {
            dongwu.eat();
        }
        public void WeiYang(List<DongWu> dongwus)
        {
            foreach (DongWu item in dongwus)
            {
                item.eat();
            }
        }
    }
}
