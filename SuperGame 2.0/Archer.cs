using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame_2._0
{
    class Archer:Unit
    {
        public int arrows;
        public int range;
        public int rangedamage;



        public Archer(string typeunitc, int maxhealthc, int healthc, int speedc, int attackspeedc, int mindamagec, int maxdamagec, int arrowsc, int rangedamagec)
        {
            typeunit = typeunitc;

            maxhealth = maxhealthc;
            health = healthc;
            speed = speedc;
            attackspeed = attackspeedc;
            mindamage = mindamagec;
            maxdamage = maxdamagec;
            arrows = arrowsc;
            rangedamage = rangedamagec;




        }
        public static void ArcherShoot(string ARCHER, string target, int targethealth, int arrows, int rangedamage)
        {

                Console.WriteLine($"{ARCHER} наносит {rangedamage} урона. У него остается {arrows - 1} стрел.");
                targethealth -= rangedamage;
                arrows -= 1;
                Console.WriteLine($"У {target} осталось {targethealth} hp.");
            if (targethealth <= 0)
            {
                Console.WriteLine($"{target} мёртв. Сожалеем.");
            }




        }

    }
}
