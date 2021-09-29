using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Stepen
    {
        public static void Ex1() 
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень числа");
            int x = int.Parse(Console.ReadLine());
            for (int i = 2; i <= x; i++)
            {
                num *= num;
            }
            Console.WriteLine(num);
        }
    }
}
