using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            

            // to use the class arithmetic - instantiate
            Arithmetic arith = new Arithmetic();

            // delcaration

            int sum = 0;
            sum = arith.Add(3, 4);
            Console.WriteLine("sum is: {0}", sum);

            int subTotal = 0;
            subTotal = arith.Subtract(3, 4);
            Console.WriteLine("Subtract total is: {0}", subTotal);

            int mulTotal = 0;
            mulTotal = arith.Mult(3, 4);
            Console.WriteLine("Product is: {0}", mulTotal);

            float quotient = 0.0f;
            quotient = arith.Div(12, 3);


            Console.ReadLine();
        }
    }
}
