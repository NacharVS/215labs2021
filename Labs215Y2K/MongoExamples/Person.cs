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
        public int number;

        [BsonIgnoreIfDefault]
        public string surname;

        [BsonIgnoreIfDefault]
        public string name;

        [BsonIgnoreIfDefault]
        public string patronymic;

        [BsonIgnoreIfDefault]
        public string gender;

        [BsonIgnoreIfDefault]
        public int yearOfBirth;

        [BsonIgnoreIfDefault]
        public int age;

        [BsonIgnoreIfDefault]
        public string work;

        [BsonIgnoreIfDefault]
        public string workyes;

        [BsonIgnoreIfDefault]
        public string playGames;

        public Person(int yearOfBirth, string workyes)
        {
            this.yearOfBirth = yearOfBirth;
            this.workyes = workyes;
        }

        public Person(string surname, string name, string patronymic, string gender, int yearOfBirth, int age)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.gender = gender;
            this.yearOfBirth = yearOfBirth;
            this.age = age;
        }

        public Person(int number, string surname, string name, string patronymic, string gender, int yearOfBirth, int age, string work, string workyes, string playGames)
        {
            this.number = number;
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.gender = gender;
            this.yearOfBirth = yearOfBirth;
            this.age = age;
            this.work = work;
            this.workyes = workyes;
            this.playGames = playGames;

        }
    }
}