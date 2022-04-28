using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle
{
    class Program
    {
        static void Main(string[] args)
        {
            // plan of action
            /* Have false letters become "-"
             * Correct letters in the wrong place are lower case
             * Correct letters in the right place are upper case
             * 
             * ---E-
             * --tER
             * TOWER
             * 
             * Could print an alphabet that 
             * 
             * when Wordle has double letters, it will show yellow for excess
             * if the letter appears once, then only one of the letters will be coloured
             */

            // could change this to extract from a dictionary
            StringBuilder word = new StringBuilder(5);
            word.Append("WORDS");

            String guess1 = "PLACEHOLDER1";
            String guess2 = "PLACEHOLDER2";
            String guess3 = "PLACEHOLDER3";
            String guess4 = "PLACEHOLDER4";
            String guess5 = "PLACEHOLDER5";
            String guess6 = "PLACEHOLDER6";
            String[] guessList = { guess1, guess2, guess3, guess4, guess5, guess6 };

            bool guessed = false;
            int tries = 6;

            StringBuilder guess = new StringBuilder(5);

            // current state: print off the no. of placeholders depending on when you guess "WORDS"
            Console.WriteLine("Welcome to Wordle! Please enter your first 5 letter guess:");
            for(int i = 0; i < tries; i++)
            {
                String guessString = Console.ReadLine().ToString();
                guess.Append(guessString);
                if(guessString == word.ToString())
                {
                    for(int j = 0; j < i; j++)
                    {
                        Console.WriteLine(guessList[j]);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("loser");
                }









               // Console.WriteLine(guessString);
            }



            Console.WriteLine(guessList[0]) ;
            Console.ReadLine();
        }
    }
}
