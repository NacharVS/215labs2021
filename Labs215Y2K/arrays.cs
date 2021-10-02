using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class arrays
    {
        public static void first()
        {
            int[] array = new int[10];
            int sum = 1;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(10, 100);
                {
                    int[] numbers = new int[] { i };

                    for (int i1 = 0; i1 < numbers.Length; i1++)
                    {
                        int value = numbers[i1];
                        sum += value;
                    }
                }
                Console.Write($" {array[i]}");
                Console.WriteLine("Сумма элементов массива: " + sum);
            }
        }
    }
}
