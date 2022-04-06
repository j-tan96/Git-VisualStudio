using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {

            /* I initially tried to split the input into an array and sum the parts
             * but it got too complicated with conversions and parsing.
             * I had to look for inspiration online in order to discover
             * this method of using mod 10 
             */



            Console.WriteLine("Type in a number, and get the sum of its digits: ");
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int modulo = 0;
            while (input > 0)
            {
                modulo = input % 10;
                sum += modulo;
                input /= 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
