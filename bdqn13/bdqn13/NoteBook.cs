using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn13
{
    public class NoteBook : Computer
    {
        private string battery;

        public string Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public NoteBook()
            :base()
        {
        }

        public NoteBook(string brandName, string computerName, string cpuType, string hardDisk, string mem, string display,string battery)
            :base(brandName,computerName,cpuType,hardDisk,mem,display)
        {
            this.battery = battery;
        }

    }
}
