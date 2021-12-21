using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Security : Person
    {
        public Security(string name, string surname) : base(name, surname)
        {
        }
        public void Guard()
        {
            Console.WriteLine($"{Name} is guarding");
        }
        public override void GoToBank()
        {
            Console.WriteLine($"{Name} goes to Bank for guarding");
        }
    }
}
