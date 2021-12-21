using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Employer : Person
    {
        public Employer(string name, string surname) : base(name, surname)
        {
        }
        public void Service()
        {
            Console.WriteLine($"{Name} is servicing");
        }
        public override void GoToBank()
        {
            Console.WriteLine($"{Name} goes to Bank for SERVICING");
        }
    }
}

