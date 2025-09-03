   DELEGATES CALCULATOR (C# PROJECT)
=============================================

This project demonstrates the use of **delegates** in C# 
by creating a simple calculator that performs arithmetic 
operations.

Delegates allow methods to be treated as objects, making it 
possible to pass them around, combine them, and call them 
dynamically. This example also shows the concept of 
**multicast delegates**, where one delegate can point to 
multiple methods.

---------------------------------------------
FEATURES
---------------------------------------------
- Delegate definition: 
  * `public delegate int Operation(int a, int b);`
  * Can reference any method with the same signature.

- Calculator class
  * Implements the following methods:
      - Add(int a, int b)
      - Subtract(int a, int b)
      - Multiply(int a, int b)
      - Divide(int a, int b)

- Program class
  * Demonstrates:
      - Assigning methods to a delegate
      - Combining multiple methods with `+=`
      - Executing all methods via multicast delegate

- Error handling
  * Divide method throws `DivideByZeroException` if the 
    denominator is zero.

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
var calc = new Calculator();
Operation op = calc.Add;
op += calc.Subtract;
op += calc.Multiply;
op += calc.Divide;

foreach (Operation method in op.GetInvocationList())
{
    method(10, 5);
}

---------------------------------------------
EXPECTED OUTPUT
---------------------------------------------
Add: 10 + 5 = 15
Subtract: 10 - 5 = 5
Multiply: 10 * 5 = 50
Divide: 10 / 5 = 2

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- **Delegates**: methods as first-class objects
- **Multicast delegates**: a delegate referencing multiple methods
- **Encapsulation**: calculator logic kept in a dedicated class
- **Error handling**: safe handling of invalid operations

---------------------------------------------
NOTE
---------------------------------------------
This project is for educational purposes only and 
demonstrates delegates in a simple calculator scenario.
