using System;

namespace MatrixMult
{
    public class Matrix
    {
        public static void ex6()
        {
            int[,] array = new int[3, 2];
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            int[,] arraytwo = new int[2, 3];
            int counttwo = 0;
            for (int i = 0; i < arraytwo.GetLength(0); i++)
            {

                for (int j = 0; j < arraytwo.GetLength(1); j++)
                {
                    arraytwo[i, j] = new Random().Next(0, 10);
                    Console.Write($" {arraytwo[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int[,] sumarray = new int[3, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < arraytwo.GetLength(1); j++)
                {
                    sumarray[i, j] = 0;
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        sumarray[i, j] += array[i, k] * arraytwo[k, j];
                    }
                }
            }

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write(sumarray[i, j] + " ");
                }

                Console.WriteLine();
            }
        
        }
    }
}