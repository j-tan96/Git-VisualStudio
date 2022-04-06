using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "hello world";
            char[] inputChar = input.ToCharArray();
            int inLength = inputChar.Length;
            char[] reverse = new char[inLength];

            for (int i = 0; i < inLength; i++)
            {
                reverse[i] = inputChar[inLength - i - 1];
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}
