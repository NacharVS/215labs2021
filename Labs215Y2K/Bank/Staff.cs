using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.Bank
{
    class Staff
    {
        private string _name;
        private string _surname;

        public Staff(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Surname { get => _surname; set => _surname = value; }
        public string Name { get => _name; set => _name = value; }

         public virtual void Actions()
         {
            Console.WriteLine($"{Name} копает шахту");
         }
    }

    class CleaningWoman : Staff
    {
        public CleaningWoman(string name, string surname) : base (name,surname)
        {
            Name = name;
            Surname = surname;
        }

        public override void Actions()
        {
            Console.WriteLine($"{Name} убирается");
        }
    }

    class SecurityGuard : Staff
    {
        public SecurityGuard(string name, string surname) : base(name, surname)
        {
            Name = name;
            Surname = surname;
        }

        public override void Actions()
        {
            Console.WriteLine($"{Name} гроза района охраняет это место");
        }
    }
}
