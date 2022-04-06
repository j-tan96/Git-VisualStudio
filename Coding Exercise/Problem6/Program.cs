using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type in a word to test for palindrome: ");
            string input = Console.ReadLine();
            // eliminating spaces allows for palindromes like "race car" to be accepted
            input = input.Replace(" ", "");
            char[] inputChar = input.ToCharArray();
            int inLength = inputChar.Length;
            char[] reverse = new char[inLength];

            for (int i = 0; i < inLength; i++)
            {
                reverse[i] = inputChar[inLength - i - 1];
            }

            if (inputChar.SequenceEqual(reverse))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }


            Console.ReadLine();
        }
    }
}
