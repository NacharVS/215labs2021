using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Killer : Unit
    {
        public Killer(string typeUnit1, int currenthealth1, int maxhealth1, int mindamage1, int maxdamage1, int speed1, int attackspeed1)
        {
            typeUnit = typeUnit1;
            currenthealth = currenthealth1;
            maxhealth = maxhealth1;
            mindamage = mindamage1;
            maxdamage = maxdamage1;
            speed = speed1;
            attackspeed = attackspeed1;
        }
        public void murder()
        {
            Console.WriteLine($"{typeUnit} made a murder");
        }
    }
}
