using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Person
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonIgnoreIfDefault]
        public string name;

        [BsonIgnoreIfDefault]
        public string surname;

        [BsonIgnoreIfDefault]
        public int age;

        [BsonIgnoreIfDefault]
        public string pobatyushke;

        [BsonIgnoreIfDefault]
        public string gender;

        [BsonIgnoreIfDefault]
        public string databirth;

        [BsonIgnoreIfDefault]
        public string zodiak;

        [BsonIgnoreIfDefault]
        public string sceencolor;

        [BsonIgnoreIfDefault]
        public string haircolor;

        [BsonIgnoreIfDefault]
        public int rost;

        [BsonIgnoreIfNull]
        public string card;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public Person(string name, string surname, int age, string pobatyushke, string gender, string databirth, string zodiak, string sceencolor, string haircolor, int rost, string card)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.pobatyushke = pobatyushke;
            this.gender = gender;
            this.databirth = databirth;
            this.zodiak = zodiak;
            this.sceencolor = sceencolor;
            this.haircolor = haircolor;
            this.rost = rost;
            this.card = card;
        }
    }
}
