using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Extensions
    {
        //public static void AddToDataBase(string name, string surname, int age, string pobatyushke, string gender, string databirth, string zodiak, string sceencolor, string haircolor, int rost)
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("PetrovBigOriginal");
        //    var collection = database.GetCollection<Person>("Persons");
        //    collection.InsertOne(new Person(name, surname, age, pobatyushke, gender, databirth, zodiak, sceencolor, haircolor, rost));
        //}

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

        public static void GetListFromDataBase(int rost)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.rost < rost).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.rost} Rost: {item.rost}");
            }

        }

        public static void GetAllFromDataBase(int rost) // Вывводит список людей с ростом ниже 170см
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            var list = collection.Find(x => x.rost < rost).ToList();

            foreach (var item in list)
            {
                Console.WriteLine($"Name: {item.name} Surname: {item.surname} Age: {item.age} Rost {item.rost}");
            }

        }
    }
}
