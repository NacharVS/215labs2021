using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Warrior : Unit
    {
        public Warrior(string typeUnit1, int currenthealth1, int maxhealth1, int mindamage1, int maxdamage1)
        {
            TypeUnit = typeUnit1;
            Currenthealth = currenthealth1;
            Maxhealth = maxhealth1;
            Mindamage = mindamage1;
            Maxdamage = maxdamage1;
        }
        public void Attack()
        {
            int hit = new Random().Next(Mindamage, Maxdamage);
            Console.WriteLine($" {TypeUnit} has dealt {hit} units of damage ");
        }
    }
}
