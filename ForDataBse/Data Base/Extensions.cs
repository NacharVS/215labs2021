using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ForDataBase.Data_Base
{
    class Extensions
    {
        public static Person SaveOne()
        {
            char a;

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

                Console.WriteLine("Введите возраст");
                int age = int.Parse(Console.ReadLine());
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
                Console.WriteLine("Введите номер водительских прав.");
                Console.WriteLine("Введите 0, если их нет.");
                int id = int.Parse(Console.ReadLine());

                Person pers1 = new Person(name, surname, age, yearOfGraduation, sex, id);

                return pers1;
        }
        public static void EditDocument()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            Console.WriteLine("Введите данные человека, которого хотите поменять");
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();

            collection.ReplaceOne(x => x.name == name && x.surname == surname, SaveOne());

        }
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
                Console.WriteLine($"Name: {item.name} Age: {item.age} Sex: {item.sex}");
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
                Console.WriteLine($"Name: {item.name} Age: {item.age} Sex: {item.sex}");
            }
        }
        public static void YearOfBirth_Sort(int YearOfBirth)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.age < YearOfBirth).ToList();
            if (list.Count == 0)
            {
                Console.WriteLine("В Базе Данных отсутствуют люди, соответствующие данному параметру.");
            }
            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} Age: {item.age} Sex: {item.sex}");
            }
        }

        public static void GetSingleFromDataBase(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            Person person = collection.Find(x => x.age < age).FirstOrDefault();

            Console.WriteLine($"Name: {person.name} Age: {person.age} Sex: {person.sex}");

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
                Console.WriteLine($"Name: {item.name} \t Surname: {item.surname} \t Age: {item.age} \t Sex: {item.sex}");
            }
        }


        public static void AddToDataBase()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
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

                Console.WriteLine("Введите возраст");
                int age = int.Parse(Console.ReadLine());
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
                Console.WriteLine("Введите номер водительских прав.");
                Console.WriteLine("Введите 0, если их нет.");
                int id = int.Parse(Console.ReadLine());
                
                collection.InsertOne(new Person(name, surname, age, yearOfGraduation, sex, id));

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