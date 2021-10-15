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
            string[] Name = new string[] {"Гажос Ярослав", "Суббот Егор", "Ташевцев Данил", "Ахметов Салават", "Салахов Булат", "Устинова Милена", "Сенюшин Артём", "Устинин Никита", "Пичкасов Дмитрий", "Маврова Анастасия"};
            for (int i = 0; i < Name.Length; i++)
            {
                StudentSort [i] = new Sort();
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
}
