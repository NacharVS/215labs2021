using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, которое хотите возвести в степень");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень числа");
            int b = int.Parse(Console.ReadLine());
            int c = 1;
                for (int i = 1; i <=b; i ++)
            {
                c = m * c;
            }
            Console.WriteLine($"полученное число - {c}");
        }
    }
}
