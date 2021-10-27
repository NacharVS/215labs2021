using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Archer : Unit
    {
        public int range;
        public int countOfArrows;
        public Archer(string typeUnit1, int currenthealth1, int maxhealth1, int mindamage1, int maxdamage1, int  range1, int countOfArrows1)
        {
            TypeUnit = typeUnit1;
            Currenthealth = currenthealth1;
            Maxhealth = maxhealth1;
            Mindamage = mindamage1;
            Maxdamage = maxdamage1;
            range = range1;
            countOfArrows = countOfArrows1;
        }
        public void Shoot()
        {
            if  (countOfArrows > 0)
            {
                int hit = new Random().Next(Mindamage, Maxdamage) + 100;
                Console.WriteLine($" {TypeUnit} took {hit} units of damage");
                countOfArrows -= 1;
            }
            else
            {
                int hit = new Random().Next(Mindamage, Maxdamage);
                Console.WriteLine($" {TypeUnit} has dealt {hit} units of damage in melee combat ");
            }
        }
    }
}
