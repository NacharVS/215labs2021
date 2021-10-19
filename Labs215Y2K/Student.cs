using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    //public class Student
    //{
    //    public int id;
    //    public string Name;
    //    public string Suname;
    //    public double Age;
    //    public double Marks;
    //    public bool ObLIIaga;
    //}
    //public static void Main()

    //{   // Массив хронящий новый тип данных
    //    Student[] students = new Student[10];

    //    // Массив хранящий имена и фамилии 10 учащихся
    //    string[,] studentsName = new string[10, 2]
    //    {
    //        { "Иван","Иванов",},
    //        { "Саша","Алексндров",},
    //        { "Петр","Петров",},
    //        { "Алексей","Алексеекич",},
    //        { "Ярослав","Ярославович",},
    //        { "Дима","Димович",},
    //        { "Маша","Иванова",},
    //        { "Даша","Александровна",},
    //        { "Ваня","Петров",},
    //        { "Леша","Алексеевич",},
    //    };

    //    // Массив хранящий оценки
    //    double[,] mark_And_age = new double[10, 4];

    //    // Массив хранящий болл общага
    //    bool[] obLIIaga = new bool[10];

    //    for (int i = 0; i < mark_And_age.GetLength(0); i++)
    //    {
    //        students[i] = new Student();

    //        students[i].id = i;
    //        mark_And_age[i, 0] = new Random().Next(16, 22);// Генерация возроста
    //        mark_And_age[i, 1] = new Random().Next(2, 5);// Генерация Оценки по Англ 
    //        mark_And_age[i, 2] = new Random().Next(2, 5);// Генерация Оценки по Матем
    //        mark_And_age[i, 4] = new Random().Next(2, 5);// Генерация Оценки по Рускому


    //        double MidMarks = mark_And_age[i, 1] + mark_And_age[i, 2] + mark_And_age[i, 3] / (mark_And_age.GetLength(1) - 1); // Расчет сред,балла

    //        students[i].id = i;//Запись Id в массив Student 

    //        students[i].Name = studentsName[i, 0]; //Запись имени в массив Student 

    //        students[i].Suname = studentsName[i, 1]; //Запись фамиилии в массив Student

    //        students[i].Age = mark_And_age[i, 0];// Запись возроста в массив Student

    //        students[i].Marks = MidMarks;// Запись ср.балла

    //        Console.Write($" {i + 1}  {studentsName[i, 0]} {studentsName[i, 1]}  {students[i].Age}");

    //        Console.WriteLine();
    //    }
    //    Console.WriteLine();
    //    for (int i = 0; i < students.GetLength(0); i++)
    //    {
    //        if (students[i].Age >= 18)
    //        {
    //            Console.Write($" {i + 1}  {studentsName[i, 0]} {studentsName[i, 1]}  {students[i].Age}");
    //        }
    //        Console.WriteLine();
    //    }
    //}
  
}
