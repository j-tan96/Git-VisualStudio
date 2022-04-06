using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dict = {"parts","traps","arts","rats","starts","tarts","rat","art","tar","tars","stars","stray"};
            string star = "star";
            char[] starChar = star.ToCharArray();
            Array.Sort(starChar);
            foreach (string dictWord in dict)
            {
                char[] split = dictWord.ToCharArray();
                Array.Sort(split);
                if (split.SequenceEqual(starChar))
                {
                    Console.WriteLine(dictWord);
                }
            }
            Console.ReadLine();

        }
    }
}
