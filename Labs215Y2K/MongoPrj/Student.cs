using System;
using System.Collections.Generic;
using System.Text;

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

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string LastName { get => _lastname; set => _lastname = value; }
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public int YearOfAdmission { get => _yearofadmission; set => _yearofadmission = value; }
        public string StudyProgress { get => _studyprogress; set => _studyprogress = value; }
        public int Course { get => _course; set => _course = value; }
        public int Group { get => _group; set => _group = value;}
        public string Specialization { get => _specialization; set => _specialization = value; }

    }
}
