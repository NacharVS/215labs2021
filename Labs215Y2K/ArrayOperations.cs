using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class ArrayOperations
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
                    array[i, j] = new Random().Next(b,c);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine(" ");
            }
        }
        public static void TwoDemitionalsArray(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                    array[i] = new Random().Next();
                Console.Write($" {array[i]}");
            }
        }
        public static void TwoDemitionalsArray(int[] array, int b = int.MinValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                    array[i] = new Random().Next(b);
                    Console.Write($" {array[i]}");
            }
        }
        public static void TwoDemitionalsArray(int[] array, int b = int.MaxValue, int c = int.MinValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                    array[i] = new Random().Next(b, c);
                    Console.Write($" {array[i]}");
            }
        }
        public static void arrayex()
        {
            //Заполнить двумерный массив по следующему правилу, массив произвольной размерности, массив передается через параметр:
            //1 2 3 4 5
            //2 1 2 3 4
            //3 2 1 2 3
            //4 3 2 1 2
            //5 4 3 2 1
            int[,] array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, 0] = new Random().Next(1, 10);
            }
            for (int j = 1; j < array.GetLength(1); j++)
            {
                array[0, j] = array[j, 0];
            }
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    array[i, j] = array[i - 1, j - 1];
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
