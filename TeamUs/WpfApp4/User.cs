using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp4
{
    class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        private string _name;

        private string _surname;


        private string _login;

        private string _email;






        public User(string name, string surname, string email, string login)
        {

            this.Name = name;
            this.Surname = surname;

            this.Email = email;
            this.Login = login;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Login { get => _login; set => _login = value; }


        public string Email { get => _email; set => _email = value; }
        public override string ToString()
        {
            return (Login);
        }


    }
}
