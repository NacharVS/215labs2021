using System;

namespace calculator
{
    class Program
    {
        static void Calsulator()
        {
            Console.WriteLine("Введите 2 числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знак действия:");
            string d =  Console.ReadLine();
            if (d == "+")
            {
                Console.WriteLine($"Сумма:{a+b}");
            }
            if (d == "-")
            {
                Console.WriteLine($"Разность:{a - b}");
            }
             if (d == "/")
             {
                Console.WriteLine($"Чё то отделения:{a / b}");
             }
             if (d == "*")
             {
                Console.WriteLine($"Произведение:{a * b}");
             }
            
        }
    }
}
