using System.Data;

namespace WpfApplication1.Model.MySQL
{
    class MySQLFunction : MySQL_Ancestor
    {
        public MySQLFunction(string connString) : base(connString, CommandType.Text) { }
    }
}
