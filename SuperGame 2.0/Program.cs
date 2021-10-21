using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame_2._0
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string typeunit = "Archer";
            int maxhealth = 60;
            int health = 60;
            int speed = 40;
            int attackspeed = 10;
            int mindamage = 15;
            int maxdamage = 20;
            int arrows = 3;
            int rangedamage = 40;
            Archer archer1 = new Archer(typeunit, maxhealth, health, speed, attackspeed, mindamage, maxdamage, arrows, rangedamage);

            string typeunit2 = "Archer";
            int maxhealth2 = 100;
            int health2 = 96;
            int speed2 = 40;
            int attackspeed2 = 10;
            int mindamage2 = 15;
            int maxdamage2 = 20;
            int countheal2 = 5;
            Healer healer1 = new Healer(typeunit2, maxhealth2, health2, speed2, attackspeed2, mindamage2, maxdamage2, countheal2);
            
       
            
            Peasant.Attack("peasant", 5, 10);
            Peasant.Skill("peasant", "добывает еду", 10);
            Archer.ArcherShoot(typeunit, arrows, rangedamage);
            Archer.ArcherShoot(typeunit, arrows, rangedamage);
            Healer.Heal(typeunit2, maxhealth2, health2, countheal2);
            Console.ReadKey();
        }
    }
}
