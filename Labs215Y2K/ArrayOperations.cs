using System;

namespace Labs215Y2K
{
    class ArrayOperations
    {
        // 1. Найти максимальный и минимальный элемент массива
        // 2. сумма и произведение 2х массивов по элементно
        // 3. найти одинаковые элементы двух массивов
        static void OperationOne()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(10, 100);

                Console.Write($" {array[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    Console.Write($" {array[i + 1]}");
                }
            }
        }
    }
}
