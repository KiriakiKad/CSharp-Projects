using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by comma");
            var input = Console.ReadLine();

            // Split the input into an array of strings
            var numbers = input.Split(',');


            var max = Int32.MinValue;
            foreach (var letter in numbers)
            {

                var number = Convert.ToInt32(letter);
                if (number > max)
                {
                    max = number;
                }

            }

            Console.WriteLine("Maximum: " + max);
        }
    }
}
