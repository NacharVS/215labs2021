using System;

namespace maxmin
{
    class Program
    {
        static void maxmin( )
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(10, 100);
                Console.Write($" {array[i]}");
            }
            int minvalue = array[0];
            int maxvalue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minvalue)
                {
                    minvalue = array[i];
                }
                if (array[i] > maxvalue)
                {
                    maxvalue = array[i];
                }
            }
            Console.WriteLine("");
            Console.WriteLine($" Миниммальное значение массива {minvalue}");
            Console.WriteLine($" Максимальное значение массива {maxvalue}");
        }
    }
}
