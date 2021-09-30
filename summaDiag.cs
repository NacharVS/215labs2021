using System;

namespace SummDiag
{
 class array25
{
    public static void ex1()
    {
        int[,] array = new int[10, 10];
        int sum = 0;
        int a = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int f = 0; f < array.GetLength(1); f++)
            {
                array[i, f] = new Random().Next(1, 10);
                Console.Write($" {array[i, f]}");
            }
            Console.WriteLine("   ");
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int f = 0; f < array.GetLength(1); f++)
            {
                sum = sum + a + array[i, f];

            }
            Console.WriteLine("");
            Console.Write($"Сумма строки = {sum}");
            sum = 0;
        }


    }
}
}
