using System;
using System.Collections.Generic;

namespace New_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Work();
           
            
        }
        public static void Work()
        {
            Warrior war = new Warrior(45, 50, 20, 30, "воин1");
            List<Unit> Chaptres = new List<Unit>();
            
            Chaptres.Add(war);

            //Расчёт характеристик

            for (int i = 0; i < Chaptres.Count; i++)
            {
                if (Chaptres[i] is Mage)
                {
                    Chaptres[i].MagAttack = Chaptres[i].Intelligence * 4;
                    Chaptres[i].MagCritChanse = 20 + Chaptres[i].Intelligence * 0.1;
                    Chaptres[i].MagCritDamage = Chaptres[i].MagAttack * (2 + Chaptres[i].Intelligence * 0.15);
                    Console.WriteLine($"Урон Мага - {Chaptres[i].MagAttack} -Шанс маг.Крит. Урона-  {Chaptres[i].MagCritChanse} Крит. Урон мага - {Chaptres[i].MagCritDamage}");
                }

               Chaptres[i].CurrencyHealth = Chaptres[i].MaxHealth = 0.5 * Chaptres[i].Strength + 2 * Chaptres[i].Constitution;
                Chaptres[i].CurrencyMana = Chaptres[i].MaxMana = Chaptres[i].Intelligence * 3;
                Chaptres[i].P_Attack = Chaptres[i].Strength * 3 + Chaptres[i].Dexterity * 0.5;
                Chaptres[i].P_Defense = Chaptres[i].Constitution * 0.5 + Chaptres[i].Dexterity * 3;
                Chaptres[i].M_Defense = Chaptres[i].Intelligence * 2;
                Chaptres[i].P_CritChance = 20 + Chaptres[i].Dexterity * 0.3;
                Chaptres[i].P_CritDamage = Chaptres[i].P_Attack * (2 + Chaptres[i].Dexterity * 0.05);

                Console.WriteLine($"Характеристика вашего персонажа: ХП- {Chaptres[i].CurrencyHealth} Мана- {Chaptres[i].CurrencyHealth} Физ.Дамаг- {Chaptres[i].P_Attack} Физ.Защита - {Chaptres[i].P_Defense} Шанс Крита {Chaptres[i].P_CritChance} Крит Урон - {Chaptres[i].P_CritDamage}");
                Console.WriteLine($"Маг.Защита - {Chaptres[i].M_Defense}");

                if(Chaptres[i] is Warrior)
                {
                    Console.WriteLine("Ваш персонаж - ВОИН. Дитя войны");
                }
                if (Chaptres[i] is Mage)
                {
                    Console.WriteLine("Вы - Маг-оступник, сошедший с пути становления архимагом, и отправились в дальний путь");
                }
                if (Chaptres[i] is Archer)
                {
                    Console.WriteLine("Охотник, проживший в лесу немало времени, открывает для себя дорогу авантюриста.");
                }
                Unit.PAttack(war, Chaptres);
            }
            
            // Расчёт окончен
           
        }
        
        
    }
}
