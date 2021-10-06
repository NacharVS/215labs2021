using System;

namespace Labs215Y2K
{
    class Program
    {
        public static void TwoDemitionalsArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next();
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine(" ");
            }
        }
        public static void TwoDemitionalsArray(int[,] array, int b = int.MinValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(b);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine(" ");
            }
        }
        public static void TwoDemitionalsArray(int[,] array, int b = int.MaxValue, int c = int.MinValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(b, c);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine(" ");
            }
        }

    }
}
