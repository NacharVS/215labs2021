using System;

namespace massiv
{
    class MinMax
    {
        public static void Ex8()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(10, 50);
                Console.Write($" {array[i]}");
            }
            Console.WriteLine();
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine($" Максимальное: {max}");
            Console.WriteLine($" Минимальное: {min}");

        }
    }
}
