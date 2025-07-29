using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an English word: ");
            var input = Console.ReadLine();

            string[] vowels = { "a", "e", "i", "o", "u" };

            int vowelCount = 0;
            foreach (var letter in input.ToLower())
            {
                if (vowels.Contains(letter.ToString()))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("The number of vowels in the word " + input + " is: " + vowelCount);
        }
    }
}
