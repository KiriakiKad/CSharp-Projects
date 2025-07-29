using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_unique_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number or Quit:");
            var input = Console.ReadLine();
            var list = new List<int>();

            while (!input.Equals("Quit"))
            {
                var number = Convert.ToInt32(input);
                list.Add(number);

                Console.Write("Enter a number or Quit:");
                input = Console.ReadLine();
            }

            var outputList = new List<int>();
            for (var i = 0; i < list.Count; i++)
            {
                var element = list[i];
                var flag = true;
                var count = 0;
                for (var j = 0; j < list.Count; j++)
                {
                    if (list[j] == element)
                    {
                        count++;
                    }

                    if (count > 1)
                    {
                        flag = false;
                        break;
                    }

                }

                if (flag)
                    outputList.Add(element);

            }

            Console.WriteLine("The unique numbers are:");
            foreach (var number in outputList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
