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
        public static void Attack(string typeunitAtt, string typeunitDef, int mindamage, int maxdamage, int healthDef)
        {

            Random z = new Random();
            int nowdamage = z.Next(mindamage, maxdamage);

            Console.WriteLine($"{typeunitAtt} наносит {nowdamage} урона {typeunitDef}.");

            Console.WriteLine($"У {typeunitDef} остаётся {healthDef -= nowdamage} hp.");

            if (healthDef <= 0)
            {
                Console.WriteLine($"{typeunitDef} мёртв. Сожалеем.");
            }

        }

        public static void Skill(string typeunitc, string skillc, int workspeedc)
        {
            Console.WriteLine($"{typeunitc} {skillc} со скоростью " + workspeedc);
            
        }

    }
}
