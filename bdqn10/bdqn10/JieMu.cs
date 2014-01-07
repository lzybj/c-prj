using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn10
{
    public class JieMu
    {
        private DateTime jieMuTime;//播出时间

        public DateTime JieMuTime
        {
            get { return jieMuTime; }
            set { jieMuTime = value; }
        }
        private string jieMuName;//节目名

        public string JieMuName
        {
            get { return jieMuName; }
            set { jieMuName = value; }
        }
        private string jieMuTimeDuan;//时间段

        public string JieMuTimeDuan
        {
            get { return jieMuTimeDuan; }
            set { jieMuTimeDuan = value; }
        }
        private string jieMuURL;

        public string JieMuURL
        {
            get { return jieMuURL; }
            set { jieMuURL = value; }
        }

        public JieMu(DateTime jieMuTime,string jieMuName,string jieMuTimeDuan,string jieMuURL)
        {
            this.jieMuTime = jieMuTime;
            this.jieMuName = jieMuName;
            this.jieMuTimeDuan = jieMuTimeDuan;
            this.jieMuURL = jieMuURL;
        }

        public JieMu(DateTime jieMuTime,string jieMuName,string jieMuURL)
        {
            this.jieMuTime = jieMuTime;
            this.jieMuName = jieMuName;
            this.jieMuURL = jieMuURL;            
        }

    }
}
