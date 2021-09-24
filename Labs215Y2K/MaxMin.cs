using System;
using System.Linq;

namespace MaxMin
{
    class Maxmin
    {
        public static void ex1()
        {
            int[] Array = new int[10];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = new Random().Next(10, 100);
                Console.WriteLine($" {Array[i]}");
            }
            int maxValue = Array[0];
            int minValue = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > maxValue)
                {
                    maxValue = Array[i];
                }
                if (Array[i] < minValue)
                {
                    minValue = Array[i];
                }
            }

            Console.WriteLine($" Максимальное: {maxValue}");
            Console.WriteLine($" Минимальное: {minValue}");
            Console.WriteLine();
        }
    }
}