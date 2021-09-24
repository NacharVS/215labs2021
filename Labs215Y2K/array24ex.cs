using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class array24ex
    {
        public static void ex1()
        {
            int[,] array = new int[10, 10];

            int summ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 3);
                    summ += array[i, j];
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine("");





            }    
        }
    }
}
