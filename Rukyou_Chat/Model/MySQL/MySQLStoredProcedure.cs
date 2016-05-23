using System.Data;

namespace WpfApplication1.Model.MySQL
{
    class MySQLStoredProcedure : MySQL_Ancestor
    {
        public MySQLStoredProcedure(string connString) : base(connString, CommandType.StoredProcedure) { }
    }
}
