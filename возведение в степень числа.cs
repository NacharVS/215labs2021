using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введие второе число");

            int b = int.Parse(Console.ReadLine());

            int c = 1;

            for (int i = 1; i <= b; i++)
            {
                c = a * c;
            }
            Console.WriteLine($"Число {a} в {b} степени равно  {c}");
        }
    }
}
