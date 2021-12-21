using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class RPG
    {
        public static void RPG1()
        {
            Warrior war = new Warrior("Warrior", 250, 80, 50, 100);
            Mage mag = new Mage("Mage", 45, 70, 250, 65);
            Archer arch = new Archer("Archer", 55, 250, 70, 70);

            List<Unit> characters = new List<Unit>();
            characters.Add(war);
            characters.Add(mag);
            characters.Add(arch);

            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine();
                characters[i].MaxHealth = 2 * characters[i].Constitution + characters[i].Strength / 2;
                characters[i].MaxMana = characters[i].Intelegent * 3;
                characters[i].CurrentHealth = characters[i].MaxHealth;
                characters[i].CurrentMana = characters[i].MaxMana;



                characters[i].P_Attack = characters[i].Strength * 3 + characters[i].Dextericy / 2;
                characters[i].P_Defense = characters[i].Constitution / 2 + characters[i].Dextericy * 3;
                characters[i].M_Attack = characters[i].Intelegent * 4;
                characters[i].M_Defense = characters[i].Intelegent * 2;



                characters[i].P_CriticalChance = 20 + characters[i].Dextericy * 3 / 10;
                characters[i].M_CriticalChance = 20 + characters[i].Intelegent / 10;
                characters[i].P_CriticalDamage = characters[i].P_Attack * (2 + characters[i].Dextericy * 5 / 100);
                characters[i].M_CriticalDamage = characters[i].M_Attack * (2 + characters[i].Intelegent * 15 / 100);




                Console.WriteLine($"Характеристика персонажa {characters[i].Class}:");
                Console.WriteLine();
                Console.WriteLine($"Сила - {characters[i].Strength}, Интеллект - {characters[i].Intelegent}");
                Console.WriteLine($"Ловкость - {characters[i].Dextericy}, Телосложение - {characters[i].Constitution}");
                Console.WriteLine();
                Console.WriteLine($"Здоровье - {characters[i].MaxHealth}, Мана - {characters[i].MaxMana}");
                Console.WriteLine($"Физ.атака - {characters[i].P_Attack}, Маг.атака - {characters[i].M_Attack}");
                Console.WriteLine($"Физ.защита - {characters[i].P_Defense}, Маг.защита - {characters[i].M_Defense}");
                Console.WriteLine($"Шанс физ.крит.урона - {characters[i].P_CriticalChance}, Шанс маг.крит.урона - {characters[i].M_CriticalChance}");
                Console.WriteLine($"Физ.крит.урон - {characters[i].P_CriticalDamage}, Маг.крит.урон - {characters[i].M_CriticalDamage}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();


            }


            while (true)
            {
                Console.WriteLine();
                //урон = физ атака * (физ атака / физ защита)

                int AttackUnit = new Random().Next(0, characters.Count);
                int DefenseUnit = new Random().Next(0, characters.Count);

                Unit.Battle(AttackUnit, DefenseUnit, characters);

                if (characters.Count == 1)
                {
                    Console.WriteLine($"{characters[0].Class} победил!");
                    break;
                }

            }
        }
    }
}
