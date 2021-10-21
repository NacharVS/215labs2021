using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Unit
    {
        public string typeUnit;
        public int currenthealth;
        public int maxhealth;
        public int mindamage;
        public int maxdamage;
        public int speed;
        public int attackspeed;


        public void Move()
        {
            Console.WriteLine($"{typeUnit} is moving");
        }
        public void Attack()
        {
            int hit = new Random().Next(mindamage, maxdamage);
            Console.WriteLine($"{typeUnit} has dealt {hit} units of damage ");
        }

    }
}
