using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_DESC_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            string input = Console.ReadLine();
            string[] numbers = input.Split('-');

            var flagASC = true;
            var flagDESC = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) != Convert.ToInt32(numbers[i - 1]) + 1)
                {
                    flagASC = false;
                }
                if (Convert.ToInt32(numbers[i]) != Convert.ToInt32(numbers[i - 1]) - 1)
                {
                    flagDESC = false;
                }
            }

            if (flagASC)
            {
                Console.WriteLine("The numbers are in ascending order");
            }
            else if (flagDESC)
            {
                Console.WriteLine("The numbers are in descending order");
            }
            else
            {
                Console.WriteLine("The numbers are not in ascending or descending order");
            }
        }
    }
}
