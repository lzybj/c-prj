using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace otherprj2.entity
{
    public struct FangXing
    {
        public double chang;
        public double kuan;
        public void mianji()
        {
            Console.WriteLine(chang * kuan);
            Random rand = new Random();
        }
        public void randStr()
        {
            Random rand = new Random();
            string str = "";
            for (int i = 0; i < 4;i++ )
            {
                str = str + (int)(rand.NextDouble() * 10);
            }
            Console.WriteLine(str);
        }

    }
}
