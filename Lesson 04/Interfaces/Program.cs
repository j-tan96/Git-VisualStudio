using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();
            Triangle tri = new Triangle();
            double a = 3;
            double b = 4;
            double c = 6;
            double area = 0;
            double perimeter = 0;

            rec.height = a;
            rec.width = b;
            area = rec.Area();

            Console.WriteLine("Area of rectangle is: {0:F}", area);
            perimeter = rec.perimeter();
            Console.WriteLine("Perimeter of rectange is: {0:F}", perimeter);


            Console.WriteLine("------------------");


            circle.radius = c;
            area = circle.Area();
            Console.WriteLine("Area of circle is: {0:F}", area);
            perimeter = circle.perimeter();
            Console.WriteLine("Perimeter of circle is: {0:F}", perimeter);
            
            Console.WriteLine("------------------");
            tri.sideA = a;
            tri.sideB = b;
            tri.sideC = c;
            area = tri.Area();
            perimeter = tri.perimeter();
            Console.WriteLine("Area of triangle is: {0:F}", area);
            perimeter = rec.perimeter();
            Console.WriteLine("Perimeter of triangle is: {0:F}", perimeter);

            Console.ReadLine();
        }
    }
}
