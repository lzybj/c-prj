using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using BanYun.entity;

namespace BanYun
{
    class Program
    {
        static void Main(string[] args)
        {
            MaYi m1 = new MaYi(1,1);
            TianPin tp = new TianPin("蛋糕",10);
            //找到蛋糕
            bool isHuJiao = m1.ZhaoDaoTianPin(tp);

            if (isHuJiao)
            {
                List<MaYi> mayis = new List<MaYi>();
                MaYi m2 = new MaYi(2, 1);
                MaYi m3 = new MaYi(3, 1);
                MaYi m4 = new MaYi(4, 1);
                mayis.Add(m1);
                mayis.Add(m2);
                mayis.Add(m3);
                mayis.Add(m4);
                m1.HuJiao(mayis);
                m1.BanZou(mayis);
            }
            else
            {
                m1.BanZou();
            }


        }
    }
}
