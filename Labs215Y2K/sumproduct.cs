using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class sumproduct
    {
        static void arr2()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int sum;
            int pr;
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Random().Next(10, 100);
                array2[i] = new Random().Next(10, 100);
                Console.Write(array1 + " ");
                Console.WriteLine();
                Console.WriteLine(array2 + " ");
            }
            for (int i = 0; i < array1.Length; i++)
            {
                sum = array1[i] + array2[i];
                pr = array1[i] * array2[i];
                Console.Write($"Сумма {sum} ");
                Console.WriteLine($"Произведение {pr}");
            }
        }
    }
}
