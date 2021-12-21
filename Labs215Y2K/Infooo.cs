using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs215Y2K
{
    class Info : Character
    {

        internal static void startredactor(List<Archer> archer, List<Warrior> warrior, List<Mage> mag, double newmaxhealth)
        {
            Console.WriteLine("Добро пожаловать в редактор персонажей! Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть характеристики мага");
            Console.WriteLine("2 - Просмотреть характеристики воина");
            Console.WriteLine("3 - Просмотреть характеристики лучника");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Mage.startmage(archer, warrior, mag, newmaxhealth);
                    break;
                case 2:
                    Warrior.startwarrior(archer, warrior, mag, newmaxhealth);
                    break;
                case 3:
                    Archer.startarcher(archer, warrior, mag, newmaxhealth);
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                    break;
            }
        }
    }
}

