   ASYNC DATA PROCESSING (C# PROJECT)
==============================================

This project demonstrates the use of **asynchronous programming** in C# 
to fetch and process data without blocking the main thread.

Async/await allows us to write asynchronous code in a clean, readable manner,
similar to synchronous code, while keeping applications responsive.

---------------------------------------------
FEATURES
---------------------------------------------
- **DataFetcher class**  
  * Contains an asynchronous method `FetchDataAsync()`  
  * Simulates a delay to fetch data (2 seconds)  
  * Returns a list of integers  

- **DataProcessor class**  
  * Contains a synchronous method `ProcessData(List<int> data)`  
  * Processes the fetched data by multiplying each number by 2 and printing it  

- **Async/Await usage**  
  * `Main` method is declared as `async Task Main`  
  * Calls `FetchDataAsync()` with `await` to asynchronously get the data  
  * Ensures non-blocking execution while waiting for the data  

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
var dataFetcher = new DataFetcher();
var dataProcessor = new DataProcessor();

var data = await dataFetcher.FetchDataAsync();
dataProcessor.ProcessData(data);

---------------------------------------------
EXPECTED OUTPUT
---------------------------------------------
1 * 2: 2
2 * 2: 4
3 * 2: 6
4 * 2: 8
5 * 2: 10

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- **Async/Await** for asynchronous operations  
- **Task<T>** to represent ongoing work  
- **Separation of concerns**: fetching data vs processing data  
- **Non-blocking execution** in the main thread  

---------------------------------------------
NOTE
---------------------------------------------
This project is for educational purposes and simulates 
a typical async data fetching scenario without using real I/O.
