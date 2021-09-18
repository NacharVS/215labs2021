using System;

namespace переворот_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, которое хотите перевернуть:");
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            while (a > 0)
            {
                b *= 10;
                b += a % 10;
                a /= 10;
            }

            Console.WriteLine($"Перевернутое число:  {b}");
        }
    }
}
