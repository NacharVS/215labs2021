using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame_2._0
{
    class Peasant:Unit
    {





        public Peasant(string typeunitc, int workspeedc, int maxhealthc, int healthc, int speedc, int attackspeedc, int mindamagec, int maxdamagec, string skillc)
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
