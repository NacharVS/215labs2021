using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class array25
    {
        public static void ex1()
        {
            int[,] array = new int[10, 10];
            int sum = 0;
            int a = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                    Console.Write($" {array[i, j]}");
                }
                Console.WriteLine("   ");
            }
            for (int i = 0; i <array.GetLength(0);i++)
            {
                for ( int j = 0; j<array.GetLength(1);j++)
                {
                    sum = sum + a + array[i, j];
                   
                }
                Console.WriteLine("");
                Console.Write($"Сумма строки = {sum}");
                sum = 0;
            }
            
            
        }
    }
}
