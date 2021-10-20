using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labs215Y2K
{
    class Units : UnitInfo
    {
        public static Units mover = new Units("Косарь", "Мирный", "косит траву", 40, 80, 0,1);
        public static Units blacksmith = new Units("Кузнец", "Мирный", "кует железо", 25, 90, 1,2);
        public static Units bricklayer = new Units("Каменщик", "Мирный", "ложит кладку", 30, 85, 0,3);
        public static Units archer = new Units("Лучник", "Боевой", "стреляет из лука", 60, 140, 70,4);
        public static Units warrior = new Units("Воин", "Боевой", "нападает на противника", 100, 190, 120,5);
        public static Units magician = new Units("Маг", "Боевой", "использует заклинания", 45, 120, 100,6);
        public  Units(string name1, string role1, string action1, int speed1, int health1, int damage1, int number1)
        {
            name = name1;
            role = role1;
            action = action1;
            speed = speed1;
            health = health1;
            damage = damage1;
            number = number1;
            
        }
        public static void Question()
        {
            Console.WriteLine("Что вы хотите сделать? Вводите цифру с клавиатуры");
            Console.WriteLine("1 - Просмотреть список NPC");
            Console.WriteLine("2 - Просмотреть действие(-ия) NPC");
            Console.WriteLine("3 - Закончить просмотр NPC");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine();
                    Units.questiontwo();
                    break;
                case 2:
                    Units.quesnpcaction();
                    break;
                case 3:
                    Console.WriteLine("Досвидания!");
                    break;
                default:
                    Console.WriteLine();
                    break;

            }
        }
        public static void questiontwo()
        {
            Console.WriteLine("Cписок каких NPC вы хотите просмотреть?");
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
                    Thread.Sleep(5000);
                    Console.Clear();
                    Units.Question();
                    break;
                case 2:
                    Console.WriteLine();
                    archer.infounit();
                    Console.WriteLine();
                    warrior.infounit();
                    Console.WriteLine();
                    magician.infounit();
                    Console.WriteLine();
                    Thread.Sleep(5000);
                    Console.Clear();
                    Units.Question();
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
                    Thread.Sleep(7000);
                    Console.Clear();
                    Units.Question();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
        public static void quesnpcaction()
        {
            Console.WriteLine();
            Console.WriteLine("Действия каких NPC вы хотите просмотреть? 1 - Мирных NPC; 2 - Боевых NPC; 3 - Всех NPC");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine();
                    mover.unitaction();
                    Console.WriteLine();
                    blacksmith.unitaction();
                    Console.WriteLine();
                    bricklayer.unitaction();
                    Console.WriteLine();
                    Thread.Sleep(5000);
                    Console.Clear();
                    Units.Question();
                    break;
                case 2:
                    Console.WriteLine();
                    archer.unitaction();
                    Console.WriteLine();
                    warrior.unitaction();
                    Console.WriteLine();
                    magician.unitaction();
                    Console.WriteLine();
                    Thread.Sleep(5000);
                    Console.Clear();
                    Units.Question();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Мирные NPC:");
                    mover.unitaction();
                    Console.WriteLine();
                    blacksmith.unitaction();
                    Console.WriteLine();
                    bricklayer.unitaction();
                    Console.WriteLine();
                    Console.WriteLine("Боевые NPC:");
                    archer.unitaction();
                    Console.WriteLine();
                    warrior.unitaction();
                    Console.WriteLine();
                    magician.unitaction();
                    Console.WriteLine();
                    Thread.Sleep(7000);
                    Console.Clear();
                    Units.Question();
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
