using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperGame_2._0
{
    class Unit
    {
        public string typeunit;
        public int maxhealth;
        public int health;
        public int workspeed;
        public int speed;
        public int attackspeed;
        public int mindamage;
        public int maxdamage;
        public string skill;
        public static void Attack(string typeunit, int mindamage, int maxdamage)
        {

            Random z = new Random();
            Console.WriteLine($"{typeunit} наносит {z.Next(mindamage, maxdamage)} ");

        }

        public static void Skill(string typeunitc, string skillc, int workspeedc)
        {
            Console.WriteLine($"{typeunitc} {skillc} со скоростью " + workspeedc);
            
        }
    }
}
