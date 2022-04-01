using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionblockSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Function to add two numbers
            int a = 0;
            int square = 0;
            Console.Write("Enter a number: ");
            a = Convert.ToInt16(Console.ReadLine());
            square = Square(a);
            Console.WriteLine(square);
            Console.ReadLine();

        }
        // function to add two numbers
        public static int Square(int a)
        {
            return a * a;
        }
    }
}
