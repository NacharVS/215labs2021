using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace bdOriginal
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
        public int yearofbirth;

        [BsonIgnoreIfDefault]
        public int schoolyear;

        [BsonIgnoreIfDefault]
        public string pol;

        [BsonIgnoreIfDefault]
        public int ves;

        [BsonIgnoreIfDefault]
        public int rost;

        [BsonIgnoreIfDefault]
        public double averagemark;

        [BsonIgnoreIfDefault]
        public string poseshaemost;


        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string car;
        

        public Person(string name, string surname, int yearofbirth, int schoolyear, string pol, int ves, int rost, double averagemark, string poseshaemost)
        {
            this.name = name;
            this.surname = surname;
            this.yearofbirth = yearofbirth;
            this.schoolyear = schoolyear;
            this.pol = pol;
            this.ves = ves;
            this.rost = rost;
            this.averagemark = averagemark;
            this.poseshaemost = poseshaemost;            
        }
        //public Person(string name, string surname, int yearofbirth, int schoolyear, string pol, int ves, int rost, double averagemark, string poseshaemost, string car)
        //{
        //    this.name = name;
        //    this.surname = surname;
        //    this.yearofbirth = yearofbirth;
        //    this.schoolyear = schoolyear;
        //    this.pol = pol;
        //    this.ves = ves;
        //    this.rost = rost;
        //    this.averagemark = averagemark;
        //    this.poseshaemost = poseshaemost;
        //    this.car = car;
        //}
        public Person(string name, string surname, int yearofbirth, int schoolyear, string pol, int ves, int rost, double averagemark, string poseshaemost, string car) : this(name, surname, yearofbirth, schoolyear, pol, ves, rost, averagemark, poseshaemost)
        {
            this.car = car;
        }       
    }
}
