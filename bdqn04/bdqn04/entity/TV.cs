using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn04.entity
{
    public class TV
    {
        private bool isOn = false;
        public void open()
        {
            if (isOn)
            {
                Console.WriteLine("已经打开了，别按了！");
            }
            else
            {
                Console.WriteLine("电视机打开了！");
                isOn = true;
            }
        }
        public void TiaoTai()
        {
            if (isOn)
            {
                Console.WriteLine("挑台！");
            }
            else
            {
                Console.WriteLine("请打开电视后，再挑台！");
            }
        }
        public void close()
        {
            if (isOn)
            {
                Console.WriteLine("电视机关闭了！");
                isOn = false;
            }
            else
            {
                Console.WriteLine("已经关了，别按了！");
            }
        }
    }
}
