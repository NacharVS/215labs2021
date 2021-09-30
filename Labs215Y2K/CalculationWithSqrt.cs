using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class CalculationWithSqrt
    {
        public static void Ex() 
        {
            Console.WriteLine("Radius = ");
            int r = int.Parse(Console.ReadLine());
            double sqrt = 4 * Math.PI * Math.Pow(r, 2);
            Console.WriteLine(sqrt);
        }
    }
}
