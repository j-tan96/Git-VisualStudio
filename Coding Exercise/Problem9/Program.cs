using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61,
                            67, 71, 73, 79, 83, 89, 9};
            int primesLength = primes.Length;
            Console.WriteLine("Please enter a number between 1 and {0}", primesLength);
            int locate = int.Parse(Console.ReadLine());
            locate--;

            if ((locate < 0) || (locate > (primesLength -1)))
            {
                Console.WriteLine("Number not in range");
            }
            else
            {
                Console.WriteLine(primes[locate]);
            }
            Console.ReadLine();
        }
    }
}
