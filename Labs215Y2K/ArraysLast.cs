using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class ArraysLast
    {
        public static void Ex2() 
        {
            Random x = new Random();
            int[,] array = new int[3, 3];

            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    array[a, b] = x.Next(10, 100);
                    Console.Write($"{ array[a, b]} ");

                }
                Console.WriteLine();
            }

            int sum = 0;

            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    sum += array[a, b];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            Console.ReadKey();
            Console.WriteLine(sum);
        }
    }
}
