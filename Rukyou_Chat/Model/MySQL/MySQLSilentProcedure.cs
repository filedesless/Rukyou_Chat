using System.Data;

namespace WpfApplication1.Model.MySQL
{
    class MySQLSilentProcedure : MySQL_Ancestor
    {
        public MySQLSilentProcedure(string connString) : base(connString, CommandType.StoredProcedure) { }
    }
}
