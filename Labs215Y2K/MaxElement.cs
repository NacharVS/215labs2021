using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class MaxElement
    {
        public static void ex5()
        {
            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
               for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 100);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] > max)
                    {
                        max = array[i,j];
                    }
                }
                Console.WriteLine($"Max elements: {max}");
                max = 0;
                Console.WriteLine();
            }
        }
    }
}
