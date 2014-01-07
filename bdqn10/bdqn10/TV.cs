using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn10
{
    public abstract class TV
    {
        private string tvType;

        public string TvType
        {
            get { return tvType; }
            set { tvType = value; }
        }
        private string tvName;

        public string TvName
        {
            get { return tvName; }
            set { tvName = value; }
        }
        private string jieMusURL;

        public string JieMusURL
        {
            get { return jieMusURL; }
            set { jieMusURL = value; }
        }
        private List<JieMu> jieMus = new List<JieMu>();

        public List<JieMu> JieMus
        {
            get { return jieMus; }
            set { jieMus = value; }
        }

        public TV()
        {
        }

        public TV(string tvType,string tvName,string jieMusURL)
        {
            this.tvType = tvType;
            this.tvName = tvName;
            this.jieMusURL = jieMusURL;
        }

        public abstract void GetJieMuData();

    }
}
