using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_limit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a speed limit: ");
            var inputLimit = Console.ReadLine();
            var limit = Convert.ToInt32(inputLimit);

            Console.WriteLine("What's the car's speed?");
            var inputSpeed = Console.ReadLine();
            var speed = Convert.ToInt32(inputSpeed);

            if (speed < limit)
            {
                Console.WriteLine("Ok, you are within the speed limit.");
            }
            else
            {
                var gap = speed - limit;
                var points = gap / 5;
                if (points > 12)
                {
                    Console.WriteLine("License Suspented");
                }
                else
                {
                    Console.WriteLine(string.Format("Your points: {0}", points));
                }

            }
        }
    }
}
