using System;

namespace SwapArray
{
    public class Swap
    {
        public static void ex5()
        {
            int[,] array = new int[2, 7];
            int swap = array[0, 0];
            int k = 0;
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
            
         for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" {array[i, j]}");
                    if (k != array.GetLength(1))
                    {
                        swap = array[0,j];
                        k++;
                        Console.Write($" {swap}");

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}