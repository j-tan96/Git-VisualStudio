using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class and create an object
            Calculator calc = new Calculator();
            // create a local variable to hold the answer
            float x = 3;
            float y = 5;
            float sum = 0;
            float sub = 0;
            float mul = 0;
            float div = 0;
            sum = calc.Add(x, y);
            sub = calc.Subtract(x, y);
            mul = calc.Multiply(x, y);
            div = calc.Divide(x, y);
            Console.WriteLine("sum of {0} + {1} = {2}", x, y, sum);
            Console.WriteLine("{0} - {1} = {2}", x, y, sub);
            Console.WriteLine("{0} * {1} = {2}", x, y, mul);
            Console.WriteLine("{0} / {1} = {2}", x, y, div);
            Console.ReadLine();
        }
    }
}
