using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoExamples
{
    class Extensions
    {
        public static void AddToDataBase(string name, int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(new Person(name, age));
        }

        public static void GetAllFromDataBase()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => true).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} Age: {item.age}");
            }
        }

        public static void GetListFromDataBase(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.age < age).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} Age: {item.age}");
            }
        }

        public static void GetSingleFromDataBase(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            Person person = collection.Find(x => x.age < age).FirstOrDefault();

                Console.WriteLine($"Name: {person.name} Age: {person.age}");
            
        }
    }
}
