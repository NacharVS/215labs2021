using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class SumMassive
    {
        public static void Massive() 
        {
            int[,] array1 = new int[10, 10];
            int sum = 0;

            for (int a = 0; a < array1.GetLength(0); a++)
            {
                for (int b = 0; b < array1.GetLength(0); b++)
                {
                    array1[a, b] = new Random().Next(0, 2);
                    Console.Write($"{array1[a, b]} ");
                }
                Console.WriteLine();
            }

            for (int a = 0; a < array1.GetLength(0); a++)

            {
                for (int b = 0; b < array1.GetLength(0); b++)
                {
                    sum += array1[a, b];

                }
                Console.Write($" Сумма - {sum}");
                Console.WriteLine();
                sum = 0;
            }

    }
}
