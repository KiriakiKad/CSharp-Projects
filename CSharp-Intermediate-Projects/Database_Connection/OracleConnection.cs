using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }
        public override void Open()
        {
            Console.WriteLine("Oracle database connection opened.");
        }
        public override void Close()
        {
            Console.WriteLine("Oracle database connection closed.");
        }
    }
}
