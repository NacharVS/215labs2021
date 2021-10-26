using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Lamberjack : Unit
    {
        public Lamberjack(string typeunitc, int workspeedc, int maxhealthc, int healthc, int speedc, int attackspeedc, int mindamagec, int maxdamagec, string skillc)
        {
            typeunit = typeunitc;
            workspeed = workspeedc;
            maxhealth = maxhealthc;
            health = healthc;
            speed = speedc;
            attackspeed = attackspeedc;
            mindamage = mindamagec;
            maxdamage = maxdamagec;
            skill = skillc;
        }
    }
}
