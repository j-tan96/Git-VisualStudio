using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberExercise6Tries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int upperBound = 99;
            int lowerBound = 0;
            int tries = 6;
            int comp = rnd.Next(lowerBound, upperBound);
            Console.WriteLine("The computer has chosen a number between 1 and 99.");
            Console.WriteLine("Please guess the number within 6 tries.");
            String hiLo = "";
            bool guessed = false;
            for (int i = 0; i < tries; i++)
            {
                Console.WriteLine("Enter your guess:");
                int userGuess = int.Parse(Console.ReadLine());

                if(userGuess == comp)
                {
                    Console.WriteLine("Congratulations! The answer was {0}.", comp);
                    guessed = true;
                    break;
                }
                else
                {
                    if(userGuess > comp)
                    {
                        hiLo = "lower";
                    }
                    else
                    {
                        hiLo = "higher";
                    }
                    Console.WriteLine("Unlucky! The computer's number is {0}. You have {1} tries left", hiLo, tries-1-i);
                }
            }
            if(guessed == false)
            {
                Console.WriteLine("Unfortunately the computer has won! The number was: {0}", comp);
            }
            
            Console.ReadLine();
        }
    }
}
