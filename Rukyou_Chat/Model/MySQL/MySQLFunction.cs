using System.Data;

namespace Rukyou_Chat.Model.MySQL
{
    class MySQLFunction : MySQL_Ancestor
    {
        public MySQLFunction(string connString) : base(connString, CommandType.Text) { }
    }
}
