using System.Data;

namespace Rukyou_Chat.Model.MySQL
{
    class MySQLStoredProcedure : MySQL_Ancestor
    {
        public MySQLStoredProcedure(string connString) : base(connString, CommandType.StoredProcedure) { }
    }
}
