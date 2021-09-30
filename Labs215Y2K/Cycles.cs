using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Cycles
    {
        public static void twonumbersdegree()
            //степень числа 
        {
            Console.WriteLine("Введите число 1");
            long a = long.Parse(Console.ReadLine());
            Console.WriteLine("Введие число 2");
            long b = long.Parse(Console.ReadLine());
            long c = 1;
            for (int i = 1; i <= b; i++)
            {
                c = a * c;
            }
            Console.WriteLine($"Число равно {c}");
        }
        public static void doorcodecombinations()
            //дверной замок комбинации
        {
            int a = int.Parse(Console.ReadLine());
            for (int x1 = 0; x1 <= 9; x1++)
            {
                for (int x2 = x1 + 1; x2 <= 9; x2++)
                {
                    for (int x3 = x2 + 1; x3 <= 9; x3++)
                    {
                        if ((x1 + x2 + x3 == a) && (x1 != x2) && (x1 != x3) && (x2 != x3))
                        {
                            Console.Write(x1);
                            Console.Write(x2);
                            Console.WriteLine(x3);
                        }
                        else Console.Write("");
                    }
                }
            }
        }
        public static void reversenubmer()
            //перевеворот числа
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
