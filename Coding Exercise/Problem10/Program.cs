using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and I will give you the next prime number");
            int next = int.Parse(Console.ReadLine());
            next++;
            int stopper = 0;
            while (stopper < 1)
            {
                if (prime_check(next) == true)
                {
                    stopper = 1;
                    Console.WriteLine(next);
                }
                else
                {
                    next++;
                }
            }
            Console.ReadLine();
        }

        static public Boolean prime_check(int n)
        {
            for (int i = 2; i < (n - 1); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
