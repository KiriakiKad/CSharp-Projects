using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portrait_or_landscape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give the height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            var answer = (width == height) ? "Is a portrait" : "Is a landscape";
            Console.WriteLine(answer);
        }
    }
}
