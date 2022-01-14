using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Extensions
    {
        public static void AddToDataBase(string name, string surname, int age, string pobatyushke, string gender, string databirth, string zodiak, string sceencolor, string haircolor, int rost)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("PetrovBigOriginal");
            var collection = database.GetCollection<Person>("Persons");
            collection.InsertOne(new Person(name, surname, age, pobatyushke,  gender,  databirth,  zodiak,  sceencolor,  haircolor,  rost));
        }
    }
}
