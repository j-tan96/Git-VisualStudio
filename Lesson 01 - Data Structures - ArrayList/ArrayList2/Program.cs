using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int highest = 0;
            int number = 0;

            // Instantiate an Array List
            ArrayList grades = new ArrayList();
            Random rnd = new Random();
            for (int x = 0; x < 10; x++)
            {
                // generate grade and add to arraylist
                number = rnd.Next(0, 100);
                grades.Add(number);
            }

            for(int i = 0; i < grades.Count; i++)
            {
                // find highest grade
                Console.WriteLine("grade[{0}] = {1}", i, (int)grades[i]);
                if ((int) grades[i] > highest)
                {
                    highest = (int)grades[i];
                }
            }
            Console.WriteLine("Maximum grade is: {0}", highest);
            Console.ReadLine();
        }
    }
}
