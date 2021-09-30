using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Diagonale
    {
        public static void Ex2() 
        {
            int[,] array = new int[3, 3];
            int sum = 0;


            Random z = new Random();
            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    array[a, b] = z.Next(100);
                    Console.Write(array[a, b] + "\t");
                }
                Console.WriteLine();

            }


            for (int a = 0; a < array.GetLength(0); a++)
            {

                sum += array[a, a];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

    }
}
