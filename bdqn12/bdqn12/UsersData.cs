using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn12
{
    [Serializable]
    public class UsersData
    {
        private List<Users> manyUsers = new List<Users>();

        public List<Users> ManyUsers
        {
            get { return manyUsers; }
            set { manyUsers = value; }
        }


    }
}
