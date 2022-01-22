using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace Игра.MongoExamples
{
    static class Extensions
    {
        public static void AddToDatabase(string name, string surname, string gender, string othestvo, int ageHappy, int numbersGroup, int averageScore, bool commerce, int payment, string activity)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("MckKtitc");
            var collection = database.GetCollection<Person>("Peson");
            collection.InsertOne(new Person(name, surname, gender, othestvo, ageHappy, numbersGroup, averageScore, commerce, payment, activity));
        }
        public static void GetListDataBase()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("MckKtitc");
            var collection = database.GetCollection<Person>("Peson");
            List<Person> list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"имя:{item._name}, фамилия:{item._surname}, отчество:{item._othestvo}, пол:{item._gender}, год рождения:{ item._ageHappy}, номер группы:{ item._numbersGroup}, активности:{ item._activity}, комерция:{item._commerce} ,плата:{item._payment}");
            }
        }
        public static void GetFindScoreDataBase()
        {
            Console.WriteLine();
            Console.WriteLine("Введите оценку");
            int Score = int.Parse(Console.ReadLine());
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("MckKtitc");
            var collection = database.GetCollection<Person>("Peson");
            List<Person> list = collection.Find(x => x._averageScore >= Score).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($" имя:{item._name}, фамилия:{item._surname}, оценка:{item._averageScore}, актовности {item._activity}");
            }
        }
        public static void GetFindCommerceDataBase()
        {
            Console.WriteLine();
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("MckKtitc");
            var collection = database.GetCollection<Person>("Peson");
            List<Person> list = collection.Find(x => x._commerce == true).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($" имя:{item._name}, фамилия:{item._surname}, комерция:{item._commerce} ,плата:{item._payment}");
            }
        }
        public static void GetFindActivnostDataBase()
        {
            Console.WriteLine();
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("MckKtitc");
            var collection = database.GetCollection<Person>("Peson");
            List<Person> list = collection.Find(x => x._activity != "").ToList();
            foreach (var item in list)
            {
                Console.WriteLine($" имя:{item._name}, фамилия:{item._surname}, активности {item._activity}");
            }
        }

    }
}
