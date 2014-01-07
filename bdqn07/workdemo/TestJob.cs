using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workdemo
{
    public class TestJob :Job
    {
        private int caseNum;

        public int CaseNum
        {
            get { return caseNum; }
            set { caseNum = value; }
        }
        private int findBugNum;

        public int FindBugNum
        {
            get { return findBugNum; }
            set { findBugNum = value; }
        }
        private int workDay;

        public int WorkDay
        {
            get { return workDay; }
            set { workDay = value; }
        }
        public TestJob()
        {
        }
        public TestJob(string workName, string workType, string workContent, int caseNum, int findBugNum, int workDay)
            : base(workName,workType,workContent)
        {
            this.caseNum = caseNum;
            this.findBugNum = findBugNum;
            this.workDay = workDay;
        }

        public override void Execute()
        {
            TestWorkFrm testFrm = new TestWorkFrm();
            testFrm.ShowDialog();
        }

        public override string Show()
        {
            string msg = "用例数:" + this.caseNum + ";发现BUG数：" + this.findBugNum + ";工作天数:" + this.workDay;
            return msg;
        }

    }
}
