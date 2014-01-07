using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn06.entity
{
    public class Job
    {
        private string jobName;

        public string JobName
        {
            get { return jobName; }
            set { jobName = value; }
        }
        private string jobContent;

        public string JobContent
        {
            get { return jobContent; }
            set { jobContent = value; }
        }

        public Job(string jobName,string jobContent)
        {
            this.jobName = jobName;
            this.jobContent = jobContent;
        }
    }
}
