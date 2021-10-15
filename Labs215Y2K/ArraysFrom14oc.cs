using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class ArraysFrom14oc
    {
        public static void arraygeneration(int[,] integersarray,int sum, int a, int[] integersarraysum, int[,] integerstring)
        {
            for (int i = 0; i < integersarray.GetLength(0); i++)
            {
                Console.Write(a);
                for (int j = 0; j < integersarray.GetLength(0); j++)
                {

                    integersarray[i, j] = new Random().Next(0, 100);
                    sum += integersarray[i, j];
                    integersarraysum[i] = sum;
                    integerstring[i, j] = integersarray[i, j];

                    Console.Write($" {integersarray[i, j]}");

                }
                Console.Write($" Сумма элементов {a} строки = {sum}");
                Console.WriteLine("");
                a += 1;
                sum = 0;
            }
            a = 0;
            Console.WriteLine();
            Console.WriteLine();
            ArraysFrom14oc.sumstring(integersarray,sum,a, integersarraysum, integerstring);
        }
        public static void sumstring(int[,] integersarray, int sum, int a, int[] integersarraysum, int[,] integerstring)
        {
            int k;
            for (int i = 0; i < integersarray.GetLength(0); i++)
            {
                for (int j = 0; j < integersarray.GetLength(0); j++)
                {
                    for (int n = j + 1; n < integersarray.GetLength(0); n++)
                    {
                        if (integersarray[i, j] > integersarray[i, n])
                        {
                            k = integersarray[i, j];
                            integersarray[i, j] = integersarray[i, n];
                            integersarray[i, n] = k;
                        }
                    }
                }
            }
            for (int i = 0; i < integersarray.GetLength(0); i++)
            {
                for (int j = 0; j < integersarray.GetLength(0); j++)
                {
                    Console.Write($" {integersarray[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public static void studentslist(string [] list, int [] age)
        {
            for (int i = 0; i < list.Length; i++)
            {
                list[0] = "Салават Ахметов, Возраст - ";
                list[1] = "Иван Пушкарёв, Возраст - ";
                list[2] = "Булат Салахов, Возраст - ";
                list[3] = "Евгений Шишкин, Возраст - ";
                list[4] = "Дмитрий Иванов, Возраст - ";
                list[5] = "Александр Петров, Возраст - ";
                list[6] = "Евгения Сергеева, Возраст - ";
                list[7] = "Максим Ахметов, Возраст - ";
                list[8] = "Диана Ахметова, Возраст - ";
                list[9] = "Олег Петров, Возраст - ";
                Console.Write($" {list[i]}");
                age[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Список студентов, кому больше или есть 18:");
            ArraysFrom14oc.adultlist(list, age);
        }
        public static void adultlist(string[] list, int[] age)
        {
            for (int i = 0; i < age.Length;i++)
            {
                if (age[i] >= 18)
                {
                    Console.Write($"{list[i]} {age[i]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Список студентов, кому нету 18 лет:");
            for (int i = 0; i< age.Length;i++)
            {
                if (age[i] < 18)
                {
                    Console.Write($"{list[i]} {age[i]}");
                    Console.WriteLine();
                }
            }
        }
    }
}
