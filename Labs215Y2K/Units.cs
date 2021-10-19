using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Units : UnitInfo
    {
        public static Units mover = new Units("Косарь", "Мирный", "Косит траву", 40, 80, 0);
        public static Units blacksmith = new Units("Кузнец", "Мирный", "Кует железо", 25, 90, 1);
        public static Units bricklayer = new Units("Каменщик", "Мирный", "Ложит кладку", 30, 85, 0);
        public static Units archer = new Units("Лучник", "Боевой", "Стреляет из лука", 60, 140, 70);
        public static Units warrior = new Units("Воин", "Боевой", "Нападает на противника", 100, 190, 120);
        public static Units magician = new Units("Маг", "Боевой", "Использует заклинания", 45, 120, 100);
        public  Units(string name1, string role1, string action1, int speed1, int health1, int damage1)
        {
            name = name1;
            role = role1;
            action = action1;
            speed = speed1;
            health = health1;
            damage = damage1;
            
        }
        public static void Question()
        {
            Console.WriteLine("Что вы хотите сделать? Вводите цифру с клавиатуры");
            Console.WriteLine("1 - Просмотреть список NPC");

            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine();
                    Units.questiontwo();
                    break;
                    
            }
        }
        public static void questiontwo()
        {
            Console.WriteLine("Что вы хотите сделать? Вводите цифру с клавиатуры");
            Console.WriteLine("1 - Просмотреть список мирных NPC");
            Console.WriteLine("2 - Просмотреть список боевых NPC");
            Console.WriteLine("3 - Просмотреть список всех NPC");
            int answertwo = int.Parse(Console.ReadLine());
            switch (answertwo)
            {
                case 1:
                    Console.WriteLine();
                    mover.infounit();
                    Console.WriteLine();
                    blacksmith.infounit();
                    Console.WriteLine();
                    bricklayer.infounit();
                    Console.WriteLine();
                    Units.questiontwo();
                    break;


                case 2:
                    Console.WriteLine();
                    archer.infounit();
                    Console.WriteLine();
                    warrior.infounit();
                    Console.WriteLine();
                    magician.infounit();
                    Console.WriteLine();
                    Units.questiontwo();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Мирные NPC:");
                    mover.infounit();
                    Console.WriteLine();
                    blacksmith.infounit();
                    Console.WriteLine();
                    bricklayer.infounit();
                    Console.WriteLine();
                    Console.WriteLine("Боевые NPC:");
                    archer.infounit();
                    Console.WriteLine();
                    warrior.infounit();
                    Console.WriteLine();
                    magician.infounit();
                    Console.WriteLine();
                    Units.questiontwo();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
