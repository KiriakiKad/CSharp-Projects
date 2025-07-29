using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            var input = Console.ReadLine();

            char[] name = input.ToCharArray();
            //reverse
            Array.Reverse(name);
            var output = new string(name);

            Console.Write("Reversed: " + output);


        }
    }
}
