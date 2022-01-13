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

        public Student(string name, string surname, string otchestvo, int age)
        {
            Name = name;
            Surname = surname;
            Otchestvo = otchestvo;
            Age = age;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Otchestvo { get => _otchestvo; set => _otchestvo = value; }
        public int Age { get => _age; set => _age = value; }
    }
}
