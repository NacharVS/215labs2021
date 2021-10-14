using System;

namespace Labs215Y2K
{
    class ArrayOperations
    {
        // 1. Найти максимальный и минимальный элемент массива
        // 2. сумма и произведение 2х массивов по элементно
        // 3. найти одинаковые элементы двух массивов
        public static void ArrayGeneration(int [,]array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0,2);
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }

        }
        public static void ArrayGeneration(int[,] array,int maxValue)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(maxValue);
                    Console.Write($"{array[i, j]} ");
                    sum += array[i, j];

            }
            Console.Write($" summ - {sum}");
            Console.WriteLine();
            sum = 0;
            }

        }
        public static void ArrayGeneration(int[,] array, int minValue, int maxValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(minValue,maxValue);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void ArrayGeneration(int[] arraytwo)
        {
            for (int i = 0; i < arraytwo.Length; i++)
            {
                {
                    arraytwo[i] = new Random().Next(0, 2);
                    Console.Write($"{arraytwo[i]} ");
                }
            }

        }
        public static void ArrayGeneration(int[] arraytwo, int maxValue)
        {
            for (int i = 0; i < arraytwo.Length; i++)
            {
                {
                    arraytwo[i] = new Random().Next(maxValue);
                    Console.Write($"{arraytwo[i]} ");
                }
            }

        }
        public static void ArrayGeneration(int[] arraytwo, int minValue, int maxValue)
        {
            for (int i = 0; i < arraytwo.Length; i++)
            {
                {
                    arraytwo[i] = new Random().Next(minValue, maxValue);
                    Console.Write($"{arraytwo[i]} ");
                }
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
