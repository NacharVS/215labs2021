using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
   class SumMassiv
        {
            public static void ex2()
            {
                int[] array = new int[10];
                int[] array2 = new int[10];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(10, 100);
                    array2[i] = new Random().Next(10, 100);
                    Console.Write($" {array[i]}");
                    Console.WriteLine($" {array2[i]}");
                }
                Console.WriteLine();
                for (int i = 0; i < array.Length; i++)
                {
                    int sum = array[i] + array2[i];
                    int multip = array[i] * array2[i];
                    Console.Write("Сумма массивов" + sum);
                    Console.WriteLine();
                    Console.WriteLine("Произвидение массивов" + multip);
                }
}
