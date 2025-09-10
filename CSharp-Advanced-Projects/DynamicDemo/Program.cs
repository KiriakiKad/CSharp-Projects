using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic value = 100;
            Console.WriteLine("The value is: "  + value);

            value = "Hello, World!";
            Console.WriteLine("The value is: " + value);

            value = DateTime.Now;
            Console.WriteLine("The value is: " + value);

            //Exception at runtime
            Console.WriteLine("Non exidted method: " + value.SayHello());
        }
    }
}
