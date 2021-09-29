using System;

namespace TwoIdentElementDeletor
{
    class Deletor
    {
        public static void ex7()
        {
            int[] Array = new int[10];
            int[] Array1 = new int[10];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = new Random().Next(10, 100);
                Console.Write($" {Array[i]}");
            }
            Console.WriteLine();
            for (int j = 0; j < Array1.Length; j++)
            {
                Array1[j] = new Random().Next(10, 100);
                Console.Write($" {Array1[j]}");
            }
            Console.WriteLine();

            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array1.Length; j++)
                {
                    if (Array[i] == Array1[j])
                    {
                        Console.Write($"Found a identical elem:{Array[i]}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}