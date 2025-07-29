using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_the_factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a number: ");
            var input = Console.ReadLine();

            var factorial = 1;
            for (var i = int.Parse(input); i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of " + input + " is " + factorial);
        }
    }
}
