using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Person
    {
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual void GoToBank()
        {
            Console.WriteLine($"{Name} goes to Bank");
        }
    }
}
