using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Labs215Y2K.MongoPrj
{
    class Student
    {
        
        private string _name;
    
        private string _surname;
        
        private string _lastname;
       
        private int _age;
        
        private string _gender;
        
        private int _yearofadmission;
        
        private string _studyprogress;
        
        private int _course;
        
        private int _group;
        
        private string _specialization;
        [BsonId]
        [BsonIgnoreIfDefault]
        public MongoDB.Bson.ObjectId _id;


        public Student(string name, string surname, string otchestvo, int age, string gender, int year, string progress, int course, int group, string specialization)
        {
            Name = name;
            Surname = surname;
            LastName = otchestvo;
            Age = age;
            Gender = gender;
            YearOfAdmission = year;
            StudyProgress = progress;
            Course = course;
            Group = group;
            Specialization = specialization;
        }
        public Student(string name, string surname )
        {
            Name = name;
            Surname = surname;
        }
        public Student(string name, string surname, string otche)
        {
            Name = name;
            Surname = surname;
            LastName = otche;
        }
        public Student(string name, string surname, string otche, int age)
        {
            Name = name;
            Surname = surname;
            LastName = otche;
            Age = age;
        }
        public Student(string name, string surname, string otche, int age, string gender)
        {
            Name = name;
            Surname = surname;
            LastName = otche;
            Age = age;
            Gender = gender;
        }
        public Student(string name, string surname, string otche, int age, string gender, int year)
        {
            Name = name;
            Surname = surname;
            LastName = otche;
            Age = age;
            Gender = gender;
            YearOfAdmission = year;
        }
        public Student(string name, string surname, string otche, int age, string gender, int year, string progress)
        {
            Name = name;
            Surname = surname;
            LastName = otche;
            Age = age;
            Gender = gender;
            YearOfAdmission = year;
            StudyProgress = progress;
        }
        public Student(string name, string surname, string otche, int age, string gender, int year, string progress, int course)
        {
            Name = name;
            Surname = surname;
            LastName = otche;
            Age = age;
            Gender = gender;
            YearOfAdmission = year;
            StudyProgress = progress;
            Course = course;
        }
        public Student(string name, string surname, string otche, int age, string gender, int year, string progress, int course, int group)
        {
            Name = name;
            Surname = surname;
            LastName = otche;
            Age = age;
            Gender = gender;
            YearOfAdmission = year;
            StudyProgress = progress;
            Course = course;
            Group = group;
        }


        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        [BsonIgnoreIfDefault]
        public string LastName { get => _lastname; set => _lastname = value; }
        [BsonIgnoreIfDefault]
        public int Age { get => _age; set => _age = value; }
        [BsonIgnoreIfDefault]
        public string Gender { get => _gender; set => _gender = value; }
        [BsonIgnoreIfDefault]
        public int YearOfAdmission { get => _yearofadmission; set => _yearofadmission = value; }
        [BsonIgnoreIfDefault]
        public string StudyProgress { get => _studyprogress; set => _studyprogress = value; }
        [BsonIgnoreIfDefault]
        public int Course { get => _course; set => _course = value; }
        [BsonIgnoreIfDefault]
        public int Group { get => _group; set => _group = value;}
        [BsonIgnoreIfDefault]
        public string Specialization { get => _specialization; set => _specialization = value; }

    }
}
