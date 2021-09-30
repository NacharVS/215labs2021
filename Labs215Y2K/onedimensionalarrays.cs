using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class onedimensionalarrays
    {
        public static void summul()
            //сумма и произведение двух массивов по элементно
        {
            int[] array1 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Random().Next(10, 100);
                Console.Write($" {array1[i]}");
            }

            Console.WriteLine("");

            int[] array2 = new int[10];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = new Random().Next(10, 100);
                Console.Write($" {array2[i]}");
            }

            int a = array1[0];
            int b = array2[0];
            int c = 1;
            int d = 1;

            for (int i = 0; i < array1.Length; i++)
            {
                c = array1[i] + array2[i];
                d = array1[i] * array2[i];
                Console.WriteLine("");
                Console.WriteLine($"Сумма равна {c}");
                Console.WriteLine($"Произведение равно {d}");
            }
        }
        public static void sameNumbersarrays()
            //одинаковые числа в двух массивах
        {
            int[] array1 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Random().Next(10, 50);
                Console.Write($" {array1[i]}");
            }
            Console.WriteLine("");
            int[] array2 = new int[10];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = new Random().Next(10, 50);
                Console.Write($" {array2[i]}");
            }

            Console.WriteLine("");

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        Console.WriteLine(array1[i]);
                        break;
                    }
                }
            }
        }
        public static void minmaxarray()
            //минимальное и максимальное число в массиве
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
