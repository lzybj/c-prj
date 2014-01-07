using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace QKCF.entity
{
    public class FanJu
    {
        public void JiaoLiu(List<Person> persons)
        {
            foreach (Person item in persons)
            {
                item.talk();
            }
        }

        public void KaiFan(List<Person> persons)
        {
            foreach (Person item in persons)
            {
                item.eat();
            }
        }
    }
}
