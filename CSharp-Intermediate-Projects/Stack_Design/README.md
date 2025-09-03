   STACK DESIGN EXAMPLE (C# PROJECT)
=============================================

This project demonstrates the design of a simple 
stack data structure in C# that follows the 
**Last-In, First-Out (LIFO)** principle.

The stack allows you to:
- Add elements (Push)
- Remove the most recent element (Pop)
- Clear all elements (Clear)

---------------------------------------------
FEATURES
---------------------------------------------
- Custom Stack class
  * Uses an internal List<object> to store items
  * Ensures null values cannot be pushed
  * Implements error handling with exceptions

- Push(object obj)
  * Adds a new element to the top of the stack
  * Throws exception if obj is null

- Pop()
  * Removes and returns the last inserted element
  * Throws exception if the stack is empty

- Clear()
  * Removes all elements from the stack

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
Stack stack = new Stack();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push("hello");
stack.Push(DateTime.Now);

stack.Pop();     // Removes latest element
stack.Pop();     // Removes next element

stack.Clear();   // Empties the stack

---------------------------------------------
EXPECTED OUTPUT (example run)
---------------------------------------------
ADDED: 1
ADDED: 2
ADDED: 3
ADDED: hello
ADDED: 09/03/2025 14:35:21
POPPED: 09/03/2025 14:35:21
POPPED: hello

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- Data structure implementation in C#
- LIFO principle
- Error handling with exceptions
- Encapsulation using private list
