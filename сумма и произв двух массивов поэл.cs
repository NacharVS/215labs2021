using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Random().Next(10, 100);
                Console.Write($" {array1[i]}");
            }
            Console.WriteLine("");
            int[] array2 = new int[10];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = new Random().Next(10, 100);
                Console.Write($" {array2[i]}");
            }
            int a = array1[0];
            int b = array2[0];
            int c = 1;
            int d = 1;
            for (int i = 0; i < array1.Length;i++)
            {
                c = array1[i] + array2[i];
                d = array1[i] * array2[i];
                Console.WriteLine("");
                Console.WriteLine($"Сумма равна {c}");
                Console.WriteLine($"Произведение равно {d}");
            }

        }
    }
}
