using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDataBase
{
    class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        private string _name;

        private string _surname;


        private string _phonenumber;
        private string _password;

        private string _email;





        public User(string name, string surname, string phonenumber, string email, string password)
        {

            this.Name = name;
            this.Surname = surname;
            this.Phonenumber = phonenumber;
            this.Email = email;
            this.Password = password;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Phonenumber { get => _phonenumber; set => _phonenumber = value; }


        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
