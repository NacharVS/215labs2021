using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Сalculator
    {
        public static void ex6()
        {
            Console.WriteLine("Введите два числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int summ = a + b;
            int minus = a - b;
            int mult = a * b;
            int del = a / b;         
            Console.WriteLine($"Сумма =" + summ);
            Console.WriteLine($"Вычитание =" + minus);
            Console.WriteLine($"Произвидение =" + mult);
            Console.WriteLine($"Деление =" + del);
        }
    }
}
