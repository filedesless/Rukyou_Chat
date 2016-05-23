using System;

namespace WpfApplication1.Model.Login
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
