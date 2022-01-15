using MongoDB.Bson;
using System;

namespace ForDataBase
{
    class Person
    {
        public ObjectId _id;
        public string name;
        public string surname;
        public int yearOfBirth;
        public int yearOfGraduation;
        public string sex;

        public Person(string name, string surname, int yearOfBirth, int yearOfGraduation, string sex)
        {
            
            this.name = name;
            this.surname = surname;
            this.yearOfBirth = yearOfBirth;
            this.yearOfGraduation = yearOfGraduation;
            this.sex = sex;

        }

    }
}

