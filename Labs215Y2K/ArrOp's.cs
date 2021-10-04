using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class ArrOp_s
    {
        public static void ArrOp0(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 2);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("_______________________________________");
        }
        public static void ArrOp1(int[,] array, int maxValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, maxValue);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("_______________________________________");
        }
        public static void ArrOp2(int[,] array, int minValue, int maxValue)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(minValue, maxValue);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            /* FOR MAIN
            *int[,] q = new int[5, 5];
            ArrOp_s.ArrOp0(q);
            ArrOp_s.ArrOp1(q, 10);
            ArrOp_s.ArrOp2(q, 10, 100);
            */
        }
    }
}
