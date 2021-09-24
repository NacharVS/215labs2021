using System;
using System.Linq;

namespace Multplus
{ 
    class MultPlus
    {
        public static void ex2()
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
            for (int i = 0; i < Array.Length ; i++)
            {
               int sum = Array[i]+Array2[i];
               int mult = Array[i] * Array2[i];
                Console.WriteLine("summ " + sum);
                Console.WriteLine("mult " + mult);
            }
        }
    }
}