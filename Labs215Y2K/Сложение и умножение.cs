using System;
using System.Linq;

namespace МинимумМаксимум
{
    class MultPlus
    {
        static void PlusMult(string[] args)
        {
            int[] Array = new int[10];
            int[] Array2 = new int[10];

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = new Random().Next(10, 100);
                Array2[i] = new Random().Next(10, 100);

                Console.Write($" {Array[i]}");
                Console.WriteLine($" {Array2[i]}");
            }
            Console.WriteLine();
            int sum1 = 0;
            int sum2 = 0;
            int mult1 = 1;
            int mult2 = 1;
            int sum = 0;
            int mult = 0;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                sum1 += Array[i];
                sum2 += Array2[i+1];
                mult1 *= Array[i];
                mult2 *= Array2[i];
                sum = sum1 + sum2;
                mult = mult1 + mult1;
            }
            Console.WriteLine("сумма" + sum);
            Console.WriteLine("Произведение" + mult);
        }
    }
}