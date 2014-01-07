using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn10
{
    [Serializable]
    public class Remind
    {
        private string tvName;

        public string TvName
        {
            get { return tvName; }
            set { tvName = value; }
        }
        private string jieMuName;

        public string JieMuName
        {
            get { return jieMuName; }
            set { jieMuName = value; }
        }

        private DateTime jieMuTime;

        public DateTime JieMuTime
        {
            get { return jieMuTime; }
            set { jieMuTime = value; }
        }


        private int remindTime;

        public int RemindTime
        {
            get { return remindTime; }
            set { remindTime = value; }
        }

        public Remind(string tvName,string jieMuName,DateTime jieMuTime,int remindTime)
        {
            this.tvName = tvName;
            this.jieMuName = jieMuName;
            this.jieMuTime = jieMuTime;
            this.remindTime = remindTime;
        }

    }
}
