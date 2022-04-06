using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] longSeq = {1,2,1,1,0,3,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0};
            int storage = 0;
            int longestSeq = 0;
            foreach (int i in longSeq)
            {
                if (i == 0)
                {
                    storage++;
                }

                else
                {
                    if (storage > longestSeq)
                    {
                        longestSeq = storage;
                        storage = 0;
                    }
                }

            }
            Console.WriteLine(longestSeq);
            Console.ReadLine();
        }
    }
}
