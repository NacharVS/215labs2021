using System;
using System.Linq;

namespace МинимумМаксимум
{
    class Maxmin
    {
        static void maxmin(string[] args)
        {
            int[] Array = new int[10];

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = new Random().Next(10, 100);

                Console.Write($" {Array[i]}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($" Максимальное: {Array.Max()}");
            Console.WriteLine($" Минимальное: {Array.Min()}");
        }
    }
}