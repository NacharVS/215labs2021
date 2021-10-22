using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Archer : Unit
    {
        public int range;
        public int countOfArrows;
        public Archer(string typeUnit1, int currenthealth1, int maxhealth1, int mindamage1, int maxdamage1, int speed1, int attackspeed1, int  range1, int countOfArrows1)
        {
            typeUnit = typeUnit1;
            currenthealth = currenthealth1;
            maxhealth = maxhealth1;
            mindamage = mindamage1;
            maxdamage = maxdamage1;
            speed = speed1;
            attackspeed = attackspeed1;
            range = range1;
            countOfArrows = countOfArrows1;
        }
        public void ArcherAttack()
        {
            if  (countOfArrows != 0)
            {
                int hit = new Random().Next(mindamage, maxdamage) + 100;
                Console.WriteLine($" {typeUnit} took {hit} units of damage");
                countOfArrows -= 1;
            }
            else
            {
                int hit = new Random().Next(mindamage, maxdamage);
                Console.WriteLine($"{typeUnit} has dealt {hit} units of damage in melee combat ");
            }
        }
    }
}
