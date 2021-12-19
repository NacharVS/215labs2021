 using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{ 
    class Info 
    {
        internal static void Startredactor(List<Archer> archer,List<Warrior> warrior,List<Mage> mag)
        {
            Console.WriteLine("Добро пожаловать в редактор персонажей! Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть характеристики мага");
            Console.WriteLine("2 - Просмотреть характеристики воина");
            Console.WriteLine("3 - Просмотреть характеристики лучника");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Mage.startmage(archer,warrior,mag);
                    break;
                case 2:
                    Warrior.startwarrior(archer,warrior, mag);
                    break;
                case 3:
                    Archer.startarcher(archer, warrior, mag);
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    Info.Startredactor(archer, warrior, mag);
                    break;
            }
        }
    }
}
