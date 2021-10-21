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
        //October 19 exercise
        public static void Reverse()
        {
            Console.WriteLine("Введите число");
            long number = long.Parse(Console.ReadLine());
            long number1 = number;
            int n = 0;
            long sum = 0;
            while (number1 != 0)
            {
                number1 = number1 / 10;
                n++;
            }
            long[] array = new long[n];
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = number % 10;
                number = number / 10;
                sum += number;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                
            }
            Console.WriteLine(sum);
        }
    }
}
