using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_the_input_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number between 1 - 10: ");
            int number = Convert.ToInt32(Console.ReadLine());

            var answer = (number >= 1 && number <= 10) ? "You entered a valid number." : "You entered an invalid number.";
            Console.WriteLine(answer);
        }
    }
}
