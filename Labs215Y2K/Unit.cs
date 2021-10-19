using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Unit
    {
        public string name;
        public string work;
        public int health;
        public int damage;
        public int stamina;

        public void Move()
        {
            Console.WriteLine($"{name} is moving");
        }
        public void Work()
        {
            Console.WriteLine($"{name} is working");
        }
    }
}
