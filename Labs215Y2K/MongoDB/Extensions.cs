using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoDB
{
    class Extensions
    {
        public static void AddToDataBase()
        {
            string driverCard = null;
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите пол");
            string gender = Console.ReadLine();
            Console.WriteLine("Есть водительские права? (1-да, 2-нет)");
            int b = int.Parse(Console.ReadLine());
            if (b == 1)
            {
                driverCard = "Есть";
            }
            else
            {
                driverCard = "Нет";
            }
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(new Person(name, surname, lastName, age, gender, driverCard));
        }
        public static void GetAllFromDataBase()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item._name} Age: {item._age}");
            }
        }
        public static void GetListFromDataBase(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x._age < age).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item._name} Age: {item._age}");
            }
        }
        public static void GetSingleFromDataBase(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            Person person = collection.Find(x => x._age < age).FirstOrDefault();
            Console.WriteLine($"Name: {person._name} Age: {person._age}");

        }
        public static void EditDocument(string searchName, Person person)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            collection.ReplaceOne(x => x._name == searchName, person);

        }
    }
}
