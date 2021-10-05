using System;

namespace Labs215Y2K
{
    class ArrayOperations
    {

        public static void TwoDimensionalArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void TwoDimensionalArray(int[,] array, int min = int.MinValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
            public static void TwoDimensionalArray(int[,] array, int min = int.MinValue , int max = int.MaxValue)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(10, 100);
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
                    static void TwoDimensionalArrayUse()
            {
                int[,] array = new int[10, 10];

                int summ = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(0, 2);
                        summ += array[i, j];
                        Console.Write($" {array[i, j]}");
                    }
                    Console.Write($"     {summ}");
                    summ = 0;
                    Console.WriteLine();
                }
            }
            static void OperationOne()
            {
                int[] array = new int[10];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(10, 100);

                    Console.Write($" {array[i]}");
                }

                Console.WriteLine();

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        Console.Write($" {array[i + 1]}");
                    }
                }
            }
        }
    }


