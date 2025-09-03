using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCalculator
{
    public delegate int Operation(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            Operation op = calc.Add;
            op += calc.Subtract;
            op += calc.Multiply;
            op += calc.Divide;

            op(10, 5);

        }
    }
}
