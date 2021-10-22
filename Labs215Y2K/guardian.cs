using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Guardian : Unit
    {
        public Guardian(string typeUnit1, int currenthealth1, int maxhealth1, int mindamage1, int maxdamage1, int speed1, int attackspeed1)
        {
            typeUnit = typeUnit1;
            currenthealth = currenthealth1;
            maxhealth = maxhealth1;
            mindamage = mindamage1;
            maxdamage = maxdamage1;
            speed = speed1;
            attackspeed = attackspeed1;
        }

    }
}
