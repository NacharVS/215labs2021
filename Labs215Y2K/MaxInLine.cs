using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class MaxInLine
    {
        static void main3(string[] args)
        {
            int[,] array = new int[5, 5];

            Random z = new Random();
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = z.Next(100);
                    Console.Write(array[y, x] + "\t");
                }
                Console.WriteLine();

            }

            int max = array[0, 0];

            for (int y = 0; y < array.GetLength(0); y++)
            {

                for (int x = 0; x < array.GetLength(1); x++)
                {
                    if (array[y, x] > max)
                    {
                        max = array[y, x];

                    }

                }

                Console.WriteLine();

                Console.WriteLine("для строки №" + y + " " + max);

                max = 0;
            }
        }
    }
}
