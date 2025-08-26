using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection sqlConnection = new SqlConnection("Server=myServer;Database=myDB;User Id=myUser;Password=myPass;");
            sqlConnection.Open();
            sqlConnection.Close();
            Console.WriteLine();

            DbConnection oracleConnection = new OracleConnection("Data Source=myOracleDB;User Id=myUser;Password=myPass;");
            oracleConnection.Open();
            oracleConnection.Close();
            Console.WriteLine();

            //with DbCommand
            DbCommand command = new DbCommand(new SqlConnection("Server=myServer;Database=myDB;User Id=myUser;Password=myPass;"), "SELECT * FROM Users");
            command.Execute();
            Console.WriteLine();

            DbCommand command2 = new DbCommand(new OracleConnection("Data Source=myOracleDB;User Id=myUser;Password=myPass;"), "SELECT * FROM Employees");
            command2.Execute();
        }
    }
}
