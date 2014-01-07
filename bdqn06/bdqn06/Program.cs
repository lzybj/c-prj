using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bdqn06.entity;

namespace bdqn06
{
    class Program
    {
        static void Main(string[] args)
        {
            //SE se = new SE();
            //se.EmpCode = "1001";
            //se.EmpName = "老郑";
            //se.EmpSex = "男";
            //se.EmpAge = 32;
            //se.DaKa();//父类的方法
            //se.work();//子类特有方法
            //Console.WriteLine(se.EmpName);

            SE se2 = new SE("1002","老王","男",30,2000);
            //Console.WriteLine(se2.EmpName);
            //Console.WriteLine(se2.JxMoney);
            Job job1 = new Job("写登陆功能","完成登陆功能的界面和业务逻辑");
            Job job2 = new Job("写查询功能","完成对员工的全部查询");
            List<Job> jobs1 = new List<Job>();
            jobs1.Add(job1);
            jobs1.Add(job2);
            se2.Jobs = jobs1;
            //se2.work();
            //se2.DaKa();
            PM pm = new PM();
            pm.EmpName = "老郑";
            Job job3 = new Job("催款","催项目1款项！");
            Job job4 = new Job("开会","项目2的启动会！");
            List<Job> jobs2 = new List<Job>();
            jobs2.Add(job3);
            jobs2.Add(job4);
            pm.Jobs = jobs2;

            CEO ceo = new CEO();

            List<Emp> emps = new List<Emp>();
            emps.Add(se2);
            emps.Add(pm);

            ceo.TingHuiBao(emps);


            /**
            if (se2 is Emp)
            {
                Console.WriteLine("se对象是一种员工！");
            }
            */
        }
    }
}
