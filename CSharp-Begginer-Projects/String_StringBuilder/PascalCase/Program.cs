using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few words separated by a space: ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No words entered.");
                return;
            }

            var word = input.ToLower();

            var words = word.Split(' ');

            var builder = new StringBuilder();
            foreach (var w in words)
            {
                builder.Append(char.ToUpper(w[0]) + w.Substring(1));
            }
            var result = builder.ToString();
            Console.WriteLine(result);

        }
    }
}
