using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_count
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for (var i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Total count of numbers divisible by 3: " + count);
        }
    }
}
