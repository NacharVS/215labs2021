using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace bdOriginal
{
    class Extensions
    {
        public static void AddToDataBase(string name, string surname, int yearofbirth, int schoolyear, string pol, int ves, int rost, double averagemark, string poseshaemost, string car)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Students");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(new Person(name, surname, yearofbirth, schoolyear, pol, ves, rost, averagemark, poseshaemost, car));
        }
        public static void AddToDataBase(string name, string surname, int yearofbirth, int schoolyear, string pol, int ves, int rost, double averagemark, string poseshaemost)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Students");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(new Person(name, surname, yearofbirth, schoolyear, pol, ves, rost, averagemark, poseshaemost));
        }
        public static void GetRostFromDataBase(int rost)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Students");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.rost < rost).ToList();

            if (list.Count == 0)
            {
                Console.WriteLine("Ошибка: нет соответствующих данных");
            }
            foreach (var item in list)
            {
                Console.WriteLine($"Имя: {item.name}; Рост: {item.rost}");
            }
        }
        public static void GetSurnameFromDataBase(string surname)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Students");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.surname == surname).ToList();

            if (list.Count == 0)
            {
                Console.WriteLine("Ошибка: нет соответствующих данных");
            }
            foreach (var item in list)
            {
                Console.WriteLine($"Имя: {item.name}; Фамилия: {item.surname}");
            }
        }
        public static void GetAverageMarkFromDataBase(double averagemark)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Students");
            var collection = database.GetCollection<Person>("Persons");
            List<Person> list = collection.Find(x => x.averagemark < averagemark).ToList();

            if(list.Count == 0)
            {
                Console.WriteLine("Ошибка: нет соответствующих данных");
            }
            foreach (var item in list)
            {
                Console.WriteLine($"Имя: {item.name}; Средний балл: {item.averagemark}");
            }
        }
        public static void EditDocument(string searchName, Person person)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Students");
            var collection = database.GetCollection<Person>("Persons");
            collection.ReplaceOne(x => x.name == searchName, person);

        }
        public static Person SuperPerson()
        {                           
                Console.WriteLine("Введите имя, фамилию, год рождения, год выпуска со школы, пол, вес, рост, средний балл, посещаемость, оценку за поведение:");
                Console.Write("Введите имя:");
                string name = Console.ReadLine();
                Console.Write("Введите фамилию:");
                string surname = Console.ReadLine();
                Console.Write("Введите год рождения:");
                int yearofbirth = int.Parse(Console.ReadLine());
                Console.Write("Введите год выпуска со школы:");
                int schoolyear = int.Parse(Console.ReadLine());
                Console.Write("Введите пол:");
                string pol = Console.ReadLine();
                Console.Write("Введите вес:");
                int ves = int.Parse(Console.ReadLine());
                Console.Write("Введите рост:");
                int rost = int.Parse(Console.ReadLine());
                Console.Write("Введите средний балл:");
                double averagemark = double.Parse(Console.ReadLine());
                Console.Write("Введите оценку за посещаемость:");
                string poseshaemost = Console.ReadLine();
                Console.Write("Введите какая машина (если нет - ничего не вводите):");
                string car = Console.ReadLine();
                Person kk = new Person(name, surname, yearofbirth, schoolyear, pol, ves, rost, averagemark, poseshaemost, car);
                Extensions.AddToDataBase(name, surname, yearofbirth, schoolyear, pol, ves, rost, averagemark, poseshaemost, car);
            
            return kk;
        }
    }
}
