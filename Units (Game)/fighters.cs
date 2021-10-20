using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame
{
    class fighters
    {
        public string name;
        public int health;
        public int speed;
        public int damage;
        public string skill;
        public static void Skill(string namec, int speedc)
        {
            Console.WriteLine($"{namec} движется по полю боя со скоростью {speedc}");
        }

        public fighters(string namec, int speedc, int damagec, int healthc, string skillc)
        {
            name = namec;
            health = healthc;
            damage = damagec;
            speed = speedc;
            skill = skillc;
        }


    }
}
