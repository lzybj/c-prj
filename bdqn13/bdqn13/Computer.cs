using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn13
{
    public class Computer
    {
        private string brandName;

        public string BrandName
        {
            get { return brandName; }
            set { brandName = value; }
        }
        private string computerName;

        public string ComputerName
        {
            get { return computerName; }
            set { computerName = value; }
        }
        private string cpuType;

        public string CpuType
        {
            get { return cpuType; }
            set { cpuType = value; }
        }
        private string hardDisk;

        public string HardDisk
        {
            get { return hardDisk; }
            set { hardDisk = value; }
        }
        private string mem;

        public string Mem
        {
            get { return mem; }
            set { mem = value; }
        }
        private string display;

        public string Display
        {
            get { return display; }
            set { display = value; }
        }

        public Computer()
        {
        }

        public Computer(string brandName,string computerName,string cpuType,string hardDisk,string mem,string display)
        {
            this.brandName = brandName;
            this.computerName = computerName;
            this.cpuType = cpuType;
            this.hardDisk = hardDisk;
            this.mem = mem;
            this.display = display;
        }

    }
}
