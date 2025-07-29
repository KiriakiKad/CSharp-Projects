using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximium_between_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            var input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number:");
            var input2 = Convert.ToInt32(Console.ReadLine());

            var answer = (input1 > input2) ? "The first number is greater than the second number." :
                (input1 < input2) ? "The first number is less than the second number." :
                "The two numbers are equal.";

            Console.WriteLine(answer);
        }
    }
}
