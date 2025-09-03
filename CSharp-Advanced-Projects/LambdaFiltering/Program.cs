using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }

    }
}
