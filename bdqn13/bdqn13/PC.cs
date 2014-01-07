using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn13
{
    public class PC : Computer
    {
        private string hostType;

        public string HostType
        {
            get { return hostType; }
            set { hostType = value; }
        }

        public PC()
            :base()
        {
        }

        public PC(string brandName, string computerName, string cpuType, string hardDisk, string mem, string display,string hostType)
            :base(brandName,computerName,cpuType,hardDisk,mem,display)
        {
            this.hostType = hostType;
        }
    }
}
