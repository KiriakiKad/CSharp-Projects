using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Calculate(stopwatch);
        }
        public static void Calculate(Stopwatch stopwatch)
        {
            try
            {
                stopwatch.Start(); // Simulate some work
                System.Threading.Thread.Sleep(2000);
                var duration = stopwatch.Stop();

                Console.WriteLine("Elapsed time: " + duration.TotalSeconds + " seconds");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
