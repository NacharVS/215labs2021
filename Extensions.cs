using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

class Extensions
{
    public static void AddToDataBase(string name, int age)
    {
        var client = new MongoClient("mongodb://localhost");
        var database = client.GetDatabase("PetrovBigOriginal");
        var collection = database.GetCollection<Person>("Persons");
        collection.InsertOne(new Person(name, age));
    }
}
