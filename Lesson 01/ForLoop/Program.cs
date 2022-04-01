using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // sum of squares
            double sum = 0;
            double count = 0;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + Math.Pow(count, 2.0);
                Console.WriteLine("count: {0} sum:{1}", count, sum);
                count++;
            }
            Console.ReadLine();
        }
    }
}
