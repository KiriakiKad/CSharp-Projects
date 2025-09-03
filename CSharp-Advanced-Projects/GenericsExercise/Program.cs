using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            Console.WriteLine(intList.Get(0)); // Output: 1
            Console.WriteLine(intList.Get(1)); // Output: 2
            Console.WriteLine(intList.Get(2)); // Output: 3
            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            Console.WriteLine(stringList.Get(0)); // Output: Hello
            Console.WriteLine(stringList.Get(1)); // Output: World
        }
    }
}
