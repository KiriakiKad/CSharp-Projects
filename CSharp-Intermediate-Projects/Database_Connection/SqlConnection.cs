using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }
        public override void Open()
        {
            Console.WriteLine("SQL database connection opened.");
        }
        public override void Close()
        {
            Console.WriteLine("SQL database connection closed.");
        }
    }
}
