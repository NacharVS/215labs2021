using System;

namespace перевернутое_число
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите трехзначное число,которое нужно перевернуть");
            int n = Convert.ToInt32(Console.ReadLine());
            n = (n / 100) + (n / 10 % 10 * 10) + (n % 10 * 100);
            Console.WriteLine($" ваше перевернутое число - {n}");
        }
    }
}
