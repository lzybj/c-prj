using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using QKCF.entity;

namespace QKCF
{
    class Program
    {
        static void Main(string[] args)
        {
            CPerson cp = new CPerson();
            cp.Name = "中国人";
            JPerson jp = new JPerson();
            jp.Name = "日本人";
            IndinaPerson inp = new IndinaPerson();
            inp.Name = "印度人";

            List<Person> persons = new List<Person>();
            persons.Add(cp);
            persons.Add(jp);
            persons.Add(inp);


            FanJu fj = new FanJu();

            fj.JiaoLiu(persons);

            fj.KaiFan(persons);
            //Son myson = new Son();
            //myson.JiSuan();

        }
    }
}
