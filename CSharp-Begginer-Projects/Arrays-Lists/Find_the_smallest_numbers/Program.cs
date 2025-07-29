using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_smallest_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Supply a list of comma separated numbers");
            var input = Console.ReadLine();

            var numbers = input.Split(',');
            while (numbers.Length < 5)
            {
                Console.WriteLine("Invalid list, try again");
                input = Console.ReadLine();
                numbers = input.Split(',');
            }

            var nums = new List<int>();

            for (var i = 0; i < numbers.Length; i++)
            {
                var element = Convert.ToInt32(numbers[i]);
                nums.Add(element);
            }

            nums.Sort();
            Console.WriteLine("The 3 smallest numbers are:");
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
