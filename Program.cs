using System;

namespace Stepen__chisla
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
