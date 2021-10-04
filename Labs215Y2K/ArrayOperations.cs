using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class ArrayOperations
    {
        public static void OperationOne()
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

        public static void ArrayGeneration (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next();
                Console.WriteLine($" {array[i]}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }


        public static void ArrayGeneration (int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(10, 100);
                    Console.WriteLine($" {array[i, j]}");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }



    }
}
