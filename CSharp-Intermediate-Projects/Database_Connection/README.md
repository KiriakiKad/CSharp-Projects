   DATABASE CONNECTION EXAMPLE (C# PROJECT)
=============================================

This project demonstrates how to design a simple 
database connection framework in C# using abstraction, 
inheritance, and polymorphism.

The goal is to represent different types of database 
connections (SQL Server and Oracle) and execute commands 
in a generic way, without tying the code to a specific 
database implementation.

---------------------------------------------
FEATURES
---------------------------------------------
- Abstract class: DbConnection
  * Defines the base contract for database connections
  * Requires implementation of Open() and Close()

- Concrete classes: SqlConnection & OracleConnection
  * Provide specific logic to open and close connections

- DbCommand class
  * Represents a database command
  * Validates connection and instruction
  * Executes by:
      1. Opening the connection
      2. Printing the instruction
      3. Closing the connection

- Polymorphism in action
  * The same DbCommand works with both SqlConnection 
    and OracleConnection

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
DbConnection sqlConnection = new SqlConnection("Server=myServer;Database=myDB;User Id=myUser;Password=myPass;");
DbCommand sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Users");
sqlCommand.Execute();

DbConnection oracleConnection = new OracleConnection("Data Source=myOracleDB;User Id=myUser;Password=myPass;");
DbCommand oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Employees");
oracleCommand.Execute();

---------------------------------------------
EXPECTED OUTPUT
---------------------------------------------
SQL database connection opened.
Executing instruction: SELECT * FROM Users
SQL database connection closed.

Oracle database connection opened.
Executing instruction: SELECT * FROM Employees
Oracle database connection closed.

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- Abstraction: subclasses must implement connection logic
- Polymorphism: same code works with different connection types
- Encapsulation & validation: DbCommand requires valid inputs

---------------------------------------------
NOTE
---------------------------------------------
This project is for educational purposes only and does 
NOT actually connect to a real database.
