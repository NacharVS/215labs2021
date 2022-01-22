using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ForDataBase
{
    class Person
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public string name;

        public string surname;

        [BsonIgnoreIfDefault]
        public int age;

        [BsonIgnoreIfDefault]
        public int yearOfGraduation;

        [BsonIgnoreIfDefault]
        public string sex;

        [BsonIgnoreIfDefault]
        public int driverCard;


        public Person(string name, string surname, int age, int yearOfGraduation, string sex)
        {
            
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.yearOfGraduation = yearOfGraduation;
            this.sex = sex;

        }
        public Person(string name, string surname, int age, int yearOfGraduation, string sex, int driverCard)
        {

            this.name = name;
            this.surname = surname;
            this.age = age;
            this.yearOfGraduation = yearOfGraduation;
            this.sex = sex;
            this.driverCard = driverCard;

        }

    }
}

