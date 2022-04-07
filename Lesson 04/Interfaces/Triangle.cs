using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Triangle : IShape
    {
        public double sideA { get; set; }
        public double sideB { get; set; }

        public double sideC { get; set; }


        public double Area()
        {
            double semiPerim = (sideA + sideB + sideC) / 2;
            double rounded = Math.Sqrt(semiPerim*(semiPerim-sideA)*(semiPerim-sideB)*(semiPerim-sideC));
            return rounded;
        }
        public double perimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}
