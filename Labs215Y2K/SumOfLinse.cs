using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class SumOfLinse
    {
        public static void ex4()
        {
            int[,] Array = new int[10, 10];          
            int sum_str = 0;           
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Array[i, j] = new Random().Next(0, 2);
                    sum_str += Array[i, j];
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine("Сумма строки  " + sum_str);
                sum_str = 0;
            }
            Console.ReadLine();
        }
    }
}
