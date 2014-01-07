using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn06.entity
{
    public class SE : Emp
    {
        private float jxMoney;

        public float JxMoney
        {
            get { return jxMoney; }
            set { jxMoney = value; }
        }
        public void work()
        {
            Console.WriteLine("我写代码！");
        }

        public SE()
        {
            Console.WriteLine("这是一个子类软件工程师的无参构造方法！");
        }

        public SE(string seCode,string seName,string seSex,int seAge,float jxMoney)
            :base(seCode,seName,seSex,seAge)
        {
            //base.EmpCode = seCode;
            //base.EmpName = seName;
            //base.EmpSex = seSex;
            //base.EmpAge = seAge;
            this.jxMoney = jxMoney;
        }

        public void HuiBaoJobs()
        {
            foreach (Job item in base.Jobs)
            {
                Console.WriteLine(item.JobName + ",描述：" + item.JobContent);
            }
        }
    }
}
