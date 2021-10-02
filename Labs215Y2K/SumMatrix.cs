using System;

namespace SumMatrix
{
    class SumMatrix
    {
        public static void sumMatrix()
        {
            int[,] array1 = new int[10, 10];
            int sum = 0;

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                Console.Write($" summ - {sum}");
                for (int j = 0; j < array1.GetLength(0); j++)
                {
                    array1[i, j] = new Random().Next(0, 2);
                    Console.Write($"{array1[i, j]} ");
                    sum += array1[i, j];
                }
                
                
                Console.WriteLine(); sum = 0;
            }

           


        }
    }
}
