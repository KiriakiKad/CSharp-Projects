using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Design
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);

            stack.Push(2);
            stack.Push(3);

            stack.Push("hello");
            stack.Push(DateTime.Now);

            try
            {
                stack.Push(null);          // Push with null
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
            }

            stack.Pop();
            stack.Pop();


            stack.Clear();
        }
    }
}
