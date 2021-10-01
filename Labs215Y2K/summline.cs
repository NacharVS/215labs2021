using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class summline
    {
        public static void Summline()
        //сумма строки
        {
            Random z = new Random();
            int[,] array = new int[3, 3];

            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = z.Next(10, 100);
                    Console.Write($"{ array[y, x]} ");

                }
                Console.WriteLine();
            }

            int sum = 0;

            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    sum += array[y, x];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            Console.ReadKey();
            Console.WriteLine(sum);

        }
        public static void MaxMin()
        {
            int[] array = new int[10];
            Random z = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = z.Next(100);
                Console.WriteLine(array[i]);
            }

            int max = array[0];
            int min = array[0];


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }


            Console.WriteLine("min" + min);
            Console.WriteLine("max" + max);
            Console.ReadKey();
        }
    }
}
