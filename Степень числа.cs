using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень числа");
            int b = int.Parse(Console.ReadLine());
            for (int i = 2;  i <= b; i++)
            {
                num *= num;
            }
            Console.WriteLine(num);
        }
    }
}
