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

            //а) количество цифр в нем;
            //б) сумму его цифр;
            //в) произведение его цифр;
            //г) среднее арифметическое его цифр;
            //д) сумму квадратов его цифр;
            //е) сумму кубов его цифр;
            //ж) его первую цифру;
            //з) сумму его первой и последней цифр.
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            double b = 0;
            int number2 = number;
            int number3 = number;
            double numbersum = 0;
            while (number2 > 0)
            {
                b++;
                number2 /= 10;
            }
            Console.WriteLine($"Количество цифр в числе: {b}");
            while (number3 > 0)
            {
                numbersum += number3 % 10;
                number3 /= 10;
            }
            number3 = number;
            int numberproizv = 1;
            Console.WriteLine($"Сумма цифр числа: {numbersum}");
            while (number3 > 0)
            {
                numberproizv *= number3 % 10;
                number3 /= 10;
            }
            number3 = number;
            double sumround = 0;
            Console.WriteLine($"Произведение цифр числа: {numberproizv}");
            Console.WriteLine($"Ср. арифмитеское цифр числа: {numbersum / b}");
            while (number3 > 0)
            {
                sumround += Math.Pow(number3 % 10, 2);
                number3 /= 10;
            }
            number3 = number;
            Console.WriteLine($"Сумма квадратов цифр числа: {sumround}");
            double sumround2 = 0;
            while (number3 > 0) 
            {
                sumround2 += Math.Pow(number3 % 10, 3);
                number3 /= 10;
            }
            number3 = number;
            Console.WriteLine($"Сумма кубов цифр числа: {sumround2}");
            int firstint = 0;
            while (number3 > 0)
            {
                firstint = number3 % 10;
                number3 /= 10;
            }
            number3 = number;
            Console.WriteLine($"Первая цифра числа: {firstint}");
            int lastint;
            lastint = number3 % 10;
            Console.WriteLine($"Сумма первой и последней цифры числа: {lastint + firstint}");

        }
        public static void ex22()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length;i++)
            {
                array[i] = new Random().Next(-10, 10);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length;j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    
                }
            }
            Console.WriteLine("Отсортированный массив");
            for (int i = 0; i < array.Length; i++)
            {
                
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        public static void exe()
        {
            for (; ; )
            {
                Console.WriteLine("Чапман блэк вишня абоба");
            }
        }
        
    }
}
