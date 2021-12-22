using System;
using System.Collections.Generic;
using System.Text;

namespace Characters.Новая_папка
{
    class Class1
    {
        public static void ex1()
        {
            //найти сумму отрицательных переменных в одномер массиве
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int sum = 0;
            Console.WriteLine();
            for (int i = 0; i < array.Length;i++)
            {
                array[i] = new Random().Next(-10, 10);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length;i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Сумма отрицательных элементов равна = {sum}");
        }
        public static void ex2()
        {
            //В одномерном массиве, состоящем из N вещественных элементов вычислить произведение элементов массива, расположенных между максимальным и минимальным элементом.
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int sum = 0;
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 100);
                Console.Write($"{array[i]} ");
            }
            int minint = array[0];
            int minid = 0;
            int maxid = 0;
            int maxint = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (minint > array[i])
                {
                    minint = array[i];
                    minid = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (maxint < array[i])
                {

                    maxint = array[i];
                    maxid = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Мин число {minint} номер {minid} Макс число {maxint} Номер {maxid}");
            if (maxid == minint + 1)
            {
                Console.WriteLine("Нельзя вычислить!");
            }
            else if (minid == maxid +1)
            {
                Console.WriteLine("Нельзя вычислить!");
            }
            else if (minid < maxid)
            {
                int sum1 = 1;
                for (int i = minid + 1; i < maxid; i++)
                {
                    sum1 *= array[i];
                }
                Console.WriteLine();
                Console.WriteLine($"Сумма {sum1}");
            }
            else if (minid > maxid)
            {
                int sum2 = 1;
                for (int i = maxid +1 ; i<minid; i++)
                {
                    sum2 *= array[i];
                }
                Console.WriteLine();
                Console.WriteLine($"Сумма {sum2}");
            }
        }
        public static void ex3()
        {
            //В одномерном массиве, состоящем из N целочисленных элементов вычислить произведение элементов с четными номерами.
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int sum = 1;
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 100);
                Console.Write($"{array[i]} ");
            }
            for (int i = 2; i < array.Length; i += 2)
            {
                sum *= array[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Произведение элементов с четными номерами {sum}");
        }
        public static void ex4()
        {
            //В одномерном массиве, состоящем из N целочисленных элементов вычислить минимальный элемент массива.
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 100);
                Console.Write($"{array[i]} ");
            }
            int sum = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (sum > array[i])
                {
                    sum = array[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
        public static void ex5()
        {
            //В одномерном массиве, состоящем из N целочисленных элементов вычислить индекс максимального элемента массива.
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 100);
                Console.Write($"{array[i]} ");
            }
            int sum = array[0];
            int index = 0;
            for (int i = 0; i < array.Length;i++)
            {
                if (sum < array[i])
                {
                    sum = array[i];
                    index = i;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Максимальный элемент {sum} индекс {index}");
        }
        
        //двухмерные массивы
        public static void ex11()
        {

        }
    }
}
