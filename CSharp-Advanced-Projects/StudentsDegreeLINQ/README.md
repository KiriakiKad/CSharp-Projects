   STUDENTS DEGREE LINQ (C# PROJECT)
=============================================

This project demonstrates the use of **LINQ** in C# 
to query and filter student data.

LINQ allows us to write clean and expressive queries 
directly in C# without manually looping through collections.

---------------------------------------------
FEATURES
---------------------------------------------
- Student class  
  * Contains `Name` and `Degree` properties  

- StudentRepo class  
  * Holds a list of pre-defined students  

- LINQ Query  
  * Filters students with Degree >= 50  
  * Orders the results by degree in **descending order**  
  * Selects only the student names  

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
var students = new StudentRepo();

var passedStudents = from s in students.Students
                     where s.Degree >= 50
                     orderby s.Degree descending
                     select s.Name;

foreach (var name in passedStudents)
{
    Console.WriteLine(name);
}

---------------------------------------------
EXPECTED OUTPUT
---------------------------------------------
Diana
Alice
Bob
Ethan
...

(The order depends on the degrees, highest first.)

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- **LINQ queries** with `where`, `orderby`, and `select`
- **Filtering** data based on conditions
- **Sorting** results in descending order
- **Projection**: selecting specific properties (Name)

---------------------------------------------
NOTE
---------------------------------------------
This project is for educational purposes 
and shows how LINQ simplifies collection querying 
compared to traditional loops.
