using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        private string name;

        private string surname;

        
        private int phonenumber;

        
        private string email;




        public User(string name, string surname, int phonenumber, string email)
        {

            this.Name = name;
            this.Surname = surname;
            this.Phonenumber = phonenumber;
            this.Email = email;
        }
        
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Phonenumber { get => phonenumber; set => phonenumber = value; }


        public string Email { get => email; set => email = value; }
    }
}
