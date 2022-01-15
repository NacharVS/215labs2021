using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace ForDataBase.Data_Base
{
    class Extensions
    {
        public static void SexSort(string sex)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.sex == sex ).ToList();
            if (list.Count == 0)
            {
                Console.WriteLine("В Базе Данных отсутствуют люди, соответствующие данному параметру.");
            }
            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} Year Of Birth: {item.yearOfBirth} Sex: {item.sex}");
            }
        }
        public static void NameSort(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.name == name).ToList();
            if (list.Count == 0)
            {
                Console.WriteLine("В Базе Данных отсутствуют люди, соответствующие данному параметру.");
            }
            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} Year Of Birth: {item.yearOfBirth} Sex: {item.sex}");
            }
        }
        public static void YearOfBirth_Sort(int YearOfBirth)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.yearOfBirth < YearOfBirth).ToList();
            if (list.Count == 0)
            {
                Console.WriteLine("В Базе Данных отсутствуют люди, соответствующие данному параметру.");
            }
            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} Year Of Birth: {item.yearOfBirth} Sex: {item.sex}");
            }
        }

        public static void GetSingleFromDataBase(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            Person person = collection.Find(x => x.yearOfBirth < age).FirstOrDefault();

            Console.WriteLine($"Name: {person.name} Year Of Birth: {person.yearOfBirth} Sex: {person.sex}");

        }

        public static void GetAllFromDataBase()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => true).ToList();
                        if (list.Count == 0)
            {
                Console.WriteLine("В Базе Данных отсутствуют люди, соответствующие данному параметру.");
            }
            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} \t Surname: {item.surname} \t Year Of Birth: {item.yearOfBirth} \t Sex: {item.sex}");
            }
        }


        public static void AddToDataBase()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("2");
            var collection = database.GetCollection<Person>("Persons");

            char a;
            
            while (true)
            {
                
                Console.WriteLine("Введите имя");
                
                    string name = Console.ReadLine();
                    name = name.ToUpper();
                    a = name[0];
                    name = name.Remove(0, 1);
                    name = a + name.ToLower();
                

                Console.WriteLine("Введите фамилию");
                string surname = Console.ReadLine();
                surname = surname.ToUpper();
                a = surname[0];
                surname = surname.Remove(0, 1);
                surname = a + surname.ToLower();

                Console.WriteLine("Введите год рождения");
                int yearOfBirth = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Введите год выпуска со школы");
                int yearOfGraduation = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите пол: 'М' или 'Ж'");
                string sex = Console.ReadLine();
                if (sex != "М" && sex != "Ж")
                {
                    sex = null;
                    Console.WriteLine("Вы ввели некорректные данные");
                }
                


                
                collection.InsertOne(new Person(name, surname, yearOfBirth, yearOfGraduation, sex));
                Console.WriteLine("Вы хотите продолжить заполнение БД? Введите 'Да' или 'Нет'.");
                string choice = Console.ReadLine();
                if (choice == "Нет" || choice == "нет")
                {
                    Console.WriteLine("Ввод данных завершён. Проверьте Базу Данных на правильность.");
                    break;
                }

        }
    }
    }
}