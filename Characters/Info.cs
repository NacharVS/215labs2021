using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{ 
    class Info 
    {
        internal static void startredactor(List<Mage> mag)
        {
            Console.WriteLine("Добро пожаловать в редактор персонажей! Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть характеристики мага");
            Console.WriteLine("2 - Просмотреть характеристики воина");
            Console.WriteLine("3 - Просмотреть характеристики лучника");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Mage.startmage(mag);
                    break;
            }
        }
    }
}
