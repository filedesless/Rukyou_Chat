using System.Data;

namespace Rukyou_Chat.Model.MySQL
{
    class MySQLSilentProcedure : MySQL_Ancestor
    {
        public MySQLSilentProcedure(string connString) : base(connString, CommandType.StoredProcedure) { }
    }
}
