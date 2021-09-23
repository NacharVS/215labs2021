using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class ArrayEx
    {
        public static void Ex3()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
                Console.Write($" {array[i]}");
            }
            Console.WriteLine("");
            int[] b = new int[10];
            for (int j = 0; j < b.Length; j++)
            {
                b[j] = new Random().Next(0, 100);
                Console.Write($" {b[j]}");
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                    if (array[i] == b[j])
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Общее число: {array[i]}");
                        break;
                    }

            }

        }
        public static void Ex5()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
                Console.Write($" {array[i]}");
            }
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }


            }
            Console.WriteLine("");
            Console.WriteLine($"Минимальное значение: {min}");
            Console.WriteLine("");
            Console.WriteLine($"Максимальное значение: {max} ");

        }
    }
}
