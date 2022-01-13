﻿using System;
using System.Collections.Generic;

namespace New_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Work();
            Console.ReadKey(); 
        }

       

        public static void Work()
        {

            Unit dualunit = new Unit(0, 0, 0, 0, "");
            Warrior war = new Warrior(30, 15, 10, 85, "воин1");
            Warrior war2 = new Warrior(50, 35, 30, 45, "воин2");
            Unit.testevent += Unit.DeBuff;

            List<Unit> Chaptres = new List<Unit>();

            Chaptres.Add(war);
            Chaptres.Add(war2);

            //Расчёт характеристик

            for (int i = 0; i < Chaptres.Count; i++)
            {
                Chaptres[i].CurrencyHealth = Chaptres[i].MaxHealth = 0.5 * Chaptres[i].Strength + 2 * Chaptres[i].Constitution;
                Chaptres[i].CurrencyMana = Chaptres[i].MaxMana;
                Console.WriteLine($"Магический Урон - {Chaptres[i].M_Attack} - Шанс магического крит. Урона-  {Chaptres[i].M_CritChance} % Крит. урон магический - {Chaptres[i].M_CritDamage}");
                Console.WriteLine($"Характеристика вашего персонажа: ХП- {Chaptres[i].CurrencyHealth} Мана- {Chaptres[i].CurrencyMana} Физ.Дамаг- {Chaptres[i].P_Attack} Физ.Защита - {Chaptres[i].P_Defense} Шанс Крита {Chaptres[i].P_CritChance} % Крит Урон - {Chaptres[i].P_CritDamage}");
                Console.WriteLine($"Маг.Защита - {Chaptres[i].M_Defense}");
                if (Chaptres[i] is Warrior)
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
                Chaptres[i].CurrencyHealth = Chaptres[i].MaxHealth = 120;
                Unit.PAttack(war, Chaptres);
            }
        
             
            // Расчёт окончен
 
  
        }


    }
}