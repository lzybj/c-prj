using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn06.entity
{
    public class PM : Emp
    {
        private float prjMoney;//项目奖金

        public float PrjMoney
        {
            get { return prjMoney; }
            set { prjMoney = value; }
        }
        private float compMoney;//公司分红

        public float CompMoney
        {
            get { return compMoney; }
            set { compMoney = value; }
        }
        public void work()
        {
            Console.WriteLine("项目管理人员！");
        }
        public void kaihui()
        {
            Console.WriteLine("项目开会！");
        }
        public void yaozhang()
        {
            Console.WriteLine("催款！");
        }

        public void HuiBaoJobs()
        {
            foreach (Job item in base.Jobs)
            {
                Console.WriteLine(item.JobName + "描述：" + item.JobContent);
            }
        }
    }
}
