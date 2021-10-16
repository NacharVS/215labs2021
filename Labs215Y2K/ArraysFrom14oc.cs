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

        public static void studentslist(string [] args)
        {
            string[] list = new string[10];
            int[] age = new int[10];
            Console.WriteLine("Введите произвольный возраст студентов");
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
            ArraysFrom14oc.questiontonext(list, age);
        }
        public static void questiontonext(string[] list, int[] age)
        {
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть список совершеннолетних студентов");
            Console.WriteLine("2 - Просмотреть средний балл студентов");
            Console.WriteLine("3 - Просмотреть список студентов, живущих в общежитии");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    ArraysFrom14oc.adultlist(list, age);
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
            

        }
        public static void adultlist(string[] list, int[] age)
        {
            Console.WriteLine();
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
        public static void averagemarks(string[] studentlistmarks)
        {
            Console.WriteLine();
            Console.WriteLine(" Введите оценки соответственно по 4 предметам каждого ученика: 1 - Математика; 2 - Русский язык; 3 - Английский язык; 4 - Физика");
            ArraysFrom14oc.studentlistmarks(studentlistmarks);
        }
        public static void studentlistmarks(string[] args)
        {
            Console.WriteLine();
            string[] studentlistmarks = new string[10];
            int[,] subjectsmarks = new int[10, 5];
            int[] averagemarklist = new int[10];
            for (int i = 0; i < studentlistmarks.Length; i++)
            {
                for(int j = 0; j < subjectsmarks.GetLength(1);j++)
                {
                    studentlistmarks[0] = "Салават Ахметов ";
                    studentlistmarks[1] = "Иван Пушкарёв ";
                    studentlistmarks[2] = "Булат Салахов ";
                    studentlistmarks[3] = "Евгений Шишкин ";
                    studentlistmarks[4] = "Дмитрий Иванов ";
                    studentlistmarks[5] = "Александр Петров ";
                    studentlistmarks[6] = "Евгения Сергеева ";
                    studentlistmarks[7] = "Максим Ахметов ";
                    studentlistmarks[8] = "Диана Ахметова";
                    studentlistmarks[9] = "Олег Петров";
                    Console.Write($" {studentlistmarks[i]}");
                    subjectsmarks[i, j] = int.Parse(Console.ReadLine());
                }   
            }
            for (int i = 0; i < subjectsmarks.GetLength(0);i++)
            {
                int average = 0;
                for (int j = 0; j < subjectsmarks.GetLength(1);j++)
                {
                    average = 0;
                    average += subjectsmarks[i, j];
                    averagemarklist[i] = average/4;
                }
                average = 0;
            }
        }
        
    }
}
