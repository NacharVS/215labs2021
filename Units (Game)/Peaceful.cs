using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame
{
    class Peaceful
    {
        public string name;
        public int health;
        public int speed;
        public int damage;
        public string skill;
        public int workspeed;
        public static void Skill(string namec, string skillc, int workspeedc)
        {
            Console.WriteLine($"{namec} {skillc} со скоростью " + workspeedc);
        }


        public Peaceful(string namec, int speedc, int damagec, int healthc, string skillc, int workspeedc)
        {
            name = namec;
            health = healthc;
            damage = damagec;
            speed = speedc;
            skill = skillc;
            workspeed = workspeedc;



        }

    }
}
