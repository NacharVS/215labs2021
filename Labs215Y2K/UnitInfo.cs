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
        public int healammount;
        public int manna;
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
        public void unitattackprocces()
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                int healthdamage = new Random().Next(40,180);
                int attackdamage = new Random().Next(mindamage, maxdamage);
                Console.WriteLine($"{number} {name} attacking with {attackdamage} damage; his current health = {currentHealth}");
                currentHealth = currentHealth - healthdamage;
                Console.WriteLine($"{name} Loses {healthdamage} health units; his current health = {currentHealth};");
                if (currentHealth <= 0)
                {
                  Console.WriteLine();
                  Console.WriteLine($"{name} died due to loss of health while fighting in battle");
                  break;
                }
                if (currentHealth > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{name} did not die in battle;his current health = {currentHealth}");
                    break;
                }
            }
        }
        public void unitlive()
        {
            if (currentHealth > 0)
            {
                Console.WriteLine($"{number} {name} is alive with current health = {currentHealth}");
            }
            else
            {
                Console.Write("");
            }
        }
        public void archerattackprocces()
        {
            Console.WriteLine();
            Console.WriteLine($"{name} attacks with arrows in ranged combat; his current health = {currentHealth}");
            for (int i = 0; i < 100; i++)
            {
                int healthdamage = new Random().Next(1, 20);
                int arrowsnumber = new Random().Next(1, 4);
                currentHealth = currentHealth - healthdamage;
                amountofArrows = amountofArrows - arrowsnumber;
                if (amountofArrows > 0 )
                {
                    Console.WriteLine($"{name} lost {arrowsnumber} arrows and lost {healthdamage} health; his current health = {currentHealth}; current arrows - {amountofArrows}");
                }
                if (amountofArrows <= 0)
                {
                    Console.WriteLine($"{name}  lost all the arrows and went into melee with {currentHealth} health");
                    break;
                }
            }
            for (int i = 0; i < 3;i++)
            {
                int meleedamage = new Random().Next(mindamage, maxdamage);
                int healthdamage1 = new Random().Next(10, 40);
                currentHealth = currentHealth - healthdamage1;
                if (currentHealth > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{name} attacking with {meleedamage} damage;{name} loses {healthdamage1} health units; his current health = {currentHealth}");
                    
                }
                if (currentHealth < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{name} died due to loss of health while fighting in melee battle");
                    break;
                }
            }
            if (currentHealth > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"{name} survived the melee his current health = {currentHealth}");
            }
            else
            {
                Console.Write("");
            }
        }
        public void unithealth()
        {
            if (currentHealth < 0)
            {
                currentHealth = 0;
                Console.WriteLine($"{number} {name} is alive with current health = {currentHealth}; max health is {maxhealth}");
            }
            else
            {
                Console.WriteLine($"{number} {name} is alive with current health = {currentHealth}; max health is {maxhealth}");
            }
        }
        public void healtunitdone()
        {
            if (currentHealth == maxhealth)
            {
                Console.WriteLine($"{number} {name} current health {currentHealth} = max health");
            }
            else if (currentHealth == 0)
            {
                Console.WriteLine($"{number} {name} current health {currentHealth} died");
            }
            else
            {
                Console.WriteLine($"{number} {name} current health {currentHealth} - alive;");
            }
        }
        public void magicianattack()
        {
            Console.WriteLine();
            Console.WriteLine($"{number} {name} will use a spell;amount of mana = {manna}; {name} have 3 spells:");
            Console.WriteLine($"1 - The Magic Arrow; ranged combat; damage in the range from 70 to 120");
            Console.WriteLine($"2 - The Magic Shield; melee combat; damage in the range from 10 to 45");
            Console.WriteLine($"3 - The Magic Staff; melee combat; damage in the range from 50 to 95");
            while (manna > 0)
            {
                Console.WriteLine("Enter the spell number to use it");

                int spell1damage = new Random().Next(70, 120);
                int spell2damage = new Random().Next(10, 45);
                int spell3damage = new Random().Next(50, 95);
                int spell1healthdamage = new Random().Next(10, 30);
                int spell2healthdamage = new Random().Next(10, 25);
                int spell3healthdamage = new Random().Next(20, 50);
                int spell1manna = 75;
                int spell2manna = 50;
                int spell3manna = 90;
                int speelnumber = int.Parse(Console.ReadLine());
                switch (speelnumber)
                {
                    case 1:
                        Console.WriteLine($"{name} uses 1 spell; damage done = {spell1damage}; lost manna = {spell1manna} ");
                        manna = manna - spell1manna;
                        currentHealth = currentHealth - spell1healthdamage;
                        Console.WriteLine($"{name} has {currentHealth} health; current manna amount = {manna}");
                        if (manna <= 0)
                        {
                            Console.WriteLine($"{name} lost all manna; his current health = {currentHealth}");
                        }
                        break;
                    case 2:
                        Console.WriteLine($"{name} uses 2 spell; damage done = {spell2damage}; lost manna = {spell2manna} ");
                        manna = manna - spell2manna;
                        currentHealth = currentHealth - spell2healthdamage;
                        Console.WriteLine($"{name} has {currentHealth} health; current manna amount = {manna}");
                        if (manna <= 0)
                        {
                            Console.WriteLine($"{name} lost all manna; his current health = {currentHealth}");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"{name} uses 3 spell; damage done = {spell3damage}; lost manna = {spell3manna} ");
                        manna = manna - spell3manna;
                        currentHealth = currentHealth - spell3healthdamage;
                        Console.WriteLine($"{name} has {currentHealth} health; current manna amount = {manna}");
                        if (manna <= 0)
                        {
                            Console.WriteLine($"{name} lost all manna; his current health = {currentHealth}");
                        }
                        break;
                }
            }
            if (currentHealth > 0)
            {
                Console.WriteLine($"{number} {name} survived in battle; his current health = {currentHealth} ");
            }
            else if (currentHealth < 0)
            {
                Console.WriteLine($"{number} {name} died in battle;");
            }
            else
            {
                Console.WriteLine();
            }
                    

        }
    }
}
