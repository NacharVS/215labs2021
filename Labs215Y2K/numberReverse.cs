using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class numberReverse
        //переворот числа
    {
        public static void ex()
        {
            int a = int.Parse(Console.ReadLine());
            int chislo = 0;
            while (a > 0)
            {
                chislo *= 10;
                chislo += a % 10;
                a /= 10;
            }
            Console.WriteLine($"{chislo}");
        }
    }
}
