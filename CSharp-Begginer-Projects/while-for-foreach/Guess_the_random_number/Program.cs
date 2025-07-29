using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_random_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess the number between 1 - 10: ");
            Random random = new Random();
            var numberToGuess = random.Next(1, 10); // Random number between 1 and 10

            var userGuess = 0;
            while (userGuess < 4)
            {
                var number = Console.ReadLine();
                if (int.Parse(number) == numberToGuess)
                {
                    Console.WriteLine("You won!");
                    break;
                }

                if (userGuess < 3)
                    Console.WriteLine("Try again");
                userGuess++;
            }

            if (userGuess != numberToGuess)
                Console.WriteLine("You lost");

            Console.WriteLine("The number is: " + numberToGuess);
        }
    }
}
