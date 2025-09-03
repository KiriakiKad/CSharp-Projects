   LAMBDA FILTERING EXERCISE (C# PROJECT)
=============================================

This project demonstrates the use of **Lambda Expressions** in C# 
by processing a list of integers with dynamic and reusable logic.

Lambda expressions allow you to define **inline anonymous functions** 
that can be assigned to delegates, improving code readability 
and flexibility.

---------------------------------------------
FEATURES
---------------------------------------------
- Using `Action<int>` to define lambdas for processing integers.
- Conditional logic inside lambdas to determine:
    * Whether a number is **even or odd**
    * Whether a number is **greater than 5**
- Applying lambdas to lists using `foreach` loops.
- Reusable and concise code compared to traditional methods.
- Demonstrates combining delegates and lambdas for simple filtering.

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Action<int> action = n =>
{
    if (n % 2 == 0)
        Console.WriteLine($"{n} is even");
    else
        Console.WriteLine($"{n} is odd");
};

foreach (var num in numbers)
{
    action(num);
}

Action<int> greaterThan5 = n =>
{
    if (n > 5)
        Console.WriteLine($"{n} is greater than 5");
};

foreach (var num in numbers)
{
    greaterThan5(num);
}

---------------------------------------------
EXPECTED OUTPUT
---------------------------------------------
1 is odd
2 is even
3 is odd
4 is even
5 is odd
6 is even
7 is odd
8 is even
9 is odd
10 is even
6 is greater than 5
7 is greater than 5
8 is greater than 5
9 is greater than 5
10 is greater than 5

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- **Lambda expressions**: inline anonymous functions
- **Delegates**: methods as objects that can be assigned or passed
- **Action<T>**: built-in delegate for void-returning methods
- **Dynamic behavior**: easily reusable and extensible logic
- **Encapsulation**: processing logic is contained in a single lambda

---------------------------------------------
NOTE
---------------------------------------------
This project is for educational purposes only and demonstrates 
lambda expressions and basic filtering in C#.
