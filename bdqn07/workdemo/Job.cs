using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace workdemo
{
    public abstract class Job
    {
        private string workName;

        public string WorkName
        {
            get { return workName; }
            set { workName = value; }
        }
        private string workType;

        public string WorkType
        {
            get { return workType; }
            set { workType = value; }
        }
        private string workContent;

        public string WorkContent
        {
            get { return workContent; }
            set { workContent = value; }
        }
        public abstract void Execute();
        public abstract string Show();

        public Job()
        {
        }
        public Job(string workName,string workType,string workContent)
        {
            this.workName = workName;
            this.workType = workType;
            this.workContent = workContent;
        }
    }
}
