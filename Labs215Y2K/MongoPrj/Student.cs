using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoPrj
{
    class Student
    {
        private string _name;
        private string _surname;
        private string _otchestvo;
        private int _age;
        private string _gender;
        private int _year;

        public Student(string name, string surname, string otchestvo, int age, string gender, int year)
        {
            Name = name;
            Surname = surname;
            Otchestvo = otchestvo;
            Age = age;
            Gender = gender;
            Year = year;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Otchestvo { get => _otchestvo; set => _otchestvo = value; }
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public int Year { get => _year; set => _year = value; }
    }
}
