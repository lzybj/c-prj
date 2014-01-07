using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workdemo
{
    public class CodeJob : Job
    {
        private int codeNum;

        public int CodeNum
        {
            get { return codeNum; }
            set { codeNum = value; }
        }
        private int bugNum;

        public int BugNum
        {
            get { return bugNum; }
            set { bugNum = value; }
        }
        private int workDay;

        public int WorkDay
        {
            get { return workDay; }
            set { workDay = value; }
        }

        public CodeJob()
        {
        }
        public CodeJob(string workName, string workType, string workContent, int codeNum,int bugNum,int workDay)
        :base(workName,workType,workContent)
        {
            this.codeNum = codeNum;
            this.bugNum = bugNum;
            this.workDay = workDay;
        }

        public override void Execute()
        {
            CodeWorkFrm codeFrm = new CodeWorkFrm();
            codeFrm.ShowDialog();
        }

        public override string Show()
        {
            string msg = "编写了" + this.codeNum + "代码；发现了" + this.bugNum + "问题；消耗了" + this.workDay + "天";
            return msg;
        }
    }
}
