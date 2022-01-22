using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoDB
{
    class Person
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonIgnoreIfDefault]
        public string _name;

        [BsonIgnoreIfDefault]
        public string _surname;

        [BsonIgnoreIfDefault]
        public string _lastName;

        [BsonIgnoreIfDefault]
        public int _age;

        [BsonIgnoreIfDefault]
        public string _gender;

        [BsonIgnoreIfDefault]
        public string _driverCard;

        public Person(string name, string surname, string lastName, int age, string gender, string driverCard)
        {
            _name = name;
            _surname = surname;
            _lastName = lastName;
            _age = age;
            _gender = gender;
            _driverCard = driverCard;
        }
    }
}
