   GENERICS EXERCISE (C# PROJECT)
=============================================

This project demonstrates the use of **Generics** in C# 
by implementing a simple generic list class.

Generics allow us to write classes and methods that work 
with any data type, while maintaining type safety and 
avoiding unnecessary casting or boxing.

---------------------------------------------
FEATURES
---------------------------------------------
- Generic class: GenericList<T>
  * Stores items of any type (int, string, custom objects, etc.)
  * Uses a fixed-size array internally (capacity = 10)
  * Provides methods to:
      - Add(T item)
      - Get(int index)

- Type safety
  * You can create a GenericList<int>, GenericList<string>, 
    or any other type.
  * Ensures compile-time type checking.

- Error handling
  * Throws exceptions if:
      - Adding more than the maximum capacity
      - Accessing an invalid index

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
GenericList<int> intList = new GenericList<int>();
intList.Add(1);
intList.Add(2);
Console.WriteLine(intList.Get(0)); // Output: 1

GenericList<string> stringList = new GenericList<string>();
stringList.Add("Hello");
stringList.Add("World");
Console.WriteLine(stringList.Get(1)); // Output: World

---------------------------------------------
EXPECTED OUTPUT
---------------------------------------------
1
2
3
Hello
World

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- **Generics**: reusable code with type safety
- **Encapsulation**: hiding internal implementation details
- **Validation**: protecting against invalid operations

---------------------------------------------
NOTE
---------------------------------------------
This project is for educational purposes only and 
is a simplified implementation compared to the 
built-in List<T> class in C#.
