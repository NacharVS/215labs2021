using System;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Person
    {
        public ObjectId _id;
        public string name;
        public string surname;
        public int age;
        public string pobatyushke;
        public string gender;
        public string databirth;
        public string zodiak;
        public string sceencolor;
        public string haircolor;
        public int rost;

        

        public Person(string name, string surname, int age, string pobatyushke, string gender, string databirth, string zodiak, string sceencolor, string haircolor, int rost)
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
        }
    }
}
