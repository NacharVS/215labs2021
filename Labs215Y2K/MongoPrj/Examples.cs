using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace Labs215Y2K.MongoPrj
{
    class Examples
    {
        public static void AddToDataBase(string name, string surname, string otchestvo, int age, string gender, int year)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students");
            collection.InsertOne(new Student(name, surname, otchestvo, age, gender, year));
           
        }
        public static void Start()
        {
            Console.WriteLine("Добро пожаловать!Добавьте студентов в базу данных");
            int i = 1;
            while (i != 0) 
            {
                Console.Write("Введите имя студента: ");
                string name = Console.ReadLine();
                Console.Write("Введите фамилию студента: ");
                string surname = Console.ReadLine();
                Console.Write("Введите отчество студента: ");
                string otchestvo = Console.ReadLine();
                Console.Write("Введите возраст студента: ");
                int age = int.Parse(Console.ReadLine());
                if (age < 16 || age > 25)
                {
                    while ( age < 16 || age > 25)
                    {
                        Console.Write("Это не возраст студента!Введите возраст по новому: ");
                        age = int.Parse(Console.ReadLine());
                        if (age < 16 || age > 25)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (age >= 16 || age <= 25)
                {

                }
                Console.Write("Введите пол студента: 1 - М; 2 - Ж:  " ) ;
                int question = int.Parse(Console.ReadLine());
                string gender = "";
                while (question != 1 || question != 2)
                {
                    Console.Write("Неверный пол!Введите цифру студента заново: ");
                    question = int.Parse(Console.ReadLine());
                    if (question == 1 )
                    {
                        gender = "М";
                        break;
                    }
                    else if (question == 2)
                    {
                        gender = "Ж";
                        break;
                    }
                    else if (question != 1 || question != 2)
                    {
                        continue;
                    }
                }
                Console.WriteLine("Введите год поступления студента: ");
                int year = int.Parse(Console.ReadLine());
                while (year < 2018 || year > 2022)
                {
                    Console.Write("Неверный год!Введите год поступления студента заново: ");
                    year = int.Parse(Console.ReadLine());
                    if (year <= 2018 || year >= 2022)
                    {
                        continue;
                    }
                    else if (year < 2018 || year > 2022)
                    {
                        break;
                    }
                }
                Examples.AddToDataBase(name, surname, otchestvo, age, gender, year);
                Console.WriteLine("Хотите продолжить? 1 - Да, 2 - Нет");
                int answer = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (answer)
                {
                    case 1:
                        continue;
                    case 2:
                        i = 0;
                        break;
                    default:
                        Console.WriteLine("Неверная цифра!");
                        break;
                    
                }
            }
        }
        
    }
}
