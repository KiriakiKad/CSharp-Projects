using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection
{
    public class DbCommand
    {
        public DbConnection Connection { get; set; }
        public string instruction { get; set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
            {
                throw new ArgumentNullException("Connection cannot be null");
            }
            if (string.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentException("Instruction cannot be null or empty", nameof(instruction));
            }
            Connection = connection;
            this.instruction = instruction;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine($"Executing instruction: {instruction}");
            Connection.Close();
        }
    }
}
