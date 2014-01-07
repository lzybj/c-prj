using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using otherprj2.entity;
using otherprj2.service;
using System.Collections;

namespace otherprj2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Emp myEmp;
            //myEmp.empName = "老郑";
            //myEmp.empSex = "男";
            //myEmp.empAge = 33;
            //myEmp.empNum = 1;
            //myEmp.test();
            //VoteSerivce vs = new VoteSerivce();
            //vs.vote(ref myEmp);
            //Console.WriteLine(myEmp.empNum);

            //FangXing fx;
            //fx.chang = 12;
            //fx.kuan = 22;
            //fx.mianji();
            //fx.randStr();
            //Demo myDemo = Demo.getInstance();
            //myDemo.ttt();
            //Demo.yyyy();
            //ArrayList arrayList = new ArrayList();
            ////添加
            //arrayList.Add("1");
            //arrayList.Add("2");
            //arrayList.Add("3");
            ////获得某个元素
            //Console.WriteLine(arrayList[0]);
            ////获得集合大小
            //Console.WriteLine(arrayList.Count);
            ////遍历
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}
            ////foreach
            //foreach (object tt in arrayList)
            //{
            //    Console.WriteLine((string)tt);
            //}

            ////删除
            //arrayList.Remove("1");
            //arrayList.RemoveAt(1);
            //Console.WriteLine(arrayList.Count);

            ////清空
            //arrayList.Clear();
            //ArrayList data = new ArrayList();

            Student myStu = new Student("1001","白燕");
            Student myStu2 = new Student("1002", "白燕2");
            Student myStu3 = new Student("1003", "白燕3");
            Student myStu4 = new Student("1001", "白燕");
            //data.Add(myStu);
            //data.Add(myStu2);
            //data.Add(myStu3);

            //foreach (object obj in data)
            //{
            //    Student stu = (Student)obj;
            //    Console.WriteLine(stu.Stuname);
            //}

            Hashtable ht = new Hashtable();
            ht.Add("1001", myStu);
            ht.Add("1002",myStu2);
            ht.Add("1003", myStu3);
           // ht.Add("1001", myStu4);

            Console.WriteLine(ht.Count);

            Console.WriteLine(((Student)ht["1001"]).Stuname);

            foreach (object obj in ht.Keys)
            {
                string key = (string)obj;
                Console.WriteLine(((Student)ht[key]).Stuname);
            }

            foreach (object obj in ht.Values)
            {
                Student stu = (Student)obj;
                Console.WriteLine(stu.Stuname);
            }

            ht.Remove("1001");

            Console.WriteLine(ht.Count);

            ht.Clear();

            List<string> data2 = new List<string>();
            List<Student> data3 = new List<Student>(); ;
            Dictionary<int, Student> data4 = new Dictionary<int, Student>();

        }
    }
}
