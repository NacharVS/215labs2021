using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class array24ex
    {
        public static void ex3()
        {
            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine("   ");
            }
            Console.WriteLine("");
            int[,] array1 = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array1[i, j] = new Random().Next(1, 10);
                    Console.Write($" {array1[i, j]}");
                }
                Console.WriteLine("   ");

            }
            Console.WriteLine("");
            int[,] array2 = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i, j] = array[i, j] * array1[i, j];
                    Console.Write($" {array2[i, j]}");
                }
                Console.WriteLine("");
            }
        }
        public static void ex1()
        {
            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 100);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }

            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (max < array[i,j])
                    {
                        max = array[i, j];
                    }
                }
                Console.Write($" Наибольший элемент строки {max}");
                max = 0;
                Console.WriteLine();
            }
        }
    }
}
    

