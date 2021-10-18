using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class StudentsInfo16
    {
        static string[] list = new string[10];
        static int[] age = new int[10];
        static string[] studentslistformarks = new string[10];
        static int[,] studentsmarks = new int[10, 4];
        static double[] middlemarks = new double[10];
        static string[] studentsforadresses = new string[10];
        static string[] addresses = new string[10];
        static string address = "Г.Казань,ул.Бари Галеева,д.3";
        static int[] numberstudent = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static void studentslist()
        {
            Console.WriteLine("Введите возраст студентов, оценки по предметам, адреса студентов");
            for (int i = 0; i < list.Length; i++)
            {
                list[0] = "Салават Ахметов, возраст - ";
                list[1] = "Иван Пушкарёв, возраст - ";
                list[2] = "Булат Салахов, возраст - ";
                list[3] = "Евгений Шишкин, возраст - ";
                list[4] = "Дмитрий Иванов, возраст - ";
                list[5] = "Александр Петров, возраст - ";
                list[6] = "Евгения Сергеева, возраст - ";
                list[7] = "Максим Ахметов, возраст - ";
                list[8] = "Диана Ахметова, возраст - ";
                list[9] = "Олег Петров, возраст - ";
                Console.Write($"{numberstudent[i]} {list[i]} ");
                age[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Введите оценки соответственно по 4 предметам каждого ученика: 1 оценка - Математика; 2 оценка - Русский язык; 3 оценка - Английский язык; 4 оценка - Физика");
            for (int i = 0;i <studentslistformarks.Length;i++)
            {
                int ii = 1;
                for(int j = 0; j < studentsmarks.GetLength(1); j++)
                {
                    studentslistformarks[0] = "Салават Ахметов ";
                    studentslistformarks[1] = "Иван Пушкарёв";
                    studentslistformarks[2] = "Булат Салахов";
                    studentslistformarks[3] = "Евгений Шишкин";
                    studentslistformarks[4] = "Дмитрий Иванов";
                    studentslistformarks[5] = "Александр Петров";
                    studentslistformarks[6] = "Евгения Сергеева";
                    studentslistformarks[7] = "Максим Ахметов";
                    studentslistformarks[8] = "Диана Ахметова";
                    studentslistformarks[9] = "Олег Петров";
                    Console.Write($"{numberstudent[i]} {studentslistformarks[i]} {ii} ");
                    studentsmarks[i,j] = int.Parse(Console.ReadLine());
                    ii++;
                }
                ii = 1;
            }
            Console.WriteLine();
            Console.WriteLine("Введите адреса студентов. Если адрес общежития - просто скопируйте и вставьте данный адрес - Г.Казань,ул.Бари Галеева,д.3");
            for (int i = 0; i < studentsforadresses.Length;i++)
            {
                studentsforadresses[0] = "Салават Ахметов, адрес - ";
                studentsforadresses[1] = "Иван Пушкарёв, адрес - ";
                studentsforadresses[2] = "Булат Салахов, адрес - ";
                studentsforadresses[3] = "Евгений Шишкин, адрес - ";
                studentsforadresses[4] = "Дмитрий Иванов, адрес - ";
                studentsforadresses[5] = "Александр Петров, адрес - ";
                studentsforadresses[6] = "Евгения Сергеева, адрес - ";
                studentsforadresses[7] = "Максим Ахметов, адрес - ";
                studentsforadresses[8] = "Диана Ахметова, адрес - ";
                studentsforadresses[9] = "Олег Петров, адрес - ";
                Console.Write($"{numberstudent[i]} {studentsforadresses[i]}");
                addresses[i] = Console.ReadLine();
            }
            Console.WriteLine();
            StudentsInfo16.questiontonext();
        }
        public static void questiontonext()
        {
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть список совершеннолетних студентов");
            Console.WriteLine("2 - Просмотреть средний балл студентов");
            Console.WriteLine("3 - Просмотреть список студентов, живущих в общежитии");
            Console.WriteLine("4 - Завершить просмотр списка");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine();
                    StudentsInfo16.adultlist();
                    break;
                case 2:
                    Console.WriteLine();
                    StudentsInfo16.middlemark();
                    break;
                case 3:
                    Console.WriteLine();
                    StudentsInfo16.addreses();
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Досвидания!");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Досвидания!");
                    break;
            }
        }
        public static void adultlist()
        {
            Console.WriteLine("Список студентов, кому есть 18 лет:");
            for (int i = 0; i < age.Length; i++)
            {
                if (age[i] >= 18)
                {
                    Console.Write($"{numberstudent[i]} {list[i]} {age[i]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Список студентов, кому нету 18 лет:");
            for (int i = 0; i < age.Length; i++)
            {
                if (age[i] < 18)
                {
                    Console.Write($"{numberstudent[i]} {list[i]} {age[i]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            StudentsInfo16.questiontonext();
        }
        public static void middlemark()
        {
            for (int i = 0; i < studentsmarks.GetLength(0); i++)
            {
                double average = 0;
                for (int j = 0; j < studentsmarks.GetLength(1); j++)
                {
                    average += studentsmarks[i, j];
                    middlemarks[i] = average / 4;
                }
                average = 0;
            }
            Console.WriteLine("Список студентов , чей ср.балл атестата равен или выше 4,4:");
            for (int i = 0; i < middlemarks.Length; i++)
            {
                if (middlemarks[i] >= 4.4)
                {
                    Console.Write($"{numberstudent[i]} {studentslistformarks[i]} {middlemarks[i]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Список студентов , чей ср.балл атестата ниже 4,4:");
            for (int i = 0; i < middlemarks.Length; i++)
            {
                if (middlemarks[i] <= 4.4)
                {
                    Console.Write($"{numberstudent[i]} {studentslistformarks[i]} {middlemarks[i]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            StudentsInfo16.questiontonext();
        }
        public static void addreses()
        {
            Console.WriteLine("");
            Console.WriteLine("Список студентов, проживающих в общежитии");
            for (int i = 0; i < studentsforadresses.Length; i++)
            {
                if (addresses[i] == address)
                {
                    Console.Write($"{numberstudent[i]} {studentsforadresses[i]} {addresses[i]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Список студентов, проживающих не в общежитии");
            for (int i = 0; i < studentsforadresses.Length; i++)
            {
                if (addresses[i] != address)
                {
                    Console.Write($"{numberstudent[i]} {studentsforadresses[i]} {addresses[i]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            StudentsInfo16.questiontonext();
        }
    }
}
