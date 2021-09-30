using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class _2Darray
    {
        public static void Ex8() 
        {
            int[,] array = new int[5, 4];
            int sum = 0;



            Random z = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = z.Next(100);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();

            }


            for (int i = 0; i < array.GetLength(0); i++)
            {


                for (int j = 0; j < array.GetLength(1); j++)
                {


                    sum += array[i, j];

                }

                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
