using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class sphereSquare
        //найти площадь шара 
    {
        public static void ex()
        {
            Console.WriteLine("Введите радиус");
            int r = int.Parse(Console.ReadLine());
            double square = 4 * Math.PI * Math.Pow(r, 2);
            Console.WriteLine(square);
            Console.WriteLine();
        }
    }
}
