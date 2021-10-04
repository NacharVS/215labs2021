using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class newdz
    {
        public static void n1()
        {
            int[,] array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    array[0, j] = array[j, 0];
                    array[i, 0] = new Random().Next(1, 10);
                }
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
