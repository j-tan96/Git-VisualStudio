using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1UsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            double average;
            int grade = 0;
            int total = 0;
            //Instantiate an Array List
            List<int> grades = new List<int>();
            Random rnd = new Random();
            for (int x = 0; x < 10; x++)
            {

                grade = rnd.Next(0, 100);
                grades.Add(grade);
            }
            for (int i = 0; i < grades.Count; i++)
            {
                //print out grades
                Console.WriteLine("grade[{0}] = {1}", i, grades[i]);
                total += grades[i];
            }
            average = total / grades.Count;
            Console.WriteLine("The average is {0}", average);
            Console.ReadLine();
        }
    }
}
