=========================================
        DYNAMIC DEMO (C# PROJECT)
=========================================

This project demonstrates the use of the **dynamic** type in C#.

A `dynamic` variable can change its type at runtime.
Unlike `var`, the compiler does not check method/property existence,
so errors are detected only at runtime.

---------------------------------------------
FEATURES
---------------------------------------------
- Demonstrates assigning different types to a `dynamic` variable:
  * `int`
  * `string`
  * `DateTime`

- Shows how calling a non-existing method 
  on a dynamic object causes a **runtime exception**.

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
dynamic value = 100;
Console.WriteLine("The value is: " + value);

value = "Hello, World!";
Console.WriteLine("The value is: " + value);

value = DateTime.Now;
Console.WriteLine("The value is: " + value);

// This will throw an exception at runtime
Console.WriteLine("Non existed method: " + value.SayHello());

---------------------------------------------
EXPECTED OUTPUT
---------------------------------------------
The value is: 100
The value is: Hello, World!
The value is: 09/09/2025 12:34:56 μμ
Unhandled Exception: Microsoft.CSharp.RuntimeBinder.RuntimeBinderException:
'System.DateTime' does not contain a definition for 'SayHello'

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- **Dynamic typing** in C#
- **Runtime type flexibility**
- **Compile-time safety trade-off**
- **Runtime exceptions** when members don't exist

---------------------------------------------
NOTE
---------------------------------------------
This project is for educational purposes 
and shows how `dynamic` differs from `var` 
by deferring type checking to runtime.
