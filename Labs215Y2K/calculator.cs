using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class calculator
    {
        public static void Ex5()
        {
            Console.WriteLine("Введите 2 числа");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите одно из нескольких действий: 1-сложение, 2-вычитание, 3-умножение, 4-деление, 5-возведение в степень, 6-остаток от деления");
            int f = int.Parse(Console.ReadLine());
            switch (f)
            {
                case 1: { Console.WriteLine(a + b); break; }
                case 2: { Console.WriteLine(a - b); break; }
                case 3: { Console.WriteLine(a * b); break; }
                case 4: { Console.WriteLine(a / b); break; }
                case 5: { Console.WriteLine(Math.Pow(a, b)); break; }
                case 6: { Console.WriteLine(a % b); break; }
                default: { Console.WriteLine("Мы пока таким не занимаемся!!!"); break; }
            }
        }
    }
}
