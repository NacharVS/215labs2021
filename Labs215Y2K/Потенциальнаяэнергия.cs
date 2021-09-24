using System;

namespace Задача
{
    class Потенциальнаяэнергия
    {
        static void энергия(string[] args)
        {


            Console.WriteLine("Vvedite m,h");
            int m = int.Parse(Console.ReadLine());
            int g = 10;
            int h = int.Parse(Console.ReadLine());
            int F = m * g * h;
            string result = "Потенциальная энергия=";
            string result2 = "Н/кг";
            Console.WriteLine(result + F + result2);
            Console.WriteLine();
        }
    }
}