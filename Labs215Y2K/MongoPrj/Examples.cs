using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace Labs215Y2K.MongoPrj
{
    class Examples
    {
        public static void AddToDataBase(string name, string surname, string otchestvo, int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students");
            collection.InsertOne(new Student(name, surname, otchestvo, age));
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
                Examples.AddToDataBase(name, surname, otchestvo, age);
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
