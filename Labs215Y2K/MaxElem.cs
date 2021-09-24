using System;
using System.Linq;

namespace MaxElement
{
    public class MaxElem
    {
        public static void ex3()
        {
            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine();
            }

                int maxValue = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j< array.GetLength(1); j++)
                {

                    if (array[i, j] > maxValue)
                    {
                        maxValue = array[i, j];
                    }
                }
                Console.Write($" максимальное значение: {maxValue}");
                maxValue = 0;
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}