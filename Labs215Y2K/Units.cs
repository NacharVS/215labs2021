using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labs215Y2K
{
    class Units : UnitInfo
    {
        public static Units mover = new Units("Mover", "Peaceful", "mowing the grass", 40, 60, 80, 10, 20, 5, 1, 0, 0, 0);
        public static Units blacksmith = new Units("Blacksmith", "Peaceful", "forges iron", 25, 50, 90, 20, 30, 10, 2, 0,0,0);
        public static Units bricklayer = new Units("Bricklayer", "Peaceful", "laying masonry", 30, 50, 85, 15, 30, 10, 3, 0,0,0);
        public static Units archer = new Units("Archer", "Сombat", "shoots with a bow", 60, 120, 150, 60, 100, 50, 5, 10,0,0);
        public static Units warrior = new Units("Warrior", "Сombat", "attacks the enemy", 100, 170, 220, 100, 170, 90, 6, 0,0,0);
        public static Units magician = new Units("Magician", "Сombat", "uses spells", 45, 150, 200, 30, 90, 45, 7, 0,0,250);
        public static Units healer = new Units("Healer", "Combat", "heals", 40, 500, 501, 1, 20, 5, 4, 0,5000,0);
        public Units(string name1, string role1, string action1, int speed1, int healthnow, int healthmax, int damagemin, int damagemax, int attackspeed, int number1, int arrowamount, int healammount1,int manna1)
        {
            Name = name1;
            Role = role1;
            Action = action1;
            Speed = speed1;
            CurrentHealth = healthnow;
            Maxhealth = healthmax;
            Mindamage = damagemin;
            Maxdamage = damagemax;
            AttackSpeed = attackspeed;
            Number = number1;
            AmountofArrows = arrowamount;
            Healammount = healammount1;
            Manna = manna1;
        }
        
        public static void Question()
        {
            Console.WriteLine();
            Console.WriteLine("What do you want to do? Enter numbers from the keyboard");
            Console.WriteLine("1 - View the list of NPC");
            Console.WriteLine("2 - View NPC action(s)");
            Console.WriteLine("3 - Send an NPC into battle");
            Console.WriteLine("4 - Finish viewing the list of NPC");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Units.questiontwo();
                    break;
                case 2:
                    Units.quesnpcaction();
                    break;
                case 3:
                    Units.war();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine();
                    break;

            }
        }
        public static void questiontwo()
        {
            Console.WriteLine();
            Console.WriteLine("which NPC`s do you want to view??");
            Console.WriteLine("1 - View the list of peaceful NPC");
            Console.WriteLine("2 - View the list of combat NPC");
            Console.WriteLine("3 - View the list of all NPC");
            Console.WriteLine("4 - View an npc using a number");
            int answertwo = int.Parse(Console.ReadLine());
            switch (answertwo)
            {
                case 1:
                    mover.infounit();;
                    blacksmith.infounit();
                    bricklayer.infounit();
                    Units.Question();
                    break;
                case 2:
                    healer.infounit();
                    archer.infounit();
                    warrior.infounit();
                    magician.infounit();
                    Units.Question();
                    break;
                case 3:
                    Console.WriteLine("Peaceful NPC:");
                    mover.infounit();
                    blacksmith.infounit();
                    bricklayer.infounit();
                    healer.infounit();
                    Console.WriteLine("Combat NPC:");
                    archer.infounit();
                    warrior.infounit();
                    magician.infounit();
                    Units.Question();
                    break;
                case 4:
                    Units.choosenpcinfo();
                    break;
                default:
                    break;
            }
        }
        public static void quesnpcaction()
        {
            Console.WriteLine();
            Console.WriteLine("Which NPC actions do you want to view? 1 - Peaceful NPC; 2 - Combat NPC; 3 - All NPC; 4 - NPC by number");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    mover.unitaction();
                    blacksmith.unitaction();
                    bricklayer.unitaction();
                    Units.Question();
                    break;
                case 2:
                    healer.unitaction();
                    archer.unitaction();
                    warrior.unitaction();
                    magician.unitaction();
                    Units.Question();
                    break;
                case 3:
                    Console.WriteLine("Peaceful NPC:");
                    mover.unitaction();
                    blacksmith.unitaction();
                    bricklayer.unitaction();
                    healer.unitaction();
                    Console.WriteLine("Combat NPC:");
                    archer.unitaction();
                    warrior.unitaction();
                    magician.unitaction();
                    Units.Question();
                    break;
                case 4:
                    Units.choosenpcaction();
                    break;
                default:
                    break;
            }
        }
        public static void attackquestion()
        {
            Console.WriteLine();
            Console.WriteLine("Which NPC attacks do you want to view? 1 - Peaceful NPC; 2 - Combat NPC; 3 - All NPC; 4 - NPC by number");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    mover.unitattack();
                    blacksmith.unitattack();
                    bricklayer.unitattack();
                    healer.unitattack();
                    Units.Question();
                    break;
                case 2:
                    archer.unitattack();
                    warrior.unitattack();
                    magician.unitattack();
                    Units.Question();
                    break;
                case 3:
                    Console.WriteLine("Peaceful NPC:");
                    mover.unitattack();
                    blacksmith.unitattack();
                    bricklayer.unitattack();
                    healer.unitattack();
                    Console.WriteLine("Combat NPC:");
                    archer.unitattack();
                    warrior.unitattack();
                    magician.unitattack();
                    Units.Question();
                    break;
                case 4:
                    Units.choosenpcattack();
                    break;
                default:
                    break;
            }
        }
        public static void choosenpcinfo()
        {
            Console.WriteLine("Enter a number of NPC from the keyboard");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    mover.infounit();
                    break;
                case 2:
                    blacksmith.infounit();
                    break;
                case 3:
                    bricklayer.infounit();
                    break;
                case 4:
                    healer.infounit();
                    break;
                case 5:
                    archer.infounit();
                    break;
                case 6:
                    warrior.infounit();
                    break;
                case 7:
                    magician.infounit();
                    break;
                default:
                    break;
            }
            Units.Question();
        }
        public static void choosenpcaction()
        {
            Console.WriteLine("Enter a number of NPC from the keyboard");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    mover.unitaction();
                    break;
                case 2:
                    blacksmith.unitaction();
                    break;
                case 3:
                    bricklayer.unitaction();
                    break;
                case 4:
                    healer.unitaction();
                    break;
                case 5:
                    archer.unitaction();
                    break;
                case 6:
                    warrior.unitaction();
                    break;
                case 7:
                    magician.unitaction();
                    break;
                default:
                    break;
            }
            Units.Question();
        }
        public static void choosenpcattack()
        {
            Console.WriteLine("Enter a number of NPC from the keyboard");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    mover.unitattack();
                    break;
                case 2:
                    blacksmith.unitattack();
                    break;
                case 3:
                    bricklayer.unitattack();
                    break;
                case 4:
                    healer.unitattack();
                    break;
                case 5:
                    archer.unitattack();
                    break;
                case 6:
                    warrior.unitattack();
                    break;
                case 7:
                    magician.unitaction();
                    break;
                default:
                    break;
            }
            Units.Question();
        }
        public static void war()
        {
            Console.WriteLine();
            Console.WriteLine("Want to send NPCs into battle? 1 - Yes; 2 - No;");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    mover.unitattackprocces();
                    bricklayer.unitattackprocces();
                    blacksmith.unitattackprocces();
                    archer.archerattackprocces();
                    warrior.unitattackprocces();
                    magician.magicianattack();
                    healer.unitattackprocces();
                    Console.WriteLine();
                    Units.unitsalive();
                    break;

                case 2:
                    Units.Question();
                    break;
            }
        }
        public static void unitsalive()
        {
            mover.unitlive();
            blacksmith.unitlive();
            bricklayer.unitlive();
            archer.unitlive();
            warrior.unitlive();
            magician.unitlive();
            healer.unitlive();
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Heal the character");
            Console.WriteLine("2 - Finish the battle and view the live characters");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Healing occurs as follows:the entered number of health units is subtracted from the ammount of heals. Maximum amount of health - rebirth NPC;Restore the healer's health is impossible;");
                    Console.WriteLine("The number of health parts that the healer can restore is 5000");
                    Console.WriteLine();
                    mover.unithealth();
                    blacksmith.unithealth();
                    bricklayer.unithealth();
                    archer.unithealth();
                    warrior.unithealth();
                    magician.unithealth();
                    Console.WriteLine($"{healer.Number} {healer.Name} is alive with current health = {healer.CurrentHealth}"); 
                    Console.WriteLine();
                    Console.WriteLine("Enter the number of the desired NPC");
                    Units.unitheal();
                    break;
                case 2:
                    Console.WriteLine();
                    mover.unitlive();
                    blacksmith.unitlive();
                    bricklayer.unitlive();
                    archer.unitlive();
                    warrior.unitlive();
                    magician.unitlive();
                    healer.unitlive();
                    Console.WriteLine("Goodbye!");
                    break;
            }
        }
        public static void unitheal()
        {
            
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Enter the number of health you want to add");
                    int healthammount1 = int.Parse(Console.ReadLine());
                    mover.CurrentHealth += healthammount1;
                    healer.Healammount = healer.Healammount - healthammount1;
                    if (mover.CurrentHealth > mover.Maxhealth)
                    {
                        Console.WriteLine($"{mover.Name} have full health;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (mover.CurrentHealth == mover.Maxhealth)
                    {
                        Console.WriteLine($"{mover.Name} revived because his health is restored;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (healer.Healammount == 0)
                    {
                        Console.WriteLine("Healer can no longer use healings");
                        Units.viewlastlistofunits();
                    }
                    else
                    {
                        Console.WriteLine($"{mover.Name} have {mover.CurrentHealth} health");
                        Units.unithealquestion();
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the number of health you want to add");
                    int healthammount2 = int.Parse(Console.ReadLine());
                    blacksmith.CurrentHealth += healthammount2;
                    healer.Healammount = healer.Healammount - healthammount2;
                    if (blacksmith.CurrentHealth > blacksmith.Maxhealth)
                    {
                        Console.WriteLine($"{blacksmith.Name} have full health;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (blacksmith.CurrentHealth == blacksmith.Maxhealth)
                    {
                        Console.WriteLine($"{blacksmith.Name} revived because his health is restored;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (healer.Healammount == 0)
                    {
                        Console.WriteLine("Healer can no longer use healings");
                        Units.viewlastlistofunits();
                    }
                    else
                    {
                        Console.WriteLine($"{blacksmith.Name} have {blacksmith.CurrentHealth} health");
                        Units.unithealquestion();
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the number of health you want to add");
                    int healthammount3 = int.Parse(Console.ReadLine());
                    bricklayer.CurrentHealth += healthammount3;
                    healer.Healammount = healer.Healammount - healthammount3;
                    if (bricklayer.CurrentHealth > bricklayer.Maxhealth)
                    {
                        Console.WriteLine($"{bricklayer.Name} have full health;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (bricklayer.CurrentHealth == bricklayer.Maxhealth)
                    {
                        Console.WriteLine($"{bricklayer.Name} revived because his health is restored;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (healer.Healammount == 0)
                    {
                        Console.WriteLine("Healer can no longer use healings");
                        Units.viewlastlistofunits();
                    }
                    else
                    {
                        Console.WriteLine($"{bricklayer.Name} have {bricklayer.CurrentHealth} health");
                        Units.unithealquestion();
                    }
                    break;
                case 4:
                    Console.WriteLine("You can`t add health to healer;");
                    Units.unithealquestion();
                    break;
                case 5:
                    Console.WriteLine("Enter the number of health you want to add");
                    int healthammount4 = int.Parse(Console.ReadLine());
                    archer.CurrentHealth += healthammount4;
                    healer.Healammount = healer.Healammount - healthammount4;
                    if (archer.CurrentHealth > archer.Maxhealth)
                    {
                        Console.WriteLine($"{archer.Name} have full health;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (archer.CurrentHealth == archer.Maxhealth)
                    {
                        Console.WriteLine($"{archer.Name} revived because his health is restored;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (healer.Healammount == 0)
                    {
                        Console.WriteLine("Healer can no longer use healings");
                        Units.viewlastlistofunits();
                    }
                    else
                    {
                        Console.WriteLine($"{archer.Name} have {archer.CurrentHealth} health");
                        Units.unithealquestion();
                    }
                    break;
                case 6:
                    Console.WriteLine("Enter the number of health you want to add");
                    int healthammount5 = int.Parse(Console.ReadLine());
                    warrior.CurrentHealth += healthammount5;
                    healer.Healammount = healer.Healammount - healthammount5;
                    if (mover.CurrentHealth > mover.Maxhealth)
                    {
                        Console.WriteLine($"{warrior.Name} have full health;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (mover.CurrentHealth == mover.Maxhealth)
                    {
                        Console.WriteLine($"{warrior.Name} revived because his health is restored;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (healer.Healammount <= 0)
                    {
                        Console.WriteLine("Healer can no longer use healings");
                        Units.viewlastlistofunits();
                    }
                    else
                    {
                        Console.WriteLine($"{warrior.Name} have {warrior.CurrentHealth} health");
                        Units.unithealquestion();
                    }
                    break;
                case 7:
                    Console.WriteLine("Enter the number of health you want to add");
                    int healthammount6 = int.Parse(Console.ReadLine());
                    magician.CurrentHealth += healthammount6;
                    healer.Healammount = healer.Healammount - healthammount6;
                    if (magician.CurrentHealth > magician.Maxhealth)
                    {
                        Console.WriteLine($"{magician.Name} have full health;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (magician.CurrentHealth == magician.Maxhealth)
                    {
                        Console.WriteLine($"{magician.Name} revived because his health is restored;You can't add more health units");
                        Units.unithealquestion();
                    }
                    else if (healer.Healammount == 0)
                    {
                        Console.WriteLine("Healer can no longer use healings");
                        Units.viewlastlistofunits();
                    }
                    else
                    {
                        Console.WriteLine($"{magician.Name} have {magician.CurrentHealth} health");
                        Units.unithealquestion();
                    }
                    break;

            }
        }
        public static void unithealquestion()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Heal the character");
            Console.WriteLine("2 - Finish and view the live characters");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Enter the number of the desired NPC");
                    Units.unitheal();
                    break;
                case 2:
                    mover.healtunitdone();
                    blacksmith.healtunitdone();
                    bricklayer.healtunitdone();
                    archer.healtunitdone();
                    warrior.healtunitdone();
                    magician.healtunitdone();
                    healer.healtunitdone();
                    break;
            }
        }
        public static void viewlastlistofunits()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - view the last list of NPC ");
            Console.WriteLine("2 - Complete the programm");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    mover.healtunitdone();
                    blacksmith.healtunitdone();
                    bricklayer.healtunitdone();
                    archer.healtunitdone();
                    warrior.healtunitdone();
                    magician.healtunitdone();
                    healer.healtunitdone();
                    break;
                case 2:
                    Console.WriteLine("Goodbye!");
                    break;
            }
        }
    }
}
