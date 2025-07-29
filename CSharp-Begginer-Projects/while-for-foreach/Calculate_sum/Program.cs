using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            while (true)
            {
                Console.Write("Enter a number or ok to exit: ");
                var input = Console.ReadLine();

                if (input.Equals("ok"))
                    break;

                sum += int.Parse(input);
            }

            Console.Write($"The sum is: " + sum);
        }
    }
}
