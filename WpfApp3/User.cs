using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp3
{
    class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        private string _name;

        private string _password2;


        private string _phonenumber;
        private string _password;

        private string _email;

        public static string logpass;
        public static string logemail;




        public User(string name,string password,string password2,string email)
        {

            this.Name = name;
            this.Password2 = password2;
            //this.Phonenumber = phonenumber;
            this.Email = email;
            this.Password = password;
        }

        public string Name { get => _name; set => _name = value; }
        public string Password2 { get => _password2; set => _password2 = value; }
        //public string Phonenumber { get => _phonenumber; set => _phonenumber = value; }


        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }

    }
}
