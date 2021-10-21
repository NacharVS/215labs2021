using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labs215Y2K
{
    class Units : UnitInfo
    {
        public static Units mover = new Units("Mover", "Peaceful", "mowing the grass", 40, 60, 80, 10, 20, 5, 1, 0);
        public static Units blacksmith = new Units("Blacksmith", "Peaceful", "forges iron", 25, 50, 90, 20, 30, 10, 2, 0);
        public static Units bricklayer = new Units("Bricklayer", "Peaceful", "laying masonry", 30, 50, 85, 15, 30, 10, 3, 0);
        public static Units archer = new Units("Archer", "Сombat", "shoots with a bow", 60, 120, 150, 60, 100, 50, 5, 20);
        public static Units warrior = new Units("Warrior", "Сombat", "attacks the enemy", 100, 170, 220, 100, 170, 90, 6, 0);
        public static Units magician = new Units("Magician", "Сombat", "uses spells", 45, 80, 120, 30, 90, 45, 7, 0);
        public static Units healer = new Units("Healer", "Peaceful", "heals", 40, 65, 105, 1, 250, 0, 4, 0);
        TextBox[] textboxes = new TextBox[7];
        public Units(string name1, string role1, string action1, int speed1, int healthnow, int healthmax, int damagemin, int damagemax, int attackspeed, int number1, int arrowamount)
        {
            name = name1;
            role = role1;
            action = action1;
            speed = speed1;
            currentHealth = healthnow;
            maxhealth = healthmax;
            mindamage = damagemin;
            maxdamage = damagemax;
            attackSpeed = attackspeed;
            number = number1;
            amountofArrows = arrowamount;

        }
        public static void Question()
        {
            Console.WriteLine();
            Console.WriteLine("What do you want to do? Enter numbers from the keyboard");
            Console.WriteLine("1 - View the list of NPC");
            Console.WriteLine("2 - View NPC action(s)");
            Console.WriteLine("3 - View NPC attack(`s)");
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
                    Units.attackquestion();
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
            Console.WriteLine("1 - View the list of peacufl NPC");
            Console.WriteLine("2 - View the list of combat NPC");
            Console.WriteLine("3 - View the list of all NPC");
            int answertwo = int.Parse(Console.ReadLine());
            switch (answertwo)
            {
                case 1:
                    mover.infounit();;
                    blacksmith.infounit();
                    bricklayer.infounit();
                    healer.infounit();
                    Units.Question();
                    break;
                case 2:
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
                default:
                    break;
            }
        }
        public static void quesnpcaction()
        {
            Console.WriteLine();
            Console.WriteLine("Which NPC actions do you want to view? 1 - Peaceful NPC; 2 - Combat NPC; 3 - All NPC");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    mover.unitaction();
                    blacksmith.unitaction();
                    bricklayer.unitaction();
                    healer.unitaction();
                    Units.Question();
                    break;
                case 2:
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
                default:
                    break;
            }
        }
        public static void attackquestion()
        {
            Console.WriteLine();
            Console.WriteLine("Which NPC attacks do you want to view? 1 - Peaceful NPC; 2 - Combat NPC; 3 - All NPC");
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
                default:
                    break;
            }
        }
        public static void choosenpc()
        {
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
        }
        public static void choosenpc1()
        {
            int choose = int.Parse(Console.ReadLine());
            for (int i = 0; i < listNpc.Length; i++)
            {
                if (choose == listNpc[i])
                {
                    
                }
            }
        }
    }
}
