using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Balls
    {
        public static void ex10()
        {
            Console.WriteLine("Введите радиус");
            int r = int.Parse(Console.ReadLine());
            double S = 4 * Math.PI * Math.Pow(r, 2);
            Console.WriteLine(S);
            
        }
    }
}
