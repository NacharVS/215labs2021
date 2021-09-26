using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Diagonal
    {
        static void main002(string[] args)
        {
            int[,] array = new int[5, 5];
            int sum = 0;
            int s = -1;
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = new Random().Next(10, 100);
                    Console.Write(array[y, x] + "\t");
                }
                Console.WriteLine();

            }


            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                { }
                s++;
                sum += array[y, s];
            }
            Console.WriteLine(sum);
        }
    }
}
