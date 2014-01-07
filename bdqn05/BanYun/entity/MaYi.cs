using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BanYun.entity
{
    public class MaYi
    {
        private TianPin tp;
        private int myID;

        public int MyID
        {
            get { return myID; }
            set { myID = value; }
        }
        private int myMaxWeight;

        public int MyMaxWeight
        {
            get { return myMaxWeight; }
            set { myMaxWeight = value; }
        }
        public MaYi(int myID,int myMaxWeight)
        {
            this.myID = myID;
            this.myMaxWeight = myMaxWeight;
        }
        //找到甜品
        public bool ZhaoDaoTianPin(TianPin tp)
        {
            this.tp = tp;
            Console.WriteLine("id为" + this.myID + "蚂蚁找到了，" + tp.TpName + "甜品");
            if (tp.TpZhongLiang > this.myMaxWeight)
            {
                Console.WriteLine("这个甜品太重了,我需要呼叫伙伴");
                return true;
            }
            else
            {
                Console.WriteLine("这个甜品我自己独享了！");
                return false;
            }
        }

        public void HuJiao(List<MaYi> mayis)
        {
            Console.WriteLine("我呼叫了" + mayis.Count + "只同伴，一起共享" + tp.TpName);
        }

        public void BanZou()
        {
            Console.WriteLine("我自己搬走！");
        }

        public void BanZou(List<MaYi> mayis)
        {
            Console.WriteLine("我们一共" + (mayis.Count + 1) + "只蚂蚁，一起搬走！");
        }

    }
}
