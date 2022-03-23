using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp4
{
    class Team
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        private string _name;
        private string _first;
        private string _second;
        private string _third;
        private string _fourth;
        private string _fifth;
        public Team(string name, string first, string second, string third, string fourth, string fifth)
        {
            this.Name = name;
            this.First = first;
            this.Second = second;
            this.Third = third;
            this.Fourth = fourth;
            this.Fifth = fifth;
        }

        public string Name { get => _name; set => _name = value; }
        public string First { get => _first; set => _first = value; }
        public string Second { get => _second; set => _second = value; }
        public string Third { get => _third; set => _third = value; }
        public string Fourth { get => _fourth; set => _fourth = value; }
        public string Fifth { get => _fifth; set => _fifth = value; }
    }
}
