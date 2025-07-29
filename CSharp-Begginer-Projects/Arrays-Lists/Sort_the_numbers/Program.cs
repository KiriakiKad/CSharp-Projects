using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_the_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5  numbers");
            Console.Write("Number:");
            var input = Console.ReadLine();

            var numbers = new int[5];
            var givenNumbers = 0;

            while (givenNumbers < 5)
            {
                var num = Convert.ToInt32(input);
                if (!numbers.Contains(num))
                {
                    numbers[givenNumbers] = num;
                    givenNumbers++;
                }
                else
                {
                    Console.WriteLine("Please enter a unique number");
                }

                if (givenNumbers < 5)
                {
                    Console.Write("Number:");
                    input = Console.ReadLine();
                }

            }

            Array.Sort(numbers);
            Console.WriteLine(string.Join(",", numbers));
        }
    }
}
