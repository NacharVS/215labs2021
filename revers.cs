using System;

namespace Chislo_2
{
    class Program
    {
        static void reverse()
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
    

