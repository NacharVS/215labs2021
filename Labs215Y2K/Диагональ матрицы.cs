using System;

namespace Diagonal
{
    class Diagonal
    {
       public static void Ex2()
        {
            int[,] array = new int[10, 10];

            int summ = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 2);
                    summ += array[i, j];

                    Console.Write($" {array[i, j]}");
                }
                Console.Write($"     {summ}");
                summ = 0;
                Console.WriteLine();

            }
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += array[i, i];
                
            }
            Console.WriteLine($"Сумма главной диагонали {sum}");
        }
    }
}
