using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class ArrayOperations
    {
        public static void ArrayGeneration(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 2);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void ArrayGeneration(int[,] array, int MaxValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(MaxValue);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void ArrayGeneration(int[,] array, int MinValue, int MaxValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(MinValue, MaxValue);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
