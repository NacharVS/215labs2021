using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class ArrayOperations
    {
        public static void ArrayGeneration(int[,] array, int maxValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(maxValue);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

        }

        public static void ArrayGeneration(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 2);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine(" ");
            }
        }
        public static void ArrayGeneration(int[,] array, int minvalue, int maxvalue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(minvalue, maxvalue);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine(" ");
            }
        }

        public static void ArrayGeneration(int[] array2)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = new Random().Next(0, 2);
                Console.Write($"{array2[i]} ");
            }
        }
        public static void ArrayGeneration(int[] array2, int maxValue)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                {
                    array2[i] = new Random().Next(maxValue);
                    Console.Write($"{array2[i]} ");
                }
            }

        }
        public static void ArrayGeneration(int[] array2, int minValue, int maxValue)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                {
                    array2[i] = new Random().Next(minValue, maxValue);
                    Console.Write($"{array2[i]} ");
                }
            }

        }


    }
}
