using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Cycles
    {
        public static void StepenChisla()
        {
            Console.WriteLine("Введите число, которое хотите возвести в степень");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень числа");
            int b = int.Parse(Console.ReadLine());
            int c = 1;
            for (int i = 1; i <= b; i++)
            {
                c = m * c;
            }
            Console.WriteLine($"полученное число - {c}");
        }

        public static void doorcode()
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
    }
}
