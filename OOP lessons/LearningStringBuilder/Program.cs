using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder(); //can be initialised without a string
            StringBuilder sb2 = new StringBuilder("Hello World!");
            StringBuilder sb3 = new StringBuilder(50); // can specify maximum capacity
            StringBuilder sb4 = new StringBuilder("Hello World!", 50); // can add string and capacity

            // once capacity is met, the capacity doubles
            // can use capacity/length to set/retrieve the StringBuilder capacity

            // can use for loop to get/set at a specified index
            StringBuilder sb5 = new StringBuilder("Hello World!");
            for (int i = 0; i < sb5.Length; i++)
                Console.WriteLine(sb5[i]); // output: Hello World!

            // retrieve string from StringBuilder
            StringBuilder sb6 = new StringBuilder("Hello World!");
            var greet = sb6.ToString(); //StringBuilder is not a String itself. Need .ToString()

            // add/append String to StringBuilder
            StringBuilder sb7 = new StringBuilder();
            sb7.Append("Hello ");
            sb7.AppendLine("World!"); // AppendLine adds a newline character at the end
            sb7.AppendLine("Hello C#");
            Console.WriteLine(sb7);

            // append formated String to StringBuilder
            StringBuilder sbAmout = new StringBuilder("Your total amount is ");
            sbAmout.AppendFormat("{0:C} ", 25);
            Console.WriteLine(sbAmout);//output: Your total amount is $ 25.00

            // insert String into StringBuilder
            StringBuilder sb8 = new StringBuilder("Hello World!");
            sb8.Insert(5, " C#"); // 0 starts before the word
            Console.WriteLine(sb8); //output: Hello C# World!

            // remove String in StringBuilder
            StringBuilder sb9 = new StringBuilder("Hello World!", 50);
            sb9.Remove(5, 7);
            Console.WriteLine(sb9); //output: Hello

            // replace String in StringBuilder
            StringBuilder sb = new StringBuilder("Hello World!");
            sb.Replace("World", "C#");
            Console.WriteLine(sb);//output: Hello C#!

            // to summarise: retrieve, append, format, insert, remove, replace


            Console.ReadLine();
        }
    }
}
