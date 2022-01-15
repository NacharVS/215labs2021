using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoExamples
{
    class Person
    {
        public ObjectId _id;
        public int number;
        public string surname;
        public string name;
        public string patronymic;
        public string gender;
        public int yearOfBirth;
        public int age;
        public string work;
        public string workyes;
        public string playGames;
       
       

        public Person(int number, string surname, string name, string patronymic, string gender, int yearOfBirth,int age, string work,string workyes, string playGames)
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