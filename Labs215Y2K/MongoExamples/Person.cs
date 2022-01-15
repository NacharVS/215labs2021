using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoExamples
{
    class Person
    {
        public ObjectId _id;
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
