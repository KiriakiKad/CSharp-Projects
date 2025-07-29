using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_the_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a time value in the 24-hour time format (e.g. 19:00): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time");
                return;
            }

            string[] timeParts = input.Split(':');

            if (timeParts.Length != 2 ||
                timeParts[0].Length != 2 ||
                timeParts[1].Length != 2)
            {
                Console.WriteLine("Invalid time");
                return;
            }

            if (IsValidHour(timeParts[0]) && IsValidMinute(timeParts[1]))
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Invalid time");
            }
        }

        static bool IsValidHour(string hour)
        {
            if (hour.Length != 2) return false;

            int value = int.Parse(hour);

            return value >= 0 && value <= 23;
        }

        static bool IsValidMinute(string minute)
        {
            if (minute.Length != 2) return false;

            int value = int.Parse(minute);

            return value >= 0 && value <= 59;
        }

    }
}
