using System;

namespace Zadachi
{
    class Простойкалькулятор
    {
        static void Калькулятор(string[] args)
        {
            Console.WriteLine("Vvedite dva chisla");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int S = a + b;
            int P = a * b;
            int M = a - b;
            int D = a / b;
            string result1 = "Summa=";
            string result2 = "Proizvedenie=";
            string result3 = "Raznostb=";
            string result4 = "delenie=";
            Console.WriteLine(result1 + S);
            Console.WriteLine(result2 + P);
            Console.WriteLine(result3 + M);
            Console.WriteLine(result4 + D);
            Console.WriteLine();
        }
    }
}
