using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoExamples
{
    class Person
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonIgnoreIfDefault]
        public string name;

        [BsonIgnoreIfDefault]
        public int age;

        [BsonIgnoreIfDefault]
        public string driverCard;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, string driverCard) : this(name, age)
        {
            this.driverCard = driverCard;
        }
    }
}
