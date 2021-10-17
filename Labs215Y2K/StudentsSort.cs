using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class StudentsSort
    {
        class Sort
        {
            public string NameSurName;
            public int Age;
            public int id;
        }
        public static void StudentSort()
        {

            Sort[] StudentSort = new Sort[10];
            string[] Name = new string[] { "Гажос Ярослав", "Суббот Егор", "Ташевцев Данил", "Ахметов Салават", "Салахов Булат", "Устинова Милена", "Сенюшин Артём", "Устинин Никита", "Пичкасов Дмитрий", "Маврова Анастасия" };
            for (int i = 0; i < Name.Length; i++)
            {
                StudentSort[i] = new Sort();
                StudentSort[i].id = i;
                StudentSort[i].NameSurName = Name[i];
                StudentSort[i].Age = new Random().Next(12, 23);
                Console.Write(" " + StudentSort[i].id);
                Console.Write(" " + StudentSort[i].NameSurName);
                Console.Write(" " + StudentSort[i].Age);
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < StudentSort.Length; i++)
            {
                if (StudentSort[i].Age >= 18)
                {
                    Console.Write(" " + StudentSort[i].id);
                    Console.Write(" " + StudentSort[i].NameSurName);
                    Console.Write(" " + StudentSort[i].Age);
                    Console.WriteLine();
                }
            }
        }
    } 
    class MarkStudentsSort
    {
            class Sort
            {
                public string NameSurName;
                public int Age;
                public int id;
                public double sum;
            }
            class SortMarks
            {
            public int Marks;
            }
            public static void MarksSort()
            {
                Sort[] StudentSort = new Sort[10];
                SortMarks[,] MarkSort = new SortMarks[10, 3];
                string[] Name = new string[] { "Гажос Ярослав", "Суббот Егор", "Ташевцев Данил", "Ахметов Салават", "Салахов Булат", "Устинова Милена", "Сенюшин Артём", "Устинин Никита", "Пичкасов Дмитрий", "Маврова Анастасия" };
            for (int i = 0; i < MarkSort.GetLength(0); i++)
            {
                StudentSort[i] = new Sort();
                StudentSort[i].id = i;
                StudentSort[i].NameSurName = Name[i];
                StudentSort[i].Age = new Random().Next(12, 23);
                Console.Write($"{StudentSort[i].id}");
                Console.Write($"  {StudentSort[i].NameSurName}");
                Console.Write($"  \t{StudentSort[i].Age}");
                for (int j = 0; j < MarkSort.GetLength(1); j++)
                {
                    MarkSort[i, j] = new SortMarks();
                    MarkSort[i, j].Marks = new Random().Next(2, 6);
                    StudentSort[i].sum += MarkSort[i, j].Marks;
                    Console.Write($" \t{MarkSort[i,j].Marks}");
                }
                StudentSort[i].sum = StudentSort[i].sum / 3;
                Console.Write($" \t{StudentSort[i].sum}");
                Console.WriteLine();
            }
            Console.WriteLine();
                for (int i = 0; i < StudentSort.Length; i++)
                {
                    if (StudentSort[i].Age >= 18)
                    {
                        Console.Write(" " + StudentSort[i].id);
                        Console.Write(" " + StudentSort[i].NameSurName);
                        Console.Write(" " + StudentSort[i].Age);
                        Console.WriteLine();
                    }
                }
            }
    }
    class StudentsList
    {
        class Sort
        {
            public string NameSurName;
            public int Age;
            public int id;
            public double sum;
            public int hostel;
        }
        class SortMarks
        {
            public int Marks;
        }
        public static void MarksSort()
        {
            Sort[] StudentSort = new Sort[10];
            SortMarks[,] MarkSort = new SortMarks[10, 3];
            string[] Name = new string[] { "Гажос Ярослав", "Суббот Егор", "Ташевцев Данил", "Ахметов Салават", "Салахов Булат", "Устинова Милена", "Сенюшин Артём", "Устинин Никита", "Пичкасов Дмитрий", "Маврова Анастасия" };
            for (int i = 0; i < MarkSort.GetLength(0); i++)
            {
                StudentSort[i] = new Sort();
                StudentSort[i].id = i;
                StudentSort[i].NameSurName = Name[i];
                StudentSort[i].Age = new Random().Next(12, 23);
                StudentSort[i].hostel = new Random().Next(1, 2);
                Console.Write($"{StudentSort[i].id}");
                Console.Write($"  {StudentSort[i].NameSurName}");
                Console.Write($"  \t{StudentSort[i].Age}");
                if(StudentSort[i].hostel == 1)
                {
                    Console.Write($"  \tЖивёт в общежитие");
                }
                else 
                {
                    Console.Write($"  \tНе живёт в общежитие");
                }
                for (int j = 0; j < MarkSort.GetLength(1); j++)
                {
                    MarkSort[i, j] = new SortMarks();
                    MarkSort[i, j].Marks = new Random().Next(2, 6);
                    StudentSort[i].sum += MarkSort[i, j].Marks;
                    Console.Write($" \t{MarkSort[i, j].Marks}");
                }
                StudentSort[i].sum = StudentSort[i].sum / 3;
                Console.Write($" \t{StudentSort[i].sum}");
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < StudentSort.Length; i++)
            {
                if (StudentSort[i].Age >= 18)
                {
                    Console.Write(" " + StudentSort[i].id);
                    Console.Write(" " + StudentSort[i].NameSurName);
                    Console.Write(" " + StudentSort[i].Age);
                    Console.WriteLine();
                }
            }
        }
    }
}

