using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                string[] stars = new string[9];
                for (int x = 0; x < stars.Length; x++)
                {
                    stars[x] = " ";
                }
                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    stars[4 + i - j] = "*";
                }

                foreach (string w in stars)
                {
                    Console.Write(w);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
