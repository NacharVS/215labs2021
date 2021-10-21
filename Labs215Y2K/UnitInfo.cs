using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class UnitInfo
    {
        public string name;
        public string role;
        public string action;
        public int speed;
        public int currentHealth;
        public int maxhealth;
        public int mindamage;
        public int maxdamage;
        public int attackSpeed;
        public int number;
        public int amountofArrows;
        public void infounit()
        {
            Console.WriteLine();
            Console.WriteLine($"{number} Gaming NPC - {name}; his role - {role};");
            Console.WriteLine($"His specifications:");
            Console.WriteLine($"movements speed - {speed}");
            Console.WriteLine($"attack speed - {attackSpeed}");
            Console.WriteLine($"current health - {currentHealth}");
            Console.WriteLine($"minimum damage - {mindamage}");
            Console.WriteLine($"maximum damage - {maxdamage}");
            if (amountofArrows == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"ammount of arrows - {amountofArrows}");
            }
        }
        public void unitaction()
        {
            Console.Write($"{number} {name} - {action}");
            Console.WriteLine();
        }
        public void unitattack()
        {
            int attackdamage = new Random().Next(mindamage, maxdamage);
            Console.WriteLine($"{number} {name} attacking with {attackdamage} damage");
        }
    }
}
