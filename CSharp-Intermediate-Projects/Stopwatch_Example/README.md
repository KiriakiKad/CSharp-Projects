   STOPWATCH EXAMPLE (C# PROJECT)
=============================================

This project demonstrates the implementation 
of a simple Stopwatch class in C#.

The Stopwatch measures elapsed time between 
starting and stopping, with error handling to 
prevent invalid operations.

---------------------------------------------
FEATURES
---------------------------------------------
- Stopwatch class
  * Start()
    - Records the current time as start
    - Throws exception if already running
  * Stop()
    - Records the current time as end
    - Calculates elapsed time (TimeSpan)
    - Throws exception if not running

- Error handling
  * Prevents starting when already running
  * Prevents stopping when not running

- Example program
  * Demonstrates usage by simulating work with 
    Thread.Sleep() and printing elapsed time

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
// Simulate work
System.Threading.Thread.Sleep(2000);
TimeSpan duration = stopwatch.Stop();

Console.WriteLine("Elapsed time: " 
                  + duration.TotalSeconds 
                  + " seconds");

---------------------------------------------
EXPECTED OUTPUT
---------------------------------------------
Elapsed time: 2.0 seconds

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- Encapsulation of time measurement logic
- Use of DateTime for tracking start/end
- Use of TimeSpan for elapsed time
- Defensive programming with exceptions
