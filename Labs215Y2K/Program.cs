using System;

namespace ALL_Homework
{
    class Program
    {
        public static void Main()
        {
            int[,] qq = new int[10, 10];
            int[,] qqnya = new int[1, qq.GetLength(0)];

            for (int i = 0; i < qq.GetLength(0); i++)
            {
                for (int j = 0; j < qq.GetLength(1); j++)
                {
                    qq[i, j] = new Random().Next(10, 100);
                    Console.Write(" " + qq[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < qqnya.GetLength(1); i++)
            {
                qqnya[0, i] = qq[i, 5];
                Console.Write(" " +qqnya[0,i]);
            }
            
        }

    }
}


