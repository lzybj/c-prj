using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ioprj
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             *1.创建文件流
             *2.创建写入器
             *3.写入
             *4.关闭所有的流
             */
            FileStream fs = new FileStream("c:/demo/log.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs,Encoding.Default);
            sw.WriteLine("aaaaabbbsss测试！！！测试！！");
            sw.WriteLine("ccccccc");
            sw.Close();
            fs.Close();
            Console.WriteLine("成功写入！");

            //FileStream fs = new FileStream("c:/demo/log.txt",FileMode.Open);
            //StreamReader sr = new StreamReader(fs);
            //string msg = sr.ReadToEnd();
            //Console.WriteLine(msg);
            //sr.Close();
            //fs.Close();

        }
    }
}
