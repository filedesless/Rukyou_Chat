using System;
using Rukyou_Chat.Model.MySQL;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;

namespace Rukyou_Chat.Model.Show
{
    class Messages : iShow
    {
        private string room;

        public Messages(string room)
        {
            this.room = room;
        }

        public List<string> show()
        {
            MySQL_Ancestor sql = new MySQLStoredProcedure(MySQL.Connection.connectionString);

            List<MySqlParameter> paramList = new List<MySqlParameter>();
            paramList.Add(new MySqlParameter("room", this.room));

            DataTable result = sql.runQuery("show_messages", paramList);

            List<string> res = new List<string>();

            foreach (DataRow row in result.Rows)
            {
                res.Add(String.Format(
                    "{0,10} : {1}",
                    row["From"], row["Message"]
                    )
                );
            }

            return res;
        }
    }
}
