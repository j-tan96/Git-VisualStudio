using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hangman
{
    class Program
    {

        // use this for when the string is bigger than size 1
        public static int inputWordAtt(string input, string currentWord, int numberOfAttempts)
        {
            if (input == currentWord)
            {
                Console.WriteLine("You are correct! Word is {0}", currentWord);
                return numberOfAttempts;
            }
            else
            {
                numberOfAttempts++;
                Console.WriteLine("You are incorrect! {0} attempts remaining", 6 - numberOfAttempts);
                return numberOfAttempts;
            }


        }

        // use this for when the input is exactly size 1
        public static int inputCharAtt(char input, string currentWord, int numberOfAttempts)
        {
            if (currentWord.Contains(input))
            {
                return numberOfAttempts;
            }
            else
            {
                numberOfAttempts++;
                Console.WriteLine("You are incorrect! {0} attempts remaining", 6 - numberOfAttempts);
                return numberOfAttempts;
            }


        }




        // luke - trying to take input char[] and current word char[] and checks for matches
        public static ArrayList charCheck(char[] input, char[] currentWord)
        {
            ArrayList indexes = new ArrayList();
            foreach (char c in currentWord)
            {
                if (c == input[0])
                {
                    indexes.Add(c);
                }
            }
            return indexes;

            //returns arraylist with indexes where they match else returns empty arraylist, check .isEmpty()
        }



        // method to print the man
        public static void figureBuilder(int n)
        {
            int incorrectAttemptCounter = n;

            switch (incorrectAttemptCounter)
            {
                case 1:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 2:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /         |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 3:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 4:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\      |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 5:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\      |");
                    Console.WriteLine("           /         |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                case 6:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("            O        |");
                    Console.WriteLine("           /|\\      |");
                    Console.WriteLine("           / \\      |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
                default:
                    Console.WriteLine("            __________");
                    Console.WriteLine("            |        |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                     |");
                    Console.WriteLine("                    /|");
                    Console.WriteLine("                   / |");
                    Console.WriteLine("    ------------------");
                    break;
            }
        }


        static void Main(string[] args)
        {

            // pick random word from list
            List<string> word = new List<string>();
            word.Add("HELLO");
            word.Add("WORLD");
            word.Add("DREAM");
            word.Add("GREAT");
            word.Add("CREAM");

            Random ran = new Random();

            string rdmWord = word[ran.Next(0, word.Count - 1)];
            Console.WriteLine(rdmWord);

           





            // underscore string
            string underscore = "";
            // number of underscores
            for (int i = 0; i < rdmWord.Length; i++)
            {
                underscore = underscore + " _ ";
            }

            Console.WriteLine(underscore);





            // prints a hangman
            int incorrectAttempts = 0;
            figureBuilder(incorrectAttempts);

            // while loop
            while (incorrectAttempts < 6)
            {
                // take input and put into a character array
                Console.WriteLine("Please enter a letter as your guess");
                String inputString = Console.ReadLine();
                inputString = inputString.ToUpper();
                char inputChar = new char();
                if (inputString.Length == 1)
                {
                    char[] stringArray = inputString.ToCharArray();
                    inputChar = stringArray[0];
                    Console.WriteLine("you entered one letter: {0}", inputChar);
                    incorrectAttempts = inputCharAtt(inputChar, rdmWord, incorrectAttempts);
                    figureBuilder(incorrectAttempts);
                }
                else
                {
                    Console.WriteLine("kept as string: {0}", inputString);
                    incorrectAttempts = inputWordAtt(inputString, rdmWord, incorrectAttempts);
                    figureBuilder(incorrectAttempts);
                }
            }

            /*
            incorrectAttempts = inputWord(inputString, rdmWord, incorrectAttempts);
            Console.WriteLine("The number of incorrect attempts is: {0}", incorrectAttempts);
            */






            // if the word is more than one character long, just takes the first character

            // add into 26 char array of "attempted" letters
            // will change triedLetters[0] to triedLetters[i] when in the loop
            /*
            char[] triedLetters = new char[26];
            triedLetters[0] = inputChar;
            Console.WriteLine(triedLetters);
            */





            Console.ReadLine();








        }
    }
}
