using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace ForDataBase.Data_Base
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
    }
}
