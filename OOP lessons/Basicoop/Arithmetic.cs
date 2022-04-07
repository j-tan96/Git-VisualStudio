using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicoop
{
    // we can see Arithmetic has inherited Multiply
    // we cannot add another class, as C# only has single inheritance
    // to add more methods, we need to add an interface
    public class Arithmetic:Multiply, IDivision
    {
        // member variables
        int x = 0;
        int y = 0;

        // methods
        public int Add(int a, int b)
        {
            x = a;
            y = b;
            int sum = x + y;
            return sum;
        }

        public float Div(int a, int b)
        {
            return a / b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

    }
}
