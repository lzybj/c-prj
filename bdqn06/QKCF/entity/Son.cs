using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QKCF.entity
{
    public class Son : Father
    {
        public override void JiSuan()
        {
            base.JiSuan();
            Console.WriteLine("儿子用计算器算数@");
        } 
    }
}
