using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn12
{
    [Serializable]
    public class Users
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        public Users(string userName,string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }

    }
}
