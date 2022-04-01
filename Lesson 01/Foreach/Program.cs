using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 2, 4, 6, 8, 10 };
            foreach (int val in number)
            {
                Console.WriteLine("{0} ", val);
                
            }
            Console.ReadLine();
        }
    }
}
