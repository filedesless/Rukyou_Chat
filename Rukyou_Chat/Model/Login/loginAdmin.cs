using System;

namespace Rukyou_Chat.Model.Login
{
    class loginAdmin : iLogin
    {
        public bool success(string user, string pass)
        {
            MySQL.MySQL_Ancestor sql = new MySQL.MySQLFunction("");
            return true;
        }
    }
}
