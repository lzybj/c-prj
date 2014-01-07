using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn10
{
    [Serializable]
    public class RemindData
    {
        private List<Remind> data = new List<Remind>();

        public List<Remind> Data
        {
            get { return data; }
            set { data = value; }
        }


    }
}
