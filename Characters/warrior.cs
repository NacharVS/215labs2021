using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    class Warrior : Characteristics
    {
        public Warrior(int strentgh, int dexterity, int intelligence, int constitutions, int health, int manna, int pattack, int pdefence, int mattack, int mdefence, int criticalchanse, int criticaldamage)
        {
            Strentgh = strentgh;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitutions = constitutions;
            Health = health;
            Pattack = pattack;
            Pdefence = pdefence;
            PCriticalchanse = criticalchanse;
            PCriticaldamage = criticaldamage;
        }
        public static Warrior war = new Warrior(30, 15, 10, 25, 0, 0, 0, 0, 0, 0, 0, 0);
        public static void startwarrior()
        {
            Console.WriteLine($"Характеристики воина:");
            Console.WriteLine($"Сила = {war.Strentgh}");
            Console.WriteLine($"Ловкость = {war.Dexterity}");
            Console.WriteLine($"Интеллект = {war.Intelligence}");
            Console.WriteLine($"Телосложение = {war.Constitutions}");
            Console.WriteLine($"Здоровье = {war.Health}");
            Console.WriteLine($"Физ. атака = {war.Pattack}");
            Console.WriteLine($"Физ. защита = {war.Pdefence}");
            Console.WriteLine($"Критический шанс = {war.PCriticalchanse}");
            Console.WriteLine($"Критический урон = {war.PCriticaldamage}");
        }
    }
}
