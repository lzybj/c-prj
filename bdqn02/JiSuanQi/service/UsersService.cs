using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JiSuanQi.service
{
    class UsersService
    {
        /// <summary>
        /// 登陆业务逻辑
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public bool IsLogin(string userName,string passWord)
        {
            if(userName.Equals("laozheng") && passWord.Equals("qaz123"))
            {
                return true;
            }
            return false;
        }
    }
}
