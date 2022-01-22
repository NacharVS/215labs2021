using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoExamples
{
    class Extensions
    {
        public static void AddToDataBase(int number, string surname, string name, string patronymic, string gender, int yearOfBirth, int age, string work, string workyes, string playGames)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SubbotAboba");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(new Person(number, surname, name, patronymic, gender, yearOfBirth, age, work, workyes, playGames));
        }
        public static void AddToDataBase(string surname, string name, string patronymic, string gender, int yearOfBirth, int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SubbotAboba");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(new Person(surname, name, patronymic, gender, yearOfBirth, age));
        }
        public static void AddToDataBase(int yearOfBirth, string workyes)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SubbotAboba");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(new Person(yearOfBirth, workyes));
        }
        public static void GetAllFromDataBase()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SubbotAboba");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => true).ToList();

            Console.WriteLine($"Id \t Фамилия \t Имя \t \t Отчество \t Год рождения \t Возраст \t Гендер \t Работа \t Хобби");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.number} \t {item.surname}  \t {item.name}   \t {item.patronymic} \t {item.yearOfBirth} \t \t {item.age} \t \t {item.gender} \t \t {item.workyes} \t {item.playGames}");
            }
        }

        public static void GetSingleFromDataBaseName(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SubbotAboba");
            var collection = database.GetCollection<Person>("Persons");
            Person person = collection.Find(x => x.name == name).FirstOrDefault();

            Console.WriteLine($"Id \t Фамилия \t Имя \t \t Отчество \t Год рождения \t Возраст \t Гендер \t Работа \t Хобби");
            Console.WriteLine($"{person.number} \t {person.surname}  \t {person.name}   \t {person.patronymic} \t {person.yearOfBirth} \t \t {person.age} \t \t {person.gender} \t \t {person.workyes} \t {person.playGames}");
        }

        public static void GetListFromDataBaseAge(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SubbotAboba");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.age < age).ToList();

            Console.WriteLine($"Id \t Фамилия \t Имя \t \t Отчество \t Год рождения \t Возраст \t Гендер \t Работа \t Хобби");
            foreach (var item in list)
            {

                Console.WriteLine($"{item.number} \t {item.surname}  \t {item.name}   \t {item.patronymic} \t {item.yearOfBirth} \t \t {item.age} \t \t {item.gender} \t \t {item.workyes} \t {item.playGames}");
            }
        }
        public static void GetListFromDataBaseWork(string workyes)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SubbotAboba");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.workyes == workyes).ToList();

            Console.WriteLine($"Id \t Фамилия \t Имя \t \t Отчество \t Год рождения \t Возраст \t Гендер \t Работа \t Хобби");
            foreach (var item in list)
            {

                Console.WriteLine($"{item.number} \t {item.surname}  \t {item.name}   \t {item.patronymic} \t {item.yearOfBirth} \t \t {item.age} \t \t {item.gender} \t \t {item.workyes} \t {item.playGames}");
            }
        }
        public static void GetListFromDataBaseGender(string gender)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SubbotAboba");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.gender == gender).ToList();

            Console.WriteLine($"Id \t Фамилия \t Имя \t \t Отчество \t Год рождения \t Возраст \t Гендер \t Работа \t Хобби");
            foreach (var item in list)
            {

                Console.WriteLine($"{item.number} \t {item.surname}  \t {item.name}   \t {item.patronymic} \t {item.yearOfBirth} \t \t {item.age} \t \t {item.gender} \t \t {item.workyes} \t {item.playGames}");
            }
        }

        public static void GetSingleFromDataBaseAge(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SubbotAboba");
            var collection = database.GetCollection<Person>("Persons");
            Person person = collection.Find(x => x.age < age).FirstOrDefault();

            Console.WriteLine($"Id \t Фамилия \t Имя \t \t Отчество \t Год рождения \t Возраст \t Гендер \t Работа \t Хобби");
            Console.WriteLine($"{person.number} \t {person.surname}  \t {person.name}   \t {person.patronymic} \t {person.yearOfBirth} \t \t {person.age} \t \t {person.gender} \t \t {person.workyes} \t {person.playGames}");
        }

        public static void EditDocument(string searchName, Person person)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SubbotAboba");
            var collection = database.GetCollection<Person>("Persons");
            collection.ReplaceOne(x => x.name == searchName, person);
        }
    }
}