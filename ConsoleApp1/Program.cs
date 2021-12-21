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
            Warrior war2 = new Warrior(80, 65, 25, 85, "warrior2");

            Mage mag1 = new Mage(15, 20, 30, 15, "mage1");
            Mage mag2 = new Mage(20, 50, 200, 15, "mage2");

            Archer arch1 = new Archer(20, 30, 15, 20, "archer1");
            Archer arch2 = new Archer(55, 250, 70, 70, "archer2");

            List<Character> Chaptres = new List<Character>();
            Chaptres.Add(war1);
            Chaptres.Add(war2);
            Chaptres.Add(mag1);
            Chaptres.Add(mag2);
            Chaptres.Add(arch1);
            Chaptres.Add(arch2);

            for (int i = 0; i < Chaptres.Count; i++)
            {
                Chaptres[i].CurrentHealth = Chaptres[i].MaxHealth = 0.5 * Chaptres[i].Strenght + 2 * Chaptres[i].Constitution;
                Chaptres[i].CurrentMana = Chaptres[i].MaxMana;
                Console.WriteLine($"Магический урон - {Chaptres[i].MAttack} - Шанс магического урона-  {Chaptres[i].MCritChance} " +
                    $"% Критический урон - {Chaptres[i].MCritDamage}");
                Console.WriteLine($"Характеристика вашего персонажа: " +
                    $"ХП- {Chaptres[i].CurrentHealth} Мана- {Chaptres[i].CurrentMana} " +
                    $"Физический дамаг- {Chaptres[i].P_Attack} Физическая защита - {Chaptres[i].PDefense} " +
                    $"Шанс крита {Chaptres[i].PCritChance} % Критический урон - {Chaptres[i].PCritDamage}");
                Console.WriteLine($"Магическая защита - {Chaptres[i].M_Defense}");

                if (Chaptres[i] is Warrior)
                {
                    Console.WriteLine("Вы - Warrior");
                }
                if (Chaptres[i] is Mage)
                {
                    Console.WriteLine("Вы - Mage");
                }
                if (Chaptres[i] is Archer)
                {
                    Console.WriteLine("Вы - Archer");
                }
                Character.PAttack(war1, Chaptres);
                Chaptres[i].CurrentHealth = Chaptres[i].MaxHealth = 120;
                Character.PAttack(war1, Chaptres);
            }
        }
    }
}
        

    

