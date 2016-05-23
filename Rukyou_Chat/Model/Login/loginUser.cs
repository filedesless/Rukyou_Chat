using System;
using Rukyou_Chat.Model.MySQL;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace Rukyou_Chat.Model.Login
{
    class loginUser : iLogin
    {
        private string username;
        private string password;

        public loginUser(string user, string pass)
        {
            this.username = user;
            this.password = pass;
        }

        public bool success()
        {
            MySQL_Ancestor sql = new MySQLFunction(Connection.connectionString);

            List<MySqlParameter> paramList = new List<MySqlParameter>();

            paramList.Add(new MySqlParameter("username", this.username));
            paramList.Add(new MySqlParameter("password", this.password));


            DataTable result = sql.runQuery("SELECT login(@username, @password) AS res", paramList);

            int i = Convert.ToInt32(result.Rows[0]["res"]);

            if (i == 1)
                return true;
            else
                return false;
        }
    }
}
