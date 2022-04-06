using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                string[] stars = new string[9];
                for (int x = 0; x < stars.Length; x++)
                {
                    stars[x] = " ";
                }

                // added a new int k to reverse the pattern
                int k = i;
                if (i > 5)
                {
                    k = 10 - i;
                }

                for (int j = 1; j <= (2 * k) - 1; j++)
                {
                    stars[4 + k - j] = "*";
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
