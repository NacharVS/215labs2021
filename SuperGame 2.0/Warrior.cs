using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame_2._0
{
    class Warrior : Unit
    {
        public Warrior(string typeunitc, int maxhealthc, int healthc, int speedc, int attackspeedc, int mindamagec, int maxdamagec)
        {
            typeunit = typeunitc;
            maxhealth = maxhealthc;
            health = healthc;
            speed = speedc;
            attackspeed = attackspeedc;
            mindamage = mindamagec;
            maxdamage = maxdamagec;




        }
    }
}
