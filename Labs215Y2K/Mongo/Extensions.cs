using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Extensions
    {
        public static void AddToDataBase(string name, string surname, int age, string pobatyushke, string gender, string databirth, string zodiak, string sceencolor, string haircolor, int rost, string card)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(new Person(name, surname, age, pobatyushke, gender, databirth, zodiak, sceencolor, haircolor, rost, card));
        }
        public static void AddToDataBase(string name, string surname, int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(new Person(name, surname, age));
        }

        public static void GetAllFromDataBase()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => true).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} Rost: {item.rost}");
            }
        }

        //public static void GetSingleFromDataBase(int rost)
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("PetrovBigOriginal");
        //    var collection = database.GetCollection<Person>("Persons");
        //    List<Person> list = collection.Find(x => x.rost < rost).ToList();

        //    foreach (var item in list)
        //    {
        //        Console.WriteLine($"Name: {item.name} Rost: {item.rost}");
        //    }

        //}

        public static void GetAllFromDataBase(int rost) // Вывводит список людей с заданным ростом
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            var list = collection.Find(x => x.rost == rost).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} Surname: {item.surname} Age: {item.age} Rost {item.rost}");
            }

        }

        public static void GetListFromDataBase(int age) // Вывводит список людей с заданным возрастом
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            var list = collection.Find(x => x.age > age).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} Surname: {item.surname} Age: {item.age} Rost {item.rost}");
            }

        }

        public static void GetListFromDataBase(string zodiak) // Вывводит всех в списке с заданным знаком зодиака
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            var list = collection.Find(x => x.zodiak == zodiak).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} Surname: {item.surname} Age: {item.age} Rost {item.rost}");
            }

        }

    }
}
