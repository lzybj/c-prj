using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeiYang
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            admin.AdminName = "小李";
            DongWu gz = new GeZi();
            DongWu sz = new ShiZi();
            DongWu hz = new HouZi();
            List<DongWu> dongwus = new List<DongWu>();
            dongwus.Add(gz);
            dongwus.Add(sz);
            dongwus.Add(hz);
            Console.WriteLine(admin.AdminName + "喂养各个动物后：");
            admin.WeiYang(dongwus);
            //admin.WeiYang(gz);
            //admin.WeiYang(hz);
            //admin.WeiYang(sz);
        }
    }
}
