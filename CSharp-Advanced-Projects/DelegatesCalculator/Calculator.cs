using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCalculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Add: {a} + {b} = {result}");
            return result;
        }

        public int Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Subtract: {a} - {b} = {result}");
            return result;
        }

        public int Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Multiply: {a} * {b} = {result}");
            return result;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero!");
            int result = a / b;
            Console.WriteLine($"Divide: {a} / {b} = {result}");
            return result;
        }
    }
}
