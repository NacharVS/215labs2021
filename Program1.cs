using System;

namespace ConsoleApp215
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите числа.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("введите действие");
            string c = Console.ReadLine();
            switch (c)
            { case "сложение":  Console.WriteLine(a + b); break;
                case "вычитание": Console.WriteLine(a - b); break;
                case "умножение": Console.WriteLine(a * b); break;
                case "деление": Console.WriteLine(a / b); break;
                case "процент от деления": Console.WriteLine(a % b); break;
                case "степень": Console.WriteLine( Math.Pow (a, b) ); break;
                case "сумма квадратов": Console.WriteLine( (a * a) + (b * b)); break;
                default: Console.WriteLine("не существующее действие"); break;

            }

        }
    }
}
