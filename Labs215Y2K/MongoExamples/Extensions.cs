using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoExamples
{
    class Extensions
    {
        public static void AddToDataBase(int number, string surname, string name, string patronymic, string gender, int yearOfBirth, int age, string work, string playGames, string attention)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("SubbotAboba");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(new Person(number, surname, name, patronymic, gender, yearOfBirth, age, work, playGames, attention));
        }
    }
}
