using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace bdqn10
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseStudent ps = new ParseStudent();
            ps.parseXML();




            //TVManager tvm = new TVManager();
            //List<TV> tvs = tvm.FindByAllTV();

            //foreach (TV item in tvs)
            //{
            //    Console.WriteLine(item.TvName);
            //}






            //TV myTv = new TVTypeB("typeA", "凤凰卫视", "file/凤凰卫视.xml");

            //myTv.GetJieMuData();

            //List<JieMu> data = myTv.JieMus;

            //foreach (JieMu item in data)
            //{
            //    Console.WriteLine(item.JieMuName);
            //    Console.WriteLine(item.JieMuTime);
            //}













            //XmlDocument myxml = new XmlDocument();
            //myxml.Load("../../Emp.xml");

            //XmlNodeList empnames = myxml.GetElementsByTagName("empname");

            //Console.WriteLine(empnames[1].InnerText);


            //XmlNodeList emps = myxml.GetElementsByTagName("emp");

            //foreach (XmlNode item in emps)
            //{
            //    Console.WriteLine(item["empcode"].InnerText);
            //    Console.WriteLine(item["empname"].InnerText);
            //}
















            //XmlElement root = myxml.DocumentElement;

            //List<Emp> emps = new List<Emp>(); 

           

            //foreach (XmlNode item in root.ChildNodes)
            //{
            //    Console.WriteLine(item["empcode"].InnerText);
            //    Console.WriteLine(item["empname"].InnerText);
            //    Console.WriteLine(item["age"].InnerText);
            //    //string empcode = item["empcode"].InnerText;
            //    //Console.WriteLine(empcode);
            //    //string empname = item.ChildNodes[1].InnerText;
            //    //int age = int.Parse(item.ChildNodes[2].InnerText);
            //    //Emp myEmp = new Emp(empcode,empname,age);
            //    //emps.Add(myEmp);
            //    //foreach (XmlNode item2 in item.ChildNodes)
            //    //{
            //    //    Console.WriteLine(item2.InnerText);
            //    //}

            //}

        }
    }
}
