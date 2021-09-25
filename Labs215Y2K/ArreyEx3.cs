using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class ArreyEx3
    {

        static public void Main()
        {
            {
                int[,] array1 = new int[10, 10];
                int sum = 0;

                for (int i = 0; i < array1.GetLength(0); i++)
                {
                   
                    for (int j = 0; j < array1.GetLength(0); j++)
                    {
                        array1[i, j] = new Random().Next(0, 2);
                        Console.Write($"{array1[i, j]} ");
                        sum += array1[i, j];
                    }
                    Console.WriteLine($" summ - {sum}");

                    Console.WriteLine();

                    sum = 0;
                }

               

                

            }


        }
    }
}
     
    





