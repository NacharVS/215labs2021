﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame_2._0
{
    class Healer : Unit
    {
        public int countheal;
        public Healer(string typeunitc, int maxhealthc, int healthc, int speedc, int attackspeedc, int mindamagec, int maxdamagec, int counthealc)
        {
            typeunit = typeunitc;
            maxhealth = maxhealthc;
            health = healthc;
            speed = speedc;
            attackspeed = attackspeedc;
            mindamage = mindamagec;
            maxdamage = maxdamagec;
            countheal = counthealc;

        }

        public static void Heal(string typeunit, int maxhealth, int health, int countheal)
        {
            if (health<maxhealth)
            {
                health += countheal;
                if (health > maxhealth)
                {
                    health = maxhealth;
                }
            }
            Console.WriteLine($"Хилер исцелён на {countheal} hp. Сейчас у него {health} hp.");
        }
    }
}
