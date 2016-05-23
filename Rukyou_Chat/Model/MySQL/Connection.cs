using System;

namespace Rukyou_Chat.Model.MySQL
{
    static class Connection
    {
        static public string connectionString = String.Format(
            "Server = {0}; Database={1} ;Uid={2} ;PASSWORD={3};",
            "sql.server.example.com", "db", "dbUser", "dbPassword"
            );
    }
}
