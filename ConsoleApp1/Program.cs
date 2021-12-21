using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Character dualcharacter = new Character(0, 0, 0, 0, "");
            Warrior war1 = new Warrior(30, 15, 10, 85, "warrior1");
            Warrior war2 = new Warrior(50, 35, 30, 45, "warrior2");

            List<Character> Chaptres = new List<Character>();
            Chaptres.Add(war1);
            Chaptres.Add(war2);

            for (int i = 0; i < Chaptres.Count; i++)
            {
                Chaptres[i].CurrentHealth = Chaptres[i].MaxHealth = 0.5 * Chaptres[i].Strenght + 2 * Chaptres[i].Constitution;
                Chaptres[i].CurrentMana = Chaptres[i].MaxMana;
                Console.WriteLine($"Магический Урон - {Chaptres[i].MAttack} - Шанс магического урона-  {Chaptres[i].MCritChance} % Крит. урон - {Chaptres[i].MCritDamage}");
                Console.WriteLine($"Характеристика вашего персонажа: ХП- {Chaptres[i].CurrentHealth} Мана- {Chaptres[i].CurrentMana} Физ.Дамаг- {Chaptres[i].P_Attack} Физ.Защита - {Chaptres[i].PDefense} Шанс Крита {Chaptres[i].PCritChance} % Крит Урон - {Chaptres[i].PCritDamage}");
                Console.WriteLine($"Маг.Защита - {Chaptres[i].M_Defense}");

                if (Chaptres[i] is Warrior)
                {
                    Console.WriteLine("Ваш персонаж - Warrior");
                }
                if (Chaptres[i] is Mage)
                {
                    Console.WriteLine("Ваш персонаж - Mage");
                }
                if (Chaptres[i] is Archer)
                {
                    Console.WriteLine("Ваш персонаж - Archer");
                }
                Character.PAttack(war1, Chaptres);
                Chaptres[i].CurrentHealth = Chaptres[i].MaxHealth = 120;
                Character.PAttack(war1, Chaptres);
            }
        }
    }
}
        

    

