using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using CW.entity;

namespace CW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();
            //Cat cat = new Cat();
            //Ya yaya = new Ya();
            //List<DongWu> dongwus = new List<DongWu>();
            //dongwus.Add(dog);
            //dongwus.Add(cat);
            //dongwus.Add(yaya);
            //CWShop shop = new CWShop();
            //shop.AiZhou(dongwus);
            Emp emp = new Emp();
            emp.EmpName = "小明";
            Car car = new Car();
            
            //emp.ShangBan(car);
            emp.ShangBan2(car);
        }
    }
}
